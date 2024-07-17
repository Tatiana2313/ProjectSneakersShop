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
    public partial class TotalsSneakers : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private Database database = new Database();

        public TotalsSneakers()
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

        private void rjButtonMax_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Самые дорогие кроссовки";
            labelTitle.Visible = true;

            try
            {
                string sql = "SELECT Sneakers_name, brand, unit_price " +
                             "FROM ViewSneakersInfo " +
                             "WHERE unit_price = (SELECT MAX(unit_price) FROM ViewSneakersInfo)";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        dataGridViewTotals.Rows.Clear();
                        dataGridViewTotals.Columns.Clear();

                        string SneakerName = reader["Sneakers_name"].ToString();
                        string Brand = reader["brand"].ToString();
                        decimal unitPrice = Convert.ToDecimal(reader["unit_price"]);

                        TotalsMaxMin();
                        dataGridViewTotals.Rows.Add(SneakerName, SneakerName, unitPrice);
                        dataGridViewTotals.Visible = true;
                    }
                    reader.Close();
                    connection.Close();
                    NumberingRow();
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

        private void TotalsMaxMin()
        {
            dataGridViewTotals.Columns.Add("SneakerName", "Название");
            dataGridViewTotals.Columns.Add("Brand", "Бренд");
            dataGridViewTotals.Columns.Add("UnitPrice", "Цена за единицу(лей)");
        }

        private void rjButtonMin_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Самые дешевые кроссовки";
            labelTitle.Visible = true;

            try
            {
                string sql = "SELECT Sneakers_name, brand, unit_price " +
                             "FROM ViewSneakersInfo " +
                             "WHERE unit_price = (SELECT MIN(unit_price) FROM ViewSneakersInfo)";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        dataGridViewTotals.Columns.Clear();
                        dataGridViewTotals.Rows.Clear();

                        string SneakerName = reader["Sneakers_name"].ToString();
                        string Brand = reader["brand"].ToString();
                        decimal unitPrice = Convert.ToDecimal(reader["unit_price"]);

                        TotalsMaxMin();
                        dataGridViewTotals.Rows.Add(SneakerName, SneakerName, unitPrice);
                        dataGridViewTotals.Visible = true;
                    }
                    reader.Close();
                    connection.Close();
                    NumberingRow();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rjButtonAvg_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Средняя цена кроссовок";
            labelTitle.Visible = true;
            try
            {
                string sql = "SELECT AVG(unit_price) AS AvgPrice FROM ViewSneakersInfo";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        decimal averagePrice = Convert.ToDecimal(result);
                        string formattedAveragePrice = averagePrice.ToString("N3");
                        dataGridViewTotals.Columns.Clear();
                        dataGridViewTotals.Rows.Clear();

                        dataGridViewTotals.Columns.Add("AvgPrice", "Средняя цена (лей)");
                        dataGridViewTotals.Rows.Add(formattedAveragePrice);
                        NumberingRow();
                        dataGridViewTotals.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Средняя цена не найдена.");
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rjButtonCount_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Кол-во кроссовок каждого вида спорта";
            labelTitle.Visible = true;

            try
            {
                string sql = "SELECT name_sport, COUNT(*) AS CountOfSneakers " +
                             "FROM ViewSneakersInfo " +
                             "GROUP BY name_sport";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    dataGridViewTotals.Columns.Clear();
                    dataGridViewTotals.Rows.Clear();
                    dataGridViewTotals.Columns.Add("NameSport", "Название спорта");
                    dataGridViewTotals.Columns.Add("Count", "Количество");

                    while (reader.Read())
                    {
                        string NameSport = reader["name_sport"].ToString();
                        int Count = Convert.ToInt32(reader["CountOfSneakers"]);
                        dataGridViewTotals.Rows.Add(NameSport, Count);
                        dataGridViewTotals.Visible = true;
                    }
                    reader.Close();
                    connection.Close();
                    NumberingRow();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
