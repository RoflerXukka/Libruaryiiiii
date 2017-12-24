namespace UserInterface
{
    partial class Books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataBooks = new System.Windows.Forms.DataGridView();
            this.Boooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearPubl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MINIMASE = new System.Windows.Forms.Button();
            this.CLOSE = new System.Windows.Forms.Button();
            this.MoveObj = new System.Windows.Forms.Label();
            this.DataBooksInf = new MetroFramework.Controls.MetroGrid();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddTooo = new MetroFramework.Controls.MetroButton();
            this.Delete = new MetroFramework.Controls.MetroButton();
            this.Search = new MetroFramework.Controls.MetroButton();
            this.InfoLabelBookUserCountValue = new System.Windows.Forms.Label();
            this.InfoLabelBookUserCount = new System.Windows.Forms.Label();
            this.InfoLabelBooksCount = new System.Windows.Forms.Label();
            this.InfoAboutGrid = new System.Windows.Forms.Label();
            this.CountOfBooksTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBooksInf)).BeginInit();
            this.SuspendLayout();
            // 
            // DataBooks
            // 
            this.DataBooks.AllowUserToAddRows = false;
            this.DataBooks.AllowUserToResizeColumns = false;
            this.DataBooks.AllowUserToResizeRows = false;
            this.DataBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataBooks.ColumnHeadersHeight = 28;
            this.DataBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Boooks,
            this.Author,
            this.Genre,
            this.YearPubl});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataBooks.EnableHeadersVisualStyles = false;
            this.DataBooks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataBooks.Location = new System.Drawing.Point(12, 59);
            this.DataBooks.MultiSelect = false;
            this.DataBooks.Name = "DataBooks";
            this.DataBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.DataBooks.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataBooks.Size = new System.Drawing.Size(518, 289);
            this.DataBooks.TabIndex = 10;
            this.DataBooks.TabStop = false;
            this.DataBooks.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataBooks_CellBeginEdit);
            this.DataBooks.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBooks_CellEndEdit);
            this.DataBooks.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataBooks_CellMouseDown);
            this.DataBooks.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DataBooks_CellValidating);
            this.DataBooks.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataBooks_UserDeletingRow);
            this.DataBooks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataBooks_KeyDown);
            this.DataBooks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataBooks_MouseClick);
            // 
            // Boooks
            // 
            this.Boooks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Boooks.DividerWidth = 1;
            this.Boooks.HeaderText = "Название книги";
            this.Boooks.Name = "Boooks";
            this.Boooks.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Boooks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Boooks.Width = 125;
            // 
            // Author
            // 
            this.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Author.DividerWidth = 1;
            this.Author.HeaderText = "Автор";
            this.Author.Name = "Author";
            this.Author.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Author.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Author.Width = 125;
            // 
            // Genre
            // 
            this.Genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Genre.DividerWidth = 1;
            this.Genre.HeaderText = "Жанр";
            this.Genre.Name = "Genre";
            this.Genre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Genre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Genre.Width = 110;
            // 
            // YearPubl
            // 
            this.YearPubl.HeaderText = "Год";
            this.YearPubl.Name = "YearPubl";
            this.YearPubl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MINIMASE
            // 
            this.MINIMASE.BackColor = System.Drawing.Color.Gainsboro;
            this.MINIMASE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MINIMASE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MINIMASE.Location = new System.Drawing.Point(765, 2);
            this.MINIMASE.Name = "MINIMASE";
            this.MINIMASE.Size = new System.Drawing.Size(40, 40);
            this.MINIMASE.TabIndex = 13;
            this.MINIMASE.TabStop = false;
            this.MINIMASE.Text = "—";
            this.MINIMASE.UseVisualStyleBackColor = false;
            this.MINIMASE.Click += new System.EventHandler(this.MINIMASE_Click);
            this.MINIMASE.MouseLeave += new System.EventHandler(this.MINIMASE_MouseLeave);
            this.MINIMASE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MINIMASE_MouseMove);
            // 
            // CLOSE
            // 
            this.CLOSE.BackColor = System.Drawing.Color.Gainsboro;
            this.CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CLOSE.Location = new System.Drawing.Point(805, 2);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(40, 40);
            this.CLOSE.TabIndex = 12;
            this.CLOSE.Text = "X";
            this.CLOSE.UseVisualStyleBackColor = false;
            this.CLOSE.Click += new System.EventHandler(this.CLOSE_Click);
            this.CLOSE.MouseLeave += new System.EventHandler(this.CLOSE_MouseLeave);
            this.CLOSE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CLOSE_MouseMove);
            // 
            // MoveObj
            // 
            this.MoveObj.Location = new System.Drawing.Point(-1, -4);
            this.MoveObj.Name = "MoveObj";
            this.MoveObj.Size = new System.Drawing.Size(855, 60);
            this.MoveObj.TabIndex = 11;
            this.MoveObj.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveObj_MouseDown);
            // 
            // DataBooksInf
            // 
            this.DataBooksInf.AllowUserToAddRows = false;
            this.DataBooksInf.AllowUserToResizeColumns = false;
            this.DataBooksInf.AllowUserToResizeRows = false;
            this.DataBooksInf.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataBooksInf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataBooksInf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataBooksInf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataBooksInf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataBooksInf.ColumnHeadersHeight = 28;
            this.DataBooksInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataBooksInf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.Adress});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataBooksInf.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataBooksInf.EnableHeadersVisualStyles = false;
            this.DataBooksInf.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataBooksInf.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataBooksInf.Location = new System.Drawing.Point(537, 59);
            this.DataBooksInf.MultiSelect = false;
            this.DataBooksInf.Name = "DataBooksInf";
            this.DataBooksInf.ReadOnly = true;
            this.DataBooksInf.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataBooksInf.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataBooksInf.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataBooksInf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataBooksInf.Size = new System.Drawing.Size(308, 150);
            this.DataBooksInf.TabIndex = 14;
            this.DataBooksInf.TabStop = false;
            this.DataBooksInf.UseCustomBackColor = true;
            this.DataBooksInf.UseCustomForeColor = true;
            this.DataBooksInf.UseStyleColors = true;
            this.DataBooksInf.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBooksInf_CellDoubleClick);
            this.DataBooksInf.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataBooksInf_UserDeletingRow);
            this.DataBooksInf.DragDrop += new System.Windows.Forms.DragEventHandler(this.DataBooksInf_DragDrop);
            this.DataBooksInf.DragOver += new System.Windows.Forms.DragEventHandler(this.DataBooksInf_DragOver);
            this.DataBooksInf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataBooksInf_KeyDown);
            this.DataBooksInf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataBooksInf_MouseClick);
            // 
            // User
            // 
            this.User.DividerWidth = 1;
            this.User.HeaderText = "Клиент";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.User.Width = 125;
            // 
            // Adress
            // 
            this.Adress.HeaderText = "Адрес";
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Adress.Width = 125;
            // 
            // AddTooo
            // 
            this.AddTooo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddTooo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddTooo.Location = new System.Drawing.Point(537, 282);
            this.AddTooo.Name = "AddTooo";
            this.AddTooo.Size = new System.Drawing.Size(170, 65);
            this.AddTooo.TabIndex = 15;
            this.AddTooo.Text = "Добавить книгу";
            this.AddTooo.UseCustomBackColor = true;
            this.AddTooo.UseCustomForeColor = true;
            this.AddTooo.UseSelectable = true;
            this.AddTooo.UseStyleColors = true;
            this.AddTooo.Click += new System.EventHandler(this.AddTooo_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Location = new System.Drawing.Point(717, 317);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(128, 30);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "Удалить...";
            this.Delete.UseCustomBackColor = true;
            this.Delete.UseCustomForeColor = true;
            this.Delete.UseSelectable = true;
            this.Delete.UseStyleColors = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Search.Location = new System.Drawing.Point(717, 282);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(128, 29);
            this.Search.TabIndex = 17;
            this.Search.TabStop = false;
            this.Search.Text = "Поиск книги";
            this.Search.UseCustomBackColor = true;
            this.Search.UseCustomForeColor = true;
            this.Search.UseSelectable = true;
            this.Search.UseStyleColors = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // InfoLabelBookUserCountValue
            // 
            this.InfoLabelBookUserCountValue.AutoSize = true;
            this.InfoLabelBookUserCountValue.BackColor = System.Drawing.Color.Gainsboro;
            this.InfoLabelBookUserCountValue.Location = new System.Drawing.Point(791, 250);
            this.InfoLabelBookUserCountValue.Name = "InfoLabelBookUserCountValue";
            this.InfoLabelBookUserCountValue.Size = new System.Drawing.Size(9, 13);
            this.InfoLabelBookUserCountValue.TabIndex = 22;
            this.InfoLabelBookUserCountValue.Text = "|";
            this.InfoLabelBookUserCountValue.Visible = false;
            // 
            // InfoLabelBookUserCount
            // 
            this.InfoLabelBookUserCount.AutoSize = true;
            this.InfoLabelBookUserCount.BackColor = System.Drawing.Color.Gainsboro;
            this.InfoLabelBookUserCount.Location = new System.Drawing.Point(537, 250);
            this.InfoLabelBookUserCount.Name = "InfoLabelBookUserCount";
            this.InfoLabelBookUserCount.Size = new System.Drawing.Size(248, 13);
            this.InfoLabelBookUserCount.TabIndex = 21;
            this.InfoLabelBookUserCount.Text = "Количество пользователей у выбранной книги:";
            this.InfoLabelBookUserCount.Visible = false;
            // 
            // InfoLabelBooksCount
            // 
            this.InfoLabelBooksCount.AutoSize = true;
            this.InfoLabelBooksCount.BackColor = System.Drawing.Color.Gainsboro;
            this.InfoLabelBooksCount.Location = new System.Drawing.Point(537, 237);
            this.InfoLabelBooksCount.Name = "InfoLabelBooksCount";
            this.InfoLabelBooksCount.Size = new System.Drawing.Size(95, 13);
            this.InfoLabelBooksCount.TabIndex = 20;
            this.InfoLabelBooksCount.Text = "Количество книг:";
            // 
            // InfoAboutGrid
            // 
            this.InfoAboutGrid.AutoSize = true;
            this.InfoAboutGrid.BackColor = System.Drawing.Color.Gainsboro;
            this.InfoAboutGrid.Location = new System.Drawing.Point(534, 224);
            this.InfoAboutGrid.Name = "InfoAboutGrid";
            this.InfoAboutGrid.Size = new System.Drawing.Size(109, 13);
            this.InfoAboutGrid.TabIndex = 19;
            this.InfoAboutGrid.Text = "Общая информация";
            // 
            // CountOfBooksTotal
            // 
            this.CountOfBooksTotal.AutoSize = true;
            this.CountOfBooksTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.CountOfBooksTotal.Location = new System.Drawing.Point(638, 237);
            this.CountOfBooksTotal.Name = "CountOfBooksTotal";
            this.CountOfBooksTotal.Size = new System.Drawing.Size(13, 13);
            this.CountOfBooksTotal.TabIndex = 18;
            this.CountOfBooksTotal.Text = "0";
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UserInterface.Properties.Resources.back_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 359);
            this.ControlBox = false;
            this.Controls.Add(this.InfoLabelBookUserCountValue);
            this.Controls.Add(this.InfoLabelBookUserCount);
            this.Controls.Add(this.InfoLabelBooksCount);
            this.Controls.Add(this.InfoAboutGrid);
            this.Controls.Add(this.CountOfBooksTotal);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.AddTooo);
            this.Controls.Add(this.DataBooksInf);
            this.Controls.Add(this.MINIMASE);
            this.Controls.Add(this.CLOSE);
            this.Controls.Add(this.MoveObj);
            this.Controls.Add(this.DataBooks);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Books";
            this.ShowIcon = false;
            this.Text = "Книги";
            this.Deactivate += new System.EventHandler(this.Books_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Books_FormClosing);
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBooksInf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataBooks;
        private System.Windows.Forms.Button MINIMASE;
        private System.Windows.Forms.Button CLOSE;
        private System.Windows.Forms.Label MoveObj;
        private MetroFramework.Controls.MetroGrid DataBooksInf;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private MetroFramework.Controls.MetroButton AddTooo;
        private MetroFramework.Controls.MetroButton Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Boooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearPubl;
        private MetroFramework.Controls.MetroButton Search;
        private System.Windows.Forms.Label InfoLabelBookUserCountValue;
        private System.Windows.Forms.Label InfoLabelBookUserCount;
        private System.Windows.Forms.Label InfoLabelBooksCount;
        private System.Windows.Forms.Label InfoAboutGrid;
        private System.Windows.Forms.Label CountOfBooksTotal;
    }
}