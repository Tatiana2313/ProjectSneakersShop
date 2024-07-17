namespace DataBaseSneakers
{
    partial class AddChek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddChek));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.maskedTextBoxTime = new System.Windows.Forms.MaskedTextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelSneakers = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rjButtonAdd = new DataBaseSneakers.RJButton();
            this.rjTextBoxNumber = new DataBaseSneakers.RJTextBox();
            this.rjComboBoxSneakers = new DataBaseSneakers.RJComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.panel1.Size = new System.Drawing.Size(653, 41);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelInfo.Location = new System.Drawing.Point(12, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(223, 22);
            this.labelInfo.TabIndex = 44;
            this.labelInfo.Text = "Добавление информации";
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(601, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(52, 41);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.Color.Purple;
            this.labelHeader.Location = new System.Drawing.Point(171, 96);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(145, 50);
            this.labelHeader.TabIndex = 14;
            this.labelHeader.Text = "Покупки";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(33, 241);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(158, 28);
            this.labelDate.TabIndex = 22;
            this.labelDate.Text = "Дата покупки:";
            // 
            // maskedTextBoxTime
            // 
            this.maskedTextBoxTime.BackColor = System.Drawing.Color.Snow;
            this.maskedTextBoxTime.Font = new System.Drawing.Font("Century", 12F);
            this.maskedTextBoxTime.Location = new System.Drawing.Point(230, 296);
            this.maskedTextBoxTime.Name = "maskedTextBoxTime";
            this.maskedTextBoxTime.ReadOnly = true;
            this.maskedTextBoxTime.Size = new System.Drawing.Size(136, 32);
            this.maskedTextBoxTime.TabIndex = 25;
            this.maskedTextBoxTime.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxDigits_KeyPress);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(33, 296);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(177, 28);
            this.labelTime.TabIndex = 24;
            this.labelTime.Text = "Время покупки:";
            // 
            // labelSneakers
            // 
            this.labelSneakers.AutoSize = true;
            this.labelSneakers.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSneakers.Location = new System.Drawing.Point(33, 370);
            this.labelSneakers.Name = "labelSneakers";
            this.labelSneakers.Size = new System.Drawing.Size(129, 28);
            this.labelSneakers.TabIndex = 32;
            this.labelSneakers.Text = "Кроссовки:";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(33, 447);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(140, 28);
            this.labelNumber.TabIndex = 34;
            this.labelNumber.Text = "Количество:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePicker.CustomFormat = "yyyy.MM.dd";
            this.dateTimePicker.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(230, 237);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(136, 32);
            this.dateTimePicker.TabIndex = 37;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // rjButtonAdd
            // 
            this.rjButtonAdd.BackColor = System.Drawing.Color.MediumPurple;
            this.rjButtonAdd.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.rjButtonAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonAdd.BorderRadius = 26;
            this.rjButtonAdd.BorderSize = 0;
            this.rjButtonAdd.Enabled = false;
            this.rjButtonAdd.FlatAppearance.BorderSize = 0;
            this.rjButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonAdd.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonAdd.ForeColor = System.Drawing.Color.White;
            this.rjButtonAdd.Location = new System.Drawing.Point(434, 524);
            this.rjButtonAdd.Name = "rjButtonAdd";
            this.rjButtonAdd.Size = new System.Drawing.Size(169, 54);
            this.rjButtonAdd.TabIndex = 36;
            this.rjButtonAdd.Text = "Добавить";
            this.rjButtonAdd.TextColor = System.Drawing.Color.White;
            this.rjButtonAdd.UseVisualStyleBackColor = false;
            this.rjButtonAdd.Click += new System.EventHandler(this.rjButtonAdd_Click);
            // 
            // rjTextBoxNumber
            // 
            this.rjTextBoxNumber.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxNumber.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxNumber.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxNumber.BorderRadius = 0;
            this.rjTextBoxNumber.BorderSize = 2;
            this.rjTextBoxNumber.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjTextBoxNumber.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxNumber.Location = new System.Drawing.Point(217, 435);
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
            this.rjTextBoxNumber.Size = new System.Drawing.Size(149, 40);
            this.rjTextBoxNumber.TabIndex = 35;
            this.rjTextBoxNumber.Texts = "";
            this.rjTextBoxNumber.UnderlinedStyle = true;
            this.rjTextBoxNumber._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.rjTextBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxDigits_KeyPress);
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
            this.rjComboBoxSneakers.Location = new System.Drawing.Point(217, 370);
            this.rjComboBoxSneakers.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBoxSneakers.Name = "rjComboBoxSneakers";
            this.rjComboBoxSneakers.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBoxSneakers.Size = new System.Drawing.Size(290, 37);
            this.rjComboBoxSneakers.TabIndex = 33;
            this.rjComboBoxSneakers.Texts = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
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
            this.rjButtonClear.Location = new System.Drawing.Point(230, 524);
            this.rjButtonClear.Name = "rjButtonClear";
            this.rjButtonClear.Size = new System.Drawing.Size(169, 54);
            this.rjButtonClear.TabIndex = 38;
            this.rjButtonClear.Text = "Очистить";
            this.rjButtonClear.TextColor = System.Drawing.Color.White;
            this.rjButtonClear.UseVisualStyleBackColor = false;
            this.rjButtonClear.Click += new System.EventHandler(this.rjButtonClear_Click);
            // 
            // AddChek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(653, 644);
            this.Controls.Add(this.rjButtonClear);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.rjButtonAdd);
            this.Controls.Add(this.rjTextBoxNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.rjComboBoxSneakers);
            this.Controls.Add(this.labelSneakers);
            this.Controls.Add(this.maskedTextBoxTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddChek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddChek";
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
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTime;
        private System.Windows.Forms.Label labelTime;
        private RJComboBox rjComboBoxSneakers;
        private System.Windows.Forms.Label labelSneakers;
        private RJTextBox rjTextBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private RJButton rjButtonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private RJButton rjButtonClear;
        private System.Windows.Forms.Label labelInfo;
    }
}