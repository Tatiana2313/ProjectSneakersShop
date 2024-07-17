namespace DataBaseSneakers.Reports
{
    partial class ChekInfoReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChekInfoReportForm));
            this.viewSneakersChekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sneakersDataSet2 = new DataBaseSneakers.SneakersDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewSneakersChekTableAdapter = new DataBaseSneakers.SneakersDataSet2TableAdapters.ViewSneakersChekTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewSneakersChekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sneakersDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // viewSneakersChekBindingSource
            // 
            this.viewSneakersChekBindingSource.DataMember = "ViewSneakersChek";
            this.viewSneakersChekBindingSource.DataSource = this.sneakersDataSet2;
            // 
            // sneakersDataSet2
            // 
            this.sneakersDataSet2.DataSetName = "SneakersDataSet2";
            this.sneakersDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ChekInfoDataSet";
            reportDataSource1.Value = this.viewSneakersChekBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DataBaseSneakers.Reports.ChekInfoReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(851, 547);
            this.reportViewer1.TabIndex = 0;
            // 
            // viewSneakersChekTableAdapter
            // 
            this.viewSneakersChekTableAdapter.ClearBeforeFill = true;
            // 
            // ChekInfoReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 547);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChekInfoReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о покупках";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChekInfoReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewSneakersChekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sneakersDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private SneakersDataSet2 sneakersDataSet2;
        private System.Windows.Forms.BindingSource viewSneakersChekBindingSource;
        private SneakersDataSet2TableAdapters.ViewSneakersChekTableAdapter viewSneakersChekTableAdapter;
    }
}