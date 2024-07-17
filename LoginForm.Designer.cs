namespace DataBaseSneakers
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjButtonClear = new DataBaseSneakers.RJButton();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.rjButtonLogIn = new DataBaseSneakers.RJButton();
            this.labelPassword = new System.Windows.Forms.Label();
            this.rjTextBoxPassword = new DataBaseSneakers.RJTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.rjTextBoxLogin = new DataBaseSneakers.RJTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 41);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::DataBaseSneakers.Properties.Resources.buttonclose;
            this.buttonClose.Location = new System.Drawing.Point(1198, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(49, 41);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1129, 662);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.rjButtonClear);
            this.panel2.Controls.Add(this.checkBoxShowPassword);
            this.panel2.Controls.Add(this.rjButtonLogIn);
            this.panel2.Controls.Add(this.labelPassword);
            this.panel2.Controls.Add(this.rjTextBoxPassword);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.labelLogin);
            this.panel2.Controls.Add(this.rjTextBoxLogin);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label);
            this.panel2.Location = new System.Drawing.Point(129, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 422);
            this.panel2.TabIndex = 3;
            // 
            // rjButtonClear
            // 
            this.rjButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(135)))), ((int)(((byte)(231)))));
            this.rjButtonClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(135)))), ((int)(((byte)(231)))));
            this.rjButtonClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonClear.BorderRadius = 20;
            this.rjButtonClear.BorderSize = 0;
            this.rjButtonClear.FlatAppearance.BorderSize = 0;
            this.rjButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonClear.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonClear.ForeColor = System.Drawing.Color.White;
            this.rjButtonClear.Location = new System.Drawing.Point(22, 326);
            this.rjButtonClear.Name = "rjButtonClear";
            this.rjButtonClear.Size = new System.Drawing.Size(139, 46);
            this.rjButtonClear.TabIndex = 9;
            this.rjButtonClear.Text = "Очистить";
            this.rjButtonClear.TextColor = System.Drawing.Color.White;
            this.rjButtonClear.UseVisualStyleBackColor = false;
            this.rjButtonClear.Click += new System.EventHandler(this.rjButtonClear_Click);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowPassword.Location = new System.Drawing.Point(200, 274);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(151, 22);
            this.checkBoxShowPassword.TabIndex = 8;
            this.checkBoxShowPassword.Text = "Показать пароль";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxPassword_CheckedChanged);
            // 
            // rjButtonLogIn
            // 
            this.rjButtonLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(135)))), ((int)(((byte)(231)))));
            this.rjButtonLogIn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(135)))), ((int)(((byte)(231)))));
            this.rjButtonLogIn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonLogIn.BorderRadius = 20;
            this.rjButtonLogIn.BorderSize = 0;
            this.rjButtonLogIn.FlatAppearance.BorderSize = 0;
            this.rjButtonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonLogIn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonLogIn.ForeColor = System.Drawing.Color.White;
            this.rjButtonLogIn.Location = new System.Drawing.Point(211, 326);
            this.rjButtonLogIn.Name = "rjButtonLogIn";
            this.rjButtonLogIn.Size = new System.Drawing.Size(150, 46);
            this.rjButtonLogIn.TabIndex = 7;
            this.rjButtonLogIn.Text = "Войти";
            this.rjButtonLogIn.TextColor = System.Drawing.Color.White;
            this.rjButtonLogIn.UseVisualStyleBackColor = false;
            this.rjButtonLogIn.Click += new System.EventHandler(this.rjButtonLogIn_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(96, 197);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(76, 27);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Пароль";
            // 
            // rjTextBoxPassword
            // 
            this.rjTextBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(124)))), ((int)(((byte)(22)))));
            this.rjTextBoxPassword.BorderRadius = 10;
            this.rjTextBoxPassword.BorderSize = 2;
            this.rjTextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjTextBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxPassword.Location = new System.Drawing.Point(101, 228);
            this.rjTextBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxPassword.MaxLength = 8;
            this.rjTextBoxPassword.MinLength = 0;
            this.rjTextBoxPassword.Multiline = false;
            this.rjTextBoxPassword.Name = "rjTextBoxPassword";
            this.rjTextBoxPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxPassword.PasswordChar = true;
            this.rjTextBoxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxPassword.PlaceholderText = "";
            this.rjTextBoxPassword.ReadOnly = false;
            this.rjTextBoxPassword.Size = new System.Drawing.Size(250, 35);
            this.rjTextBoxPassword.TabIndex = 5;
            this.rjTextBoxPassword.Texts = "";
            this.rjTextBoxPassword.UnderlinedStyle = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(36, 216);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(96, 107);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(65, 27);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Логин";
            // 
            // rjTextBoxLogin
            // 
            this.rjTextBoxLogin.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxLogin.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxLogin.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(124)))), ((int)(((byte)(22)))));
            this.rjTextBoxLogin.BorderRadius = 10;
            this.rjTextBoxLogin.BorderSize = 2;
            this.rjTextBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjTextBoxLogin.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxLogin.Location = new System.Drawing.Point(101, 138);
            this.rjTextBoxLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxLogin.MaxLength = 8;
            this.rjTextBoxLogin.MinLength = 0;
            this.rjTextBoxLogin.Multiline = false;
            this.rjTextBoxLogin.Name = "rjTextBoxLogin";
            this.rjTextBoxLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxLogin.PasswordChar = false;
            this.rjTextBoxLogin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxLogin.PlaceholderText = "";
            this.rjTextBoxLogin.ReadOnly = false;
            this.rjTextBoxLogin.Size = new System.Drawing.Size(250, 35);
            this.rjTextBoxLogin.TabIndex = 2;
            this.rjTextBoxLogin.Texts = "";
            this.rjTextBoxLogin.UnderlinedStyle = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(36, 126);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label.Location = new System.Drawing.Point(107, 27);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(216, 50);
            this.label.TabIndex = 0;
            this.label.Text = "Авторизация";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1247, 730);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelLogin;
        private RJTextBox rjTextBoxLogin;
        private RJButton rjButtonLogIn;
        private System.Windows.Forms.Label labelPassword;
        private RJTextBox rjTextBoxPassword;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private RJButton rjButtonClear;
    }
}