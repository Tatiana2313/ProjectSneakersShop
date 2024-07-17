using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataBaseSneakers
{
    public static class DatabaseMethods
    {
        private static Database database = new Database();

        public static void fillComboBoxSport(RJComboBox comboBox)
        {
            try
            {
                string sql = "SELECT DISTINCT cod_kind_of_sport, name_sport FROM Kind_of_sport";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "sport_data");
                    comboBox.ValueMember = "cod_kind_of_sport";
                    comboBox.DisplayMember = "name_sport";
                    comboBox.DataSource = ds.Tables["sport_data"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void fillComboBoxSneakers(RJComboBox comboBox)
        {
            try
            {
                string sql = "SELECT DISTINCT cod_sneakers, Sneakers_name FROM Sneakers";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "sneakers_data");
                    comboBox.ValueMember = "cod_sneakers";
                    comboBox.DisplayMember = "Sneakers_name";
                    comboBox.DataSource = ds.Tables["sneakers_data"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void fillComboBoxProviver(RJComboBox comboBox)
        {
            try
            {
                string sql = "SELECT DISTINCT cod_provider, provider_name FROM Providerr";

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "provider_data");
                    comboBox.ValueMember = "cod_provider";
                    comboBox.DisplayMember = "provider_name";
                    comboBox.DataSource = ds.Tables["provider_data"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
