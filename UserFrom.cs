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
    public partial class UserFrom : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private Database database = new Database();
        string mode = "";

        public UserFrom()
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void NumberingRow()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void rjButtonSneakers_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ViewSneakersInfo";
            ShowSneakers(sql);

            pictureBox2.Visible = true;
            labelHeader.Visible = true;
            pictureBox2.Image = Image.FromFile(@"..\..\image\sneakrs-1.png");
            labelHeader.Text = "Спортивные кроссовки";
            rjTextBoxResearch.Visible = true;
            rjButtonResearch.Visible = true;
            rjButtonFiltration.Visible = true;
            pictureBoxWelcome.Visible = false;
        }

        private void ShowSneakers(string sql)
        {
            try
            {
                mode = "sneakers";
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "SneakersData");
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "SneakersData";
                    dataGridView1.Columns[0].Visible = false;
                    NumberingRow();
                    ShowHeadersSneakers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowHeadersSneakers()
        {
            dataGridView1.Columns[1].HeaderText = "Название кроссовок";
            dataGridView1.Columns[2].HeaderText = "Артикул";
            dataGridView1.Columns[3].HeaderText = "Бренд";
            dataGridView1.Columns[4].HeaderText = "Страна производитель";
            dataGridView1.Columns[5].HeaderText = "Название спорта";
            dataGridView1.Columns[6].HeaderText = "Материал";
            dataGridView1.Columns[7].HeaderText = "Пол";
            dataGridView1.Columns[8].HeaderText = "Размер";
            dataGridView1.Columns[9].HeaderText = "Цвет";
            dataGridView1.Columns[10].HeaderText = "Цена за единицу";
        }

        private void rjButtonResearch_Click(object sender, EventArgs e)
        {
            string sql;
            if (mode == "sneakers")
            {
                sql = $"SELECT * FROM ViewSneakersInfo WHERE CONCAT(cod_sneakers, Sneakers_name, Vendor_code, brand, Producing_country, name_sport, material, gender, size, color, unit_price) LIKE '%{rjTextBoxResearch.Texts}%'";
                ShowSneakers(sql);
            }
        }

        private void rjTextBoxResearch__TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (rjTextBoxResearch.Texts.Length != 0)
            {
                rjButtonResearch.Enabled = true;
            }
            else
            {
                if (mode == "sneakers")
                {
                    sql = "SELECT * FROM ViewSneakersInfo";
                    ShowSneakers(sql);
                }
            }
        }

        private void rjButtonFiltration_Click(object sender, EventArgs e)
        {
            panelFiltration.Visible = true;
            DatabaseMethods.fillComboBoxSneakers(rjComboBoxSneakers);
            DatabaseMethods.fillComboBoxSport(rjComboBoxSport);
            ClearAll();

        }

        private void rjButtonClose_Click(object sender, EventArgs e)
        {
            panelFiltration.Visible = false;
            string sql = "SELECT * FROM ViewSneakersInfo";
            ShowSneakers(sql);
        }

        public void ClearAll()
        {
            rjComboBoxSneakers.SelectedIndex = -1;
            rjComboBoxBrand.SelectedIndex = -1;
            rjComboBoxProdCountry.SelectedIndex = -1;
            rjComboBoxSport.SelectedIndex = -1;
            rjComboBoxGender.SelectedIndex = -1;
            rjComboBoxSize.SelectedIndex = -1;
            rjComboBoxColor.SelectedIndex = -1;
            rjTextBoxPrice1.Clear();
            rjTextBoxPrice2.Clear();
            string sql = "SELECT * FROM ViewSneakersInfo";
            ShowSneakers(sql);
        }

        private void rjButtonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void rjComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string sneakersFilter = "", brandFilter = "", CountryFilter = "", SportFilter = "", GenderFilter = "", SizeFilter = "", ColorFilter = "", PriceFilter = "";

            if (rjComboBoxSneakers.SelectedIndex != -1)
            {
                sneakersFilter = $"Sneakers_name = '{rjComboBoxSneakers.GetItemText(rjComboBoxSneakers.SelectedItem)}'";
            }

            if (rjComboBoxBrand.SelectedIndex != -1)
            {
                brandFilter = $"brand = '{rjComboBoxBrand.GetItemText(rjComboBoxBrand.SelectedItem)}'";
            }

            if (rjComboBoxProdCountry.SelectedIndex != -1)
            {
                CountryFilter = $"Producing_country = '{rjComboBoxProdCountry.GetItemText(rjComboBoxProdCountry.SelectedItem)}'";
            }

            if (rjComboBoxSport.SelectedIndex != -1)
            {
                SportFilter = $"name_sport = '{rjComboBoxSport.GetItemText(rjComboBoxSport.SelectedItem)}'";
            }

            if (rjComboBoxGender.SelectedIndex != -1)
            {
                GenderFilter = $"gender = '{rjComboBoxGender.GetItemText(rjComboBoxGender.SelectedItem)}'";
            }

            if (rjComboBoxSize.SelectedIndex != -1)
            {
                SizeFilter = $"size = '{rjComboBoxSize.GetItemText(rjComboBoxSize.SelectedItem)}'";
            }

            if (rjComboBoxColor.SelectedIndex != -1)
            {
                ColorFilter = $"color = '{rjComboBoxColor.GetItemText(rjComboBoxColor.SelectedItem)}'";
            }

            if (!string.IsNullOrEmpty(rjTextBoxPrice1.Texts) || !string.IsNullOrEmpty(rjTextBoxPrice2.Texts))
            {
                double price1 = 0, price2 = 0;
                string unitPrice1 = rjTextBoxPrice1.Texts.Replace(",", ".");
                string unitPrice2 = rjTextBoxPrice2.Texts.Replace(",", ".");
                bool validPrice1 = double.TryParse(unitPrice1, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out price1);
                bool validPrice2 = double.TryParse(unitPrice2, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out price2);

                if (validPrice1 && validPrice2)
                {
                    PriceFilter = $"unit_price BETWEEN '{unitPrice1}' AND '{unitPrice2}'";
                }
                else if (validPrice1)
                {
                    PriceFilter = $"unit_price >= '{unitPrice1}'";
                }
                else if (validPrice2)
                {
                    PriceFilter = $"unit_price <= '{unitPrice2}'";
                }
            }

            string sql = "SELECT * FROM ViewSneakersInfo WHERE ";
            List<string> filters = new List<string> { sneakersFilter, brandFilter, CountryFilter, SportFilter, GenderFilter, SizeFilter, ColorFilter, PriceFilter };
            filters.RemoveAll(string.IsNullOrEmpty);
            if (filters.Count > 0)
            {
                sql += string.Join(" AND ", filters);
            }
            else
            {
                sql += "1=1";
            }

            ShowSneakers(sql);
        }

        
        private void rjTextBoxPrice1__TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void rjTextBoxPrice2__TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void rjTextBoxPrice1_Leave(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void rjTextBoxPrice2_Leave(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void rjTextBoxDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            RJTextBox rjTextBox = (RJTextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == ',' && rjTextBox.Texts.IndexOf(',') > -1)
                e.Handled = true;
        }

        private void rjButtonHelp_Click(object sender, EventArgs e)
        {
            string info = "Раздел \"Кроссовки\" - предназначен для отображения полной информации о кроссовках\n\n";
            HelpForm f = new HelpForm(info);
            f.Height = 522;
            f.Width = 1007;
            f.ShowDialog();
        }
    }
}
