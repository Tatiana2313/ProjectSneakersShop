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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBaseSneakers
{
    public partial class AddSneakers : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private Database database = new Database();

        public string data;

        public AddSneakers()
        {
            InitializeComponent();
            DatabaseMethods.fillComboBoxSport(rjComboBoxSport);

            this.Width = 697;
            this.Height = 465;
            rjButtonClear.Location = new Point(467, 397);
            rjButtonClear.Parent.Invalidate();
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

        private void rjTextBoxLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void rjTextBoxDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void rjTextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            RJTextBox rjTextBox = (RJTextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == '.' && rjTextBox.Texts.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void rjTextBox__TextChanged(object sender, EventArgs e)
        {
            EnableAddButton();
            PanelAdd();
            PanelAdd2();
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            EnableAddButton();
        }

        private void EnableAddButton()
        {
            if (!string.IsNullOrWhiteSpace(rjTextBoxSneakersName.Texts) && !string.IsNullOrWhiteSpace(rjTextBoxVentor.Texts) && !string.IsNullOrWhiteSpace(rjTextBoxBrand.Texts) && 
                !string.IsNullOrWhiteSpace(rjTextBoxProdCountry.Texts) && rjComboBoxSport.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(rjTextBoxMaterial.Texts) && rjComboBoxGender.SelectedIndex != -1 &&
                rjComboBoxSize.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(rjTextBoxColor.Texts) && !string.IsNullOrWhiteSpace(rjTextBoPrice.Texts))
            {
                rjButtonAdd.Enabled = true;
            }
            else
            {
                rjButtonAdd.Enabled = false;
            }
        }

        private void rjButtonAdd_Click(object sender, EventArgs e)
        {
            string Sneakers_name = rjTextBoxSneakersName.Texts;
            string Vendor_code = rjTextBoxVentor.Texts;
            string brand = rjTextBoxBrand.Texts;
            string Producing_country = rjTextBoxProdCountry.Texts;
            int cod_kind_of_sport = Convert.ToInt32(rjComboBoxSport.SelectedValue);
            string material = rjTextBoxMaterial.Texts;
            string gender = Convert.ToString(rjComboBoxGender.SelectedItem.ToString());
            int size = Convert.ToInt32(rjComboBoxSize.SelectedItem);
            string color = rjTextBoxColor.Texts;
            double price = Convert.ToDouble(rjTextBoPrice.Texts);

            // Заменяем запятую на точку
            string unitPriceText = rjTextBoPrice.Texts.Replace(",", ".");
            unitPriceText = unitPriceText.Trim();
            double unit_price = double.Parse(unitPriceText, System.Globalization.CultureInfo.InvariantCulture);

            try
            {
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("AddSneakers", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Sneakers_name", Sneakers_name);
                        command.Parameters.AddWithValue("@Vendor_code", Vendor_code);
                        command.Parameters.AddWithValue("@brand", brand);
                        command.Parameters.AddWithValue("@Producing_country", Producing_country);
                        command.Parameters.AddWithValue("@cod_kind_of_sport", cod_kind_of_sport);
                        command.Parameters.AddWithValue("@material", material);
                        command.Parameters.AddWithValue("@gender", gender);
                        command.Parameters.AddWithValue("@size", size);
                        command.Parameters.AddWithValue("@color", color);
                        command.Parameters.AddWithValue("@unit_price", unit_price);

                        string id = command.ExecuteScalar().ToString();

                        MessageBox.Show("Успешное добавление", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        data = id + ";" + Sneakers_name + ";" + Vendor_code + ";" + brand + ";" + Producing_country + ";" + rjComboBoxSport.Texts + ";" + material + ";" + gender + ";" + size + ";" + color + ";" + price;
                    }
                }
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public string GetData()
        {
            return data;
        }

        private void rjButtonClear_Click(object sender, EventArgs e)
        {
            rjTextBoxSneakersName.Clear();
            rjTextBoxVentor.Clear();
            rjTextBoxBrand.Clear();
            rjTextBoxProdCountry.Clear();
            rjTextBoxMaterial.Clear();
            rjTextBoxColor.Clear();
            rjTextBoPrice.Clear();
            rjComboBoxSport.SelectedItem = null;
            rjComboBoxGender.SelectedIndex = -1;
            rjComboBoxSize.SelectedIndex = -1;

            this.Width = 697;
            this.Height = 465;
            rjButtonClear.Location = new Point(467, 397);
            rjButtonClear.Parent.Invalidate();
        }

        private void PanelAdd()
        {
            if (!string.IsNullOrWhiteSpace(rjTextBoxSneakersName.Texts) && !string.IsNullOrWhiteSpace(rjTextBoxVentor.Texts) && !string.IsNullOrWhiteSpace(rjTextBoxBrand.Texts))
            {
                panelAdd1.Visible = true;
                this.Width = 697;
                this.Height = 665;
                rjButtonClear.Location = new Point(480, 599);
                rjButtonClear.Parent.Invalidate();
            }
            else panelAdd1.Visible = false;
        }

        private void PanelAdd2()
        {
            if (!string.IsNullOrWhiteSpace(rjTextBoxProdCountry.Texts) && rjComboBoxSport.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(rjTextBoxMaterial.Texts))
            {
                panelAdd2.Visible = true;
                this.Width = 697;
                this.Height = 985;  //484; 582
                rjButtonClear.Location = new Point(44, 897);
                rjButtonClear.Parent.Invalidate();
            }
            else panelAdd2.Visible = false;
        }

        private void rjTextBoxBrand_Leave(object sender, EventArgs e)
        {
            PanelAdd();
        }

        private void rjTextBoxMaterial_Leave(object sender, EventArgs e)
        {
            PanelAdd2();
        }
    }
}
