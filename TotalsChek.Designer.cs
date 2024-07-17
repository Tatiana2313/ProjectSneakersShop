namespace DataBaseSneakers
{
    partial class TotalsChek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalsChek));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridViewTotals = new System.Windows.Forms.DataGridView();
            this.rjButtonSum = new DataBaseSneakers.RJButton();
            this.rjButtonProfitBrand = new DataBaseSneakers.RJButton();
            this.rjButtonSale = new DataBaseSneakers.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotals)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 41);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(950, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(52, 41);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(309, 213);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(76, 35);
            this.labelTitle.TabIndex = 46;
            this.labelTitle.Text = "label1";
            this.labelTitle.Visible = false;
            // 
            // dataGridViewTotals
            // 
            this.dataGridViewTotals.AllowUserToAddRows = false;
            this.dataGridViewTotals.AllowUserToDeleteRows = false;
            this.dataGridViewTotals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTotals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTotals.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewTotals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTotals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTotals.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTotals.Location = new System.Drawing.Point(88, 268);
            this.dataGridViewTotals.Name = "dataGridViewTotals";
            this.dataGridViewTotals.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTotals.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTotals.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTotals.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTotals.RowTemplate.Height = 24;
            this.dataGridViewTotals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTotals.Size = new System.Drawing.Size(834, 293);
            this.dataGridViewTotals.TabIndex = 45;
            this.dataGridViewTotals.Visible = false;
            // 
            // rjButtonSum
            // 
            this.rjButtonSum.BackColor = System.Drawing.Color.DarkCyan;
            this.rjButtonSum.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.rjButtonSum.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonSum.BorderRadius = 26;
            this.rjButtonSum.BorderSize = 0;
            this.rjButtonSum.FlatAppearance.BorderSize = 0;
            this.rjButtonSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonSum.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonSum.ForeColor = System.Drawing.Color.White;
            this.rjButtonSum.Location = new System.Drawing.Point(707, 102);
            this.rjButtonSum.Name = "rjButtonSum";
            this.rjButtonSum.Size = new System.Drawing.Size(203, 55);
            this.rjButtonSum.TabIndex = 43;
            this.rjButtonSum.Text = "Общая прибыль";
            this.rjButtonSum.TextColor = System.Drawing.Color.White;
            this.rjButtonSum.UseVisualStyleBackColor = false;
            this.rjButtonSum.Click += new System.EventHandler(this.rjButtonSum_Click);
            // 
            // rjButtonProfitBrand
            // 
            this.rjButtonProfitBrand.BackColor = System.Drawing.Color.DarkCyan;
            this.rjButtonProfitBrand.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.rjButtonProfitBrand.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonProfitBrand.BorderRadius = 26;
            this.rjButtonProfitBrand.BorderSize = 0;
            this.rjButtonProfitBrand.FlatAppearance.BorderSize = 0;
            this.rjButtonProfitBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonProfitBrand.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonProfitBrand.ForeColor = System.Drawing.Color.White;
            this.rjButtonProfitBrand.Location = new System.Drawing.Point(385, 102);
            this.rjButtonProfitBrand.Name = "rjButtonProfitBrand";
            this.rjButtonProfitBrand.Size = new System.Drawing.Size(285, 55);
            this.rjButtonProfitBrand.TabIndex = 42;
            this.rjButtonProfitBrand.Text = "Прибыль за каждый бренд";
            this.rjButtonProfitBrand.TextColor = System.Drawing.Color.White;
            this.rjButtonProfitBrand.UseVisualStyleBackColor = false;
            this.rjButtonProfitBrand.Click += new System.EventHandler(this.rjButtonProfitBrand_Click);
            // 
            // rjButtonSale
            // 
            this.rjButtonSale.BackColor = System.Drawing.Color.DarkCyan;
            this.rjButtonSale.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.rjButtonSale.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonSale.BorderRadius = 26;
            this.rjButtonSale.BorderSize = 0;
            this.rjButtonSale.FlatAppearance.BorderSize = 0;
            this.rjButtonSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonSale.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonSale.ForeColor = System.Drawing.Color.White;
            this.rjButtonSale.Location = new System.Drawing.Point(34, 102);
            this.rjButtonSale.Name = "rjButtonSale";
            this.rjButtonSale.Size = new System.Drawing.Size(309, 55);
            this.rjButtonSale.TabIndex = 41;
            this.rjButtonSale.Text = "Самая продоваемая модель";
            this.rjButtonSale.TextColor = System.Drawing.Color.White;
            this.rjButtonSale.UseVisualStyleBackColor = false;
            this.rjButtonSale.Click += new System.EventHandler(this.rjButtonSale_Click);
            // 
            // TotalsChek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1002, 655);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dataGridViewTotals);
            this.Controls.Add(this.rjButtonSum);
            this.Controls.Add(this.rjButtonProfitBrand);
            this.Controls.Add(this.rjButtonSale);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TotalsChek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TotalsChek";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewTotals;
        private RJButton rjButtonSum;
        private RJButton rjButtonProfitBrand;
        private RJButton rjButtonSale;
    }
}