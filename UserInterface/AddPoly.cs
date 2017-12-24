using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace UserInterface
{
    public partial class AddPoly : Form
    {
        private Form ownerform;
        public AddPoly(Users main)
        {
            InitializeComponent();
            ownerform = main;
            MoveObj.BackColor = System.Drawing.Color.Transparent;
            CLOSE.FlatAppearance.BorderSize = 0;
            this.FirstText.Text = "Ф.И.О клиента";
            this.SecondText.Text = "Адрес клиента";
            this.ThirdText.Visible = false;
            this.ThirdPoly.Visible = false;
            this.FourthText.Visible = false;
            this.FourthPoly.Visible = false;
            this.Height = 200;
            this.AddPolys.Location = new System.Drawing.Point(59, 150);
            this.Cancel.Location = new System.Drawing.Point(304, 150);
            ProgressSpinner.Location = new System.Drawing.Point(87, 150);
        }
        public AddPoly(Books main)
        {
            InitializeComponent();
            ownerform = main;
            MoveObj.BackColor = System.Drawing.Color.Transparent;
            CLOSE.FlatAppearance.BorderSize = 0;
            this.FirstText.Text = "Название книги";
            this.SecondText.Text = "Автор";
            this.ThirdText.Text = "Жанр";
            this.FourthText.Text = "Год";
        }
        private const int CS_DROPSHADOW = 0x00020000;
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
        }
        private void AddPolys_Click(object sender, EventArgs e)
        {
            Regex regEx;
            if (ownerform is Users users)
            {
                if (FirstPoly.Text.Length == 0 || SecondPoly.Text.Length == 0 )
                {
                    MessageBox.Show("Все поля должны быть заполнены");
                    return;
                }
                regEx = new Regex(@"^([А-Я][а-я]+) (([А-Я][а-я]+)|([А-Я][а-я]+)-([А-Я][а-я]+))(( [А-Я][а-я]+)|)$");
                Match match = regEx.Match(FirstPoly.Text);
                if (!match.Success)
                {
                    MessageBox.Show("Вы ввели некорректную абривиатуру ФИО пользователя");
                    return;
                }
                regEx = new Regex(@"^(((ул. [А-Я][а-я]+)|((пр|пр-т). [А-Я][а-я]+)|([А-Я][а-я]+ (тр|тркт).)), дом [0-9]{1,})$");
                match = regEx.Match(SecondPoly.Text);
                if (!match.Success)
                {
                    MessageBox.Show("Вы ввели некорректный адрес проживания пользователя");
                    return;
                }
                users.AddToDATA(FirstPoly.Text, SecondPoly.Text);
            }
            else
            {
                
                if (FirstPoly.Text.Length == 0 || SecondPoly.Text.Length == 0 || ThirdPoly.Text.Length == 0 || FourthPoly.Text.Length == 0)
                {
                    MessageBox.Show("Все поля должны быть заполнены");
                    return;
                }
                string error_simbols = @"qwertyuiop[]asdfghjkl;zxcvbnm/\`|~#$%^&*()[]_+";
                string text = FirstPoly.Text.ToLower();
                for (int i = 0; i < text.Length; i++)
                {
                    if (error_simbols.IndexOf(text[i]) > 0)
                    {
                        MessageBox.Show("Вы ввели некорректное название книги");
                        return;
                    }
                }
                regEx = new Regex(@"^([А-Я][а-я]+) (([А-Я][а-я]+)|([А-Я][а-я]+)-([А-Я][а-я]+))(( [А-Я][а-я]+)|)$");
                Match match = regEx.Match(SecondPoly.Text);
                if (!match.Success)
                {
                    MessageBox.Show("Вы ввели некорректную абривиатуру ФИО автора");
                    return;
                }
                text = ThirdPoly.Text.ToLower();
                for (int i = 0; i < text.Length; i++)
                {
                    if (error_simbols.IndexOf(text[i]) > 0)
                    {
                        MessageBox.Show("Вы ввели некорректное название жанра");
                        return;
                    }
                }
                if (!int.TryParse(FourthPoly.Text, out int dd))
                {
                    MessageBox.Show("Вы ввели некорректную дату выхода");
                    return;
                }
                ((Books)ownerform).AddToDATA(FirstPoly.Text, SecondPoly.Text, ThirdPoly.Text, FourthPoly.Text);
            }

        }
        private void Cancel_Click(object sender, EventArgs e) => Close();
        private void MoveObj_MouseDown(object sender, MouseEventArgs e)
        {
            MoveObj.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
        private void CLOSE_Click(object sender, EventArgs e) => Close();
        private void CLOSE_MouseMove(object sender, MouseEventArgs e) { CLOSE.BackColor = Color.Crimson; CLOSE.ForeColor = Color.White; }
        private void CLOSE_MouseLeave(object sender, EventArgs e) { CLOSE.BackColor = Color.Gainsboro; CLOSE.ForeColor = Color.Black; }
    }
}