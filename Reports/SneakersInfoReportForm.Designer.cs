namespace DataBaseSneakers.Reports
{
    partial class SneakersInfoReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SneakersInfoReportForm));
            this.viewSneakersInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sneakersDataSet = new DataBaseSneakers.SneakersDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewSneakersInfoTableAdapter = new DataBaseSneakers.SneakersDataSetTableAdapters.ViewSneakersInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewSneakersInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sneakersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // viewSneakersInfoBindingSource
            // 
            this.viewSneakersInfoBindingSource.DataMember = "ViewSneakersInfo";
            this.viewSneakersInfoBindingSource.DataSource = this.sneakersDataSet;
            // 
            // sneakersDataSet
            // 
            this.sneakersDataSet.DataSetName = "SneakersDataSet";
            this.sneakersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "SneakersInfoDataSet";
            reportDataSource2.Value = this.viewSneakersInfoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DataBaseSneakers.Reports.SneakersInfoReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // viewSneakersInfoTableAdapter
            // 
            this.viewSneakersInfoTableAdapter.ClearBeforeFill = true;
            // 
            // SneakersInfoReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SneakersInfoReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о кроссовках";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SneakersInfoReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewSneakersInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sneakersDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private SneakersDataSet sneakersDataSet;
        private System.Windows.Forms.BindingSource viewSneakersInfoBindingSource;
        private SneakersDataSetTableAdapters.ViewSneakersInfoTableAdapter viewSneakersInfoTableAdapter;
    }
}