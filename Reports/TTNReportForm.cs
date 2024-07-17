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
    public partial class TTNReportForm : Form
    {
        public TTNReportForm()
        {
            InitializeComponent();
        }

        private void TTNReportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sneakersDataSet1.ViewSneakersTTN". При необходимости она может быть перемещена или удалена.
            this.viewSneakersTTNTableAdapter.Fill(this.sneakersDataSet1.ViewSneakersTTN);

            this.reportViewer1.RefreshReport();
        }
    }
}
