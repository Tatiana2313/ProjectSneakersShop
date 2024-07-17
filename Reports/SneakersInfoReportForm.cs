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
    public partial class SneakersInfoReportForm : Form
    {
        public SneakersInfoReportForm()
        {
            InitializeComponent();
        }

        private void SneakersInfoReportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sneakersDataSet.ViewSneakersInfo". При необходимости она может быть перемещена или удалена.
            this.viewSneakersInfoTableAdapter.Fill(this.sneakersDataSet.ViewSneakersInfo);

            this.reportViewer1.RefreshReport();
        }
    }
}
