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
    public partial class AddUser : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private Database database = new Database();
        public string data;

        public AddUser()
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

        private void rjTextBox__TextChanged(object sender, EventArgs e)
        {
            EnableAddButton();
        }

        private void rjComboBoxRole_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            EnableAddButton();
        }

        private void EnableAddButton()
        {
            if (!string.IsNullOrWhiteSpace(rjTextBoxLogin.Texts) && !string.IsNullOrWhiteSpace(rjTextBoxPassword.Texts) && 
                rjTextBoxPassword.Texts.Length == 8 && rjComboBoxRole.SelectedIndex != -1)
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
            string login_user = rjTextBoxLogin.Texts;
            string password_user = rjTextBoxPassword.Texts;
            string name_role = Convert.ToString(rjComboBoxRole.SelectedItem.ToString());

            try
            {
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("AddUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@name_role", name_role);
                        command.Parameters.AddWithValue("@login_user", login_user);
                        command.Parameters.AddWithValue("@password_user", password_user);

                        string id = command.ExecuteScalar().ToString();

                        MessageBox.Show("Запись успешно добавлена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        data = id + ";" + name_role + ";" + login_user + ";" + password_user;
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
            rjTextBoxLogin.Clear();
            rjTextBoxPassword.Clear();
            rjComboBoxRole.SelectedItem = null;
        }

        public string GetData()
        {
            return data;
        }
    }
}
