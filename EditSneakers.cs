using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseSneakers
{
    public partial class EditSneakers : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private Database database = new Database();
        public string info = "";
        public int ID;

        public EditSneakers(string row)
        {
            InitializeComponent();

            string[] data = row.Split(';');
            ID = Convert.ToInt16(data[0]);
            rjTextBoxSneakersName.Texts = data[1];
            rjTextBoxVentor.Texts = data[2];
            rjTextBoxBrand.Texts = data[3];
            rjTextBoxProdCountry.Texts = data[4];
            DatabaseMethods.fillComboBoxSport(rjComboBoxSport);
            int indexSport = rjComboBoxSport.FindString(data[5]);
            rjComboBoxSport.SelectedIndex = indexSport;
            rjTextBoxMaterial.Texts = data[6];
            int indexGender = rjComboBoxGender.FindString(data[7]);
            rjComboBoxGender.SelectedIndex = indexGender;
            int indexSize = rjComboBoxSize.FindString(data[8]);
            rjComboBoxSize.SelectedIndex = indexSize;
            rjTextBoxColor.Texts = data[9];
            rjTextBoPrice.Texts = data[10];
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
        }

        private void EnableAddButton()
        {
            if (!string.IsNullOrWhiteSpace(rjTextBoxSneakersName.Texts) && !string.IsNullOrWhiteSpace(rjTextBoxVentor.Texts) && !string.IsNullOrWhiteSpace(rjTextBoxBrand.Texts) &&
                !string.IsNullOrWhiteSpace(rjTextBoxProdCountry.Texts) && rjComboBoxSport.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(rjTextBoxMaterial.Texts) && rjComboBoxGender.SelectedIndex != -1 &&
                rjComboBoxSize.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(rjTextBoxColor.Texts) && !string.IsNullOrWhiteSpace(rjTextBoPrice.Texts))
            {
                rjButtonEdit.Enabled = true;
            }
            else
            {
                rjButtonEdit.Enabled = false;
            }
        }

        private void rjButtonEdit_Click(object sender, EventArgs e)
        {
            string Sneakers_name = rjTextBoxSneakersName.Texts;
            string Vendor_code = rjTextBoxVentor.Texts;
            string brand = rjTextBoxBrand.Texts;
            string Producing_country = rjTextBoxProdCountry.Texts;
            int cod_kind_of_sport = Convert.ToInt32(rjComboBoxSport.SelectedValue);
            string material = rjTextBoxMaterial.Texts;
            string gender = Convert.ToString(rjComboBoxGender.SelectedItem.ToString());
            int size = Convert.ToInt32(rjComboBoxSize.SelectedItem.ToString());
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
                    using (SqlCommand command = new SqlCommand("UpdateSneakers", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@cod_sneakers", ID);
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
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно изменина.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        info = ID.ToString() + ";" + Sneakers_name + ";" + Vendor_code + ";" + brand + ";" + Producing_country + ";" +
                                rjComboBoxSport.Texts + ";" + material + ";" + gender + ";" + size + ";" + color + ";" + price;
                    }
                }
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public string GetData()
        {
            return info;
        }

        private void radioButtonSneakersName_CheckedChanged(object sender, EventArgs e)
        {
            panelSneakersName.Visible = true;
            panelVentor.Visible = false;
            panelBrand.Visible = false;
            panelProdCountry.Visible = false;
            panelSport.Visible = false;
            panelMaterial.Visible = false;
            panelGender.Visible = false;
            panelSize.Visible = false;
            panelColor.Visible = false;
            panelPrice.Visible = false;
        }

        private void radioButtonVentor_CheckedChanged(object sender, EventArgs e)
        {
            panelSneakersName.Visible = false;
            panelBrand.Visible = false;
            panelProdCountry.Visible = false;
            panelMaterial.Visible = false;
            panelSport.Visible = false;
            panelGender.Visible = false;
            panelSize.Visible = false;
            panelColor.Visible = false;
            panelPrice.Visible = false;
            panelVentor.Visible = true;
        }

        private void radioButtonBrand_CheckedChanged(object sender, EventArgs e)
        {
            panelSneakersName.Visible = false;
            panelVentor.Visible = false;
            panelProdCountry.Visible = false;
            panelSport.Visible = false;
            panelMaterial.Visible = false;
            panelGender.Visible = false;
            panelSize.Visible = false;
            panelColor.Visible = false;
            panelPrice.Visible = false;
            panelBrand.Visible = true;
        }

        private void radioButtonProdCountry_CheckedChanged(object sender, EventArgs e)
        {
            panelSneakersName.Visible = false;
            panelVentor.Visible = false;
            panelBrand.Visible = false;
            panelSport.Visible = false;
            panelMaterial.Visible = false;
            panelGender.Visible = false;
            panelSize.Visible = false;
            panelColor.Visible = false;
            panelPrice.Visible = false;
            panelProdCountry.Visible = true;
        }

        private void radioButtonSport_CheckedChanged(object sender, EventArgs e)
        {
            panelSneakersName.Visible = false;
            panelVentor.Visible = false;
            panelBrand.Visible = false;
            panelProdCountry.Visible = false;
            panelMaterial.Visible = false;
            panelGender.Visible = false;
            panelSize.Visible = false;
            panelColor.Visible = false;
            panelPrice.Visible = false;
            panelSport.Visible = true;
        }

        private void radioButtonMaterial_CheckedChanged(object sender, EventArgs e)
        {
            panelSneakersName.Visible = false;
            panelVentor.Visible = false;
            panelBrand.Visible = false;
            panelProdCountry.Visible = false;
            panelSport.Visible = false;
            panelGender.Visible = false;
            panelSize.Visible = false;
            panelColor.Visible = false;
            panelPrice.Visible = false;
            panelMaterial.Visible = true;
        }

        private void radioButtonGender_CheckedChanged(object sender, EventArgs e)
        {
            panelSneakersName.Visible = false;
            panelVentor.Visible = false;
            panelBrand.Visible = false;
            panelProdCountry.Visible = false;
            panelSport.Visible = false;
            panelMaterial.Visible = false;
            panelSize.Visible = false;
            panelColor.Visible = false;
            panelPrice.Visible = false;
            panelGender.Visible = true;
        }

        private void radioButtonSize_CheckedChanged(object sender, EventArgs e)
        {
            panelSneakersName.Visible = false;
            panelVentor.Visible = false;
            panelBrand.Visible = false;
            panelProdCountry.Visible = false;
            panelSport.Visible = false;
            panelMaterial.Visible = false;
            panelGender.Visible = false;
            panelColor.Visible = false;
            panelPrice.Visible = false;
            panelSize.Visible = true;
        }

        private void radioButtonColor_CheckedChanged(object sender, EventArgs e)
        {
            panelSneakersName.Visible = false;
            panelVentor.Visible = false;
            panelBrand.Visible = false;
            panelProdCountry.Visible = false;
            panelSport.Visible = false;
            panelMaterial.Visible = false;
            panelGender.Visible = false;
            panelSize.Visible = false;
            panelPrice.Visible = false;
            panelColor.Visible = true;
        }

        private void radioButtonPrice_CheckedChanged(object sender, EventArgs e)
        {
            panelSneakersName.Visible = false;
            panelVentor.Visible = false;
            panelBrand.Visible = false;
            panelProdCountry.Visible = false;
            panelSport.Visible = false;
            panelMaterial.Visible = false;
            panelGender.Visible = false;
            panelSize.Visible = false;
            panelColor.Visible = false;
            panelPrice.Visible = true;
        }

        private void rjButtonClear_Click(object sender, EventArgs e)
        {
            if (radioButtonSneakersName.Checked) rjTextBoxSneakersName.Clear();
            else if (radioButtonBrand.Checked) rjTextBoxBrand.Clear();
            else if (radioButtonVentor.Checked) rjTextBoxVentor.Clear();
            else if (radioButtonProdCountry.Checked) rjTextBoxProdCountry.Clear();
            else if (radioButtonSport.Checked) rjComboBoxSport.Texts = "";
            else if (radioButtonMaterial.Checked) rjTextBoxMaterial.Clear();
            else if (radioButtonGender.Checked) rjComboBoxGender.Texts = "";
            else if (radioButtonSize.Checked) rjComboBoxSize.Texts = "";
            else if (radioButtonColor.Checked) rjTextBoxColor.Clear();
            else if (radioButtonPrice.Checked) rjTextBoPrice.Clear();
        }
    }
}
