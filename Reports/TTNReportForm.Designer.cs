namespace DataBaseSneakers.Reports
{
    partial class TTNReportForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TTNReportForm));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sneakersDataSet1 = new DataBaseSneakers.SneakersDataSet1();
            this.viewSneakersTTNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewSneakersTTNTableAdapter = new DataBaseSneakers.SneakersDataSet1TableAdapters.ViewSneakersTTNTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sneakersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSneakersTTNBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TTNInfoDataSet";
            reportDataSource1.Value = this.viewSneakersTTNBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DataBaseSneakers.Reports.TTNReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // sneakersDataSet1
            // 
            this.sneakersDataSet1.DataSetName = "SneakersDataSet1";
            this.sneakersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewSneakersTTNBindingSource
            // 
            this.viewSneakersTTNBindingSource.DataMember = "ViewSneakersTTN";
            this.viewSneakersTTNBindingSource.DataSource = this.sneakersDataSet1;
            // 
            // viewSneakersTTNTableAdapter
            // 
            this.viewSneakersTTNTableAdapter.ClearBeforeFill = true;
            // 
            // TTNReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TTNReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товарно-транспортная накладная";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TTNReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sneakersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSneakersTTNBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private SneakersDataSet1 sneakersDataSet1;
        private System.Windows.Forms.BindingSource viewSneakersTTNBindingSource;
        private SneakersDataSet1TableAdapters.ViewSneakersTTNTableAdapter viewSneakersTTNTableAdapter;
    }
}