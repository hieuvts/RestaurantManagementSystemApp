using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ConnectionString
    {
        public static string connectionString = "Data Source=" + Dns.GetHostName() + ";Initial Catalog=RMS;Integrated Security=True";
        public SqlConnection GetConnect()
        {
            return new SqlConnection(connectionString);
        }
    }
}
