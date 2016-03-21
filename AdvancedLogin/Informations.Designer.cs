namespace AdvancedLogin
{
    partial class Informations
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
            this.textBox_un_update = new System.Windows.Forms.TextBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.textBox_pw_update = new System.Windows.Forms.TextBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.attendanceBtn = new MetroFramework.Controls.MetroTile();
            this.NewRegistration = new MetroFramework.Controls.MetroTile();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_un_update
            // 
            this.textBox_un_update.Location = new System.Drawing.Point(90, 24);
            this.textBox_un_update.Name = "textBox_un_update";
            this.textBox_un_update.Size = new System.Drawing.Size(140, 20);
            this.textBox_un_update.TabIndex = 0;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(110, 100);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(89, 23);
            this.button_Update.TabIndex = 1;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // textBox_pw_update
            // 
            this.textBox_pw_update.Location = new System.Drawing.Point(90, 50);
            this.textBox_pw_update.Name = "textBox_pw_update";
            this.textBox_pw_update.Size = new System.Drawing.Size(140, 20);
            this.textBox_pw_update.TabIndex = 2;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(705, 448);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.TabIndex = 5;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroTile1);
            this.metroTabPage1.Controls.Add(this.attendanceBtn);
            this.metroTabPage1.Controls.Add(this.NewRegistration);
            this.metroTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 47);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(697, 397);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "ManageUsers";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTile1.Location = new System.Drawing.Point(3, 197);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(342, 168);
            this.metroTile1.TabIndex = 6;
            this.metroTile1.Text = "ExistingEmplyee";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            // 
            // attendanceBtn
            // 
            this.attendanceBtn.ActiveControl = null;
            this.attendanceBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.attendanceBtn.Location = new System.Drawing.Point(177, 23);
            this.attendanceBtn.Name = "attendanceBtn";
            this.attendanceBtn.Size = new System.Drawing.Size(168, 168);
            this.attendanceBtn.TabIndex = 5;
            this.attendanceBtn.Text = "Attendance";
            this.attendanceBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.attendanceBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.attendanceBtn.UseCustomForeColor = true;
            this.attendanceBtn.UseSelectable = true;
            // 
            // NewRegistration
            // 
            this.NewRegistration.ActiveControl = null;
            this.NewRegistration.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewRegistration.Location = new System.Drawing.Point(3, 23);
            this.NewRegistration.Name = "NewRegistration";
            this.NewRegistration.Size = new System.Drawing.Size(168, 168);
            this.NewRegistration.TabIndex = 2;
            this.NewRegistration.Text = "New Registration";
            this.NewRegistration.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NewRegistration.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.NewRegistration.UseCustomForeColor = true;
            this.NewRegistration.UseSelectable = true;
            this.NewRegistration.Click += new System.EventHandler(this.NewRegistration_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.label2);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.Controls.Add(this.textBox_pw_update);
            this.metroTabPage2.Controls.Add(this.button_Update);
            this.metroTabPage2.Controls.Add(this.textBox_un_update);
            this.metroTabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 47);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(697, 397);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "ChangeCredential";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdvancedLogin.Properties.Resources.IMG_20150428_WA0001;
            this.pictureBox1.Location = new System.Drawing.Point(748, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe WP Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(569, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "Procheta Nag";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe WP", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(688, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Admin";
            // 
            // Informations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 535);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "Informations";
            this.Resizable = false;
            this.Text = "Admin Area";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_un_update;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.TextBox textBox_pw_update;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile NewRegistration;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile attendanceBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}