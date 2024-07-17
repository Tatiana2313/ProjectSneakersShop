using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBaseSneakers
{
    public partial class Form1 : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        int index;
        private Database database = new Database();
        string mode = "";

        public Form1()
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
            //this.Close();
            Application.Exit();
        }

        private void rjButtonKindSport_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Kind_of_sport";
            ShowSport(sql);

            pictureBox2.Visible = true;
            labelHeader.Visible = true;
            pictureBox2.Image = Image.FromFile(@"..\..\image\sports-1.png");
            labelHeader.Text = "Вид спорта";
            rjButtonAdd.Visible = true;
            rjButtonDelete.Visible = true;
            rjTextBoxResearch.Visible = true;
            rjButtonResearch.Visible = true;
            rjButtonEdit.Visible = true;
            rjButtonFiltration.Visible = false;
            rjButtonTotal.Visible = false;
            panelReport.Visible = false;
            pictureBoxWelcome.Visible = false;
        }

        private void ShowSport(string sql)
        {
            try
            {
                mode = "sport";
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "SportData");
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "SportData";
                    dataGridView1.Columns[0].Visible = false;
                    NumberingRow();
                    ShowHeadersSport();
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

        public void ShowHeadersSport()
        {
            dataGridView1.Columns[1].HeaderText = "Название спорта";
        }

        private void rjButtonSneakers_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ViewSneakersInfo";
            ShowSneakers(sql);

            pictureBox2.Visible = true;
            labelHeader.Visible = true;
            pictureBox2.Image = Image.FromFile(@"..\..\image\sneakrs-1.png");
            labelHeader.Text = "Спортивные кроссовки";
            rjButtonAdd.Visible = true;
            rjButtonDelete.Visible = true;
            rjTextBoxResearch.Visible = true;
            rjButtonResearch.Visible = true;
            rjButtonEdit.Visible = true;
            rjButtonFiltration.Visible = true;
            rjButtonTotal.Visible = true;
            rjButtonTotal.Location = new Point(1314, 220);
            rjButtonTotal.Parent.Invalidate();
            panelReport.Visible = false;
            pictureBoxWelcome.Visible = false;
        }

        private void ShowSneakers(string sql)
        {
            try
            {
                mode = "sneakers";
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "SneakersData");
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "SneakersData";
                    dataGridView1.Columns[0].Visible = false;
                    NumberingRow();
                    ShowHeadersSneakers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowHeadersSneakers()
        {
            dataGridView1.Columns[1].HeaderText = "Название кроссовок";
            dataGridView1.Columns[2].HeaderText = "Артикул";
            dataGridView1.Columns[3].HeaderText = "Бренд";
            dataGridView1.Columns[4].HeaderText = "Страна производитель";
            dataGridView1.Columns[5].HeaderText = "Название спорта";
            dataGridView1.Columns[6].HeaderText = "Материал";
            dataGridView1.Columns[7].HeaderText = "Пол";
            dataGridView1.Columns[8].HeaderText = "Размер";
            dataGridView1.Columns[9].HeaderText = "Цвет";
            dataGridView1.Columns[10].HeaderText = "Цена за единицу";
        }

        private void rjButtonProvider_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Providerr";
            ShowProviders(sql);

            pictureBox2.Visible = true;
            labelHeader.Visible = true;
            pictureBox2.Image = Image.FromFile(@"..\..\image\provider-2.png");
            labelHeader.Text = "Поставщики";
            rjButtonAdd.Visible = true;
            rjButtonDelete.Visible = true;
            rjTextBoxResearch.Visible = true;
            rjButtonResearch.Visible = true;
            rjButtonEdit.Visible = true;
            rjButtonFiltration.Visible = false;
            rjButtonTotal.Visible = false;
            panelReport.Visible = false;
            pictureBoxWelcome.Visible = false;
        }

        private void ShowProviders(string sql)
        {
            try
            {
                mode = "provider";
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "ProvidersData");
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "ProvidersData";
                    dataGridView1.Columns[0].Visible = false;
                    NumberingRow();
                    ShowHeadersProviders();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowHeadersProviders()
        {
            dataGridView1.Columns[1].HeaderText = "Название поставщика";
            dataGridView1.Columns[2].HeaderText = "Адрес";
            dataGridView1.Columns[3].HeaderText = "Телефон";
            dataGridView1.Columns[4].HeaderText = "Расчетный счет";
            
        }

        private void rjButtonTTN_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ViewSneakersTTN";
            ShowTTN(sql);

            pictureBox2.Visible = true;
            labelHeader.Visible = true;
            pictureBox2.Image = Image.FromFile(@"..\..\image\document.png");
            labelHeader.Text = "ТТН (накладная)";
            rjButtonAdd.Visible = true;
            rjButtonDelete.Visible = true;
            rjTextBoxResearch.Visible = true;
            rjButtonResearch.Visible = true;
            rjButtonEdit.Visible = true;
            rjButtonFiltration.Visible = false;
            rjButtonTotal.Visible = false;
            panelReport.Visible = false;
            pictureBoxWelcome.Visible = false;
        }

        public void ShowHeadersTTN()
        {
            dataGridView1.Columns[0].HeaderText = "Номер документа";
            dataGridView1.Columns[1].HeaderText = "Дата поставки";
            dataGridView1.Columns[2].HeaderText = "Название поставщика";
            dataGridView1.Columns[3].HeaderText = "Название кроссовок";
            dataGridView1.Columns[4].HeaderText = "Бренд";
            dataGridView1.Columns[5].HeaderText = "Цена за единицу(лей)";
            dataGridView1.Columns[6].HeaderText = "Кол-во";
            dataGridView1.Columns[7].HeaderText = "Общая сумма(лей)";
        }

        public void ShowHeadersCheck()
        {
            dataGridView1.Columns[0].HeaderText = "Номер покупки";
            dataGridView1.Columns[1].HeaderText = "Дата покупки";
            dataGridView1.Columns[2].HeaderText = "Время покупки";
            dataGridView1.Columns[3].HeaderText = "Название кроссовок";
            dataGridView1.Columns[4].HeaderText = "Бренд";
            dataGridView1.Columns[5].HeaderText = "Цена за единицу(лей)";
            dataGridView1.Columns[6].HeaderText = "Кол-во";
            dataGridView1.Columns[7].HeaderText = "Общая сумма(лей)";
        }

        private void rjButtonChek_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ViewSneakersChek";
            ShowChek(sql);

            pictureBox2.Visible = true;
            labelHeader.Visible = true;
            pictureBox2.Image = Image.FromFile(@"..\..\image\shopping-bag.png");
            labelHeader.Text = "Покупки";
            rjButtonAdd.Visible = true;
            rjButtonDelete.Visible = true;
            rjTextBoxResearch.Visible = true;
            rjButtonResearch.Visible = true;
            rjButtonEdit.Visible = true;
            rjButtonFiltration.Visible = false;
            rjButtonTotal.Visible = true;
            rjButtonTotal.Location = new Point(1552, 217);
            rjButtonTotal.Parent.Invalidate();
            panelReport.Visible = false;
            pictureBoxWelcome.Visible = false;
        }

        private void rjButtonJurnal_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ViewSneakersJurnal";
            ShowJurnalUceta(sql);

            pictureBox2.Visible = true;
            labelHeader.Visible = true;
            pictureBox2.Image = Image.FromFile(@"..\..\image\accounting-1.png");
            labelHeader.Text = "Журнал учета";
            rjButtonAdd.Visible = true;
            rjButtonDelete.Visible = true;
            rjTextBoxResearch.Visible = true;
            rjButtonResearch.Visible = true;
            rjButtonEdit.Visible = true;
            rjButtonFiltration.Visible = false;
            rjButtonTotal.Visible = false;
            panelReport.Visible = false;
            pictureBoxWelcome.Visible = false;
        }

        public void ShowHeadersUcet()
        {
            dataGridView1.Columns[0].HeaderText = "Месяц";
            dataGridView1.Columns[1].HeaderText = "Название кроссовок";
            dataGridView1.Columns[2].HeaderText = "Бренд";
            dataGridView1.Columns[3].HeaderText = "Кол-во поставленных";
            dataGridView1.Columns[4].HeaderText = "Кол-во проданных";
            dataGridView1.Columns[5].HeaderText = "Остаток";
        }

        private void rjButtonAdd_Click(object sender, EventArgs e)
        {
            string row = "";

            if (mode == "sport")
            {
                AddKindSport f = new AddKindSport();
                f.ShowDialog();
                row = f.GetData();
            }

            if (mode == "sneakers")
            {
                AddSneakers f = new AddSneakers();
                f.ShowDialog();
                row = f.GetData();
            }

            if (mode == "provider")
            {
                AddProvider f = new AddProvider();
                f.ShowDialog();
                row = f.GetData();
            }

            if (mode == "TTN")
            {
                AddTTN f = new AddTTN();
                f.ShowDialog();
                string sql = "SELECT * FROM ViewSneakersTTN";
                ShowTTN(sql);
            }

            if (mode == "chek")
            {
                AddChek f = new AddChek();
                f.ShowDialog();
                string sql = "SELECT * FROM ViewSneakersChek";
                ShowChek(sql);
            }

            if (mode == "jurnal")
            {
                AddJurnalUceta f = new AddJurnalUceta();
                f.ShowDialog();
                string sql = "SELECT * FROM ViewSneakersJurnal";
                ShowJurnalUceta(sql);
            }

            string[] data;
            if (!string.IsNullOrEmpty(row))
            {
                data = row.Split(';');
                DataSet ds = new DataSet();
                ds = (DataSet)(dataGridView1.DataSource);
                DataTable dt = ds.Tables[0];
                dt.Rows.Add(data);
                NumberingRow();
            }
            else return;
        }

        public void ShowTTN(string sql)
        {
            try
            {
                mode = "TTN";
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "TTNData");
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "TTNData";
                    NumberingRow();
                    ShowHeadersTTN();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowChek(string sql)
        {
            try
            {
                mode = "chek";
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "ChecksData");
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "ChecksData";
                    NumberingRow();
                    ShowHeadersCheck();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowJurnalUceta(string sql)
        {
            try
            {
                mode = "jurnal";
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "UcetData");
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "UcetData";
                    NumberingRow();
                    ShowHeadersUcet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            index = dataGridView1.SelectedCells[0].RowIndex;
            rjButtonDelete.Enabled = true;
            rjButtonEdit.Enabled = true;
        }

        private void rjButtonDelete_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];

                DialogResult result = MessageBox.Show("Удалить информацию?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    if (mode == "sport")
                    {
                        int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                        try
                        {
                            using (var connection = database.GetConnection())
                            {
                                connection.Open();
                                using (SqlCommand command = new SqlCommand("DeleteRecordSport", connection))
                                {
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@recordID", id);
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
                    }

                    if (mode == "sneakers")
                    {
                        int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                        try
                        {
                            using (var connection = database.GetConnection())
                            {
                                connection.Open();
                                using (SqlCommand command = new SqlCommand("DeleteRecordsSneakers", connection))
                                {
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@recordID", id);
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
                    }

                    if (mode == "provider")
                    {
                        int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                        try
                        {
                            using (var connection = database.GetConnection())
                            {
                                connection.Open();
                                using (SqlCommand command = new SqlCommand("DeleteRecordsProvider", connection))
                                {
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@recordID", id);
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
                    }

                    if (mode == "TTN")
                    {
                        int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                        try
                        {
                            using (var connection = database.GetConnection())
                            {
                                connection.Open();
                                using (SqlCommand command = new SqlCommand("DeleteRecordsTTN", connection))
                                {
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@recordID", id);
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
                    }

                    if (mode == "chek")
                    {
                        int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                        try
                        {
                            using (var connection = database.GetConnection())
                            {
                                connection.Open();
                                using (SqlCommand command = new SqlCommand("DeleteRecordsCheck", connection))
                                {
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@recordID", id);
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
                    }

                    if (mode == "jurnal")
                    {
                        string month = selectedRow.Cells[0].Value.ToString();
                        string album = selectedRow.Cells[1].Value.ToString();
                        try
                        {
                            using (var connection = database.GetConnection())
                            {
                                connection.Open();
                                using (SqlCommand command = new SqlCommand("DeleteRecordsUcet", connection))
                                {
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@month", month);
                                    command.Parameters.AddWithValue("@name", album);
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
                    }
                    DataSet ds = new DataSet();
                    ds = (DataSet)(dataGridView1.DataSource);
                    DataTable dt = ds.Tables[0];
                    dt.Rows.RemoveAt(index);
                    dataGridView1.DataSource = ds;
                    NumberingRow();
                }
            }
            else return;
        }

        private void rjButtonResearch_Click(object sender, EventArgs e)
        {
            string sql;
            if (mode == "sport")
            {
                sql = $"SELECT * FROM Kind_of_sport WHERE CONCAT(cod_kind_of_sport, name_sport) LIKE '%{rjTextBoxResearch.Texts}'";
                ShowSport(sql);
            }

            if (mode == "provider")
            {
                sql = $"SELECT * FROM Providerr WHERE CONCAT(cod_provider, provider_name, addres, phone_fax, rascet_scet) LIKE '%{rjTextBoxResearch.Texts}%'";
                ShowProviders(sql);
            }
            if (mode == "sneakers")
            {
                sql = $"SELECT * FROM ViewSneakersInfo WHERE CONCAT(cod_sneakers, Sneakers_name, Vendor_code, brand, Producing_country, name_sport, material, gender, size, color, unit_price) LIKE '%{rjTextBoxResearch.Texts}%'";
                ShowSneakers(sql);
            }
            if (mode == "TTN")
            {
                sql = $"SELECT * FROM ViewSneakersTTN WHERE CONCAT(num_doc, date_post, provider_name, Sneakers_name, brand, unit_price, number_of_sneakers, total) LIKE '%{rjTextBoxResearch.Texts}%'";
                ShowTTN(sql);
            }
            if (mode == "chek")
            {
                sql = $"SELECT * FROM ViewSneakersChek WHERE CONCAT(check_number, date_of_sale, sale_time, Sneakers_name, brand, unit_price, number_of_sneakers, total_Price) LIKE '%{rjTextBoxResearch.Texts}%'";
                ShowChek(sql);
            }
            if (mode == "jurnal")
            {
                sql = $"SELECT * FROM ViewSneakersJurnal WHERE CONCAT(month_name, Sneakers_name, brand, NumbeOfDeliveredSneakers, NumberOfSneakersSold, remainder) LIKE '%{rjTextBoxResearch.Texts}%'";
                ShowJurnalUceta(sql);
            }
        }

        private void rjTextBoxResearch__TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (rjTextBoxResearch.Texts.Length != 0)
            {
                rjButtonResearch.Enabled = true;
            }
            else
            {
                rjButtonResearch.Enabled = false;
                if (mode == "sport")
                {
                    sql = "SELECT * FROM Kind_of_sport";
                    ShowSport(sql);
                }

                if (mode == "provider")
                {
                    sql = "SELECT * FROM Providerr";
                    ShowProviders(sql);
                }
                if (mode == "sneakers")
                {
                    sql = "SELECT * FROM ViewSneakersInfo";
                    ShowSneakers(sql);
                }
                if (mode == "TTN")
                {
                    sql = "SELECT * FROM ViewSneakersTTN";
                    ShowTTN(sql);
                }
                if (mode == "chek")
                {
                    sql = "SELECT * FROM ViewSneakersChek";
                    ShowChek(sql);
                }
                if (mode == "jurnal")
                {
                    sql = "SELECT * FROM ViewSneakersJurnal";
                    ShowJurnalUceta(sql);
                }
            }
        }

        private void rjButtonEdit_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                if (mode == "sport")
                {
                    string id = selectedRow.Cells[0].Value.ToString();
                    string name_sport = selectedRow.Cells[1].Value.ToString();
                    string info = id + ";" + name_sport;
                    EditSport f = new EditSport(info);
                    f.ShowDialog();

                    string row = f.GetData();
                    string[] data;
                    if (!string.IsNullOrEmpty(row))
                    {
                        data = row.Split(';');
                        DataSet ds = new DataSet();
                        ds = (DataSet)(dataGridView1.DataSource);
                        DataTable dt = ds.Tables[0];
                        dt.Rows[index][0] = data[0];
                        dt.Rows[index][1] = data[1];
                        NumberingRow();
                    }
                    else return;
                }

                if (mode == "sneakers")
                {
                    string id = selectedRow.Cells[0].Value.ToString();
                    string Sneakers_name = selectedRow.Cells[1].Value.ToString();
                    string Vendor_code = selectedRow.Cells[2].Value.ToString();
                    string brand = selectedRow.Cells[3].Value.ToString();
                    string Producing_country = selectedRow.Cells[4].Value.ToString();
                    string cod_kind_of_sport = selectedRow.Cells[5].Value.ToString();
                    string material = selectedRow.Cells[6].Value.ToString();
                    string gender = selectedRow.Cells[7].Value.ToString();
                    string size = selectedRow.Cells[8].Value.ToString();
                    string color = selectedRow.Cells[9].Value.ToString();
                    string price = selectedRow.Cells[10].Value.ToString();
                    string info = id + ";" + Sneakers_name + ";" + Vendor_code + ";" + brand + ";" + Producing_country + ";" + cod_kind_of_sport + ";" +
                                  material + ";" + gender + ";" + size + ";" + color + ";" + price;
                    EditSneakers f = new EditSneakers(info);
                    f.ShowDialog();

                    string row = f.GetData();
                    string[] data;
                    if (!string.IsNullOrEmpty(row))
                    {
                        data = row.Split(';');
                        DataSet ds = new DataSet();
                        ds = (DataSet)(dataGridView1.DataSource);
                        DataTable dt = ds.Tables[0];
                        dt.Rows[index][0] = data[0];
                        dt.Rows[index][1] = data[1];
                        dt.Rows[index][2] = data[2];
                        dt.Rows[index][3] = data[3];
                        dt.Rows[index][4] = data[4];
                        dt.Rows[index][5] = data[5];
                        dt.Rows[index][6] = data[6];
                        dt.Rows[index][7] = data[7];
                        dt.Rows[index][8] = data[8];
                        dt.Rows[index][9] = data[9];
                        dt.Rows[index][10] = data[10];
                        NumberingRow();
                    }
                    else return;
                }
                if (mode == "provider")
                {
                    string id = selectedRow.Cells[0].Value.ToString();
                    string provider_name = selectedRow.Cells[1].Value.ToString();
                    string addres = selectedRow.Cells[2].Value.ToString();
                    string phone_fax = selectedRow.Cells[3].Value.ToString();
                    string rascet_scet = selectedRow.Cells[4].Value.ToString();
                    string info = id + ";" + provider_name + ";" + addres + ";" + phone_fax + ";" + rascet_scet;
                    EditProvider f = new EditProvider(info);
                    f.ShowDialog();

                    string row = f.GetData();
                    string[] data;
                    if (!string.IsNullOrEmpty(row))
                    {
                        data = row.Split(';');
                        DataSet ds = new DataSet();
                        ds = (DataSet)(dataGridView1.DataSource);
                        DataTable dt = ds.Tables[0];
                        dt.Rows[index][0] = data[0];
                        dt.Rows[index][1] = data[1];
                        dt.Rows[index][2] = data[2];
                        dt.Rows[index][3] = data[3];
                        dt.Rows[index][4] = data[4];
                        NumberingRow();
                    }
                    else return;
                }
                if (mode == "TTN")
                {
                    string id = selectedRow.Cells[0].Value.ToString();
                    string date_post = selectedRow.Cells[1].Value.ToString();
                    string cod_provider = selectedRow.Cells[2].Value.ToString();
                    string cod_sneakers = selectedRow.Cells[3].Value.ToString();
                    string number_of_sneakers = selectedRow.Cells[6].Value.ToString();
                    string info = id + ";" + date_post + ";" + cod_provider + ";" + cod_sneakers + ";" + number_of_sneakers;
                    EditTTN f = new EditTTN(info);
                    f.ShowDialog();
                    string sql = "SELECT * FROM ViewSneakersTTN";
                    ShowTTN(sql);
                }
                if (mode == "chek")
                {
                    string id = selectedRow.Cells[0].Value.ToString();
                    string date_of_sale = selectedRow.Cells[1].Value.ToString();
                    string sale_time = selectedRow.Cells[2].Value.ToString();
                    string cod_sneakers = selectedRow.Cells[3].Value.ToString();
                    string number_of_sneakers = selectedRow.Cells[6].Value.ToString();
                    string info = id + ";" + date_of_sale + ";" + sale_time + ";" + cod_sneakers + ";" + number_of_sneakers;
                    EditChek f = new EditChek(info);
                    f.ShowDialog();
                    string sql = "SELECT * FROM ViewSneakersChek";
                    ShowChek(sql);
                }
                if (mode == "jurnal")
                {
                    string month_name = selectedRow.Cells[0].Value.ToString();
                    string cod_sneakers = selectedRow.Cells[1].Value.ToString();
                    string NumbeOfDeliveredSneakers = selectedRow.Cells[3].Value.ToString();
                    string NumberOfSneakersSold = selectedRow.Cells[4].Value.ToString();
                    string info = month_name + ";" + cod_sneakers + ";" + NumbeOfDeliveredSneakers + ";" + NumberOfSneakersSold;
                    EditJurnalUceta f = new EditJurnalUceta(info);
                    f.ShowDialog();
                    string sql = "SELECT * FROM ViewSneakersJurnal";
                    ShowJurnalUceta(sql);
                }
            }
        }

        private void rjButtonFiltration_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panelFiltration.Visible = true;
            DatabaseMethods.fillComboBoxSneakers(rjComboBoxSneakers);
            DatabaseMethods.fillComboBoxSport(rjComboBoxSport);
            ClearAll();
        }

        private void rjButtonClose_Click(object sender, EventArgs e)
        {
            panelFiltration.Visible = false;
            panel2.Visible = true;
            string sql = "SELECT * FROM ViewSneakersInfo";
            ShowSneakers(sql);
        }

        public void ClearAll()
        {
            rjComboBoxSneakers.SelectedIndex = -1;
            rjComboBoxBrand.SelectedIndex = -1;
            rjComboBoxProdCountry.SelectedIndex = -1;
            rjComboBoxSport.SelectedIndex = -1;
            rjComboBoxGender.SelectedIndex = -1;
            rjComboBoxSize.SelectedIndex = -1;
            rjComboBoxColor.SelectedIndex = -1;
            rjTextBoxPrice1.Clear();
            rjTextBoxPrice2.Clear();
            string sql = "SELECT * FROM ViewSneakersInfo";
            ShowSneakers(sql);
        }

        private void rjButtonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void rjComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string sneakersFilter = "", brandFilter = "", CountryFilter = "", SportFilter = "", GenderFilter = "", SizeFilter = "", ColorFilter = "", PriceFilter = "";

            if (rjComboBoxSneakers.SelectedIndex != -1)
            {
                sneakersFilter = $"Sneakers_name = '{rjComboBoxSneakers.GetItemText(rjComboBoxSneakers.SelectedItem)}'";
            }

            if (rjComboBoxBrand.SelectedIndex != -1)
            {
                brandFilter = $"brand = '{rjComboBoxBrand.GetItemText(rjComboBoxBrand.SelectedItem)}'";
            }

            if (rjComboBoxProdCountry.SelectedIndex != -1)
            {
                CountryFilter = $"Producing_country = '{rjComboBoxProdCountry.GetItemText(rjComboBoxProdCountry.SelectedItem)}'";
            }

            if (rjComboBoxSport.SelectedIndex != -1)
            {
                SportFilter = $"name_sport = '{rjComboBoxSport.GetItemText(rjComboBoxSport.SelectedItem)}'";
            }

            if (rjComboBoxGender.SelectedIndex != -1)
            {
                GenderFilter = $"gender = '{rjComboBoxGender.GetItemText(rjComboBoxGender.SelectedItem)}'";
            }

            if (rjComboBoxSize.SelectedIndex != -1)
            {
                SizeFilter = $"size = '{rjComboBoxSize.GetItemText(rjComboBoxSize.SelectedItem)}'";
            }

            if (rjComboBoxColor.SelectedIndex != -1)
            {
                ColorFilter = $"color = '{rjComboBoxColor.GetItemText(rjComboBoxColor.SelectedItem)}'";
            }

            if (!string.IsNullOrEmpty(rjTextBoxPrice1.Texts) || !string.IsNullOrEmpty(rjTextBoxPrice2.Texts))
            {
                double price1 = 0, price2 = 0;
                string unitPrice1 = rjTextBoxPrice1.Texts.Replace(",", ".");
                string unitPrice2 = rjTextBoxPrice2.Texts.Replace(",", ".");
                bool validPrice1 = double.TryParse(unitPrice1, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out price1);
                bool validPrice2 = double.TryParse(unitPrice2, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out price2);

                if (validPrice1 && validPrice2)
                {
                    PriceFilter = $"unit_price BETWEEN '{unitPrice1}' AND '{unitPrice2}'";
                }
                else if (validPrice1)
                {
                    PriceFilter = $"unit_price >= '{unitPrice1}'";
                }
                else if (validPrice2)
                {
                    PriceFilter = $"unit_price <= '{unitPrice2}'";
                }
            }

            string sql = "SELECT * FROM ViewSneakersInfo WHERE ";
            List<string> filters = new List<string> { sneakersFilter, brandFilter, CountryFilter, SportFilter, GenderFilter, SizeFilter, ColorFilter, PriceFilter };
            filters.RemoveAll(string.IsNullOrEmpty); 
            if (filters.Count > 0)
            {
                sql += string.Join(" AND ", filters);
            }
            else
            {
                sql += "1=1";
            }

            ShowSneakers(sql);
        }

        private void rjTextBoxPrice1__TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void rjTextBoxPrice2__TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void rjTextBoxPrice1_Leave(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void rjTextBoxPrice2_Leave(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void rjTextBoxDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            RJTextBox rjTextBox = (RJTextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == ',' && rjTextBox.Texts.IndexOf(',') > -1)
                e.Handled = true;
        }

        private void rjButtonTotal_Click(object sender, EventArgs e)
        {
            if (mode == "sneakers")
            {
                TotalsSneakers f = new TotalsSneakers();
                f.ShowDialog();
            }
            if (mode == "chek")
            {
                TotalsChek f = new TotalsChek();
                f.ShowDialog();
            }
        }

        private void rjButtonReport_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            pictureBox2.Visible = false;
            labelHeader.Visible = false;
            rjButtonAdd.Visible = false;
            rjButtonDelete.Visible = false;
            rjTextBoxResearch.Visible = false;
            rjButtonResearch.Visible = false;
            rjButtonEdit.Visible = false;
            rjButtonFiltration.Visible = false;
            rjButtonTotal.Visible = false;
            panelReport.Visible = true;
            pictureBoxWelcome.Visible = false;
        }

        private void rjButtonSneakersInfoReport_Click(object sender, EventArgs e)
        {
            Reports.SneakersInfoReportForm f = new Reports.SneakersInfoReportForm();
            f.ShowDialog();
        }

        private void rjButtonTTNReport_Click(object sender, EventArgs e)
        {
            Reports.TTNReportForm f = new Reports.TTNReportForm();
            f.ShowDialog();
        }

        private void rjButtonChekReport_Click(object sender, EventArgs e)
        {
            Reports.ChekInfoReportForm f = new Reports.ChekInfoReportForm();
            f.ShowDialog();
        }

        private void rjButtonDiagramReport_Click(object sender, EventArgs e)
        {
            Reports.BrandSaleDiagramReportForm f = new Reports.BrandSaleDiagramReportForm();
            f.ShowDialog();
        }

        private void rjButtonAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanelForm f = new AdminPanelForm();
            this.Hide();
            f.ShowDialog();
        }

        private void rjButtonHelp_Click(object sender, EventArgs e)
        {
            string info = "Раздел \"Вид спорта\" - представляет собой раздел, предназначенный для отображения\n данных о видах спорта кроссовок\n\n" +
                          "Раздел \"Кроссовки\" - предназначен для отображения полной информации о кроссовках\n\n" +
                          "Раздел \"Поставщики\" - предназначен для отображения информации о поставщиках,\n которые поставляют кроссовки в магазин\n\n" +
                          "Раздел \"ТТН(накладная)\" - предназначен для отображения полной информации\n о поставках, осуществленных в магазин\n\n" +
                          "Раздел \"Покупки\" - предназначен для отображения полной информации\n о покупках, осуществленных в магазин покупателями\n\n" +
                          "Раздел \"Журнал учета\" - предназначен для отображения учета продаж,\n в котором есть количество поставленных и проданных кроссовок и их остаток.\n\n" +
                          "Раздел \"Отчеты\" - предоставляет возможность просмотреть интересующую информацию\n и распечатать\n\n" +
                          "Раздел \"Панель админа\" - предоставляет возможность управлять пользователями\n базы данных, создавать резервные копии и восстановить их";
            HelpForm f = new HelpForm(info);
            f.ShowDialog();
        }
    }
}
