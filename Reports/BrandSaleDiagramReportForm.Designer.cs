namespace DataBaseSneakers.Reports
{
    partial class BrandSaleDiagramReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandSaleDiagramReportForm));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sneakersDataSet2 = new DataBaseSneakers.SneakersDataSet2();
            this.viewSneakersChekTableAdapter = new DataBaseSneakers.SneakersDataSet2TableAdapters.ViewSneakersChekTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sneakersDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DataBaseSneakers.Reports.BrandSaleDiagramReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(984, 600);
            this.reportViewer1.TabIndex = 0;
            // 
            // sneakersDataSet2
            // 
            this.sneakersDataSet2.DataSetName = "SneakersDataSet2";
            this.sneakersDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewSneakersChekTableAdapter
            // 
            this.viewSneakersChekTableAdapter.ClearBeforeFill = true;
            // 
            // BrandSaleDiagramReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 600);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrandSaleDiagramReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrandSaleDiagramReportForm";
            this.Load += new System.EventHandler(this.BrandSaleDiagramReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sneakersDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private SneakersDataSet2 sneakersDataSet2;
        private SneakersDataSet2TableAdapters.ViewSneakersChekTableAdapter viewSneakersChekTableAdapter;
    }
}