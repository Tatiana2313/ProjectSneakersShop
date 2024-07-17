using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseSneakers
{
    public partial class AddJurnalUceta : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private Database database = new Database();

        public string data;

        public AddJurnalUceta()
        {
            InitializeComponent();
            int currentMonth = DateTime.Now.Month;
            rjComboBoxMonth.SelectedIndex = currentMonth - 1;
            DatabaseMethods.fillComboBoxSneakers(rjComboBoxSneakers);
            rjComboBoxSneakers.Texts = "";
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

        private void rjTextBoxDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void rjTextBoxLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void rjTextBox__TextChanged(object sender, EventArgs e)
        {
            EnableAddButton();
        }

        private void EnableAddButton()
        {
            if (rjComboBoxMonth.SelectedIndex != -1 && rjComboBoxSneakers.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(rjTextBoxNumDeliver.Texts) && !string.IsNullOrWhiteSpace(rjTextBoxNumSold.Texts))
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
            string month_name = rjComboBoxMonth.SelectedItem.ToString();
            int cod_sneakers = Convert.ToInt32(rjComboBoxSneakers.SelectedValue);
            int NumbeOfDeliveredSneakers = Convert.ToInt32(rjTextBoxNumDeliver.Texts);
            int NumberOfSneakersSold = Convert.ToInt32(rjTextBoxNumSold.Texts);

            try
            {
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("AddJurnalInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@month_name", month_name);
                        command.Parameters.AddWithValue("@cod_sneakers", cod_sneakers);
                        command.Parameters.AddWithValue("@NumbeOfDeliveredSneakers", NumbeOfDeliveredSneakers);
                        command.Parameters.AddWithValue("@NumberOfSneakersSold", NumberOfSneakersSold);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Успешное добавление", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rjButtonClear_Click(object sender, EventArgs e)
        {
            rjComboBoxSneakers.Texts = "";
            rjTextBoxNumDeliver.Clear();
            rjTextBoxNumSold.Clear();
        }
    }
}
