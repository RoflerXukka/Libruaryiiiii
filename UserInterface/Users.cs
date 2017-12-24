using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserInterface
{
    public partial class Users : Form
    {
        AddPoly addpoly;
        private Helper helper;
        private Search_form sf;
        private Books friend;
        private bool Lock_Flag { get; set; }
        private List<List<DataGridViewRow>> Books;
        private List<List<string>> DatesOfAddBooks;
        public DataGridView DataUserGrid => DataUsers;
        public DataGridView DataCurrentUser => DataUserInf;
        private DataGridViewRow item;

        #region Анимация
        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                cp.ClassStyle &= CS_DROPSHADOW;
                return cp;
            }
        } // для тени формы
        private void MoveObj_MouseDown(object sender, MouseEventArgs e)
        {
            MoveObj.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
        private void MINIMASE_MouseMove(object sender, MouseEventArgs e) => MINIMASE.BackColor = Color.Silver;
        private void MINIMASE_MouseLeave(object sender, EventArgs e) => MINIMASE.BackColor = Color.Gainsboro;
        private void CLOSE_MouseMove(object sender, MouseEventArgs e)
        {
            CLOSE.BackColor = Color.Crimson;
            CLOSE.ForeColor = Color.White;
        }  // ЭТО ВСЁ ДЛЯ КРАСИВОЙ АНИМАЦИИ
        private void CLOSE_MouseLeave(object sender, EventArgs e)
        {
            CLOSE.BackColor = Color.Gainsboro;
            CLOSE.ForeColor = Color.Black;
        } // И ЭТО
        private void MainForm_Deactivate(object sender, EventArgs e) => MoveObj.Focus();
        private void MINIMASE_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void CLOSE_Click(object sender, EventArgs e) {
            try
            {
                Application.Exit();
            }
            catch { }
        } // ЭТО ТОЖЕ
        #endregion

        #region Служебные методы, облегчающие разработку
        public void UpdateDataUserInf()
        {
            if(DataUsers.SelectedRows.Count != 0)
                DataUsers_SelectionChanged(1, new EventArgs());
        }
        public void AddBookDrDr(DataGridViewRow row)
        {
            Books[DataUsers.CurrentRow.Index].Add(row);
            DatesOfAddBooks[DataUsers.CurrentRow.Index].Add(DateTime.Today.ToShortDateString());
            int n = DataUserInf.Rows.Add();
            DataUserInf.Rows[n].Cells[0].Value = Books[DataUsers.CurrentRow.Index][Books[DataUsers.CurrentRow.Index].Count - 1].Cells[0].Value.ToString();
            DataUserInf.Rows[n].Cells[1].Value = Books[DataUsers.CurrentRow.Index][Books[DataUsers.CurrentRow.Index].Count - 1].Cells[1].Value.ToString();
            DataUserInf.Rows[n].Cells[2].Value = DatesOfAddBooks[DataUsers.CurrentRow.Index][DatesOfAddBooks[DataUsers.CurrentRow.Index].Count - 1];
        }
        public void RemoveingUser(int IndexBook, int IndexUser)
        {
            for (int i = 0; i < Books[IndexUser].Count; i++)
            {
                if (Books[IndexUser][i].Index == IndexBook)
                {
                    Books[IndexUser].RemoveAt(i);
                    break;
                }
            }

        }
        public void RemoveingBook(List<DataGridViewRow> list, int index)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < Books[list[i].Index].Count; j++)
                {
                    if (Books[list[i].Index][j].Index == index)
                    {
                        Books[list[i].Index].RemoveAt(j);
                        break;
                    }
                }
            }

        }
        public void LoadMainData()
        {
            DataSet dataalll = new DataSet();
            dataalll.ReadXml("BD.xml");
            try
            {
                int n;
                foreach (DataRow row in dataalll.Tables["Users"].Rows)
                {
                    n = DataUsers.Rows.Add(); // добавляем новую сроку в dataGridView1
                    DataUsers.Rows[n].Cells[0].Value = row["UserName"]; // заносим в первый столбец созданной строки данные из первого столбца таблицы ds.
                    DataUsers.Rows[n].Cells[1].Value = row["Adress"]; // то же самое со вторым столбцом
                }
            }
            catch
            {
                return;
            }
        }
        public async void AddToDATA(string first, string second)
        {
            addpoly.Cancel.Enabled = addpoly.AddPolys.Visible = addpoly.CLOSE.Enabled = false;
            addpoly.ProgressSpinner.Visible = true;
            bool resultOfChek = await CheckThisUser(first, second);
            if (resultOfChek)
            {
                addpoly.ProgressSpinner.Visible = false;
                addpoly.Cancel.Enabled = addpoly.AddPolys.Visible = addpoly.CLOSE.Enabled = true;
                MessageBox.Show("Такой пользователь уже есть...");
                return;
            }
            DataUsers.Rows.Add();
            DataUsers.Rows[DataUsers.Rows.Count - 1].Cells[0].Value = first;
            DataUsers.Rows[DataUsers.Rows.Count - 1].Cells[1].Value = second;
            DataUsers.Rows[DataUsers.Rows.Count - 1].Cells[2].Value = 0;
            SelectAndScrollToUser(DataUsers.RowCount - 1);
            Books.Add(new List<DataGridViewRow>());
            DatesOfAddBooks.Add(new List<string>());
            if (DataUsers.RowCount == 1)
            {
                InfoLabelUserBookCount.Visible = InfoLabelUserBookCountValue.Visible = true;
                InfoLabelUserBookCountValue.Text = DataUserInf.RowCount.ToString();
            }
            CountOfUsersTotal.Text = DataUsers.RowCount.ToString();
            addpoly.Close();
        } // это метод добавления пользователя или книги
        public (string User, string Adress) GetDataUser(int index) => (DataUsers.Rows[index].Cells[0].Value.ToString(), DataUsers.Rows[index].Cells[1].Value.ToString());
        private (string, string) GetDataRow(DataGridViewRow row) => (row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
        public void SelectAndScrollToUser(int indexOfUser)
        {
            DataUsers.SelectionChanged -= DataUsers_SelectionChanged;
            DataUsers.ClearSelection();
            DataUsers.Rows[indexOfUser].Selected = true;
            DataUsers.FirstDisplayedScrollingRowIndex = indexOfUser;
            DataUsers.CurrentCell = DataUsers.Rows[indexOfUser].Cells[2];
            DataUsers.SelectionChanged += DataUsers_SelectionChanged;
            DataUsers_SelectionChanged(1, new EventArgs());
        }
        private Task<bool> CheckThisUser(string name, string addres)
        {
            return Task.Run(() =>
            {
                for(int i =0; i < DataUsers.RowCount; i++)
                {
                    if(DataUsers.Rows[i].Cells[0].Value.ToString() == name)
                    {
                        if(DataUsers.Rows[i].Cells[1].Value.ToString() == addres)
                        {
                            return true;
                        }
                    }
                }
                return false;
            });
        }
        #endregion

        public Users()
        {
            
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            helper = new Helper(this);
            if (!File.Exists("BD.xml"))
            {
                MessageBox.Show("Не удалось открыть файл", "Ошибка");
                Application.Exit();
            }
            Books = new List<List<DataGridViewRow>>();
            DatesOfAddBooks = new List<List<string>>();
            InitializeComponent();
            Lock_Flag = false;
            Delete.Enabled = false;
            MoveObj.BackColor = System.Drawing.Color.Transparent;
            CLOSE.FlatAppearance.BorderSize = 0;
            MINIMASE.FlatAppearance.BorderSize = 0;
            friend = new Books(this);
            // впихнуть синхронизацию
            //Thread thread = new Thread(friend.LoadMainData);
            //thread.Start(wait);
            //thread.Join();
            friend.LoadMainData(1);
            LoadMainData();
            //wait.WaitOne();
            friend.Show();
        } // происходит при инициализации формы
        private async void DataUsers_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                switch (e.Button)
                {
                    case MouseButtons.Left when (DataUsers.CurrentRow.Selected):
                        DataUserInf.Rows.Clear();
                        for (int i = 0; i < Books[DataUsers.CurrentRow.Index].Count; i++)
                        {
                            int n = DataUserInf.Rows.Add();
                            (DataUserInf.Rows[n].Cells[0].Value, DataUserInf.Rows[n].Cells[1].Value) = GetDataRow(Books[DataUsers.CurrentRow.Index][i]);
                            DataUserInf.Rows[n].Cells[2].Value = DatesOfAddBooks[DataUsers.CurrentRow.Index][i];
                        }
                        DataUserInf.ClearSelection();
                        Delete.Enabled = true;
                        Delete.Text = "Удалить пользователя";
                        break;
                    case MouseButtons.Middle:
                        await helper.UnHideAllRowsAsyncUnsafe(DataUsers);
                        DataUsers.ClearSelection();
                        DataUserInf.Rows.Clear();
                        Delete.Text = "Удалить...";
                        Delete.Enabled = false;
                        InfoLabelUserBookCount.Visible = InfoLabelUserBookCountValue.Visible = false;
                        break;
                }
            }
            catch { }
        } // обычный клик на таблицу с пользователями
        private void MainForm_Load(object sender, EventArgs e)
        {
            DataSet dataalll = new DataSet();
            dataalll.ReadXml("BD.xml");
            try
            {
                int i = 0;
                int n = 0;
                foreach (DataRow row in dataalll.Tables["Users"].Rows)
                {
                    DataUsers.Rows[n++].Cells[2].Value = row["NberReatedBooks"]; // то же самое с третьим столбцом
                    string[] indexes = row["IndexesOfCurrentBooks"].ToString().Split('.');
                    string[] dates = row["DatesOfAddBooks"].ToString().Split(';');
                    int j = 0;
                    foreach (string index in indexes)
                    {
                        Books.Add(new List<DataGridViewRow>());
                        DatesOfAddBooks.Add(new List<string>());
                        try
                        {
                            this.Books[i].Add(friend.DataBooksGrid.Rows[Convert.ToInt32(index)]);
                            DatesOfAddBooks[i].Add(dates[j++]);
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                    i++;
                }
                DataUsers.ClearSelection();
                MoveObj.Focus();
            }
            catch
            {
                return;
            }
            this.DataUsers.SelectionChanged += new System.EventHandler(this.DataUsers_SelectionChanged);
            CountOfUsersTotal.Text = DataUsers.RowCount.ToString();
            this.DataUsers.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DataUsers_CellValidating); // происходит параша
        } // происходит при загрузке формы
        private void Delete_Click(object sender, EventArgs e)
        {
            if (Delete.Text == "Удалить пользователя")
            {
                DataUserInf.Rows.Clear();
                friend.RemoveingUser(Books[DataUsers.CurrentRow.Index], DataUsers.CurrentRow.Index);
                Books.RemoveAt(DataUsers.CurrentRow.Index);
                DatesOfAddBooks.RemoveAt(DataUsers.CurrentRow.Index);
                DataUsers.Rows.RemoveAt(DataUsers.CurrentRow.Index);
                if (DataUsers.Rows.Count == 0)
                {
                    Delete.Enabled = false;
                    Delete.Text = "Удалить...";
                    InfoLabelUserBookCountValue.Visible = InfoLabelUserBookCount.Visible = false;
                }
                CountOfUsersTotal.Text = DataUsers.RowCount.ToString();
            }
            else
            {
                friend.RemoveingBook(DataUsers.CurrentRow.Index, Books[DataUsers.CurrentRow.Index][DataUserInf.CurrentRow.Index].Index);
                Books[DataUsers.CurrentRow.Index].RemoveAt(DataUserInf.CurrentRow.Index);
                DataUserInf.Rows.RemoveAt(DataUserInf.CurrentRow.Index);
                InfoLabelUserBookCountValue.Text = DataUserInf.RowCount.ToString();
                if (DataUserInf.RowCount == 0)
                {
                    Delete.Enabled = false;
                    Delete.Text = "Удалить...";
                    InfoLabelUserBookCountValue.Visible = InfoLabelUserBookCount.Visible = false;
                }
            }
            friend.UpdateDataBooksInf();
        } // удаление выбранной книги / выбранного пользователя
        private void AddTooo_Click(object sender, EventArgs e)
        {
            addpoly = new AddPoly(this);
            addpoly.ShowDialog();
        } // ОКНО ДОБАВЛЕНИЯ ДАННЫХ (пользователь или книга)
        private void DataUserInf_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                switch (e.Button)
                {
                    case MouseButtons.Right:
                        DataUserInf.ClearSelection();
                        Delete.Enabled = false;
                        Delete.Text = "Удалить...";
                        break;
                    case MouseButtons.Left when (DataUserInf.CurrentRow.Selected):
                        Delete.Enabled = true;
                        Delete.Text = "Убрать книгу";
                        break;
                }
            }
            catch (Exception) { }
        }
        private void DataUsers_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataUserInf.Rows.Clear();
            friend.RemoveingUser(Books[e.Row.Index], e.Row.Index);
            Books.RemoveAt(e.Row.Index);
            DatesOfAddBooks.RemoveAt(e.Row.Index);
            friend.UpdateDataBooksInf();
            CountOfUsersTotal.Text = (DataUsers.RowCount - 1).ToString();
            if (DataUsers.RowCount == 1)
                InfoLabelUserBookCountValue.Visible = InfoLabelUserBookCount.Visible = false;
        }
        private void DataUserInf_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            friend.RemoveingBook(DataUsers.CurrentRow.Index, Books[DataUsers.CurrentRow.Index][e.Row.Index].Index);
            Books[DataUsers.CurrentRow.Index].RemoveAt(e.Row.Index);
            if (DataUserInf.Rows.Count == 1)
            {
                Delete.Enabled = false;
                Delete.Text = "Удалить...";
            }
            InfoLabelUserBookCountValue.Text = (DataUserInf.RowCount - 1).ToString();
            friend.UpdateDataBooksInf();
        }
        private void DataUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (DataUsers.RowCount == 0)
            {
                Delete.Enabled = false;
                Delete.Text = "Удалить...";
                return;
            }
            DataUserInf.Rows.Clear();
            try
            {
                for (int i = 0; i < Books[DataUsers.CurrentRow.Index].Count; i++)
                {
                    int n = DataUserInf.Rows.Add();
                    (DataUserInf.Rows[n].Cells[0].Value, DataUserInf.Rows[n].Cells[1].Value) = GetDataRow(Books[DataUsers.CurrentRow.Index][i]);
                    DataUserInf.Rows[n].Cells[2].Value = DatesOfAddBooks[DataUsers.CurrentRow.Index][i];
                }
            }
            catch { return; }
            DataUserInf.ClearSelection();
            InfoLabelUserBookCount.Visible = InfoLabelUserBookCountValue.Visible = true;
            InfoLabelUserBookCountValue.Text = DataUserInf.RowCount.ToString();
            Delete.Enabled = true;
            Delete.Text = "Удалить пользователя";
        }
        private void DataUsers_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right when (DataUsers.RowCount != 0 && DataUsers.CurrentRow.Selected && DataUserInf.RowCount != 0):
                    DataUserInf.Rows[0].Selected = true;
                    DataUserInf.Focus();
                    Delete.Text = "Убрать книгу";
                    break;
            }
        }
        private void DataUserInf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Left) return;
            DataUsers.Focus();
            Delete.Text = "Удалить пользователя";
            Delete.Enabled = true;
            DataUserInf.ClearSelection();
        }
        private void DataUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right || e.RowIndex == -1) return;
            Lock_Flag = false;
            DataUsers.CurrentCell = DataUsers.Rows[e.RowIndex].Cells[0];///////////////////////////
            DataUsers.CurrentRow.Selected = true;
            Lock_Flag = true;
            DataUsers_SelectionChanged(1, new EventArgs());
            try { if (!friend.DataBooksGrid.CurrentRow.Selected) return; }
            catch { return; }
            friend.DataCurrentBook.AllowDrop = true;
            friend.DataCurrentBook.DoDragDrop(DataUsers.CurrentRow, DragDropEffects.All);
            friend.DataCurrentBook.AllowDrop = false;
            InfoLabelUserBookCountValue.Text = DataUserInf.RowCount.ToString();
        }
        private void DataUserInf_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            item = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));
        }
        private void DataUserInf_DragDrop(object sender, DragEventArgs e)
        {
            for (int i = 0; i < DataUserInf.Rows.Count; i++)
                if (DataUserInf.Rows[i].Cells[0].Value.ToString() == item.Cells[0].Value.ToString() && DataUserInf.Rows[i].Cells[1].Value.ToString() == item.Cells[1].Value.ToString())
                {
                    MessageBox.Show("Данная книга уже имеется у выбранного Вами пользователя", "Ошибка добавления");
                    return;
                }
            int n = DataUserInf.Rows.Add();
            DataUserInf.Rows[n].Cells[0].Value = item.Cells[0].Value.ToString();
            DataUserInf.Rows[n].Cells[1].Value = item.Cells[1].Value.ToString();
            DataUserInf.Rows[n].Cells[2].Value = DateTime.Today.ToShortDateString();
            Books[DataUsers.CurrentRow.Index].Add(item);
            DatesOfAddBooks[DataUsers.CurrentRow.Index].Add(DataUserInf.Rows[n].Cells[2].Value.ToString());
            friend.AddUserDrDr(DataUsers.CurrentRow);
            InfoLabelUserBookCountValue.Text = DataUserInf.RowCount.ToString();
        }
        private void Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataSet dataalll = new DataSet();
            dataalll.ReadXml("BD.xml");
            try { dataalll.Tables.Remove("Users"); }
            catch { } // удаление старой таблицы
            DataTable dt = new DataTable();
            dt.TableName = "Users";
            dt.Columns.Add("UserName");
            dt.Columns.Add("Adress");
            dt.Columns.Add("NberReatedBooks");
            dt.Columns.Add("IndexesOfCurrentBooks");
            dt.Columns.Add("DatesOfAddBooks");
            dataalll.Tables.Add(dt);
            foreach (DataGridViewRow row in DataUsers.Rows)
            {
                DataRow data = dataalll.Tables["Users"].NewRow();
                data["UserName"] = row.Cells[0].Value.ToString();
                data["Adress"] = row.Cells[1].Value.ToString();
                data["NberReatedBooks"] = row.Cells[2].Value.ToString();
                string indexesanddate = "";
                for (int i = 0; i < Books[row.Index].Count; i++)
                    indexesanddate += Books[row.Index][i].Index.ToString() + '.';
                data["IndexesOfCurrentBooks"] = indexesanddate;
                indexesanddate = "";
                for (int i = 0; i < DatesOfAddBooks[row.Index].Count; i++)
                    indexesanddate += DatesOfAddBooks[row.Index][i] + ';';
                data["DatesOfAddBooks"] = indexesanddate;
                dataalll.Tables["Users"].Rows.Add(data);
            } // создание таблицы с данными 
            dataalll.WriteXml("BD.xml"); // сохранение данных в файл
        }
        private void Search_Click(object sender, EventArgs e)
        {
            sf = new Search_form(this);
            sf.ShowDialog();
        }
        public async void Searching(SearchData data)
        {
            await helper.UnHideAllRowsAsyncUnsafe(DataUsers);
            int countOfRes = await helper.StartSearchAnsyc(data, DataUsers);
            MessageBox.Show("Совпадений найдено: " + countOfRes.ToString());
            sf.Close();
        }
        private void DataUsers_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (!Lock_Flag || !DataUsers.CurrentCell.IsInEditMode) return;
            Regex regEx;
            switch (e.ColumnIndex)
            {
                case 0:
                    regEx = new Regex(@"^([А-Я][а-я]+) (([А-Я][а-я]+)|([А-Я][а-я]+)-([А-Я][а-я]+))(( [А-Я][а-я]+)|)$");
                    Match match = regEx.Match(e.FormattedValue.ToString());
                    if (!match.Success)
                    {
                        MessageBox.Show("Вы ввели некорректную абривиатуру ФИО пользователя");
                        goto default;
                    }
                    break;
                case 1:
                    regEx = new Regex(@"^(((ул. [А-Я][а-я]+)|((пр|пр-т). [А-Я][а-я]+)|([А-Я][а-я]+ (тр|тркт).)), дом [0-9]{1,})$");
                    match = regEx.Match(e.FormattedValue.ToString());
                    if (!match.Success)
                    {
                        MessageBox.Show("Вы ввели некорректный адрес проживания пользователя");
                        goto default;
                    }
                    break;
                case 2:
                    if(!int.TryParse(e.FormattedValue.ToString(), out int dd))
                    {
                        MessageBox.Show("Вы ввели некорректное значение колличества прочитанных книг");
                        goto default;
                    }
                    break;
                default:
                    e.Cancel = true;
                    return;
            }
            Lock_Flag = false;
        } // сделать проверку на редактирование
        private void DataUsers_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) => Lock_Flag = true;
        private void DataUsers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Lock_Flag = false;
            friend.UpdateDataBooksInf();
        }
        private void DataUserInf_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Books[DataUsers.CurrentRow.Index].Count == 0) return;
            int indexOfBook = Books[DataUsers.CurrentRow.Index][e.RowIndex].Index;
            friend.SelectAndScrollToBook(indexOfBook);
            friend.Focus();
            friend.Select();
        }
    }
}
