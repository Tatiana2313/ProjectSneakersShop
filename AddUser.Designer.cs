namespace DataBaseSneakers
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.rjButtonClear = new DataBaseSneakers.RJButton();
            this.rjButtonAdd = new DataBaseSneakers.RJButton();
            this.rjComboBoxRole = new DataBaseSneakers.RJComboBox();
            this.rjTextBoxPassword = new DataBaseSneakers.RJTextBox();
            this.rjTextBoxLogin = new DataBaseSneakers.RJTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(121)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 41);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(25, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(226, 22);
            this.labelInfo.TabIndex = 50;
            this.labelInfo.Text = "Добавление пользователя";
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(533, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(52, 41);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.Color.Purple;
            this.labelHeader.Location = new System.Drawing.Point(182, 96);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(227, 50);
            this.labelHeader.TabIndex = 60;
            this.labelHeader.Text = "Пользователи";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(62, 222);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(84, 28);
            this.labelLogin.TabIndex = 62;
            this.labelLogin.Text = "Логин:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(62, 290);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(95, 28);
            this.labelPassword.TabIndex = 64;
            this.labelPassword.Text = "Пароль:";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.Location = new System.Drawing.Point(62, 357);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(65, 28);
            this.labelRole.TabIndex = 66;
            this.labelRole.Text = "Роль:";
            // 
            // rjButtonClear
            // 
            this.rjButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(71)))), ((int)(((byte)(209)))));
            this.rjButtonClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(71)))), ((int)(((byte)(209)))));
            this.rjButtonClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonClear.BorderRadius = 26;
            this.rjButtonClear.BorderSize = 0;
            this.rjButtonClear.FlatAppearance.BorderSize = 0;
            this.rjButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonClear.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonClear.ForeColor = System.Drawing.Color.White;
            this.rjButtonClear.Location = new System.Drawing.Point(171, 469);
            this.rjButtonClear.Name = "rjButtonClear";
            this.rjButtonClear.Size = new System.Drawing.Size(169, 54);
            this.rjButtonClear.TabIndex = 69;
            this.rjButtonClear.Text = "Очистить";
            this.rjButtonClear.TextColor = System.Drawing.Color.White;
            this.rjButtonClear.UseVisualStyleBackColor = false;
            this.rjButtonClear.Click += new System.EventHandler(this.rjButtonClear_Click);
            // 
            // rjButtonAdd
            // 
            this.rjButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(71)))), ((int)(((byte)(209)))));
            this.rjButtonAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(71)))), ((int)(((byte)(209)))));
            this.rjButtonAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonAdd.BorderRadius = 26;
            this.rjButtonAdd.BorderSize = 0;
            this.rjButtonAdd.Enabled = false;
            this.rjButtonAdd.FlatAppearance.BorderSize = 0;
            this.rjButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonAdd.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonAdd.ForeColor = System.Drawing.Color.White;
            this.rjButtonAdd.Location = new System.Drawing.Point(370, 469);
            this.rjButtonAdd.Name = "rjButtonAdd";
            this.rjButtonAdd.Size = new System.Drawing.Size(169, 54);
            this.rjButtonAdd.TabIndex = 68;
            this.rjButtonAdd.Text = "Добавить";
            this.rjButtonAdd.TextColor = System.Drawing.Color.White;
            this.rjButtonAdd.UseVisualStyleBackColor = false;
            this.rjButtonAdd.Click += new System.EventHandler(this.rjButtonAdd_Click);
            // 
            // rjComboBoxRole
            // 
            this.rjComboBoxRole.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBoxRole.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxRole.BorderSize = 2;
            this.rjComboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rjComboBoxRole.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjComboBoxRole.ForeColor = System.Drawing.Color.Black;
            this.rjComboBoxRole.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxRole.Items.AddRange(new object[] {
            "admin",
            "user",
            "seller"});
            this.rjComboBoxRole.ListBackColor = System.Drawing.Color.Lavender;
            this.rjComboBoxRole.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBoxRole.Location = new System.Drawing.Point(191, 357);
            this.rjComboBoxRole.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBoxRole.Name = "rjComboBoxRole";
            this.rjComboBoxRole.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBoxRole.Size = new System.Drawing.Size(200, 37);
            this.rjComboBoxRole.TabIndex = 67;
            this.rjComboBoxRole.Texts = "";
            this.rjComboBoxRole.OnSelectedIndexChanged += new System.EventHandler(this.rjComboBoxRole_OnSelectedIndexChanged);
            // 
            // rjTextBoxPassword
            // 
            this.rjTextBoxPassword.BackColor = System.Drawing.Color.SeaShell;
            this.rjTextBoxPassword.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxPassword.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxPassword.BorderRadius = 0;
            this.rjTextBoxPassword.BorderSize = 2;
            this.rjTextBoxPassword.Font = new System.Drawing.Font("Century", 12F);
            this.rjTextBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxPassword.Location = new System.Drawing.Point(194, 279);
            this.rjTextBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxPassword.MaxLength = 8;
            this.rjTextBoxPassword.MinLength = 8;
            this.rjTextBoxPassword.Multiline = false;
            this.rjTextBoxPassword.Name = "rjTextBoxPassword";
            this.rjTextBoxPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxPassword.PasswordChar = false;
            this.rjTextBoxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxPassword.PlaceholderText = "8 символов";
            this.rjTextBoxPassword.ReadOnly = false;
            this.rjTextBoxPassword.Size = new System.Drawing.Size(190, 39);
            this.rjTextBoxPassword.TabIndex = 65;
            this.rjTextBoxPassword.Texts = "";
            this.rjTextBoxPassword.UnderlinedStyle = true;
            this.rjTextBoxPassword._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            // 
            // rjTextBoxLogin
            // 
            this.rjTextBoxLogin.BackColor = System.Drawing.Color.SeaShell;
            this.rjTextBoxLogin.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxLogin.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxLogin.BorderRadius = 0;
            this.rjTextBoxLogin.BorderSize = 2;
            this.rjTextBoxLogin.Font = new System.Drawing.Font("Century", 12F);
            this.rjTextBoxLogin.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxLogin.Location = new System.Drawing.Point(194, 211);
            this.rjTextBoxLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxLogin.MaxLength = 32767;
            this.rjTextBoxLogin.MinLength = 0;
            this.rjTextBoxLogin.Multiline = false;
            this.rjTextBoxLogin.Name = "rjTextBoxLogin";
            this.rjTextBoxLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxLogin.PasswordChar = false;
            this.rjTextBoxLogin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxLogin.PlaceholderText = "";
            this.rjTextBoxLogin.ReadOnly = false;
            this.rjTextBoxLogin.Size = new System.Drawing.Size(190, 39);
            this.rjTextBoxLogin.TabIndex = 63;
            this.rjTextBoxLogin.Texts = "";
            this.rjTextBoxLogin.UnderlinedStyle = true;
            this.rjTextBoxLogin._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(585, 558);
            this.Controls.Add(this.rjButtonClear);
            this.Controls.Add(this.rjButtonAdd);
            this.Controls.Add(this.rjComboBoxRole);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.rjTextBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.rjTextBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelHeader;
        private RJTextBox rjTextBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private RJTextBox rjTextBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelRole;
        private RJComboBox rjComboBoxRole;
        private RJButton rjButtonClear;
        private RJButton rjButtonAdd;
    }
}