using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseSneakers
{
    public class Database
    {
        private readonly string connectionString = @"Data Source=DESKTOP-K260DFM; Initial Catalog = Sneakers;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
