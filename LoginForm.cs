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
    public partial class LoginForm : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private Database database = new Database();

        public LoginForm()
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
            this.Close();
        }

        private void rjButtonClear_Click(object sender, EventArgs e)
        {
            rjTextBoxLogin.Clear();
            rjTextBoxPassword.Clear();
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                rjTextBoxPassword.PasswordChar = false;
            }
            else
            {
                rjTextBoxPassword.PasswordChar = true;
            }
        }

        private void rjButtonLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rjTextBoxLogin.Texts) || string.IsNullOrWhiteSpace(rjTextBoxPassword.Texts))
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                string username = rjTextBoxLogin.Texts.Trim();
                string password = rjTextBoxPassword.Texts;
                try
                {
                    string sql = "SELECT name_role FROM Users WHERE login_user = @username AND password_user = @password";

                    using (var connection = database.GetConnection())
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string name_role = reader["name_role"].ToString();

                            if (name_role == "admin")
                            {
                                this.Hide();
                                Form1 f = new Form1();
                                f.ShowDialog();
                            }
                            else if (name_role == "user")
                            {
                                this.Hide();
                                UserFrom f = new UserFrom();
                                f.ShowDialog();
                            }
                            else if (name_role == "seller")
                            {
                                this.Hide();
                                SellerForm f = new SellerForm();
                                f.ShowDialog();
                            }
                        }
                        else
                        {   
                            MessageBox.Show("Невернный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            rjTextBoxLogin.Clear();
                            rjTextBoxPassword.Clear();
                            rjTextBoxLogin.Focus();
                        }
                        reader.Close();
                        connection.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Не удалось подключится к базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
