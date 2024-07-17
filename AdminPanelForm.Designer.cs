namespace DataBaseSneakers
{
    partial class AdminPanelForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rjButtonDelete = new DataBaseSneakers.RJButton();
            this.rjButtonEdit = new DataBaseSneakers.RJButton();
            this.rjButtonAdd = new DataBaseSneakers.RJButton();
            this.rjButtonUsers = new DataBaseSneakers.RJButton();
            this.rjButtonBackupRestore = new DataBaseSneakers.RJButton();
            this.rjButtonBackup = new DataBaseSneakers.RJButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 40);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::DataBaseSneakers.Properties.Resources.buttonclose;
            this.buttonClose.Location = new System.Drawing.Point(958, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(49, 40);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.Color.Purple;
            this.labelHeader.Location = new System.Drawing.Point(158, 94);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(566, 50);
            this.labelHeader.TabIndex = 36;
            this.labelHeader.Text = "Панель управления администратора";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(145, 515);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(640, 312);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.Visible = false;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 773);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(179, 110);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(815, 773);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 99);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // rjButtonDelete
            // 
            this.rjButtonDelete.BackColor = System.Drawing.Color.Transparent;
            this.rjButtonDelete.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButtonDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonDelete.BorderRadius = 0;
            this.rjButtonDelete.BorderSize = 0;
            this.rjButtonDelete.FlatAppearance.BorderSize = 0;
            this.rjButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonDelete.ForeColor = System.Drawing.Color.White;
            this.rjButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("rjButtonDelete.Image")));
            this.rjButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButtonDelete.Location = new System.Drawing.Point(791, 620);
            this.rjButtonDelete.Name = "rjButtonDelete";
            this.rjButtonDelete.Size = new System.Drawing.Size(44, 42);
            this.rjButtonDelete.TabIndex = 45;
            this.rjButtonDelete.TextColor = System.Drawing.Color.White;
            this.rjButtonDelete.UseVisualStyleBackColor = false;
            this.rjButtonDelete.Visible = false;
            this.rjButtonDelete.Click += new System.EventHandler(this.rjButtonDelete_Click);
            // 
            // rjButtonEdit
            // 
            this.rjButtonEdit.BackColor = System.Drawing.Color.Transparent;
            this.rjButtonEdit.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButtonEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonEdit.BorderRadius = 0;
            this.rjButtonEdit.BorderSize = 0;
            this.rjButtonEdit.FlatAppearance.BorderSize = 0;
            this.rjButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonEdit.ForeColor = System.Drawing.Color.White;
            this.rjButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("rjButtonEdit.Image")));
            this.rjButtonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButtonEdit.Location = new System.Drawing.Point(791, 572);
            this.rjButtonEdit.Name = "rjButtonEdit";
            this.rjButtonEdit.Size = new System.Drawing.Size(44, 42);
            this.rjButtonEdit.TabIndex = 44;
            this.rjButtonEdit.TextColor = System.Drawing.Color.White;
            this.rjButtonEdit.UseVisualStyleBackColor = false;
            this.rjButtonEdit.Visible = false;
            this.rjButtonEdit.Click += new System.EventHandler(this.rjButtonEdit_Click);
            // 
            // rjButtonAdd
            // 
            this.rjButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.rjButtonAdd.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButtonAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonAdd.BorderRadius = 0;
            this.rjButtonAdd.BorderSize = 0;
            this.rjButtonAdd.FlatAppearance.BorderSize = 0;
            this.rjButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonAdd.ForeColor = System.Drawing.Color.White;
            this.rjButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("rjButtonAdd.Image")));
            this.rjButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButtonAdd.Location = new System.Drawing.Point(791, 515);
            this.rjButtonAdd.Name = "rjButtonAdd";
            this.rjButtonAdd.Size = new System.Drawing.Size(44, 51);
            this.rjButtonAdd.TabIndex = 43;
            this.rjButtonAdd.TextColor = System.Drawing.Color.White;
            this.rjButtonAdd.UseVisualStyleBackColor = false;
            this.rjButtonAdd.Visible = false;
            this.rjButtonAdd.Click += new System.EventHandler(this.rjButtonAdd_Click);
            // 
            // rjButtonUsers
            // 
            this.rjButtonUsers.BackColor = System.Drawing.Color.MediumPurple;
            this.rjButtonUsers.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.rjButtonUsers.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonUsers.BorderRadius = 10;
            this.rjButtonUsers.BorderSize = 0;
            this.rjButtonUsers.FlatAppearance.BorderSize = 0;
            this.rjButtonUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.rjButtonUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.rjButtonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonUsers.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonUsers.ForeColor = System.Drawing.Color.White;
            this.rjButtonUsers.Location = new System.Drawing.Point(235, 420);
            this.rjButtonUsers.Name = "rjButtonUsers";
            this.rjButtonUsers.Size = new System.Drawing.Size(452, 59);
            this.rjButtonUsers.TabIndex = 40;
            this.rjButtonUsers.Text = "Пользователи";
            this.rjButtonUsers.TextColor = System.Drawing.Color.White;
            this.rjButtonUsers.UseVisualStyleBackColor = false;
            this.rjButtonUsers.Click += new System.EventHandler(this.rjButtonUsers_Click);
            // 
            // rjButtonBackupRestore
            // 
            this.rjButtonBackupRestore.BackColor = System.Drawing.Color.MediumPurple;
            this.rjButtonBackupRestore.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.rjButtonBackupRestore.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonBackupRestore.BorderRadius = 10;
            this.rjButtonBackupRestore.BorderSize = 0;
            this.rjButtonBackupRestore.FlatAppearance.BorderSize = 0;
            this.rjButtonBackupRestore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.rjButtonBackupRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.rjButtonBackupRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonBackupRestore.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonBackupRestore.ForeColor = System.Drawing.Color.White;
            this.rjButtonBackupRestore.Location = new System.Drawing.Point(235, 333);
            this.rjButtonBackupRestore.Name = "rjButtonBackupRestore";
            this.rjButtonBackupRestore.Size = new System.Drawing.Size(452, 59);
            this.rjButtonBackupRestore.TabIndex = 39;
            this.rjButtonBackupRestore.Text = "Восстановить данные";
            this.rjButtonBackupRestore.TextColor = System.Drawing.Color.White;
            this.rjButtonBackupRestore.UseVisualStyleBackColor = false;
            this.rjButtonBackupRestore.Click += new System.EventHandler(this.rjButtonBackupRestore_Click);
            // 
            // rjButtonBackup
            // 
            this.rjButtonBackup.BackColor = System.Drawing.Color.MediumPurple;
            this.rjButtonBackup.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.rjButtonBackup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonBackup.BorderRadius = 10;
            this.rjButtonBackup.BorderSize = 0;
            this.rjButtonBackup.FlatAppearance.BorderSize = 0;
            this.rjButtonBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.rjButtonBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.rjButtonBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonBackup.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonBackup.ForeColor = System.Drawing.Color.White;
            this.rjButtonBackup.Location = new System.Drawing.Point(235, 241);
            this.rjButtonBackup.Name = "rjButtonBackup";
            this.rjButtonBackup.Size = new System.Drawing.Size(452, 59);
            this.rjButtonBackup.TabIndex = 38;
            this.rjButtonBackup.Text = "Создать резервную копию";
            this.rjButtonBackup.TextColor = System.Drawing.Color.White;
            this.rjButtonBackup.UseVisualStyleBackColor = false;
            this.rjButtonBackup.Click += new System.EventHandler(this.rjButtonBackup_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1007, 882);
            this.Controls.Add(this.rjButtonDelete);
            this.Controls.Add(this.rjButtonEdit);
            this.Controls.Add(this.rjButtonAdd);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rjButtonUsers);
            this.Controls.Add(this.rjButtonBackupRestore);
            this.Controls.Add(this.rjButtonBackup);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdminPanelForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RJButton rjButtonBackup;
        private RJButton rjButtonBackupRestore;
        private RJButton rjButtonUsers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private RJButton rjButtonAdd;
        private RJButton rjButtonEdit;
        private RJButton rjButtonDelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}