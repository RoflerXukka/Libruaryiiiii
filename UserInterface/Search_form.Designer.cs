namespace UserInterface
{
    partial class Search_form
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
            this.MoveObj = new System.Windows.Forms.Label();
            this.CloSE = new System.Windows.Forms.Button();
            this.StartSearch = new MetroFramework.Controls.MetroButton();
            this.SearchPoly = new MetroFramework.Controls.MetroComboBox();
            this.WordOllChekBox = new MetroFramework.Controls.MetroCheckBox();
            this.KeyWord = new MetroFramework.Controls.MetroTextBox();
            this.RegistrOn = new MetroFramework.Controls.MetroCheckBox();
            this.MultiThreadCheckBox = new MetroFramework.Controls.MetroToggle();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.MessageAboutSearch = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // MoveObj
            // 
            this.MoveObj.Location = new System.Drawing.Point(0, -1);
            this.MoveObj.Name = "MoveObj";
            this.MoveObj.Size = new System.Drawing.Size(343, 47);
            this.MoveObj.TabIndex = 5;
            this.MoveObj.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveObj_MouseDown);
            // 
            // CloSE
            // 
            this.CloSE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloSE.BackColor = System.Drawing.Color.Gainsboro;
            this.CloSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloSE.Location = new System.Drawing.Point(295, 2);
            this.CloSE.Name = "CloSE";
            this.CloSE.Size = new System.Drawing.Size(40, 40);
            this.CloSE.TabIndex = 6;
            this.CloSE.TabStop = false;
            this.CloSE.Text = "X";
            this.CloSE.UseVisualStyleBackColor = false;
            this.CloSE.Click += new System.EventHandler(this.CloSE_Click);
            this.CloSE.MouseLeave += new System.EventHandler(this.CloSE_MouseLeave);
            this.CloSE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloSE_MouseMove);
            // 
            // StartSearch
            // 
            this.StartSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StartSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartSearch.Location = new System.Drawing.Point(114, 151);
            this.StartSearch.Name = "StartSearch";
            this.StartSearch.Size = new System.Drawing.Size(125, 32);
            this.StartSearch.TabIndex = 16;
            this.StartSearch.Text = "Найти";
            this.StartSearch.UseCustomBackColor = true;
            this.StartSearch.UseCustomForeColor = true;
            this.StartSearch.UseSelectable = true;
            this.StartSearch.UseStyleColors = true;
            this.StartSearch.Click += new System.EventHandler(this.StartSearch_Click);
            // 
            // SearchPoly
            // 
            this.SearchPoly.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchPoly.ForeColor = System.Drawing.SystemColors.Window;
            this.SearchPoly.FormatString = "Поле для поиска";
            this.SearchPoly.FormattingEnabled = true;
            this.SearchPoly.ItemHeight = 23;
            this.SearchPoly.Location = new System.Drawing.Point(13, 50);
            this.SearchPoly.Name = "SearchPoly";
            this.SearchPoly.PromptText = "Поле для поиска";
            this.SearchPoly.Size = new System.Drawing.Size(142, 29);
            this.SearchPoly.TabIndex = 17;
            this.SearchPoly.Text = "Поле для поиска";
            this.SearchPoly.UseCustomBackColor = true;
            this.SearchPoly.UseCustomForeColor = true;
            this.SearchPoly.UseSelectable = true;
            this.SearchPoly.UseStyleColors = true;
            this.SearchPoly.SelectedIndexChanged += new System.EventHandler(this.SearchPoly_SelectedIndexChanged);
            // 
            // WordOllChekBox
            // 
            this.WordOllChekBox.AutoSize = true;
            this.WordOllChekBox.BackColor = System.Drawing.Color.Gainsboro;
            this.WordOllChekBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.WordOllChekBox.Location = new System.Drawing.Point(180, 57);
            this.WordOllChekBox.Name = "WordOllChekBox";
            this.WordOllChekBox.Size = new System.Drawing.Size(110, 15);
            this.WordOllChekBox.TabIndex = 18;
            this.WordOllChekBox.Text = "Слово целиком";
            this.WordOllChekBox.UseCustomBackColor = true;
            this.WordOllChekBox.UseSelectable = true;
            // 
            // KeyWord
            // 
            // 
            // 
            // 
            this.KeyWord.CustomButton.Image = null;
            this.KeyWord.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.KeyWord.CustomButton.Name = "";
            this.KeyWord.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.KeyWord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.KeyWord.CustomButton.TabIndex = 1;
            this.KeyWord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.KeyWord.CustomButton.UseSelectable = true;
            this.KeyWord.CustomButton.Visible = false;
            this.KeyWord.Lines = new string[0];
            this.KeyWord.Location = new System.Drawing.Point(180, 122);
            this.KeyWord.MaxLength = 32767;
            this.KeyWord.Name = "KeyWord";
            this.KeyWord.PasswordChar = '\0';
            this.KeyWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.KeyWord.SelectedText = "";
            this.KeyWord.SelectionLength = 0;
            this.KeyWord.SelectionStart = 0;
            this.KeyWord.ShortcutsEnabled = true;
            this.KeyWord.Size = new System.Drawing.Size(127, 23);
            this.KeyWord.TabIndex = 19;
            this.KeyWord.UseSelectable = true;
            this.KeyWord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.KeyWord.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // RegistrOn
            // 
            this.RegistrOn.AutoSize = true;
            this.RegistrOn.BackColor = System.Drawing.Color.Gainsboro;
            this.RegistrOn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegistrOn.Location = new System.Drawing.Point(180, 75);
            this.RegistrOn.Name = "RegistrOn";
            this.RegistrOn.Size = new System.Drawing.Size(127, 15);
            this.RegistrOn.TabIndex = 20;
            this.RegistrOn.Text = "Учитывать регистр";
            this.RegistrOn.UseCustomBackColor = true;
            this.RegistrOn.UseSelectable = true;
            // 
            // MultiThreadCheckBox
            // 
            this.MultiThreadCheckBox.AutoSize = true;
            this.MultiThreadCheckBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MultiThreadCheckBox.Checked = true;
            this.MultiThreadCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MultiThreadCheckBox.Location = new System.Drawing.Point(12, 128);
            this.MultiThreadCheckBox.Name = "MultiThreadCheckBox";
            this.MultiThreadCheckBox.Size = new System.Drawing.Size(80, 17);
            this.MultiThreadCheckBox.TabIndex = 21;
            this.MultiThreadCheckBox.Text = "On";
            this.MultiThreadCheckBox.UseCustomBackColor = true;
            this.MultiThreadCheckBox.UseSelectable = true;
            // 
            // InformationLabel
            // 
            this.InformationLabel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.InformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InformationLabel.Location = new System.Drawing.Point(9, 98);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(135, 30);
            this.InformationLabel.TabIndex = 22;
            this.InformationLabel.Text = "Использовать многопоточный поиск";
            // 
            // MessageAboutSearch
            // 
            this.MessageAboutSearch.AutoSize = true;
            this.MessageAboutSearch.BackColor = System.Drawing.Color.LightGray;
            this.MessageAboutSearch.Location = new System.Drawing.Point(138, 157);
            this.MessageAboutSearch.Name = "MessageAboutSearch";
            this.MessageAboutSearch.Size = new System.Drawing.Size(77, 19);
            this.MessageAboutSearch.TabIndex = 23;
            this.MessageAboutSearch.Text = "Поиск идет";
            this.MessageAboutSearch.UseCustomBackColor = true;
            this.MessageAboutSearch.UseCustomForeColor = true;
            this.MessageAboutSearch.Visible = false;
            // 
            // Search_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UserInterface.Properties.Resources.back_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(341, 195);
            this.Controls.Add(this.MessageAboutSearch);
            this.Controls.Add(this.InformationLabel);
            this.Controls.Add(this.MultiThreadCheckBox);
            this.Controls.Add(this.RegistrOn);
            this.Controls.Add(this.KeyWord);
            this.Controls.Add(this.WordOllChekBox);
            this.Controls.Add(this.SearchPoly);
            this.Controls.Add(this.StartSearch);
            this.Controls.Add(this.CloSE);
            this.Controls.Add(this.MoveObj);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search_form";
            this.TransparencyKey = System.Drawing.Color.Salmon;
            this.Deactivate += new System.EventHandler(this.Search_form_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MoveObj;
        private System.Windows.Forms.Button CloSE;
        private MetroFramework.Controls.MetroButton StartSearch;
        private MetroFramework.Controls.MetroComboBox SearchPoly;
        private MetroFramework.Controls.MetroCheckBox WordOllChekBox;
        private MetroFramework.Controls.MetroTextBox KeyWord;
        private MetroFramework.Controls.MetroCheckBox RegistrOn;
        private MetroFramework.Controls.MetroToggle MultiThreadCheckBox;
        private System.Windows.Forms.Label InformationLabel;
        private MetroFramework.Controls.MetroLabel MessageAboutSearch;
    }
}