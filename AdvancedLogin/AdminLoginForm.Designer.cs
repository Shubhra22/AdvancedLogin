namespace AdvancedLogin
{
    partial class AdminLoginForm
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
            this.label_Un = new System.Windows.Forms.Label();
            this.label_PW = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label_Un
            // 
            this.label_Un.AutoSize = true;
            this.label_Un.Location = new System.Drawing.Point(30, 70);
            this.label_Un.Name = "label_Un";
            this.label_Un.Size = new System.Drawing.Size(68, 13);
            this.label_Un.TabIndex = 1;
            this.label_Un.Text = "USERNAME";
            // 
            // label_PW
            // 
            this.label_PW.AutoSize = true;
            this.label_PW.Location = new System.Drawing.Point(31, 96);
            this.label_PW.Name = "label_PW";
            this.label_PW.Size = new System.Drawing.Size(70, 13);
            this.label_PW.TabIndex = 2;
            this.label_PW.Text = "PASSWORD";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(104, 67);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(163, 20);
            this.textBox_username.TabIndex = 3;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(105, 93);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(162, 20);
            this.textBox_Password.TabIndex = 4;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(105, 138);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(119, 23);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseSelectable = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 188);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_PW);
            this.Controls.Add(this.label_Un);
            this.MaximizeBox = false;
            this.Name = "AdminLoginForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Admin";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Un;
        private System.Windows.Forms.Label label_PW;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_Password;
        private MetroFramework.Controls.MetroButton btn_Login;
    }
}

