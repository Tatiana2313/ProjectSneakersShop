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
    public partial class EditChek : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private Database database = new Database();
        public int check_number;

        public EditChek(string row)
        {
            InitializeComponent();

            string[] data = row.Split(';');
            check_number = Convert.ToInt16(data[0]);
            dateTimePicker.Text = data[1];
            maskedTextBoxTime.Text = data[2];
            DatabaseMethods.fillComboBoxSneakers(rjComboBoxSneakers);
            int indexSneakers = rjComboBoxSneakers.FindString(data[3]);
            rjComboBoxSneakers.SelectedIndex = indexSneakers;
            rjTextBoxNumber.Texts = data[4];
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

        private void rjTextBox__TextChanged(object sender, EventArgs e)
        {
            EnableAddButton();
        }

        private void EnableAddButton()
        {
            if (maskedTextBoxTime.MaskCompleted && rjComboBoxSneakers.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(rjTextBoxNumber.Texts))
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
            int cod_sneakers = Convert.ToInt32(rjComboBoxSneakers.SelectedValue);
            int number_of_sneakers = Convert.ToInt32(rjTextBoxNumber.Texts);

            try
            {
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UpdateCheck", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@check_number", check_number);
                        command.Parameters.AddWithValue("@cod_sneakers", cod_sneakers);
                        command.Parameters.AddWithValue("@number_of_sneakers", number_of_sneakers);
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
            rjComboBoxSneakers.Texts = "";
            rjTextBoxNumber.Clear();
        }
    }
}
