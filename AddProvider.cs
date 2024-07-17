using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseSneakers
{
    public partial class AddProvider : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private Database database = new Database();

        public string data;

        public AddProvider()
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

        private void rjTextBoxLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void TextBoxRasScet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rjTextBox__TextChanged(object sender, EventArgs e)
        {
            EnableAddButton();
        }

        private void maskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            EnableAddButton();
        }

        private void EnableAddButton()
        {
            if (!string.IsNullOrWhiteSpace(rjTextBoxPrName.Texts) && maskedTextBoxPhone.MaskCompleted && !string.IsNullOrWhiteSpace(rjTextBoxAddress.Texts) && maskedTextBoxScet.MaskCompleted)
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
            string provider_name = rjTextBoxPrName.Texts;
            string addres = rjTextBoxAddress.Texts;
            string phone_fax = maskedTextBoxPhone.Text;
            string rascet_scet = maskedTextBoxScet.Text;

            try
            {
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("AddProviders", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@provider_name", provider_name);
                        command.Parameters.AddWithValue("@addres", addres);
                        command.Parameters.AddWithValue("@phone_fax", phone_fax);
                        command.Parameters.AddWithValue("@rascet_scet", rascet_scet);

                        string id = command.ExecuteScalar().ToString();

                        MessageBox.Show("Успешное добавление", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        data = id + ";" + provider_name + ";" + addres + ";" + phone_fax + ";" + rascet_scet;
                    }
                }
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public string GetData()
        {
            return data;
        }

        private void rjButtonClear_Click(object sender, EventArgs e)
        {
            rjTextBoxPrName.Clear();
            rjTextBoxAddress.Clear();
            maskedTextBoxScet.Clear();
            maskedTextBoxPhone.Clear();
        }
    }
}
