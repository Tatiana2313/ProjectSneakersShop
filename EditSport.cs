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
    public partial class EditSport : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private Database database = new Database();
        public string info = "";
        public int ID;

        public EditSport(string row)
        {
            InitializeComponent();

            string[] data = row.Split(';');
            ID = Convert.ToInt16(data[0]);
            rjTextBoxSport.Texts = data[1];
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

        private void rjTextBoxSport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void rjTextBoxSport__TextChanged(object sender, EventArgs e)
        {
            if (rjTextBoxSport.Texts.Length != 0)
            {
                rjButtonEdit.Enabled = true;
            }
            else if (rjTextBoxSport.Texts.Length == 0)
            {
                rjButtonEdit.Enabled = false;
            }
        }

        private void rjButtonEdit_Click(object sender, EventArgs e)
        {
            string name_sport = rjTextBoxSport.Texts;
            try
            {
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UpdateSport", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@cod_kind_of_sport", ID);
                        command.Parameters.AddWithValue("@name_sport", name_sport);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно изменина.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        info = ID.ToString() + ";" + name_sport;
                    }
                }
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public string GetData()
        {
            return info;
        }

        private void rjButtonClear_Click(object sender, EventArgs e)
        {
            rjTextBoxSport.Clear();
        }
    }
}
