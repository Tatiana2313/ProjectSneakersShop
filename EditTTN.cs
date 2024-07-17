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
    public partial class EditTTN : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private Database database = new Database();
        public int num_doc;

        public EditTTN(string row)
        {
            InitializeComponent();

            string[] data = row.Split(';');
            num_doc = Convert.ToInt16(data[0]);
            dateTimePicker.Text = data[1];
            DatabaseMethods.fillComboBoxProviver(rjComboBoxProvider);
            DatabaseMethods.fillComboBoxSneakers(rjComboBoxSneakers);
            int indexProvider = rjComboBoxProvider.FindString(data[2]);
            rjComboBoxProvider.SelectedIndex = indexProvider;
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
            if (rjComboBoxProvider.SelectedIndex != -1 && rjComboBoxSneakers.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(rjTextBoxNumber.Texts))
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
            int cod_provider = Convert.ToInt32(rjComboBoxProvider.SelectedValue);
            int cod_sneakers = Convert.ToInt32(rjComboBoxSneakers.SelectedValue);
            int number_of_sneakers = Convert.ToInt32(rjTextBoxNumber.Texts);

            try
            {
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UpdateTTN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@num_doc", num_doc);
                        command.Parameters.AddWithValue("@cod_provider", cod_provider);
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
            rjComboBoxProvider.Texts = "";
            rjComboBoxSneakers.Texts = ""; 
            rjTextBoxNumber.Clear();
        }
    }
}
