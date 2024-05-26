using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class Connection
    {
        public static SqlConnection getConnection()
        {
            string query = "Data Source=ADMIN;Initial Catalog=firstDB;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(query);
            return conn;
        }
    }
}
