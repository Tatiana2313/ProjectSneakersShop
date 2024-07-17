namespace DataBaseSneakers
{
    partial class TotalsSneakers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalsSneakers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.rjButtonMax = new DataBaseSneakers.RJButton();
            this.rjButtonMin = new DataBaseSneakers.RJButton();
            this.rjButtonAvg = new DataBaseSneakers.RJButton();
            this.rjButtonCount = new DataBaseSneakers.RJButton();
            this.dataGridViewTotals = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotals)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 41);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(1080, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(52, 41);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // rjButtonMax
            // 
            this.rjButtonMax.BackColor = System.Drawing.Color.RoyalBlue;
            this.rjButtonMax.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rjButtonMax.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonMax.BorderRadius = 26;
            this.rjButtonMax.BorderSize = 0;
            this.rjButtonMax.FlatAppearance.BorderSize = 0;
            this.rjButtonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonMax.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonMax.ForeColor = System.Drawing.Color.White;
            this.rjButtonMax.Location = new System.Drawing.Point(27, 77);
            this.rjButtonMax.Name = "rjButtonMax";
            this.rjButtonMax.Size = new System.Drawing.Size(287, 63);
            this.rjButtonMax.TabIndex = 35;
            this.rjButtonMax.Text = "Самые дорогие кроссовки";
            this.rjButtonMax.TextColor = System.Drawing.Color.White;
            this.rjButtonMax.UseVisualStyleBackColor = false;
            this.rjButtonMax.Click += new System.EventHandler(this.rjButtonMax_Click);
            // 
            // rjButtonMin
            // 
            this.rjButtonMin.BackColor = System.Drawing.Color.RoyalBlue;
            this.rjButtonMin.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rjButtonMin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonMin.BorderRadius = 26;
            this.rjButtonMin.BorderSize = 0;
            this.rjButtonMin.FlatAppearance.BorderSize = 0;
            this.rjButtonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonMin.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonMin.ForeColor = System.Drawing.Color.White;
            this.rjButtonMin.Location = new System.Drawing.Point(342, 77);
            this.rjButtonMin.Name = "rjButtonMin";
            this.rjButtonMin.Size = new System.Drawing.Size(285, 63);
            this.rjButtonMin.TabIndex = 36;
            this.rjButtonMin.Text = "Самые дешевые кроссовки";
            this.rjButtonMin.TextColor = System.Drawing.Color.White;
            this.rjButtonMin.UseVisualStyleBackColor = false;
            this.rjButtonMin.Click += new System.EventHandler(this.rjButtonMin_Click);
            // 
            // rjButtonAvg
            // 
            this.rjButtonAvg.BackColor = System.Drawing.Color.RoyalBlue;
            this.rjButtonAvg.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rjButtonAvg.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonAvg.BorderRadius = 26;
            this.rjButtonAvg.BorderSize = 0;
            this.rjButtonAvg.FlatAppearance.BorderSize = 0;
            this.rjButtonAvg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonAvg.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonAvg.ForeColor = System.Drawing.Color.White;
            this.rjButtonAvg.Location = new System.Drawing.Point(656, 81);
            this.rjButtonAvg.Name = "rjButtonAvg";
            this.rjButtonAvg.Size = new System.Drawing.Size(203, 55);
            this.rjButtonAvg.TabIndex = 37;
            this.rjButtonAvg.Text = "Средняя цена";
            this.rjButtonAvg.TextColor = System.Drawing.Color.White;
            this.rjButtonAvg.UseVisualStyleBackColor = false;
            this.rjButtonAvg.Click += new System.EventHandler(this.rjButtonAvg_Click);
            // 
            // rjButtonCount
            // 
            this.rjButtonCount.BackColor = System.Drawing.Color.RoyalBlue;
            this.rjButtonCount.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rjButtonCount.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonCount.BorderRadius = 26;
            this.rjButtonCount.BorderSize = 0;
            this.rjButtonCount.FlatAppearance.BorderSize = 0;
            this.rjButtonCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonCount.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonCount.ForeColor = System.Drawing.Color.White;
            this.rjButtonCount.Location = new System.Drawing.Point(893, 81);
            this.rjButtonCount.Name = "rjButtonCount";
            this.rjButtonCount.Size = new System.Drawing.Size(187, 55);
            this.rjButtonCount.TabIndex = 38;
            this.rjButtonCount.Text = "Количество";
            this.rjButtonCount.TextColor = System.Drawing.Color.White;
            this.rjButtonCount.UseVisualStyleBackColor = false;
            this.rjButtonCount.Click += new System.EventHandler(this.rjButtonCount_Click);
            // 
            // dataGridViewTotals
            // 
            this.dataGridViewTotals.AllowUserToAddRows = false;
            this.dataGridViewTotals.AllowUserToDeleteRows = false;
            this.dataGridViewTotals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTotals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTotals.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewTotals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTotals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTotals.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTotals.Location = new System.Drawing.Point(79, 260);
            this.dataGridViewTotals.Name = "dataGridViewTotals";
            this.dataGridViewTotals.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTotals.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTotals.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTotals.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTotals.RowTemplate.Height = 24;
            this.dataGridViewTotals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTotals.Size = new System.Drawing.Size(915, 370);
            this.dataGridViewTotals.TabIndex = 39;
            this.dataGridViewTotals.Visible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(346, 205);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(87, 40);
            this.labelTitle.TabIndex = 40;
            this.labelTitle.Text = "label1";
            this.labelTitle.Visible = false;
            // 
            // TotalsSneakers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1132, 669);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dataGridViewTotals);
            this.Controls.Add(this.rjButtonCount);
            this.Controls.Add(this.rjButtonAvg);
            this.Controls.Add(this.rjButtonMin);
            this.Controls.Add(this.rjButtonMax);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TotalsSneakers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TotalsSneakers";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private RJButton rjButtonMax;
        private RJButton rjButtonMin;
        private RJButton rjButtonAvg;
        private RJButton rjButtonCount;
        private System.Windows.Forms.DataGridView dataGridViewTotals;
        private System.Windows.Forms.Label labelTitle;
    }
}