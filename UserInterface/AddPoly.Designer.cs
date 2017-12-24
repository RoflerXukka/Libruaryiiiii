namespace UserInterface
{
    partial class AddPoly
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
            this.FirstPoly = new System.Windows.Forms.TextBox();
            this.SecondPoly = new System.Windows.Forms.TextBox();
            this.ThirdPoly = new System.Windows.Forms.TextBox();
            this.FirstText = new System.Windows.Forms.Label();
            this.SecondText = new System.Windows.Forms.Label();
            this.ThirdText = new System.Windows.Forms.Label();
            this.FourthPoly = new System.Windows.Forms.TextBox();
            this.FourthText = new System.Windows.Forms.Label();
            this.AddPolys = new MetroFramework.Controls.MetroButton();
            this.Cancel = new MetroFramework.Controls.MetroButton();
            this.CLOSE = new System.Windows.Forms.Button();
            this.ProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.SuspendLayout();
            // 
            // MoveObj
            // 
            this.MoveObj.Location = new System.Drawing.Point(2, -1);
            this.MoveObj.Name = "MoveObj";
            this.MoveObj.Size = new System.Drawing.Size(460, 52);
            this.MoveObj.TabIndex = 0;
            this.MoveObj.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveObj_MouseDown);
            // 
            // FirstPoly
            // 
            this.FirstPoly.Location = new System.Drawing.Point(176, 60);
            this.FirstPoly.Name = "FirstPoly";
            this.FirstPoly.Size = new System.Drawing.Size(200, 20);
            this.FirstPoly.TabIndex = 1;
            // 
            // SecondPoly
            // 
            this.SecondPoly.Location = new System.Drawing.Point(176, 102);
            this.SecondPoly.Name = "SecondPoly";
            this.SecondPoly.Size = new System.Drawing.Size(200, 20);
            this.SecondPoly.TabIndex = 2;
            // 
            // ThirdPoly
            // 
            this.ThirdPoly.Location = new System.Drawing.Point(176, 145);
            this.ThirdPoly.Name = "ThirdPoly";
            this.ThirdPoly.Size = new System.Drawing.Size(200, 20);
            this.ThirdPoly.TabIndex = 3;
            // 
            // FirstText
            // 
            this.FirstText.AutoSize = true;
            this.FirstText.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstText.Location = new System.Drawing.Point(84, 60);
            this.FirstText.Name = "FirstText";
            this.FirstText.Size = new System.Drawing.Size(28, 13);
            this.FirstText.TabIndex = 5;
            this.FirstText.Text = "Text";
            // 
            // SecondText
            // 
            this.SecondText.AutoSize = true;
            this.SecondText.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondText.Location = new System.Drawing.Point(84, 102);
            this.SecondText.Name = "SecondText";
            this.SecondText.Size = new System.Drawing.Size(28, 13);
            this.SecondText.TabIndex = 6;
            this.SecondText.Text = "Text";
            // 
            // ThirdText
            // 
            this.ThirdText.AutoSize = true;
            this.ThirdText.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThirdText.Location = new System.Drawing.Point(84, 145);
            this.ThirdText.Name = "ThirdText";
            this.ThirdText.Size = new System.Drawing.Size(28, 13);
            this.ThirdText.TabIndex = 7;
            this.ThirdText.Text = "Text";
            // 
            // FourthPoly
            // 
            this.FourthPoly.Location = new System.Drawing.Point(176, 187);
            this.FourthPoly.Name = "FourthPoly";
            this.FourthPoly.Size = new System.Drawing.Size(200, 20);
            this.FourthPoly.TabIndex = 4;
            // 
            // FourthText
            // 
            this.FourthText.AutoSize = true;
            this.FourthText.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FourthText.Location = new System.Drawing.Point(84, 187);
            this.FourthText.Name = "FourthText";
            this.FourthText.Size = new System.Drawing.Size(28, 13);
            this.FourthText.TabIndex = 7;
            this.FourthText.Text = "Text";
            // 
            // AddPolys
            // 
            this.AddPolys.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddPolys.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddPolys.Location = new System.Drawing.Point(46, 235);
            this.AddPolys.Name = "AddPolys";
            this.AddPolys.Size = new System.Drawing.Size(125, 40);
            this.AddPolys.TabIndex = 5;
            this.AddPolys.Text = "Добавить";
            this.AddPolys.UseCustomBackColor = true;
            this.AddPolys.UseCustomForeColor = true;
            this.AddPolys.UseSelectable = true;
            this.AddPolys.UseStyleColors = true;
            this.AddPolys.Click += new System.EventHandler(this.AddPolys_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel.Location = new System.Drawing.Point(311, 235);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(125, 40);
            this.Cancel.TabIndex = 17;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseCustomBackColor = true;
            this.Cancel.UseCustomForeColor = true;
            this.Cancel.UseSelectable = true;
            this.Cancel.UseStyleColors = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // CLOSE
            // 
            this.CLOSE.BackColor = System.Drawing.Color.Gainsboro;
            this.CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CLOSE.Location = new System.Drawing.Point(412, 2);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(40, 40);
            this.CLOSE.TabIndex = 18;
            this.CLOSE.TabStop = false;
            this.CLOSE.Text = "X";
            this.CLOSE.UseVisualStyleBackColor = false;
            this.CLOSE.Click += new System.EventHandler(this.CLOSE_Click);
            this.CLOSE.MouseLeave += new System.EventHandler(this.CLOSE_MouseLeave);
            this.CLOSE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CLOSE_MouseMove);
            // 
            // ProgressSpinner
            // 
            this.ProgressSpinner.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProgressSpinner.Location = new System.Drawing.Point(87, 235);
            this.ProgressSpinner.Maximum = 100;
            this.ProgressSpinner.Name = "ProgressSpinner";
            this.ProgressSpinner.Size = new System.Drawing.Size(46, 40);
            this.ProgressSpinner.Speed = 4F;
            this.ProgressSpinner.Style = MetroFramework.MetroColorStyle.Black;
            this.ProgressSpinner.TabIndex = 19;
            this.ProgressSpinner.TabStop = false;
            this.ProgressSpinner.UseCustomBackColor = true;
            this.ProgressSpinner.UseCustomForeColor = true;
            this.ProgressSpinner.UseSelectable = true;
            this.ProgressSpinner.UseStyleColors = true;
            this.ProgressSpinner.Value = 65;
            this.ProgressSpinner.Visible = false;
            // 
            // AddPoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UserInterface.Properties.Resources.back_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 287);
            this.Controls.Add(this.ProgressSpinner);
            this.Controls.Add(this.CLOSE);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddPolys);
            this.Controls.Add(this.FourthText);
            this.Controls.Add(this.ThirdText);
            this.Controls.Add(this.SecondText);
            this.Controls.Add(this.FirstText);
            this.Controls.Add(this.FourthPoly);
            this.Controls.Add(this.ThirdPoly);
            this.Controls.Add(this.SecondPoly);
            this.Controls.Add(this.FirstPoly);
            this.Controls.Add(this.MoveObj);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPoly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddPoly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MoveObj;
        private System.Windows.Forms.TextBox FirstPoly;
        private System.Windows.Forms.TextBox SecondPoly;
        private System.Windows.Forms.TextBox ThirdPoly;
        private System.Windows.Forms.Label FirstText;
        private System.Windows.Forms.Label SecondText;
        private System.Windows.Forms.Label ThirdText;
        private System.Windows.Forms.TextBox FourthPoly;
        private System.Windows.Forms.Label FourthText;
        public MetroFramework.Controls.MetroProgressSpinner ProgressSpinner;
        public MetroFramework.Controls.MetroButton Cancel;
        public System.Windows.Forms.Button CLOSE;
        public MetroFramework.Controls.MetroButton AddPolys;
    }
}