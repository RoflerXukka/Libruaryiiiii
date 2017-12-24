using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Search_form : Form
    {
        private Form owner;
        public Search_form(Users form)
        {
            InitializeComponent();
            StartSearch.Enabled = false;
            MultiThreadCheckBox.Checked = WordOllChekBox.Checked = true;
            MoveObj.BackColor = System.Drawing.Color.Transparent;
            CloSE.FlatAppearance.BorderSize = 0;
            owner = form;
            SearchPoly.Items.Add("Все поля");
            for (int i = 0; i < form.DataUserGrid.ColumnCount; i++)
                SearchPoly.Items.Add(form.DataUserGrid.Columns[i].HeaderText);
        }
        public Search_form(Books form)
        {
            InitializeComponent();
            StartSearch.Enabled = false;
            MultiThreadCheckBox.Checked = WordOllChekBox.Checked = true;
            MoveObj.BackColor = System.Drawing.Color.Transparent;
            CloSE.FlatAppearance.BorderSize = 0;
            owner = form;
            SearchPoly.Items.Add("Все поля");
            for (int i = 0; i < form.DataBooksGrid.ColumnCount; i++)
                SearchPoly.Items.Add(form.DataBooksGrid.Columns[i].HeaderText);
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
        private void Search_form_Deactivate(object sender, EventArgs e) => MoveObj.Focus();
        private void CloSE_Click(object sender, EventArgs e) => Close();
        private void CloSE_MouseMove(object sender, MouseEventArgs e) { CloSE.BackColor = Color.Crimson; CloSE.ForeColor = Color.White; }
        private void CloSE_MouseLeave(object sender, EventArgs e) { CloSE.BackColor = Color.Gainsboro; CloSE.ForeColor = Color.Black; }
        private void SearchPoly_SelectedIndexChanged(object sender, EventArgs e) => StartSearch.Enabled = true;
        private void StartSearch_Click(object sender, EventArgs e)
        {
            CloSE.Visible = false;
            StartSearch.Visible = false;
            MessageAboutSearch.Visible = true;
            MessageAboutSearch.Focus();
            switch (owner)
            {
                case Users usersForm:
                    SearchData data = new SearchData(0, usersForm.DataUserGrid.RowCount, SearchPoly.SelectedIndex == 0 ? 5 : SearchPoly.SelectedIndex - 1, KeyWord.Text, WordOllChekBox.Checked, RegistrOn.Checked, MultiThreadCheckBox.Checked);
                    usersForm.Searching(data);
                    break;
                case Books booksForm:
                    data = new SearchData(0, booksForm.DataBooksGrid.RowCount, SearchPoly.SelectedIndex == 0 ? 5 : SearchPoly.SelectedIndex - 1, KeyWord.Text, WordOllChekBox.Checked, RegistrOn.Checked, MultiThreadCheckBox.Checked);
                    booksForm.Searching(data);
                    break;
            }
        }
    }
}