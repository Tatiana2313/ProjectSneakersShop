﻿namespace DataBaseSneakers
{
    partial class SellerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjButtonChek = new DataBaseSneakers.RJButton();
            this.rjButtonSneakers = new DataBaseSneakers.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rjButtonFiltration = new DataBaseSneakers.RJButton();
            this.rjButtonResearch = new DataBaseSneakers.RJButton();
            this.rjTextBoxResearch = new DataBaseSneakers.RJTextBox();
            this.rjButtonAdd = new DataBaseSneakers.RJButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSneakers = new System.Windows.Forms.Label();
            this.rjComboBoxSneakers = new DataBaseSneakers.RJComboBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.rjComboBoxBrand = new DataBaseSneakers.RJComboBox();
            this.labelProdCountry = new System.Windows.Forms.Label();
            this.rjComboBoxProdCountry = new DataBaseSneakers.RJComboBox();
            this.labelSport = new System.Windows.Forms.Label();
            this.rjComboBoxSport = new DataBaseSneakers.RJComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.rjComboBoxGender = new DataBaseSneakers.RJComboBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.rjComboBoxSize = new DataBaseSneakers.RJComboBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.rjComboBoxColor = new DataBaseSneakers.RJComboBox();
            this.rjTextBoxPrice1 = new DataBaseSneakers.RJTextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rjTextBoxPrice2 = new DataBaseSneakers.RJTextBox();
            this.rjButtonClear = new DataBaseSneakers.RJButton();
            this.rjButtonClose = new DataBaseSneakers.RJButton();
            this.panelFiltration = new System.Windows.Forms.Panel();
            this.pictureBoxWelcome = new System.Windows.Forms.PictureBox();
            this.rjButtonHelp = new DataBaseSneakers.RJButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelFiltration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1780, 49);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::DataBaseSneakers.Properties.Resources.buttonclose;
            this.buttonClose.Location = new System.Drawing.Point(1731, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(49, 49);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.rjButtonChek);
            this.panel2.Controls.Add(this.rjButtonSneakers);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 983);
            this.panel2.TabIndex = 12;
            // 
            // rjButtonChek
            // 
            this.rjButtonChek.BackColor = System.Drawing.Color.Transparent;
            this.rjButtonChek.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButtonChek.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonChek.BorderRadius = 0;
            this.rjButtonChek.BorderSize = 0;
            this.rjButtonChek.FlatAppearance.BorderSize = 0;
            this.rjButtonChek.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.rjButtonChek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.rjButtonChek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonChek.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonChek.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButtonChek.Image = ((System.Drawing.Image)(resources.GetObject("rjButtonChek.Image")));
            this.rjButtonChek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButtonChek.Location = new System.Drawing.Point(16, 329);
            this.rjButtonChek.Name = "rjButtonChek";
            this.rjButtonChek.Size = new System.Drawing.Size(323, 74);
            this.rjButtonChek.TabIndex = 6;
            this.rjButtonChek.Text = "      Покупки";
            this.rjButtonChek.TextColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButtonChek.UseVisualStyleBackColor = false;
            this.rjButtonChek.Click += new System.EventHandler(this.rjButtonChek_Click);
            // 
            // rjButtonSneakers
            // 
            this.rjButtonSneakers.BackColor = System.Drawing.Color.Transparent;
            this.rjButtonSneakers.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButtonSneakers.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonSneakers.BorderRadius = 0;
            this.rjButtonSneakers.BorderSize = 0;
            this.rjButtonSneakers.FlatAppearance.BorderSize = 0;
            this.rjButtonSneakers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.rjButtonSneakers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.rjButtonSneakers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonSneakers.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonSneakers.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButtonSneakers.Image = ((System.Drawing.Image)(resources.GetObject("rjButtonSneakers.Image")));
            this.rjButtonSneakers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButtonSneakers.Location = new System.Drawing.Point(12, 222);
            this.rjButtonSneakers.Name = "rjButtonSneakers";
            this.rjButtonSneakers.Size = new System.Drawing.Size(323, 74);
            this.rjButtonSneakers.TabIndex = 4;
            this.rjButtonSneakers.Text = "      Кроссовки";
            this.rjButtonSneakers.TextColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButtonSneakers.UseVisualStyleBackColor = false;
            this.rjButtonSneakers.Click += new System.EventHandler(this.rjButtonSneakers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(169, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 105);
            this.label1.TabIndex = 1;
            this.label1.Text = "   Магазин \r\n спортивных \r\n  кроссовок";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rjButtonFiltration
            // 
            this.rjButtonFiltration.BackColor = System.Drawing.Color.Transparent;
            this.rjButtonFiltration.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButtonFiltration.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonFiltration.BorderRadius = 0;
            this.rjButtonFiltration.BorderSize = 0;
            this.rjButtonFiltration.FlatAppearance.BorderSize = 0;
            this.rjButtonFiltration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.rjButtonFiltration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.rjButtonFiltration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonFiltration.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonFiltration.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButtonFiltration.Image = ((System.Drawing.Image)(resources.GetObject("rjButtonFiltration.Image")));
            this.rjButtonFiltration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButtonFiltration.Location = new System.Drawing.Point(1481, 227);
            this.rjButtonFiltration.Name = "rjButtonFiltration";
            this.rjButtonFiltration.Size = new System.Drawing.Size(228, 69);
            this.rjButtonFiltration.TabIndex = 24;
            this.rjButtonFiltration.Text = "Фильтрация";
            this.rjButtonFiltration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButtonFiltration.TextColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButtonFiltration.UseVisualStyleBackColor = false;
            this.rjButtonFiltration.Visible = false;
            this.rjButtonFiltration.Click += new System.EventHandler(this.rjButtonFiltration_Click);
            // 
            // rjButtonResearch
            // 
            this.rjButtonResearch.BackColor = System.Drawing.Color.Transparent;
            this.rjButtonResearch.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButtonResearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonResearch.BorderRadius = 10;
            this.rjButtonResearch.BorderSize = 0;
            this.rjButtonResearch.Enabled = false;
            this.rjButtonResearch.FlatAppearance.BorderSize = 0;
            this.rjButtonResearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.rjButtonResearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.rjButtonResearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonResearch.ForeColor = System.Drawing.Color.Black;
            this.rjButtonResearch.Image = ((System.Drawing.Image)(resources.GetObject("rjButtonResearch.Image")));
            this.rjButtonResearch.Location = new System.Drawing.Point(643, 244);
            this.rjButtonResearch.Name = "rjButtonResearch";
            this.rjButtonResearch.Size = new System.Drawing.Size(68, 58);
            this.rjButtonResearch.TabIndex = 22;
            this.rjButtonResearch.TextColor = System.Drawing.Color.Black;
            this.rjButtonResearch.UseVisualStyleBackColor = false;
            this.rjButtonResearch.Visible = false;
            this.rjButtonResearch.Click += new System.EventHandler(this.rjButtonResearch_Click);
            // 
            // rjTextBoxResearch
            // 
            this.rjTextBoxResearch.BackColor = System.Drawing.Color.SeaShell;
            this.rjTextBoxResearch.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rjTextBoxResearch.BorderFocusColor = System.Drawing.Color.Crimson;
            this.rjTextBoxResearch.BorderRadius = 0;
            this.rjTextBoxResearch.BorderSize = 2;
            this.rjTextBoxResearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjTextBoxResearch.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxResearch.Location = new System.Drawing.Point(387, 258);
            this.rjTextBoxResearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxResearch.MaxLength = 32767;
            this.rjTextBoxResearch.MinLength = 0;
            this.rjTextBoxResearch.Multiline = false;
            this.rjTextBoxResearch.Name = "rjTextBoxResearch";
            this.rjTextBoxResearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxResearch.PasswordChar = false;
            this.rjTextBoxResearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxResearch.PlaceholderText = "";
            this.rjTextBoxResearch.ReadOnly = false;
            this.rjTextBoxResearch.Size = new System.Drawing.Size(250, 35);
            this.rjTextBoxResearch.TabIndex = 21;
            this.rjTextBoxResearch.Texts = "";
            this.rjTextBoxResearch.UnderlinedStyle = false;
            this.rjTextBoxResearch.Visible = false;
            this.rjTextBoxResearch._TextChanged += new System.EventHandler(this.rjTextBoxResearch__TextChanged);
            // 
            // rjButtonAdd
            // 
            this.rjButtonAdd.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButtonAdd.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButtonAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonAdd.BorderRadius = 27;
            this.rjButtonAdd.BorderSize = 0;
            this.rjButtonAdd.FlatAppearance.BorderSize = 0;
            this.rjButtonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.rjButtonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.rjButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonAdd.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonAdd.ForeColor = System.Drawing.Color.White;
            this.rjButtonAdd.Location = new System.Drawing.Point(1543, 121);
            this.rjButtonAdd.Name = "rjButtonAdd";
            this.rjButtonAdd.Size = new System.Drawing.Size(166, 56);
            this.rjButtonAdd.TabIndex = 19;
            this.rjButtonAdd.Text = "Добавить";
            this.rjButtonAdd.TextColor = System.Drawing.Color.White;
            this.rjButtonAdd.UseVisualStyleBackColor = false;
            this.rjButtonAdd.Visible = false;
            this.rjButtonAdd.Click += new System.EventHandler(this.rjButtonAdd_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(387, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.Color.Purple;
            this.labelHeader.Location = new System.Drawing.Point(520, 110);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(0, 50);
            this.labelHeader.TabIndex = 17;
            this.labelHeader.Visible = false;
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
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
            this.dataGridView1.Location = new System.Drawing.Point(387, 331);
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
            this.dataGridView1.Size = new System.Drawing.Size(1322, 526);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(184, 170);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(145, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "   Фильтрация";
            // 
            // labelSneakers
            // 
            this.labelSneakers.AutoSize = true;
            this.labelSneakers.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSneakers.Location = new System.Drawing.Point(12, 195);
            this.labelSneakers.Name = "labelSneakers";
            this.labelSneakers.Size = new System.Drawing.Size(112, 24);
            this.labelSneakers.TabIndex = 46;
            this.labelSneakers.Text = "Кроссовки:";
            // 
            // rjComboBoxSneakers
            // 
            this.rjComboBoxSneakers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rjComboBoxSneakers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rjComboBoxSneakers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBoxSneakers.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxSneakers.BorderSize = 2;
            this.rjComboBoxSneakers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rjComboBoxSneakers.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjComboBoxSneakers.ForeColor = System.Drawing.Color.Black;
            this.rjComboBoxSneakers.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxSneakers.ListBackColor = System.Drawing.Color.Lavender;
            this.rjComboBoxSneakers.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBoxSneakers.Location = new System.Drawing.Point(130, 192);
            this.rjComboBoxSneakers.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBoxSneakers.Name = "rjComboBoxSneakers";
            this.rjComboBoxSneakers.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBoxSneakers.Size = new System.Drawing.Size(205, 35);
            this.rjComboBoxSneakers.TabIndex = 47;
            this.rjComboBoxSneakers.Texts = "";
            this.rjComboBoxSneakers.OnSelectedIndexChanged += new System.EventHandler(this.rjComboBox_OnSelectedIndexChanged);
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBrand.Location = new System.Drawing.Point(12, 269);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(71, 24);
            this.labelBrand.TabIndex = 48;
            this.labelBrand.Text = "Бренд:";
            // 
            // rjComboBoxBrand
            // 
            this.rjComboBoxBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rjComboBoxBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rjComboBoxBrand.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBoxBrand.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxBrand.BorderSize = 2;
            this.rjComboBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rjComboBoxBrand.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjComboBoxBrand.ForeColor = System.Drawing.Color.Black;
            this.rjComboBoxBrand.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxBrand.Items.AddRange(new object[] {
            "Nike",
            "Demix",
            "FILA",
            "Puma",
            "JORDAN",
            "Reebok",
            "Adidas"});
            this.rjComboBoxBrand.ListBackColor = System.Drawing.Color.Lavender;
            this.rjComboBoxBrand.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBoxBrand.Location = new System.Drawing.Point(102, 263);
            this.rjComboBoxBrand.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBoxBrand.Name = "rjComboBoxBrand";
            this.rjComboBoxBrand.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBoxBrand.Size = new System.Drawing.Size(205, 36);
            this.rjComboBoxBrand.TabIndex = 49;
            this.rjComboBoxBrand.Texts = "";
            this.rjComboBoxBrand.OnSelectedIndexChanged += new System.EventHandler(this.rjComboBox_OnSelectedIndexChanged);
            // 
            // labelProdCountry
            // 
            this.labelProdCountry.AutoSize = true;
            this.labelProdCountry.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProdCountry.Location = new System.Drawing.Point(21, 329);
            this.labelProdCountry.Name = "labelProdCountry";
            this.labelProdCountry.Size = new System.Drawing.Size(224, 24);
            this.labelProdCountry.TabIndex = 50;
            this.labelProdCountry.Text = "Страна производитель:";
            // 
            // rjComboBoxProdCountry
            // 
            this.rjComboBoxProdCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rjComboBoxProdCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rjComboBoxProdCountry.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBoxProdCountry.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxProdCountry.BorderSize = 2;
            this.rjComboBoxProdCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rjComboBoxProdCountry.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjComboBoxProdCountry.ForeColor = System.Drawing.Color.Black;
            this.rjComboBoxProdCountry.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxProdCountry.Items.AddRange(new object[] {
            "Vietnam",
            "Great Britain",
            "China",
            "USA",
            "France",
            "Indonesia"});
            this.rjComboBoxProdCountry.ListBackColor = System.Drawing.Color.Lavender;
            this.rjComboBoxProdCountry.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBoxProdCountry.Location = new System.Drawing.Point(25, 369);
            this.rjComboBoxProdCountry.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBoxProdCountry.Name = "rjComboBoxProdCountry";
            this.rjComboBoxProdCountry.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBoxProdCountry.Size = new System.Drawing.Size(220, 37);
            this.rjComboBoxProdCountry.TabIndex = 51;
            this.rjComboBoxProdCountry.Texts = "";
            this.rjComboBoxProdCountry.OnSelectedIndexChanged += new System.EventHandler(this.rjComboBox_OnSelectedIndexChanged);
            // 
            // labelSport
            // 
            this.labelSport.AutoSize = true;
            this.labelSport.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSport.Location = new System.Drawing.Point(21, 427);
            this.labelSport.Name = "labelSport";
            this.labelSport.Size = new System.Drawing.Size(172, 24);
            this.labelSport.TabIndex = 52;
            this.labelSport.Text = "Название спорта:";
            // 
            // rjComboBoxSport
            // 
            this.rjComboBoxSport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBoxSport.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxSport.BorderSize = 2;
            this.rjComboBoxSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rjComboBoxSport.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjComboBoxSport.ForeColor = System.Drawing.Color.Black;
            this.rjComboBoxSport.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxSport.ListBackColor = System.Drawing.Color.Lavender;
            this.rjComboBoxSport.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBoxSport.Location = new System.Drawing.Point(25, 461);
            this.rjComboBoxSport.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBoxSport.Name = "rjComboBoxSport";
            this.rjComboBoxSport.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBoxSport.Size = new System.Drawing.Size(220, 37);
            this.rjComboBoxSport.TabIndex = 53;
            this.rjComboBoxSport.Texts = "";
            this.rjComboBoxSport.OnSelectedIndexChanged += new System.EventHandler(this.rjComboBox_OnSelectedIndexChanged);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(21, 532);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(51, 24);
            this.labelGender.TabIndex = 54;
            this.labelGender.Text = "Пол:";
            // 
            // rjComboBoxGender
            // 
            this.rjComboBoxGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBoxGender.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxGender.BorderSize = 2;
            this.rjComboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rjComboBoxGender.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjComboBoxGender.ForeColor = System.Drawing.Color.Black;
            this.rjComboBoxGender.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxGender.Items.AddRange(new object[] {
            "F",
            "M"});
            this.rjComboBoxGender.ListBackColor = System.Drawing.Color.Lavender;
            this.rjComboBoxGender.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBoxGender.Location = new System.Drawing.Point(107, 532);
            this.rjComboBoxGender.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBoxGender.Name = "rjComboBoxGender";
            this.rjComboBoxGender.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBoxGender.Size = new System.Drawing.Size(200, 37);
            this.rjComboBoxGender.TabIndex = 55;
            this.rjComboBoxGender.Texts = "";
            this.rjComboBoxGender.OnSelectedIndexChanged += new System.EventHandler(this.rjComboBox_OnSelectedIndexChanged);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSize.Location = new System.Drawing.Point(20, 600);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(81, 24);
            this.labelSize.TabIndex = 30;
            this.labelSize.Text = "Размер:";
            // 
            // rjComboBoxSize
            // 
            this.rjComboBoxSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rjComboBoxSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rjComboBoxSize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBoxSize.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxSize.BorderSize = 2;
            this.rjComboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rjComboBoxSize.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjComboBoxSize.ForeColor = System.Drawing.Color.Black;
            this.rjComboBoxSize.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxSize.Items.AddRange(new object[] {
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48"});
            this.rjComboBoxSize.ListBackColor = System.Drawing.Color.Lavender;
            this.rjComboBoxSize.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBoxSize.Location = new System.Drawing.Point(107, 593);
            this.rjComboBoxSize.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBoxSize.Name = "rjComboBoxSize";
            this.rjComboBoxSize.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBoxSize.Size = new System.Drawing.Size(200, 37);
            this.rjComboBoxSize.TabIndex = 56;
            this.rjComboBoxSize.Texts = "";
            this.rjComboBoxSize.OnSelectedIndexChanged += new System.EventHandler(this.rjComboBox_OnSelectedIndexChanged);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor.Location = new System.Drawing.Point(21, 665);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(60, 24);
            this.labelColor.TabIndex = 57;
            this.labelColor.Text = "Цвет:";
            // 
            // rjComboBoxColor
            // 
            this.rjComboBoxColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rjComboBoxColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rjComboBoxColor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBoxColor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxColor.BorderSize = 2;
            this.rjComboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rjComboBoxColor.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjComboBoxColor.ForeColor = System.Drawing.Color.Black;
            this.rjComboBoxColor.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxColor.Items.AddRange(new object[] {
            "blue",
            "black",
            "black-red",
            "lilac",
            "black-blue",
            "red and white",
            "pink/white",
            "yellow"});
            this.rjComboBoxColor.ListBackColor = System.Drawing.Color.Lavender;
            this.rjComboBoxColor.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBoxColor.Location = new System.Drawing.Point(107, 662);
            this.rjComboBoxColor.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBoxColor.Name = "rjComboBoxColor";
            this.rjComboBoxColor.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBoxColor.Size = new System.Drawing.Size(200, 37);
            this.rjComboBoxColor.TabIndex = 58;
            this.rjComboBoxColor.Texts = "";
            this.rjComboBoxColor.OnSelectedIndexChanged += new System.EventHandler(this.rjComboBox_OnSelectedIndexChanged);
            // 
            // rjTextBoxPrice1
            // 
            this.rjTextBoxPrice1.BackColor = System.Drawing.Color.Lavender;
            this.rjTextBoxPrice1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxPrice1.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxPrice1.BorderRadius = 0;
            this.rjTextBoxPrice1.BorderSize = 2;
            this.rjTextBoxPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjTextBoxPrice1.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxPrice1.Location = new System.Drawing.Point(102, 724);
            this.rjTextBoxPrice1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxPrice1.MaxLength = 32767;
            this.rjTextBoxPrice1.MinLength = 0;
            this.rjTextBoxPrice1.Multiline = false;
            this.rjTextBoxPrice1.Name = "rjTextBoxPrice1";
            this.rjTextBoxPrice1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxPrice1.PasswordChar = false;
            this.rjTextBoxPrice1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxPrice1.PlaceholderText = "";
            this.rjTextBoxPrice1.ReadOnly = false;
            this.rjTextBoxPrice1.Size = new System.Drawing.Size(78, 35);
            this.rjTextBoxPrice1.TabIndex = 59;
            this.rjTextBoxPrice1.Texts = "";
            this.rjTextBoxPrice1.UnderlinedStyle = true;
            this.rjTextBoxPrice1._TextChanged += new System.EventHandler(this.rjTextBoxPrice1__TextChanged);
            this.rjTextBoxPrice1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxDigits_KeyPress);
            this.rjTextBoxPrice1.Leave += new System.EventHandler(this.rjTextBoxPrice1_Leave);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(20, 732);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(62, 24);
            this.labelPrice.TabIndex = 60;
            this.labelPrice.Text = "Цена:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(182, 721);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 38);
            this.label6.TabIndex = 61;
            this.label6.Text = " - ";
            // 
            // rjTextBoxPrice2
            // 
            this.rjTextBoxPrice2.BackColor = System.Drawing.Color.Lavender;
            this.rjTextBoxPrice2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxPrice2.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.rjTextBoxPrice2.BorderRadius = 0;
            this.rjTextBoxPrice2.BorderSize = 2;
            this.rjTextBoxPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjTextBoxPrice2.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxPrice2.Location = new System.Drawing.Point(222, 721);
            this.rjTextBoxPrice2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjTextBoxPrice2.MaxLength = 32767;
            this.rjTextBoxPrice2.MinLength = 0;
            this.rjTextBoxPrice2.Multiline = false;
            this.rjTextBoxPrice2.Name = "rjTextBoxPrice2";
            this.rjTextBoxPrice2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxPrice2.PasswordChar = false;
            this.rjTextBoxPrice2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxPrice2.PlaceholderText = "";
            this.rjTextBoxPrice2.ReadOnly = false;
            this.rjTextBoxPrice2.Size = new System.Drawing.Size(85, 35);
            this.rjTextBoxPrice2.TabIndex = 62;
            this.rjTextBoxPrice2.Texts = "";
            this.rjTextBoxPrice2.UnderlinedStyle = true;
            this.rjTextBoxPrice2._TextChanged += new System.EventHandler(this.rjTextBoxPrice2__TextChanged);
            this.rjTextBoxPrice2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBoxDigits_KeyPress);
            this.rjTextBoxPrice2.Leave += new System.EventHandler(this.rjTextBoxPrice2_Leave);
            // 
            // rjButtonClear
            // 
            this.rjButtonClear.BackColor = System.Drawing.Color.Transparent;
            this.rjButtonClear.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButtonClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonClear.BorderRadius = 0;
            this.rjButtonClear.BorderSize = 0;
            this.rjButtonClear.FlatAppearance.BorderSize = 0;
            this.rjButtonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.rjButtonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.rjButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonClear.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonClear.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("rjButtonClear.Image")));
            this.rjButtonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButtonClear.Location = new System.Drawing.Point(24, 799);
            this.rjButtonClear.Name = "rjButtonClear";
            this.rjButtonClear.Size = new System.Drawing.Size(77, 65);
            this.rjButtonClear.TabIndex = 63;
            this.rjButtonClear.TextColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButtonClear.UseVisualStyleBackColor = false;
            this.rjButtonClear.Click += new System.EventHandler(this.rjButtonClear_Click);
            // 
            // rjButtonClose
            // 
            this.rjButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.rjButtonClose.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButtonClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonClose.BorderRadius = 0;
            this.rjButtonClose.BorderSize = 0;
            this.rjButtonClose.FlatAppearance.BorderSize = 0;
            this.rjButtonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.rjButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.rjButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonClose.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonClose.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("rjButtonClose.Image")));
            this.rjButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButtonClose.Location = new System.Drawing.Point(231, 802);
            this.rjButtonClose.Name = "rjButtonClose";
            this.rjButtonClose.Size = new System.Drawing.Size(61, 59);
            this.rjButtonClose.TabIndex = 12;
            this.rjButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButtonClose.TextColor = System.Drawing.Color.DarkSlateBlue;
            this.rjButtonClose.UseVisualStyleBackColor = false;
            this.rjButtonClose.Click += new System.EventHandler(this.rjButtonClose_Click);
            // 
            // panelFiltration
            // 
            this.panelFiltration.BackColor = System.Drawing.Color.Lavender;
            this.panelFiltration.Controls.Add(this.rjButtonClose);
            this.panelFiltration.Controls.Add(this.rjButtonClear);
            this.panelFiltration.Controls.Add(this.rjTextBoxPrice2);
            this.panelFiltration.Controls.Add(this.label6);
            this.panelFiltration.Controls.Add(this.labelPrice);
            this.panelFiltration.Controls.Add(this.rjTextBoxPrice1);
            this.panelFiltration.Controls.Add(this.rjComboBoxColor);
            this.panelFiltration.Controls.Add(this.labelColor);
            this.panelFiltration.Controls.Add(this.rjComboBoxSize);
            this.panelFiltration.Controls.Add(this.labelSize);
            this.panelFiltration.Controls.Add(this.rjComboBoxGender);
            this.panelFiltration.Controls.Add(this.labelGender);
            this.panelFiltration.Controls.Add(this.rjComboBoxSport);
            this.panelFiltration.Controls.Add(this.labelSport);
            this.panelFiltration.Controls.Add(this.rjComboBoxProdCountry);
            this.panelFiltration.Controls.Add(this.labelProdCountry);
            this.panelFiltration.Controls.Add(this.rjComboBoxBrand);
            this.panelFiltration.Controls.Add(this.labelBrand);
            this.panelFiltration.Controls.Add(this.rjComboBoxSneakers);
            this.panelFiltration.Controls.Add(this.labelSneakers);
            this.panelFiltration.Controls.Add(this.label2);
            this.panelFiltration.Controls.Add(this.pictureBox3);
            this.panelFiltration.Location = new System.Drawing.Point(0, 49);
            this.panelFiltration.Name = "panelFiltration";
            this.panelFiltration.Size = new System.Drawing.Size(355, 980);
            this.panelFiltration.TabIndex = 13;
            this.panelFiltration.Visible = false;
            // 
            // pictureBoxWelcome
            // 
            this.pictureBoxWelcome.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWelcome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWelcome.Image")));
            this.pictureBoxWelcome.Location = new System.Drawing.Point(403, 199);
            this.pictureBoxWelcome.Name = "pictureBoxWelcome";
            this.pictureBoxWelcome.Size = new System.Drawing.Size(1322, 823);
            this.pictureBoxWelcome.TabIndex = 25;
            this.pictureBoxWelcome.TabStop = false;
            // 
            // rjButtonHelp
            // 
            this.rjButtonHelp.BackColor = System.Drawing.Color.Transparent;
            this.rjButtonHelp.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButtonHelp.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonHelp.BorderRadius = 0;
            this.rjButtonHelp.BorderSize = 0;
            this.rjButtonHelp.FlatAppearance.BorderSize = 0;
            this.rjButtonHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.rjButtonHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.rjButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonHelp.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonHelp.ForeColor = System.Drawing.Color.SlateBlue;
            this.rjButtonHelp.Image = ((System.Drawing.Image)(resources.GetObject("rjButtonHelp.Image")));
            this.rjButtonHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButtonHelp.Location = new System.Drawing.Point(1593, 948);
            this.rjButtonHelp.Name = "rjButtonHelp";
            this.rjButtonHelp.Size = new System.Drawing.Size(166, 62);
            this.rjButtonHelp.TabIndex = 26;
            this.rjButtonHelp.Text = "Помощь";
            this.rjButtonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButtonHelp.TextColor = System.Drawing.Color.SlateBlue;
            this.rjButtonHelp.UseVisualStyleBackColor = false;
            this.rjButtonHelp.Click += new System.EventHandler(this.rjButtonHelp_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1780, 1022);
            this.Controls.Add(this.rjButtonHelp);
            this.Controls.Add(this.pictureBoxWelcome);
            this.Controls.Add(this.rjButtonAdd);
            this.Controls.Add(this.rjButtonFiltration);
            this.Controls.Add(this.rjButtonResearch);
            this.Controls.Add(this.rjTextBoxResearch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelFiltration);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 49);
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelFiltration.ResumeLayout(false);
            this.panelFiltration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel2;
        private RJButton rjButtonChek;
        private RJButton rjButtonSneakers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJButton rjButtonFiltration;
        private RJButton rjButtonResearch;
        private RJTextBox rjTextBoxResearch;
        private RJButton rjButtonAdd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSneakers;
        private RJComboBox rjComboBoxSneakers;
        private System.Windows.Forms.Label labelBrand;
        private RJComboBox rjComboBoxBrand;
        private System.Windows.Forms.Label labelProdCountry;
        private RJComboBox rjComboBoxProdCountry;
        private System.Windows.Forms.Label labelSport;
        private RJComboBox rjComboBoxSport;
        private System.Windows.Forms.Label labelGender;
        private RJComboBox rjComboBoxGender;
        private System.Windows.Forms.Label labelSize;
        private RJComboBox rjComboBoxSize;
        private System.Windows.Forms.Label labelColor;
        private RJComboBox rjComboBoxColor;
        private RJTextBox rjTextBoxPrice1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label6;
        private RJTextBox rjTextBoxPrice2;
        private RJButton rjButtonClear;
        private RJButton rjButtonClose;
        private System.Windows.Forms.Panel panelFiltration;
        private System.Windows.Forms.PictureBox pictureBoxWelcome;
        private RJButton rjButtonHelp;
    }
}