using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseSneakers
{
    public partial class TotalsChek : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private Database database = new Database();

        public TotalsChek()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // check if the click was on the title bar
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButtonSale_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Самая(ые) продаваемая(ые) модель(и) кроссовок";
            labelTitle.Visible = true;

            try
            {
                string sql = @"SELECT Sneakers_name, SUM(number_of_sneakers) AS TotalSales
                       FROM ViewSneakersChek
                       GROUP BY Sneakers_name
                       HAVING SUM(number_of_sneakers) = (SELECT MAX(SneakersSales)
                                                       FROM (SELECT SUM(number_of_sneakers) AS SneakersSales
                                                             FROM ViewSneakersChek
                                                             GROUP BY Sneakers_name ) AS Sales )";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    dataGridViewTotals.Columns.Clear();
                    dataGridViewTotals.Rows.Clear();
                    dataGridViewTotals.Columns.Add("SneakersName", "Название кроссовок");
                    dataGridViewTotals.Columns.Add("TotalSales", "Общее количество продаж");

                    while (reader.Read())
                    {
                        string albumName = reader["Sneakers_name"].ToString();
                        int totalSales = Convert.ToInt32(reader["TotalSales"]);

                        dataGridViewTotals.Rows.Add(albumName, totalSales);
                    }
                    NumberingRow();
                    dataGridViewTotals.Visible = true;
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NumberingRow()
        {
            for (int i = 0; i < dataGridViewTotals.Rows.Count; i++)
            {
                dataGridViewTotals.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewTotals.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void rjButtonProfitBrand_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Прибыль, полученная магазином за каждый бренд";
            labelTitle.Visible = true;

            try
            {
                string sql = @"SELECT brand, SUM(total_Price) AS TotalProfit
                               FROM ViewSneakersChek
                               GROUP BY brand";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    dataGridViewTotals.Columns.Clear();
                    dataGridViewTotals.Rows.Clear();
                    dataGridViewTotals.Columns.Add("Brand", "Бренд");
                    dataGridViewTotals.Columns.Add("TotalProfit", "Прибыль (общая сумма в леях)");

                    while (reader.Read())
                    {
                        string Brand = reader["Brand"].ToString();
                        decimal TotalProfit = Convert.ToDecimal(reader["TotalProfit"]);

                        dataGridViewTotals.Rows.Add(Brand, TotalProfit);
                    }
                    NumberingRow();
                    dataGridViewTotals.Visible = true;
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rjButtonSum_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Общая прибыль магазина";
            labelTitle.Visible = true;

            try
            {
                string sql = @"SELECT SUM(total_Price) AS TotalProfit FROM ViewSneakersChek";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    dataGridViewTotals.Columns.Clear();
                    dataGridViewTotals.Rows.Clear();
                    dataGridViewTotals.Columns.Add("TotalProfit", "Общая прибыль (лей)");

                    while (reader.Read())
                    {
                        decimal TotalProfit = Convert.ToDecimal(reader["TotalProfit"]);

                        dataGridViewTotals.Rows.Add(TotalProfit);
                    }
                    NumberingRow();
                    dataGridViewTotals.Visible = true;
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
