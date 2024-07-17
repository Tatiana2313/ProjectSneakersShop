using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseSneakers.Reports
{
    public partial class BrandSaleDiagramReportForm : Form
    {
        public BrandSaleDiagramReportForm()
        {
            InitializeComponent();
        }

        private void BrandSaleDiagramReportForm_Load(object sender, EventArgs e)
        {
            var myDataTable = (DataTable)this.sneakersDataSet2.ViewSneakersChek;
            ReportDataSource rds = new ReportDataSource("DiagramDataSet", myDataTable as DataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            viewSneakersChekTableAdapter.Fill(sneakersDataSet2.ViewSneakersChek);

            this.reportViewer1.RefreshReport();
        }
    }
}
