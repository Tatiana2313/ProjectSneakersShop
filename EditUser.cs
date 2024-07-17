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
    public partial class EditUser : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private Database database = new Database();
        public string info = "";
        public int ID;

        public EditUser(string row)
        {
            InitializeComponent();

            string[] data = row.Split(';');
            ID = Convert.ToInt16(data[0]);
            int indexRole = rjComboBoxRole.FindString(data[1]);
            rjComboBoxRole.SelectedIndex = indexRole;
            rjTextBoxLogin.Texts = data[2];
            rjTextBoxPassword.Texts = data[3];
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
            if (!string.IsNullOrWhiteSpace(rjTextBoxLogin.Texts) && !string.IsNullOrWhiteSpace(rjTextBoxPassword.Texts) && rjComboBoxRole.SelectedIndex != -1)
            {
                rjButtonEdit.Enabled = true;
            }
            else
            {
                rjButtonEdit.Enabled = false;
            }
        }

        private void rjButtonClear_Click(object sender, EventArgs e)
        {
            rjTextBoxLogin.Clear();
            rjTextBoxPassword.Clear();
            rjComboBoxRole.SelectedItem = null;
        }

        private void rjButtonEdit_Click(object sender, EventArgs e)
        {
            string login_user = rjTextBoxLogin.Texts;
            string password_user = rjTextBoxPassword.Texts;
            string name_role = Convert.ToString(rjComboBoxRole.SelectedItem.ToString());

            try
            {
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UpdateUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id_user", ID);
                        command.Parameters.AddWithValue("@name_role", name_role);
                        command.Parameters.AddWithValue("@login_user", login_user);
                        command.Parameters.AddWithValue("@password_user", password_user);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Запись успешно изменина.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        info = ID.ToString() + ";" + name_role + ";" + login_user + ";" + password_user;
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
    }
}
