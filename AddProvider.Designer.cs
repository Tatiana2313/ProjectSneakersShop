namespace DataBaseSneakers
{
    partial class AddProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProvider));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelPrName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelScet = new System.Windows.Forms.Label();
            this.rjButtonAdd = new DataBaseSneakers.RJButton();
            this.rjTextBoxAddress = new DataBaseSneakers.RJTextBox();
            this.rjTextBoxPrName = new DataBaseSneakers.RJTextBox();
            this.maskedTextBoxScet = new System.Windows.Forms.MaskedTextBox();
            this.rjButtonClear = new DataBaseSneakers.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 41);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelInfo.Location = new System.Drawing.Point(12, 8);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(223, 22);
            this.labelInfo.TabIndex = 45;
            this.labelInfo.Text = "Добавление информации";
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(573, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(52, 41);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.Color.Purple;
            this.labelHeader.Location = new System.Drawing.Point(166, 86);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(208, 50);
            this.labelHeader.TabIndex = 10;
            this.labelHeader.Text = "Поставщики";
            // 
            // labelPrName
            // 
            this.labelPrName.AutoSize = true;
            this.labelPrName.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrName.Location = new System.Drawing.Point(28, 212);
            this.labelPrName.Name = "labelPrName";
            this.labelPrName.Size = new System.Drawing.Size(195, 28);
            this.labelPrName.TabIndex = 13;
            this.labelPrName.Text = "Имя поставщика:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress.Location = new System.Drawing.Point(28, 274);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(82, 28);
            this.labelAddress.TabIndex = 15;
            this.labelAddress.Text = "Адрес:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(28, 341);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(107, 28);
            this.labelPhone.TabIndex = 17;
            this.labelPhone.Text = "Телефон:";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(153, 342);
            this.maskedTextBoxPhone.Mask = "+37300000000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(172, 29);
            this.maskedTextBoxPhone.TabIndex = 18;
            this.maskedTextBoxPhone.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBox_Validating);
            // 
            // labelScet
            // 
            this.labelScet.AutoSize = true;
            this.labelScet.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScet.Location = new System.Drawing.Point(28, 407);
            this.labelScet.Name = "labelScet";
            this.labelScet.Size = new System.Drawing.Size(184, 28);
            this.labelScet.TabIndex = 19;
            this.labelScet.Text = "Расчетный счет:";
            // 
            // rjButtonAdd
            // 
            this.rjButtonAdd.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButtonAdd.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButtonAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonAdd.BorderRadius = 26;
            this.rjButtonAdd.BorderSize = 0;
            this.rjButtonAdd.Enabled = false;
            this.rjButtonAdd.FlatAppearance.BorderSize = 0;
            this.rjButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonAdd.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonAdd.ForeColor = System.Drawing.Color.White;
            this.rjButtonAdd.Location = new System.Drawing.Point(408, 487);
            this.rjButtonAdd.Name = "rjButtonAdd";
            this.rjButtonAdd.Size = new System.Drawing.Size(169, 54);
            this.rjButtonAdd.TabIndex = 21;
            this.rjButtonAdd.Text = "Добавить";
            this.rjButtonAdd.TextColor = System.Drawing.Color.White;
            this.rjButtonAdd.UseVisualStyleBackColor = false;
            this.rjButtonAdd.Click += new System.EventHandler(this.rjButtonAdd_Click);
            // 
            // rjTextBoxAddress
            // 
            this.rjTextBoxAddress.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxAddress.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxAddress.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxAddress.BorderRadius = 0;
            this.rjTextBoxAddress.BorderSize = 2;
            this.rjTextBoxAddress.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjTextBoxAddress.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxAddress.Location = new System.Drawing.Point(135, 263);
            this.rjTextBoxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxAddress.MaxLength = 32767;
            this.rjTextBoxAddress.MinLength = 0;
            this.rjTextBoxAddress.Multiline = false;
            this.rjTextBoxAddress.Name = "rjTextBoxAddress";
            this.rjTextBoxAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxAddress.PasswordChar = false;
            this.rjTextBoxAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxAddress.PlaceholderText = "";
            this.rjTextBoxAddress.ReadOnly = false;
            this.rjTextBoxAddress.Size = new System.Drawing.Size(299, 39);
            this.rjTextBoxAddress.TabIndex = 16;
            this.rjTextBoxAddress.Texts = "";
            this.rjTextBoxAddress.UnderlinedStyle = true;
            this.rjTextBoxAddress._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            // 
            // rjTextBoxPrName
            // 
            this.rjTextBoxPrName.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxPrName.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxPrName.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxPrName.BorderRadius = 0;
            this.rjTextBoxPrName.BorderSize = 2;
            this.rjTextBoxPrName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjTextBoxPrName.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxPrName.Location = new System.Drawing.Point(244, 201);
            this.rjTextBoxPrName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxPrName.MaxLength = 32767;
            this.rjTextBoxPrName.MinLength = 0;
            this.rjTextBoxPrName.Multiline = false;
            this.rjTextBoxPrName.Name = "rjTextBoxPrName";
            this.rjTextBoxPrName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxPrName.PasswordChar = false;
            this.rjTextBoxPrName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxPrName.PlaceholderText = "";
            this.rjTextBoxPrName.ReadOnly = false;
            this.rjTextBoxPrName.Size = new System.Drawing.Size(190, 39);
            this.rjTextBoxPrName.TabIndex = 14;
            this.rjTextBoxPrName.Texts = "";
            this.rjTextBoxPrName.UnderlinedStyle = true;
            this.rjTextBoxPrName._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.rjTextBoxPrName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxLetters_KeyPress);
            // 
            // maskedTextBoxScet
            // 
            this.maskedTextBoxScet.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxScet.Location = new System.Drawing.Point(231, 406);
            this.maskedTextBoxScet.Mask = "00000000000000000000";
            this.maskedTextBoxScet.Name = "maskedTextBoxScet";
            this.maskedTextBoxScet.Size = new System.Drawing.Size(223, 29);
            this.maskedTextBoxScet.TabIndex = 22;
            this.maskedTextBoxScet.TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.maskedTextBoxScet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxRasScet_KeyPress);
            this.maskedTextBoxScet.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBox_Validating);
            // 
            // rjButtonClear
            // 
            this.rjButtonClear.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButtonClear.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButtonClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonClear.BorderRadius = 26;
            this.rjButtonClear.BorderSize = 0;
            this.rjButtonClear.FlatAppearance.BorderSize = 0;
            this.rjButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonClear.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonClear.ForeColor = System.Drawing.Color.White;
            this.rjButtonClear.Location = new System.Drawing.Point(205, 487);
            this.rjButtonClear.Name = "rjButtonClear";
            this.rjButtonClear.Size = new System.Drawing.Size(169, 54);
            this.rjButtonClear.TabIndex = 23;
            this.rjButtonClear.Text = "Очистить";
            this.rjButtonClear.TextColor = System.Drawing.Color.White;
            this.rjButtonClear.UseVisualStyleBackColor = false;
            this.rjButtonClear.Click += new System.EventHandler(this.rjButtonClear_Click);
            // 
            // AddProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(625, 573);
            this.Controls.Add(this.rjButtonClear);
            this.Controls.Add(this.maskedTextBoxScet);
            this.Controls.Add(this.rjButtonAdd);
            this.Controls.Add(this.labelScet);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.rjTextBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.rjTextBoxPrName);
            this.Controls.Add(this.labelPrName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProvider";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelHeader;
        private RJTextBox rjTextBoxPrName;
        private System.Windows.Forms.Label labelPrName;
        private RJTextBox rjTextBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label labelScet;
        private RJButton rjButtonAdd;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxScet;
        private RJButton rjButtonClear;
        private System.Windows.Forms.Label labelInfo;
    }
}