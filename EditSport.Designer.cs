namespace DataBaseSneakers
{
    partial class EditSport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.rjButtonEdit = new DataBaseSneakers.RJButton();
            this.rjTextBoxSport = new DataBaseSneakers.RJTextBox();
            this.labelSport = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.rjButtonClear = new DataBaseSneakers.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 42);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(475, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 42);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.rjButtonEdit.Location = new System.Drawing.Point(296, 330);
            this.rjButtonEdit.Name = "rjButtonEdit";
            this.rjButtonEdit.Size = new System.Drawing.Size(169, 54);
            this.rjButtonEdit.TabIndex = 15;
            this.rjButtonEdit.Text = "Изменить";
            this.rjButtonEdit.TextColor = System.Drawing.Color.White;
            this.rjButtonEdit.UseVisualStyleBackColor = false;
            this.rjButtonEdit.Click += new System.EventHandler(this.rjButtonEdit_Click);
            // 
            // rjTextBoxSport
            // 
            this.rjTextBoxSport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjTextBoxSport.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxSport.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxSport.BorderRadius = 0;
            this.rjTextBoxSport.BorderSize = 2;
            this.rjTextBoxSport.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.rjTextBoxSport.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxSport.Location = new System.Drawing.Point(263, 237);
            this.rjTextBoxSport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxSport.MaxLength = 32767;
            this.rjTextBoxSport.MinLength = 0;
            this.rjTextBoxSport.Multiline = false;
            this.rjTextBoxSport.Name = "rjTextBoxSport";
            this.rjTextBoxSport.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxSport.PasswordChar = false;
            this.rjTextBoxSport.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxSport.PlaceholderText = "";
            this.rjTextBoxSport.ReadOnly = false;
            this.rjTextBoxSport.Size = new System.Drawing.Size(202, 37);
            this.rjTextBoxSport.TabIndex = 14;
            this.rjTextBoxSport.Texts = "";
            this.rjTextBoxSport.UnderlinedStyle = true;
            this.rjTextBoxSport._TextChanged += new System.EventHandler(this.rjTextBoxSport__TextChanged);
            this.rjTextBoxSport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxSport_KeyPress);
            // 
            // labelSport
            // 
            this.labelSport.AutoSize = true;
            this.labelSport.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSport.Location = new System.Drawing.Point(58, 244);
            this.labelSport.Name = "labelSport";
            this.labelSport.Size = new System.Drawing.Size(193, 28);
            this.labelSport.TabIndex = 13;
            this.labelSport.Text = "Название спорта:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.Color.Purple;
            this.labelHeader.Location = new System.Drawing.Point(182, 100);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(197, 50);
            this.labelHeader.TabIndex = 11;
            this.labelHeader.Text = "Вид спорта";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(28, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(217, 22);
            this.labelInfo.TabIndex = 46;
            this.labelInfo.Text = "Изменение информации";
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
            this.rjButtonClear.Location = new System.Drawing.Point(32, 330);
            this.rjButtonClear.Name = "rjButtonClear";
            this.rjButtonClear.Size = new System.Drawing.Size(169, 54);
            this.rjButtonClear.TabIndex = 16;
            this.rjButtonClear.Text = "Очистить";
            this.rjButtonClear.TextColor = System.Drawing.Color.White;
            this.rjButtonClear.UseVisualStyleBackColor = false;
            this.rjButtonClear.Click += new System.EventHandler(this.rjButtonClear_Click);
            // 
            // EditSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(515, 461);
            this.Controls.Add(this.rjButtonClear);
            this.Controls.Add(this.rjButtonEdit);
            this.Controls.Add(this.rjTextBoxSport);
            this.Controls.Add(this.labelSport);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditSport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditSport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private RJButton rjButtonEdit;
        private RJTextBox rjTextBoxSport;
        private System.Windows.Forms.Label labelSport;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelInfo;
        private RJButton rjButtonClear;
    }
}