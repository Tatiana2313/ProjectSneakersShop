namespace DataBaseSneakers
{
    partial class EditProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProvider));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.maskedTextBoxScet = new System.Windows.Forms.MaskedTextBox();
            this.labelScet = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPrName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.rjButtonClear = new DataBaseSneakers.RJButton();
            this.rjButtonEdit = new DataBaseSneakers.RJButton();
            this.rjTextBoxAddress = new DataBaseSneakers.RJTextBox();
            this.rjTextBoxPrName = new DataBaseSneakers.RJTextBox();
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
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(16, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(217, 22);
            this.labelInfo.TabIndex = 47;
            this.labelInfo.Text = "Изменение информации";
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
            // maskedTextBoxScet
            // 
            this.maskedTextBoxScet.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxScet.Location = new System.Drawing.Point(241, 408);
            this.maskedTextBoxScet.Mask = "00000000000000000000";
            this.maskedTextBoxScet.Name = "maskedTextBoxScet";
            this.maskedTextBoxScet.Size = new System.Drawing.Size(223, 29);
            this.maskedTextBoxScet.TabIndex = 33;
            this.maskedTextBoxScet.TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.maskedTextBoxScet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxRasScet_KeyPress);
            // 
            // labelScet
            // 
            this.labelScet.AutoSize = true;
            this.labelScet.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScet.Location = new System.Drawing.Point(38, 409);
            this.labelScet.Name = "labelScet";
            this.labelScet.Size = new System.Drawing.Size(184, 28);
            this.labelScet.TabIndex = 31;
            this.labelScet.Text = "Расчетный счет:";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(163, 344);
            this.maskedTextBoxPhone.Mask = "+37300000000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(172, 29);
            this.maskedTextBoxPhone.TabIndex = 30;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(38, 343);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(107, 28);
            this.labelPhone.TabIndex = 29;
            this.labelPhone.Text = "Телефон:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress.Location = new System.Drawing.Point(38, 276);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(82, 28);
            this.labelAddress.TabIndex = 27;
            this.labelAddress.Text = "Адрес:";
            // 
            // labelPrName
            // 
            this.labelPrName.AutoSize = true;
            this.labelPrName.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrName.Location = new System.Drawing.Point(38, 214);
            this.labelPrName.Name = "labelPrName";
            this.labelPrName.Size = new System.Drawing.Size(195, 28);
            this.labelPrName.TabIndex = 25;
            this.labelPrName.Text = "Имя поставщика:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(43, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.Color.Purple;
            this.labelHeader.Location = new System.Drawing.Point(176, 88);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(208, 50);
            this.labelHeader.TabIndex = 23;
            this.labelHeader.Text = "Поставщики";
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
            this.rjButtonClear.Location = new System.Drawing.Point(197, 489);
            this.rjButtonClear.Name = "rjButtonClear";
            this.rjButtonClear.Size = new System.Drawing.Size(169, 54);
            this.rjButtonClear.TabIndex = 34;
            this.rjButtonClear.Text = "Очистить";
            this.rjButtonClear.TextColor = System.Drawing.Color.White;
            this.rjButtonClear.UseVisualStyleBackColor = false;
            this.rjButtonClear.Click += new System.EventHandler(this.rjButtonClear_Click);
            // 
            // rjButtonEdit
            // 
            this.rjButtonEdit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButtonEdit.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButtonEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonEdit.BorderRadius = 26;
            this.rjButtonEdit.BorderSize = 0;
            this.rjButtonEdit.Enabled = false;
            this.rjButtonEdit.FlatAppearance.BorderSize = 0;
            this.rjButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonEdit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonEdit.ForeColor = System.Drawing.Color.White;
            this.rjButtonEdit.Location = new System.Drawing.Point(418, 489);
            this.rjButtonEdit.Name = "rjButtonEdit";
            this.rjButtonEdit.Size = new System.Drawing.Size(169, 54);
            this.rjButtonEdit.TabIndex = 32;
            this.rjButtonEdit.Text = "Изменить";
            this.rjButtonEdit.TextColor = System.Drawing.Color.White;
            this.rjButtonEdit.UseVisualStyleBackColor = false;
            this.rjButtonEdit.Click += new System.EventHandler(this.rjButtonEdit_Click);
            // 
            // rjTextBoxAddress
            // 
            this.rjTextBoxAddress.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxAddress.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxAddress.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxAddress.BorderRadius = 0;
            this.rjTextBoxAddress.BorderSize = 2;
            this.rjTextBoxAddress.Font = new System.Drawing.Font("Century", 12F);
            this.rjTextBoxAddress.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxAddress.Location = new System.Drawing.Point(145, 265);
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
            this.rjTextBoxAddress.Size = new System.Drawing.Size(300, 39);
            this.rjTextBoxAddress.TabIndex = 28;
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
            this.rjTextBoxPrName.Font = new System.Drawing.Font("Century", 12F);
            this.rjTextBoxPrName.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxPrName.Location = new System.Drawing.Point(255, 203);
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
            this.rjTextBoxPrName.TabIndex = 26;
            this.rjTextBoxPrName.Texts = "";
            this.rjTextBoxPrName.UnderlinedStyle = true;
            this.rjTextBoxPrName._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.rjTextBoxPrName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxLetters_KeyPress);
            // 
            // EditProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(625, 573);
            this.Controls.Add(this.rjButtonClear);
            this.Controls.Add(this.maskedTextBoxScet);
            this.Controls.Add(this.rjButtonEdit);
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
            this.Name = "EditProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProvider";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxScet;
        private RJButton rjButtonEdit;
        private System.Windows.Forms.Label labelScet;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private RJTextBox rjTextBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private RJTextBox rjTextBoxPrName;
        private System.Windows.Forms.Label labelPrName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelInfo;
        private RJButton rjButtonClear;
    }
}