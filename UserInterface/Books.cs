using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserInterface
{
    public partial class Books : Form
    {
        AddPoly addpoly;
        Helper helper;
        string buffer_word;
        private List< List<DataGridViewRow> > Users;
        private bool Lock_Flag { get; set; }
        public DataGridView DataBooksGrid => DataBooks;
        private Search_form sf;
        public DataGridView DataCurrentBook => DataBooksInf;
        private DataGridViewRow item;
        private Users friend;

        #region Анимация
        private int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        } // для тени формы
        private void MoveObj_MouseDown(object sender, MouseEventArgs e)
        {
            MoveObj.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
        private void MINIMASE_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void CLOSE_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch { }
        }
        private void Books_Deactivate(object sender, EventArgs e)
        {
            MoveObj.Focus();
        }
        private void MINIMASE_MouseMove(object sender, MouseEventArgs e)
        {
            MINIMASE.BackColor = Color.Silver;
        }
        private void MINIMASE_MouseLeave(object sender, EventArgs e)
        {
            MINIMASE.BackColor = Color.Gainsboro;
        }
        private void CLOSE_MouseMove(object sender, MouseEventArgs e)
        {
            CLOSE.BackColor = Color.Crimson;
            CLOSE.ForeColor = Color.White;
        }
        private void CLOSE_MouseLeave(object sender, EventArgs e)
        {
            CLOSE.BackColor = Color.Gainsboro;
            CLOSE.ForeColor = Color.Black;
        }
        #endregion

        #region Служебные методы, облегчающие разработку
        private (string, string) GetDataRow(DataGridViewRow row)
        {
            return (row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
        }
        public async void AddToDATA(string first, string second, string third, string fourth)
        {
            addpoly.Cancel.Enabled = addpoly.AddPolys.Visible = addpoly.CLOSE.Enabled = false;
            addpoly.ProgressSpinner.Visible = true;
            bool resultOfChek = await CheckThisUser(first, second);
            if (resultOfChek)
            {
                addpoly.ProgressSpinner.Visible = false;
                addpoly.Cancel.Enabled = addpoly.AddPolys.Visible = addpoly.CLOSE.Enabled = true;
                MessageBox.Show("Такая книга уже есть...");
                return;
            }
            int n = DataBooks.Rows.Add();
            DataBooks.Rows[n].Cells[0].Value = first;
            DataBooks.Rows[n].Cells[1].Value = second;
            DataBooks.Rows[n].Cells[2].Value = third;
            DataBooks.Rows[n].Cells[3].Value = fourth;
            SelectAndScrollToBook(DataBooks.RowCount - 1);
            Users.Add(new List<DataGridViewRow>());
            if (DataBooks.RowCount == 1)
            {
                InfoLabelBookUserCount.Visible = InfoLabelBookUserCountValue.Visible = true;
                InfoLabelBookUserCountValue.Text = DataBooksInf.RowCount.ToString();
            }
            CountOfBooksTotal.Text = DataBooks.RowCount.ToString();
            addpoly.Close();
        } // это метод добавления пользователя или книги
        public void LoadMainData(Object t)
        {
            DataSet dataalll = new DataSet();
            dataalll.ReadXml("BD.xml");
            try
            {
                int n;
                foreach (DataRow row in dataalll.Tables["Books"].Rows)
                {
                    n = DataBooks.Rows.Add(); // добавляем новую сроку в dataGridView1
                    DataBooks.Rows[n].Cells[0].Value = row["BooksName"]; // заносим в первый столбец созданной строки данные из первого столбца таблицы ds.
                    DataBooks.Rows[n].Cells[1].Value = row["Author"]; // то же самое со вторым столбцом
                }
            }
            catch
            {
                return;
            }
            // ((AutoResetEvent)t).Set();
        }
        public void RemoveingUser(List<DataGridViewRow> list, int index)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < Users[list[i].Index].Count; j++)
                {
                    if (Users[list[i].Index][j].Index == index)
                    {
                        Users[list[i].Index].RemoveAt(j);
                    }
                }
            }

        }
        public void RemoveingBook(int IndexUser, int IndexBook)
        {
            for (int i = 0; i < Users[IndexBook].Count; i++)
            {
                if (Users[IndexBook][i].Index == IndexUser)
                {
                    this.Users[IndexBook].RemoveAt(i);
                    break;
                }
            }
        }
        public void UpdateDataBooksInf()
        {
            if(DataBooks.SelectedRows.Count != 0)
                DataBooks_SelectionChanged(1, new EventArgs());
        }
        public void AddUserDrDr(DataGridViewRow row)
        {
            Users[DataBooks.CurrentRow.Index].Add(row);
            int n = DataBooksInf.Rows.Add();
            DataBooksInf.Rows[n].Cells[0].Value = Users[DataBooks.CurrentRow.Index][Users[DataBooks.CurrentRow.Index].Count - 1].Cells[0].Value.ToString();
            DataBooksInf.Rows[n].Cells[1].Value = Users[DataBooks.CurrentRow.Index][Users[DataBooks.CurrentRow.Index].Count - 1].Cells[1].Value.ToString();
        }
        public void SelectAndScrollToBook(int indexOfBook)
        {
            DataBooks.SelectionChanged -= DataBooks_SelectionChanged;
            DataBooks.ClearSelection();
            DataBooks.Rows[indexOfBook].Selected = true;
            DataBooks.FirstDisplayedScrollingRowIndex = indexOfBook;
            DataBooks.CurrentCell = DataBooks.Rows[indexOfBook].Cells[3];
            DataBooks.SelectionChanged += DataBooks_SelectionChanged;
            DataBooks_SelectionChanged(1, new EventArgs());
        }
        private Task<bool> CheckThisUser(string name, string author)
        {
            return Task.Run(() =>
            {
                for (int i = 0; i < DataBooks.RowCount; i++)
                {
                    if (DataBooks.Rows[i].Cells[0].Value.ToString() == name)
                    {
                        if (DataBooks.Rows[i].Cells[1].Value.ToString() == author)
                        {
                            return true;
                        }
                    }
                }
                return false;
            });
        }
        #endregion

        public Books(Users friend)
        {
            helper = new Helper(this);
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            Users = new List<List<DataGridViewRow>>();
            InitializeComponent();
            Lock_Flag = false;
            string kek = "";
            Delete.Enabled = false;
            this.friend = friend;
            MoveObj.BackColor = System.Drawing.Color.Transparent;
            CLOSE.FlatAppearance.BorderSize = 0;
            MINIMASE.FlatAppearance.BorderSize = 0;
            friend.FormClosing += Friend_FormClosing;
        }
        private void AddTooo_Click(object sender, EventArgs e)
        {
            addpoly = new AddPoly(this);
            addpoly.ShowDialog();
        }
        private async void DataBooks_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                switch (e.Button)
                {
                    case MouseButtons.Left when (DataBooks.CurrentRow.Selected):
                        DataBooksInf.Rows.Clear();
                        for (int i = 0; i < Users[DataBooks.CurrentRow.Index].Count; i++)
                        {
                            int n = DataBooksInf.Rows.Add();
                            (DataBooksInf.Rows[n].Cells[0].Value, DataBooksInf.Rows[n].Cells[1].Value) = GetDataRow(Users[DataBooks.CurrentRow.Index][i]);
                        }
                        DataBooksInf.ClearSelection();
                        Delete.Enabled = true;
                        Delete.Text = "Удалить книгу";
                        break;
                    case MouseButtons.Middle:
                        await helper.UnHideAllRowsAsyncUnsafe(DataBooks);
                        DataBooks.ClearSelection();
                        DataBooksInf.Rows.Clear();
                        Delete.Text = "Удалить...";
                        Delete.Enabled = false;
                        InfoLabelBookUserCount.Visible = InfoLabelBookUserCountValue.Visible = false;
                        break;
                }
            }
            catch { }
        }
        private void Delete_Click(object sender, EventArgs e) 
        {
            if (Delete.Text == "Удалить книгу")
            {
                DataBooksInf.Rows.Clear();
                friend.RemoveingBook(Users[DataBooks.CurrentRow.Index], DataBooks.CurrentRow.Index);
                Users.RemoveAt(DataBooks.CurrentRow.Index);
                DataBooks.Rows.RemoveAt(DataBooks.CurrentRow.Index);
                if (DataBooks.Rows.Count == 0)
                {
                    Delete.Enabled = false;
                    Delete.Text = "Удалить...";
                }
                CountOfBooksTotal.Text = DataBooks.RowCount.ToString();
                if (DataBooks.RowCount == 0)
                {
                    InfoLabelBookUserCount.Visible = false;
                    InfoLabelBookUserCountValue.Visible = false;
                }
            }
            else
            {
                friend.RemoveingUser(DataBooks.CurrentRow.Index, Users[DataBooks.CurrentRow.Index][DataBooksInf.CurrentRow.Index].Index);
                Users[DataBooks.CurrentRow.Index].RemoveAt(DataBooksInf.CurrentRow.Index);
                DataBooksInf.Rows.RemoveAt(DataBooksInf.CurrentRow.Index);
                if (DataBooksInf.Rows.Count == 0)
                {
                    Delete.Enabled = false;
                    Delete.Text = "Удалить...";
                }
                InfoLabelBookUserCountValue.Text = DataBooksInf.RowCount.ToString();
            }
            friend.UpdateDataUserInf();
            //Delete.Enabled = false;
            //Delete.Text = "Удалить...";
        }
        private void Books_Load(object sender, EventArgs e)
        {
            DataSet dataalll = new DataSet();
            dataalll.ReadXml("BD.xml");
            try
            {
                int i = 0;
                int n = 0;
                foreach (DataRow row in dataalll.Tables["Books"].Rows)
                {
                    DataBooks.Rows[n].Cells[2].Value = row["Genre"]; // то же самое с третьим столбцом
                    DataBooks.Rows[n++].Cells[3].Value = row["YearPublication"]; // то же самое с четвертым столбцом
                    string[] indexes = row["IndexesOfCurrentUsers"].ToString().Split('.');
                    foreach (string index in indexes)
                    {
                        Users.Add(new List<DataGridViewRow>());
                        try
                        {
                            Users[i].Add(friend.DataUserGrid.Rows[Convert.ToInt32(index)]);
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                    i++;
                }
                DataBooks.ClearSelection();
                MoveObj.Focus();
            }
            catch (NullReferenceException)
            {
                return;
            }
            this.DataBooks.SelectionChanged += new System.EventHandler(this.DataBooks_SelectionChanged);

            CountOfBooksTotal.Text = DataBooks.RowCount.ToString();
        }
        private void DataBooksInf_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                switch (e.Button)
                {
                    case MouseButtons.Right:
                        DataBooksInf.ClearSelection();
                        Delete.Enabled = false;
                        Delete.Text = "Удалить...";
                        break;
                    case MouseButtons.Left when (DataBooksInf.SelectedRows.Count == 1):
                        Delete.Enabled = true;
                        Delete.Text = "Убрать пользователя";
                        break;
                }
            }
            catch { }
        }
        private void DataBooks_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataBooksInf.Rows.Clear();
            friend.RemoveingBook(Users[e.Row.Index], e.Row.Index);
            Users.RemoveAt(e.Row.Index);
            friend.UpdateDataUserInf();
            CountOfBooksTotal.Text = (DataBooks.RowCount - 1).ToString();
            if (DataBooks.RowCount == 1)
            {
                InfoLabelBookUserCount.Visible = false;
                InfoLabelBookUserCountValue.Visible = false;
            }
        }
        private void DataBooksInf_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            friend.RemoveingUser(DataBooks.CurrentRow.Index, Users[DataBooks.CurrentRow.Index][e.Row.Index].Index);
            Users[DataBooks.CurrentRow.Index].RemoveAt(e.Row.Index);
            if (DataBooksInf.Rows.Count == 1)
            {
                Delete.Enabled = false;
                Delete.Text = "Удалить...";
            }
            InfoLabelBookUserCountValue.Text = (DataBooksInf.RowCount - 1).ToString();
            friend.UpdateDataUserInf();
        }
        private void DataBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (DataBooks.RowCount == 0)
            {
                Delete.Enabled = false;
                Delete.Text = "Удалить...";
                return;
            }
            DataBooksInf.Rows.Clear();
            try
            {
                for (int i = 0; i < Users[DataBooks.CurrentRow.Index].Count; i++)
                {
                    int n = DataBooksInf.Rows.Add();
                    (DataBooksInf.Rows[n].Cells[0].Value, DataBooksInf.Rows[n].Cells[1].Value) = GetDataRow(Users[DataBooks.CurrentRow.Index][i]);
                }
            }
            catch { return; }
            DataBooksInf.ClearSelection();
            InfoLabelBookUserCount.Visible = InfoLabelBookUserCountValue.Visible = true;
            InfoLabelBookUserCountValue.Text = DataBooksInf.RowCount.ToString();
            Delete.Enabled = true;
            Delete.Text = "Удалить книгу";
        }
        private void DataBooks_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right when (DataBooks.RowCount != 0 || DataBooks.CurrentRow.Selected || DataBooksInf.RowCount != 0):
                    DataBooksInf.Rows[0].Selected = true;
                    DataBooksInf.Focus();
                    Delete.Text = "Убрать пользователя";
                    break;
            }
        }
        private void DataBooksInf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Left) return;
            DataBooks.Focus();
            Delete.Text = "Удалить книгу";
            Delete.Enabled = true;
            DataBooksInf.ClearSelection();
        }
        private void DataBooksInf_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            item = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));
        }
        private void DataBooksInf_DragDrop(object sender, DragEventArgs e)
        {
            for(int i = 0; i < DataBooksInf.Rows.Count; i++)
                if(DataBooksInf.Rows[i].Cells[0].Value.ToString() == item.Cells[0].Value.ToString() && DataBooksInf.Rows[i].Cells[1].Value.ToString() == item.Cells[1].Value.ToString())
                {
                    MessageBox.Show("Данный пользователь уже имеется у выбранной Вами книги", "Ошибка добавления");
                    return;
                }
            int n = DataBooksInf.Rows.Add();
            DataBooksInf.Rows[n].Cells[0].Value = item.Cells[0].Value.ToString();
            DataBooksInf.Rows[n].Cells[1].Value = item.Cells[1].Value.ToString();
            Users[DataBooks.CurrentRow.Index].Add(item);
            friend.AddBookDrDr(DataBooks.CurrentRow);
            InfoLabelBookUserCountValue.Text = DataBooksInf.RowCount.ToString();
        }
        private void DataBooks_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right || e.RowIndex == -1) return;
            Lock_Flag = false;
            DataBooks.CurrentCell = DataBooks.Rows[e.RowIndex].Cells[0];///////////////////////////
            DataBooks.CurrentRow.Selected = true;
            Lock_Flag = true;
            DataBooks_SelectionChanged(1, new EventArgs());
            try { if (!friend.DataUserGrid.CurrentRow.Selected) return; }
            catch { return; }
            friend.DataCurrentUser.AllowDrop = true;
            friend.DataCurrentUser.DoDragDrop(DataBooks.CurrentRow, DragDropEffects.All);
            friend.DataCurrentUser.AllowDrop = false;
            InfoLabelBookUserCountValue.Text = DataBooksInf.RowCount.ToString();
            
        }
        private void Books_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataSet dataalll = new DataSet();
            dataalll.ReadXml("BD.xml");
            try { dataalll.Tables.Remove("Books"); }
            catch { }
            DataTable dt = new DataTable();
            dt.TableName = "Books";
            dt.Columns.Add("BooksName");
            dt.Columns.Add("Author");
            dt.Columns.Add("Genre");
            dt.Columns.Add("YearPublication");
            dt.Columns.Add("IndexesOfCurrentUsers");
            dataalll.Tables.Add(dt);
            foreach (DataGridViewRow row in DataBooks.Rows)
            {
                DataRow data = dataalll.Tables["Books"].NewRow();
                data["BooksName"] = row.Cells[0].Value.ToString();
                data["Author"] = row.Cells[1].Value.ToString();
                data["Genre"] = row.Cells[2].Value.ToString();
                data["YearPublication"] = row.Cells[3].Value.ToString();
                string indexesofbooks = "";
                for (int i = 0; i < Users[row.Index].Count; i++)
                    indexesofbooks += Users[row.Index][i].Index.ToString() + '.';
                data["IndexesOfCurrentUsers"] = indexesofbooks;
                dataalll.Tables["Books"].Rows.Add(data);
            }
            dataalll.WriteXml("BD.xml");
            if (!Lock_Flag) friend.Close();
        }
        private void Friend_FormClosing(object sender, FormClosingEventArgs e) => Lock_Flag = true;
        private void Search_Click(object sender, EventArgs e)
        {
            sf = new Search_form(this);
            sf.ShowDialog();
        }
        public async void Searching(SearchData data)
        {
            await helper.UnHideAllRowsAsyncUnsafe(DataBooks);
            int countOfRes = await helper.StartSearchAnsyc(data, DataBooks);
            MessageBox.Show("Совпадений найдено: " + countOfRes.ToString());
            sf.Close();
        }
        private void DataBooks_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (!Lock_Flag || !DataBooks.CurrentCell.IsInEditMode) return;
            Regex regEx;
            switch (e.ColumnIndex)
            {
                case 0:
                    string error_simbols = @"qwertyuiop[]asdfghjkl;zxcvbnm/\`|~#$%^&*()[]_+";
                    string text = e.FormattedValue.ToString().ToLower();
                    for (int i = 0; i < text.Length; i++)
                    {
                        if(error_simbols.IndexOf(text[i]) > 0)
                        {
                            MessageBox.Show("Вы ввели некорректное название книги");
                            goto default;
                        }
                    }
                    break;
                case 1:
                    regEx = new Regex(@"^([А-Я][а-я]+) (([А-Я][а-я]+)|([А-Я][а-я]+)-([А-Я][а-я]+))(( [А-Я][а-я]+)|)$");
                    Match match = regEx.Match(e.FormattedValue.ToString());
                    if (!match.Success)
                    {
                        MessageBox.Show("Вы ввели некорректное имя автора");
                        goto default;
                    }
                    break;
                case 2:
                    error_simbols = @"qwertyuiop[]asdfghjkl;zxcvbnm/\`|~#$%^&*()[]_+";
                    text = e.FormattedValue.ToString().ToLower();
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (error_simbols.IndexOf(text[i]) > 0)
                        {
                            MessageBox.Show("Вы ввели некорректное название жанра");
                            goto default;
                        }
                    }
                    break;
                case 3:
                    if (!int.TryParse(e.FormattedValue.ToString(), out int dd))
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
        }
        private void DataBooks_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) => Lock_Flag = true;
        private void DataBooks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Lock_Flag = false;
            friend.UpdateDataUserInf();
        }
        private void DataBooksInf_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Users[DataBooks.CurrentRow.Index].Count == 0) return;
            int indexOfUser = Users[DataBooks.CurrentRow.Index][e.RowIndex].Index;
            friend.SelectAndScrollToUser(indexOfUser);
            friend.Focus();
            friend.Select();
        }
    }
}