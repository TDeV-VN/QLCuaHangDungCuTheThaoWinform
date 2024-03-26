using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatabaseAccess
    {
        // Tạo kết nối đến cơ sở dữ liệu
        public static SqlConnection GetConnection()
        {
            string connectionString = @"";
            return new SqlConnection(connectionString);
        }
    }
}
