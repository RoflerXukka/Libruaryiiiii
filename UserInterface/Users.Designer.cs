namespace UserInterface
{
    partial class Users
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
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
            this.MoveObj = new System.Windows.Forms.Label();
            this.CLOSE = new System.Windows.Forms.Button();
            this.MINIMASE = new System.Windows.Forms.Button();
            this.AddTooo = new MetroFramework.Controls.MetroButton();
            this.Delete = new MetroFramework.Controls.MetroButton();
            this.DataUsers = new System.Windows.Forms.DataGridView();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NberOfReatedB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataUserInf = new MetroFramework.Controls.MetroGrid();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search = new MetroFramework.Controls.MetroButton();
            this.CountOfUsersTotal = new System.Windows.Forms.Label();
            this.InfoAboutGrid = new System.Windows.Forms.Label();
            this.InfoLabelUsersCount = new System.Windows.Forms.Label();
            this.InfoLabelUserBookCount = new System.Windows.Forms.Label();
            this.InfoLabelUserBookCountValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataUserInf)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveObj
            // 
            this.MoveObj.Location = new System.Drawing.Point(1, 1);
            this.MoveObj.Name = "MoveObj";
            this.MoveObj.Size = new System.Drawing.Size(864, 60);
            this.MoveObj.TabIndex = 0;
            this.MoveObj.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveObj_MouseDown);
            // 
            // CLOSE
            // 
            this.CLOSE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CLOSE.BackColor = System.Drawing.Color.Gainsboro;
            this.CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CLOSE.Location = new System.Drawing.Point(815, 2);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(40, 40);
            this.CLOSE.TabIndex = 1;
            this.CLOSE.TabStop = false;
            this.CLOSE.Text = "X";
            this.CLOSE.UseVisualStyleBackColor = false;
            this.CLOSE.Click += new System.EventHandler(this.CLOSE_Click);
            this.CLOSE.MouseLeave += new System.EventHandler(this.CLOSE_MouseLeave);
            this.CLOSE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CLOSE_MouseMove);
            // 
            // MINIMASE
            // 
            this.MINIMASE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MINIMASE.BackColor = System.Drawing.Color.Gainsboro;
            this.MINIMASE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MINIMASE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MINIMASE.Location = new System.Drawing.Point(776, 2);
            this.MINIMASE.Name = "MINIMASE";
            this.MINIMASE.Size = new System.Drawing.Size(40, 40);
            this.MINIMASE.TabIndex = 2;
            this.MINIMASE.TabStop = false;
            this.MINIMASE.Text = "—";
            this.MINIMASE.UseVisualStyleBackColor = false;
            this.MINIMASE.Click += new System.EventHandler(this.MINIMASE_Click);
            this.MINIMASE.MouseLeave += new System.EventHandler(this.MINIMASE_MouseLeave);
            this.MINIMASE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MINIMASE_MouseMove);
            // 
            // AddTooo
            // 
            this.AddTooo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddTooo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddTooo.Location = new System.Drawing.Point(487, 287);
            this.AddTooo.Name = "AddTooo";
            this.AddTooo.Size = new System.Drawing.Size(188, 65);
            this.AddTooo.TabIndex = 5;
            this.AddTooo.TabStop = false;
            this.AddTooo.Text = "Добавить пользователя";
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
            this.Delete.Location = new System.Drawing.Point(681, 320);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(162, 32);
            this.Delete.TabIndex = 8;
            this.Delete.TabStop = false;
            this.Delete.Text = "Удалить...";
            this.Delete.UseCustomBackColor = true;
            this.Delete.UseCustomForeColor = true;
            this.Delete.UseSelectable = true;
            this.Delete.UseStyleColors = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DataUsers
            // 
            this.DataUsers.AllowUserToAddRows = false;
            this.DataUsers.AllowUserToResizeColumns = false;
            this.DataUsers.AllowUserToResizeRows = false;
            this.DataUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataUsers.ColumnHeadersHeight = 28;
            this.DataUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.Adres,
            this.NberOfReatedB});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DataUsers.EnableHeadersVisualStyles = false;
            this.DataUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataUsers.Location = new System.Drawing.Point(9, 63);
            this.DataUsers.MultiSelect = false;
            this.DataUsers.Name = "DataUsers";
            this.DataUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.DataUsers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataUsers.Size = new System.Drawing.Size(471, 289);
            this.DataUsers.TabIndex = 9;
            this.DataUsers.TabStop = false;
            this.DataUsers.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataUsers_CellBeginEdit);
            this.DataUsers.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataUsers_CellEndEdit);
            this.DataUsers.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataUsers_CellMouseDown);
            this.DataUsers.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataUsers_UserDeletingRow);
            this.DataUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataUsers_KeyDown);
            this.DataUsers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataUsers_MouseClick);
            // 
            // User
            // 
            this.User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.User.DividerWidth = 1;
            this.User.HeaderText = "Клиент";
            this.User.Name = "User";
            this.User.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.User.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.User.Width = 150;
            // 
            // Adres
            // 
            this.Adres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Adres.DividerWidth = 1;
            this.Adres.HeaderText = "Адрес";
            this.Adres.Name = "Adres";
            this.Adres.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Adres.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Adres.Width = 150;
            // 
            // NberOfReatedB
            // 
            this.NberOfReatedB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NberOfReatedB.HeaderText = "Прочитано книг";
            this.NberOfReatedB.Name = "NberOfReatedB";
            this.NberOfReatedB.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NberOfReatedB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NberOfReatedB.Width = 113;
            // 
            // DataUserInf
            // 
            this.DataUserInf.AllowUserToAddRows = false;
            this.DataUserInf.AllowUserToResizeRows = false;
            this.DataUserInf.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataUserInf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataUserInf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataUserInf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataUserInf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataUserInf.ColumnHeadersHeight = 28;
            this.DataUserInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataUserInf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book,
            this.Author,
            this.DateAdd});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataUserInf.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataUserInf.EnableHeadersVisualStyles = false;
            this.DataUserInf.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataUserInf.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataUserInf.Location = new System.Drawing.Point(487, 64);
            this.DataUserInf.MultiSelect = false;
            this.DataUserInf.Name = "DataUserInf";
            this.DataUserInf.ReadOnly = true;
            this.DataUserInf.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataUserInf.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataUserInf.RowHeadersWidth = 28;
            this.DataUserInf.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataUserInf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataUserInf.Size = new System.Drawing.Size(368, 166);
            this.DataUserInf.TabIndex = 10;
            this.DataUserInf.TabStop = false;
            this.DataUserInf.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataUserInf_CellDoubleClick);
            this.DataUserInf.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataUserInf_UserDeletingRow);
            this.DataUserInf.DragDrop += new System.Windows.Forms.DragEventHandler(this.DataUserInf_DragDrop);
            this.DataUserInf.DragOver += new System.Windows.Forms.DragEventHandler(this.DataUserInf_DragOver);
            this.DataUserInf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataUserInf_KeyDown);
            this.DataUserInf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataUserInf_MouseClick);
            // 
            // Book
            // 
            this.Book.DividerWidth = 1;
            this.Book.HeaderText = "Книга";
            this.Book.Name = "Book";
            this.Book.ReadOnly = true;
            this.Book.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Book.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Book.Width = 120;
            // 
            // Author
            // 
            this.Author.DividerWidth = 1;
            this.Author.HeaderText = "Автор";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Author.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DateAdd
            // 
            this.DateAdd.HeaderText = "Дата добавления";
            this.DateAdd.Name = "DateAdd";
            this.DateAdd.ReadOnly = true;
            this.DateAdd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DateAdd.Width = 103;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Search.Location = new System.Drawing.Point(681, 287);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(162, 32);
            this.Search.TabIndex = 11;
            this.Search.TabStop = false;
            this.Search.Text = "Поиск полльзователя";
            this.Search.UseCustomBackColor = true;
            this.Search.UseCustomForeColor = true;
            this.Search.UseSelectable = true;
            this.Search.UseStyleColors = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // CountOfUsersTotal
            // 
            this.CountOfUsersTotal.AutoSize = true;
            this.CountOfUsersTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.CountOfUsersTotal.Location = new System.Drawing.Point(645, 250);
            this.CountOfUsersTotal.Name = "CountOfUsersTotal";
            this.CountOfUsersTotal.Size = new System.Drawing.Size(13, 13);
            this.CountOfUsersTotal.TabIndex = 12;
            this.CountOfUsersTotal.Text = "0";
            // 
            // InfoAboutGrid
            // 
            this.InfoAboutGrid.AutoSize = true;
            this.InfoAboutGrid.BackColor = System.Drawing.Color.Gainsboro;
            this.InfoAboutGrid.Location = new System.Drawing.Point(487, 237);
            this.InfoAboutGrid.Name = "InfoAboutGrid";
            this.InfoAboutGrid.Size = new System.Drawing.Size(109, 13);
            this.InfoAboutGrid.TabIndex = 13;
            this.InfoAboutGrid.Text = "Общая информация";
            // 
            // InfoLabelUsersCount
            // 
            this.InfoLabelUsersCount.AutoSize = true;
            this.InfoLabelUsersCount.BackColor = System.Drawing.Color.Gainsboro;
            this.InfoLabelUsersCount.Location = new System.Drawing.Point(490, 250);
            this.InfoLabelUsersCount.Name = "InfoLabelUsersCount";
            this.InfoLabelUsersCount.Size = new System.Drawing.Size(149, 13);
            this.InfoLabelUsersCount.TabIndex = 14;
            this.InfoLabelUsersCount.Text = "Количество пользователей:";
            // 
            // InfoLabelUserBookCount
            // 
            this.InfoLabelUserBookCount.AutoSize = true;
            this.InfoLabelUserBookCount.BackColor = System.Drawing.Color.Gainsboro;
            this.InfoLabelUserBookCount.Location = new System.Drawing.Point(490, 263);
            this.InfoLabelUserBookCount.Name = "InfoLabelUserBookCount";
            this.InfoLabelUserBookCount.Size = new System.Drawing.Size(241, 13);
            this.InfoLabelUserBookCount.TabIndex = 15;
            this.InfoLabelUserBookCount.Text = "Количество книг у выбранного пользователя:";
            this.InfoLabelUserBookCount.Visible = false;
            // 
            // InfoLabelUserBookCountValue
            // 
            this.InfoLabelUserBookCountValue.AutoSize = true;
            this.InfoLabelUserBookCountValue.BackColor = System.Drawing.Color.Gainsboro;
            this.InfoLabelUserBookCountValue.Location = new System.Drawing.Point(737, 263);
            this.InfoLabelUserBookCountValue.Name = "InfoLabelUserBookCountValue";
            this.InfoLabelUserBookCountValue.Size = new System.Drawing.Size(9, 13);
            this.InfoLabelUserBookCountValue.TabIndex = 16;
            this.InfoLabelUserBookCountValue.Text = "|";
            this.InfoLabelUserBookCountValue.Visible = false;
            // 
            // Users
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::UserInterface.Properties.Resources.back_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 362);
            this.ControlBox = false;
            this.Controls.Add(this.InfoLabelUserBookCountValue);
            this.Controls.Add(this.InfoLabelUserBookCount);
            this.Controls.Add(this.InfoLabelUsersCount);
            this.Controls.Add(this.InfoAboutGrid);
            this.Controls.Add(this.DataUsers);
            this.Controls.Add(this.CountOfUsersTotal);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.DataUserInf);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.AddTooo);
            this.Controls.Add(this.MINIMASE);
            this.Controls.Add(this.CLOSE);
            this.Controls.Add(this.MoveObj);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Users";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Users_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataUserInf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MoveObj;
        private System.Windows.Forms.Button CLOSE;
        private System.Windows.Forms.Button MINIMASE;
        private MetroFramework.Controls.MetroButton AddTooo;
        private MetroFramework.Controls.MetroButton Delete;
        private MetroFramework.Controls.MetroGrid DataUserInf;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn NberOfReatedB;
        private MetroFramework.Controls.MetroButton Search;
        private System.Windows.Forms.Label CountOfUsersTotal;
        private System.Windows.Forms.DataGridView DataUsers;
        private System.Windows.Forms.Label InfoAboutGrid;
        private System.Windows.Forms.Label InfoLabelUsersCount;
        private System.Windows.Forms.Label InfoLabelUserBookCount;
        private System.Windows.Forms.Label InfoLabelUserBookCountValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAdd;
    }
}

