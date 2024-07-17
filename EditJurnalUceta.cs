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
    public partial class EditJurnalUceta : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private Database database = new Database();
        public string month_name;

        public EditJurnalUceta(string row)
        {
            InitializeComponent();

            rjTextBoxMonth.ReadOnly = true;

            string[] data = row.Split(';');
            month_name = data[0];
            rjTextBoxMonth.Texts = month_name;
            DatabaseMethods.fillComboBoxSneakers(rjComboBoxSneakers);
            int indexSneakers = rjComboBoxSneakers.FindString(data[1]);
            rjComboBoxSneakers.SelectedIndex = indexSneakers;
            rjTextBoxNumDeliver.Texts = data[2];
            rjTextBoxNumSold.Texts = data[3];
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
            if (!string.IsNullOrWhiteSpace(rjTextBoxMonth.Texts) && rjComboBoxSneakers.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(rjTextBoxNumDeliver.Texts) && !string.IsNullOrWhiteSpace(rjTextBoxNumSold.Texts))
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
            string month_name = rjTextBoxMonth.Texts;
            int cod_sneakers = Convert.ToInt32(rjComboBoxSneakers.SelectedValue);
            int NumbeOfDeliveredSneakers = Convert.ToInt32(rjTextBoxNumDeliver.Texts);
            int NumberOfSneakersSold = Convert.ToInt32(rjTextBoxNumSold.Texts);

            try
            {
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UpdateJurnalUceta", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@month_name", month_name);
                        command.Parameters.AddWithValue("@cod_sneakers", cod_sneakers);
                        command.Parameters.AddWithValue("@NumbeOfDeliveredSneakers", NumbeOfDeliveredSneakers);
                        command.Parameters.AddWithValue("@NumberOfSneakersSold", NumberOfSneakersSold);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно изменина.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void rjButtonClear_Click(object sender, EventArgs e)
        {
            rjTextBoxNumDeliver.Clear();
            rjTextBoxNumSold.Clear();
        }
    }
}
