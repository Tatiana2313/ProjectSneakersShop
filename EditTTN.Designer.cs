namespace DataBaseSneakers
{
    partial class EditTTN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTTN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rjButtonEdit = new DataBaseSneakers.RJButton();
            this.rjTextBoxNumber = new DataBaseSneakers.RJTextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.rjComboBoxSneakers = new DataBaseSneakers.RJComboBox();
            this.labelSneakers = new System.Windows.Forms.Label();
            this.rjComboBoxProvider = new DataBaseSneakers.RJComboBox();
            this.labelProvider = new System.Windows.Forms.Label();
            this.labelPostDate = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(689, 41);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(22, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(217, 22);
            this.labelInfo.TabIndex = 48;
            this.labelInfo.Text = "Изменение информации";
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(637, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(52, 41);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePicker.CustomFormat = "yyyy.MM.dd";
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(249, 258);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(134, 32);
            this.dateTimePicker.TabIndex = 49;
            // 
            // rjButtonEdit
            // 
            this.rjButtonEdit.BackColor = System.Drawing.Color.MediumPurple;
            this.rjButtonEdit.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.rjButtonEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonEdit.BorderRadius = 26;
            this.rjButtonEdit.BorderSize = 0;
            this.rjButtonEdit.Enabled = false;
            this.rjButtonEdit.FlatAppearance.BorderSize = 0;
            this.rjButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonEdit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonEdit.ForeColor = System.Drawing.Color.White;
            this.rjButtonEdit.Location = new System.Drawing.Point(469, 562);
            this.rjButtonEdit.Name = "rjButtonEdit";
            this.rjButtonEdit.Size = new System.Drawing.Size(169, 54);
            this.rjButtonEdit.TabIndex = 48;
            this.rjButtonEdit.Text = "Изменить";
            this.rjButtonEdit.TextColor = System.Drawing.Color.White;
            this.rjButtonEdit.UseVisualStyleBackColor = false;
            this.rjButtonEdit.Click += new System.EventHandler(this.rjButtonEdit_Click);
            // 
            // rjTextBoxNumber
            // 
            this.rjTextBoxNumber.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxNumber.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxNumber.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxNumber.BorderRadius = 0;
            this.rjTextBoxNumber.BorderSize = 2;
            this.rjTextBoxNumber.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.rjTextBoxNumber.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxNumber.Location = new System.Drawing.Point(300, 475);
            this.rjTextBoxNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxNumber.MaxLength = 10;
            this.rjTextBoxNumber.MinLength = 0;
            this.rjTextBoxNumber.Multiline = false;
            this.rjTextBoxNumber.Name = "rjTextBoxNumber";
            this.rjTextBoxNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxNumber.PasswordChar = false;
            this.rjTextBoxNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxNumber.PlaceholderText = "";
            this.rjTextBoxNumber.ReadOnly = false;
            this.rjTextBoxNumber.Size = new System.Drawing.Size(149, 37);
            this.rjTextBoxNumber.TabIndex = 47;
            this.rjTextBoxNumber.Texts = "";
            this.rjTextBoxNumber.UnderlinedStyle = true;
            this.rjTextBoxNumber._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.rjTextBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxDigits_KeyPress);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(42, 482);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(241, 28);
            this.labelNumber.TabIndex = 46;
            this.labelNumber.Text = "Кол-во поставленных:";
            // 
            // rjComboBoxSneakers
            // 
            this.rjComboBoxSneakers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBoxSneakers.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxSneakers.BorderSize = 2;
            this.rjComboBoxSneakers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rjComboBoxSneakers.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjComboBoxSneakers.ForeColor = System.Drawing.Color.Black;
            this.rjComboBoxSneakers.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxSneakers.ListBackColor = System.Drawing.Color.Lavender;
            this.rjComboBoxSneakers.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBoxSneakers.Location = new System.Drawing.Point(249, 405);
            this.rjComboBoxSneakers.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBoxSneakers.Name = "rjComboBoxSneakers";
            this.rjComboBoxSneakers.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBoxSneakers.Size = new System.Drawing.Size(290, 37);
            this.rjComboBoxSneakers.TabIndex = 45;
            this.rjComboBoxSneakers.Texts = "";
            // 
            // labelSneakers
            // 
            this.labelSneakers.AutoSize = true;
            this.labelSneakers.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSneakers.Location = new System.Drawing.Point(42, 405);
            this.labelSneakers.Name = "labelSneakers";
            this.labelSneakers.Size = new System.Drawing.Size(129, 28);
            this.labelSneakers.TabIndex = 44;
            this.labelSneakers.Text = "Кроссовки:";
            // 
            // rjComboBoxProvider
            // 
            this.rjComboBoxProvider.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBoxProvider.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxProvider.BorderSize = 2;
            this.rjComboBoxProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rjComboBoxProvider.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjComboBoxProvider.ForeColor = System.Drawing.Color.Black;
            this.rjComboBoxProvider.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxProvider.ListBackColor = System.Drawing.Color.Lavender;
            this.rjComboBoxProvider.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBoxProvider.Location = new System.Drawing.Point(249, 324);
            this.rjComboBoxProvider.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBoxProvider.Name = "rjComboBoxProvider";
            this.rjComboBoxProvider.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBoxProvider.Size = new System.Drawing.Size(290, 37);
            this.rjComboBoxProvider.TabIndex = 43;
            this.rjComboBoxProvider.Texts = "";
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProvider.Location = new System.Drawing.Point(42, 329);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(137, 28);
            this.labelProvider.TabIndex = 42;
            this.labelProvider.Text = "Поставщик:";
            // 
            // labelPostDate
            // 
            this.labelPostDate.AutoSize = true;
            this.labelPostDate.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPostDate.Location = new System.Drawing.Point(42, 259);
            this.labelPostDate.Name = "labelPostDate";
            this.labelPostDate.Size = new System.Drawing.Size(166, 28);
            this.labelPostDate.TabIndex = 41;
            this.labelPostDate.Text = "Дата поставки:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(46, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.Color.Purple;
            this.labelHeader.Location = new System.Drawing.Point(179, 99);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(258, 50);
            this.labelHeader.TabIndex = 39;
            this.labelHeader.Text = "ТТН (накладная)";
            // 
            // rjButtonClear
            // 
            this.rjButtonClear.BackColor = System.Drawing.Color.MediumPurple;
            this.rjButtonClear.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.rjButtonClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonClear.BorderRadius = 26;
            this.rjButtonClear.BorderSize = 0;
            this.rjButtonClear.FlatAppearance.BorderSize = 0;
            this.rjButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonClear.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonClear.ForeColor = System.Drawing.Color.White;
            this.rjButtonClear.Location = new System.Drawing.Point(249, 562);
            this.rjButtonClear.Name = "rjButtonClear";
            this.rjButtonClear.Size = new System.Drawing.Size(169, 54);
            this.rjButtonClear.TabIndex = 50;
            this.rjButtonClear.Text = "Очистить";
            this.rjButtonClear.TextColor = System.Drawing.Color.White;
            this.rjButtonClear.UseVisualStyleBackColor = false;
            this.rjButtonClear.Click += new System.EventHandler(this.rjButtonClear_Click);
            // 
            // EditTTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(689, 677);
            this.Controls.Add(this.rjButtonClear);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.rjButtonEdit);
            this.Controls.Add(this.rjTextBoxNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.rjComboBoxSneakers);
            this.Controls.Add(this.labelSneakers);
            this.Controls.Add(this.rjComboBoxProvider);
            this.Controls.Add(this.labelProvider);
            this.Controls.Add(this.labelPostDate);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTTN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditTTN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private RJButton rjButtonEdit;
        private RJTextBox rjTextBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private RJComboBox rjComboBoxSneakers;
        private System.Windows.Forms.Label labelSneakers;
        private RJComboBox rjComboBoxProvider;
        private System.Windows.Forms.Label labelProvider;
        private System.Windows.Forms.Label labelPostDate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelInfo;
        private RJButton rjButtonClear;
    }
}