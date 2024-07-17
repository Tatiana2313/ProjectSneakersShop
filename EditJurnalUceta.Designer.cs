namespace DataBaseSneakers
{
    partial class EditJurnalUceta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditJurnalUceta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.rjButtonEdit = new DataBaseSneakers.RJButton();
            this.rjTextBoxNumDeliver = new DataBaseSneakers.RJTextBox();
            this.labelNumDeliver = new System.Windows.Forms.Label();
            this.rjTextBoxNumSold = new DataBaseSneakers.RJTextBox();
            this.labelNumSold = new System.Windows.Forms.Label();
            this.rjComboBoxSneakers = new DataBaseSneakers.RJComboBox();
            this.labelSneakers = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.rjTextBoxMonth = new DataBaseSneakers.RJTextBox();
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
            this.panel1.Size = new System.Drawing.Size(695, 41);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(23, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(217, 22);
            this.labelInfo.TabIndex = 50;
            this.labelInfo.Text = "Изменение информации";
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(643, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(52, 41);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
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
            this.rjButtonEdit.Location = new System.Drawing.Point(468, 513);
            this.rjButtonEdit.Name = "rjButtonEdit";
            this.rjButtonEdit.Size = new System.Drawing.Size(169, 54);
            this.rjButtonEdit.TabIndex = 51;
            this.rjButtonEdit.Text = "Изменить";
            this.rjButtonEdit.TextColor = System.Drawing.Color.White;
            this.rjButtonEdit.UseVisualStyleBackColor = false;
            this.rjButtonEdit.Click += new System.EventHandler(this.rjButtonEdit_Click);
            // 
            // rjTextBoxNumDeliver
            // 
            this.rjTextBoxNumDeliver.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxNumDeliver.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxNumDeliver.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxNumDeliver.BorderRadius = 0;
            this.rjTextBoxNumDeliver.BorderSize = 2;
            this.rjTextBoxNumDeliver.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.rjTextBoxNumDeliver.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxNumDeliver.Location = new System.Drawing.Point(309, 357);
            this.rjTextBoxNumDeliver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxNumDeliver.MaxLength = 10;
            this.rjTextBoxNumDeliver.MinLength = 0;
            this.rjTextBoxNumDeliver.Multiline = false;
            this.rjTextBoxNumDeliver.Name = "rjTextBoxNumDeliver";
            this.rjTextBoxNumDeliver.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxNumDeliver.PasswordChar = false;
            this.rjTextBoxNumDeliver.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxNumDeliver.PlaceholderText = "";
            this.rjTextBoxNumDeliver.ReadOnly = false;
            this.rjTextBoxNumDeliver.Size = new System.Drawing.Size(149, 40);
            this.rjTextBoxNumDeliver.TabIndex = 50;
            this.rjTextBoxNumDeliver.Texts = "";
            this.rjTextBoxNumDeliver.UnderlinedStyle = true;
            this.rjTextBoxNumDeliver._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.rjTextBoxNumDeliver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxDigits_KeyPress);
            // 
            // labelNumDeliver
            // 
            this.labelNumDeliver.AutoSize = true;
            this.labelNumDeliver.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumDeliver.Location = new System.Drawing.Point(53, 369);
            this.labelNumDeliver.Name = "labelNumDeliver";
            this.labelNumDeliver.Size = new System.Drawing.Size(241, 28);
            this.labelNumDeliver.TabIndex = 49;
            this.labelNumDeliver.Text = "Кол-во поставленных:";
            // 
            // rjTextBoxNumSold
            // 
            this.rjTextBoxNumSold.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxNumSold.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxNumSold.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxNumSold.BorderRadius = 0;
            this.rjTextBoxNumSold.BorderSize = 2;
            this.rjTextBoxNumSold.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.rjTextBoxNumSold.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxNumSold.Location = new System.Drawing.Point(309, 427);
            this.rjTextBoxNumSold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxNumSold.MaxLength = 10;
            this.rjTextBoxNumSold.MinLength = 0;
            this.rjTextBoxNumSold.Multiline = false;
            this.rjTextBoxNumSold.Name = "rjTextBoxNumSold";
            this.rjTextBoxNumSold.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxNumSold.PasswordChar = false;
            this.rjTextBoxNumSold.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxNumSold.PlaceholderText = "";
            this.rjTextBoxNumSold.ReadOnly = false;
            this.rjTextBoxNumSold.Size = new System.Drawing.Size(149, 40);
            this.rjTextBoxNumSold.TabIndex = 48;
            this.rjTextBoxNumSold.Texts = "";
            this.rjTextBoxNumSold.UnderlinedStyle = true;
            this.rjTextBoxNumSold._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.rjTextBoxNumSold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxDigits_KeyPress);
            // 
            // labelNumSold
            // 
            this.labelNumSold.AutoSize = true;
            this.labelNumSold.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumSold.Location = new System.Drawing.Point(53, 439);
            this.labelNumSold.Name = "labelNumSold";
            this.labelNumSold.Size = new System.Drawing.Size(210, 28);
            this.labelNumSold.TabIndex = 47;
            this.labelNumSold.Text = "Кол-во проданных:";
            // 
            // rjComboBoxSneakers
            // 
            this.rjComboBoxSneakers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBoxSneakers.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxSneakers.BorderSize = 2;
            this.rjComboBoxSneakers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBoxSneakers.Enabled = false;
            this.rjComboBoxSneakers.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjComboBoxSneakers.ForeColor = System.Drawing.Color.Black;
            this.rjComboBoxSneakers.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxSneakers.ListBackColor = System.Drawing.Color.OldLace;
            this.rjComboBoxSneakers.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBoxSneakers.Location = new System.Drawing.Point(214, 295);
            this.rjComboBoxSneakers.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBoxSneakers.Name = "rjComboBoxSneakers";
            this.rjComboBoxSneakers.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBoxSneakers.Size = new System.Drawing.Size(290, 37);
            this.rjComboBoxSneakers.TabIndex = 46;
            this.rjComboBoxSneakers.Texts = "";
            // 
            // labelSneakers
            // 
            this.labelSneakers.AutoSize = true;
            this.labelSneakers.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSneakers.Location = new System.Drawing.Point(53, 295);
            this.labelSneakers.Name = "labelSneakers";
            this.labelSneakers.Size = new System.Drawing.Size(129, 28);
            this.labelSneakers.TabIndex = 45;
            this.labelSneakers.Text = "Кроссовки:";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMonth.Location = new System.Drawing.Point(53, 232);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(86, 28);
            this.labelMonth.TabIndex = 43;
            this.labelMonth.Text = "Месяц:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(44, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.Color.Purple;
            this.labelHeader.Location = new System.Drawing.Point(177, 94);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(234, 50);
            this.labelHeader.TabIndex = 41;
            this.labelHeader.Text = "Журнал учета";
            // 
            // rjTextBoxMonth
            // 
            this.rjTextBoxMonth.BackColor = System.Drawing.Color.Snow;
            this.rjTextBoxMonth.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxMonth.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxMonth.BorderRadius = 0;
            this.rjTextBoxMonth.BorderSize = 2;
            this.rjTextBoxMonth.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.rjTextBoxMonth.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxMonth.Location = new System.Drawing.Point(186, 223);
            this.rjTextBoxMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxMonth.MaxLength = 10;
            this.rjTextBoxMonth.MinLength = 0;
            this.rjTextBoxMonth.Multiline = false;
            this.rjTextBoxMonth.Name = "rjTextBoxMonth";
            this.rjTextBoxMonth.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxMonth.PasswordChar = false;
            this.rjTextBoxMonth.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxMonth.PlaceholderText = "";
            this.rjTextBoxMonth.ReadOnly = true;
            this.rjTextBoxMonth.Size = new System.Drawing.Size(184, 37);
            this.rjTextBoxMonth.TabIndex = 44;
            this.rjTextBoxMonth.Texts = "";
            this.rjTextBoxMonth.UnderlinedStyle = true;
            this.rjTextBoxMonth._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.rjTextBoxMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxLetters_KeyPress);
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
            this.rjButtonClear.Location = new System.Drawing.Point(254, 513);
            this.rjButtonClear.Name = "rjButtonClear";
            this.rjButtonClear.Size = new System.Drawing.Size(169, 54);
            this.rjButtonClear.TabIndex = 54;
            this.rjButtonClear.Text = "Очистить";
            this.rjButtonClear.TextColor = System.Drawing.Color.White;
            this.rjButtonClear.UseVisualStyleBackColor = false;
            this.rjButtonClear.Click += new System.EventHandler(this.rjButtonClear_Click);
            // 
            // EditJurnalUceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(695, 602);
            this.Controls.Add(this.rjButtonClear);
            this.Controls.Add(this.rjButtonEdit);
            this.Controls.Add(this.rjTextBoxNumDeliver);
            this.Controls.Add(this.labelNumDeliver);
            this.Controls.Add(this.rjTextBoxNumSold);
            this.Controls.Add(this.labelNumSold);
            this.Controls.Add(this.rjComboBoxSneakers);
            this.Controls.Add(this.labelSneakers);
            this.Controls.Add(this.rjTextBoxMonth);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditJurnalUceta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditJurnalUceta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private RJButton rjButtonEdit;
        private RJTextBox rjTextBoxNumDeliver;
        private System.Windows.Forms.Label labelNumDeliver;
        private RJTextBox rjTextBoxNumSold;
        private System.Windows.Forms.Label labelNumSold;
        private RJComboBox rjComboBoxSneakers;
        private System.Windows.Forms.Label labelSneakers;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelHeader;
        private RJTextBox rjTextBoxMonth;
        private RJButton rjButtonClear;
        private System.Windows.Forms.Label labelInfo;
    }
}