using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseSneakers
{
    public partial class AdminPanelForm : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private Database database = new Database();
        int index;

        public AdminPanelForm()
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
            Form1 f = new Form1();
            f.Show();
        }

        private void rjButtonUsers_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Users WHERE name_role = 'user' or name_role = 'seller'";

            try
            {
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    dataGridView1.Columns.Clear();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Add("id_user", "id");
                    dataGridView1.Columns.Add("Role", "Роль");
                    dataGridView1.Columns.Add("Login", "Логин");
                    dataGridView1.Columns.Add("Password", "Пароль");

                    while (reader.Read())
                    {
                        string id_user = reader["id_user"].ToString();
                        string UserName = reader["login_user"].ToString();
                        string UserPassword = reader["password_user"].ToString();
                        string name_role = reader["name_role"].ToString();

                        dataGridView1.Rows.Add(id_user, name_role, UserName, UserPassword);
                    }

                    dataGridView1.Visible = true;
                    rjButtonAdd.Visible = true;
                    rjButtonDelete.Visible = true;
                    rjButtonEdit.Visible = true;
                    dataGridView1.Columns["id_user"].Visible = false;
                    NumberingRow();
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NumberingRow()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            index = dataGridView1.SelectedCells[0].RowIndex;
        }

        private void rjButtonAdd_Click(object sender, EventArgs e)
        {
            string row = "";
            AddUser f = new AddUser();
            f.ShowDialog();
            row = f.GetData();

            string[] data;
            if (!string.IsNullOrEmpty(row))
            {
                data = row.Split(';');
                if (data.Length == dataGridView1.Columns.Count)
                {
                    dataGridView1.Rows.Add(data);
                    NumberingRow();
                }
                else return;
            }
            else return;
        }

        private void rjButtonDelete_Click(object sender, EventArgs e)
        {
            if (index > 0 && index < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];

                DialogResult result = MessageBox.Show("Удалить пользователя?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                    try
                    {
                        using (var connection = database.GetConnection())
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand("DeleteUser", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@UserID", id);
                                command.ExecuteNonQuery();
                                MessageBox.Show("Запись успешно удалена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dataGridView1.Rows.RemoveAt(index);
                    NumberingRow();
                }
                else return;
            }
            else MessageBox.Show("Выделите строку для удаления!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rjButtonEdit_Click(object sender, EventArgs e)
        {
            if (index > 0 && index < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                string id = selectedRow.Cells[0].Value.ToString();
                string name_role = selectedRow.Cells[1].Value.ToString();
                string login_user = selectedRow.Cells[2].Value.ToString();
                string password_user = selectedRow.Cells[3].Value.ToString();
                string info = id + ";" + name_role + ";" + login_user + ";" + password_user;
                EditUser f = new EditUser(info);
                f.ShowDialog();

                string row = f.GetData();
                string[] data;
                if (!string.IsNullOrEmpty(row))
                {
                    data = row.Split(';');
                    if (data.Length == dataGridView1.Columns.Count)
                    {
                        selectedRow.Cells[0].Value = data[0];
                        selectedRow.Cells[1].Value = data[1];
                        selectedRow.Cells[2].Value = data[2];
                        selectedRow.Cells[3].Value = data[3];
                        NumberingRow();
                    }
                }
                else return;
            }
            else MessageBox.Show("Выделите строку для удаления!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rjButtonBackup_Click(object sender, EventArgs e)
        {
            string FilePath = "";
            bool SaveFileDialog()
            {
                saveFileDialog.Filter = "Backup Files (.bak)|*.bak";
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FilePath = saveFileDialog.FileName;
                    return true;
                }
                return false;
            }

            if (SaveFileDialog())
            {
                try
                {
                    using (var connection = database.GetConnection())
                    {
                        connection.Open();
                        string query = "BACKUP DATABASE Sneakers TO DISK = N'" + FilePath + "' WITH NOFORMAT, NOINIT, NAME = N'Sneakers-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Успешное создание резервной копиии!\nПуть к файлу резервной копии: " + FilePath, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка создания резервной копии: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rjButtonBackupRestore_Click(object sender, EventArgs e)
        {
            string FilePath = "";
            bool OpenFileDialog()
            {
                openFileDialog.FileName = "backup";
                openFileDialog.Title = "Select backup file";
                openFileDialog.Filter = "Backup files (*.bak)|*.bak|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FilePath = openFileDialog.FileName;
                    return true;
                }
                return false;
            }

            if (OpenFileDialog())
            {
                try
                {
                    using (var connection = database.GetConnection())
                    {
                        connection.Open();
                        bool isDatabaseInUse = IsDatabaseInUse(connection, "Sneakers");
                        if (isDatabaseInUse) DisconnectDatabase(connection, "Sneakers");

                        string query = "USE master RESTORE DATABASE Sneakers FROM DISK = N'" + FilePath + "' WITH  FILE = 1,  NOUNLOAD, STATS = 5";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Успешное восстановление резервной копиии", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка восстановления резервной копии: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Метод для проверки, используется ли база данных
        private bool IsDatabaseInUse(SqlConnection connection, string databaseName)
        {
            string query = $"SELECT COUNT(*) FROM sys.dm_exec_sessions WHERE database_id = DB_ID('{databaseName}')";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                int sessionCount = (int)cmd.ExecuteScalar();
                return sessionCount > 0;
            }
        }

        // Метод для отключения всех соединений с базой данных
        private void DisconnectDatabase(SqlConnection connection, string databaseName)
        {
            string query = $"ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
