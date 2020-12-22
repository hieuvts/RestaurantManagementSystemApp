using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using DTO;
using System.Data.SqlClient;
using Dapper;

namespace DAL
{
    public class banAn_DAL
    {
        private static banAn_DAL instance;
        public static banAn_DAL Instance
        {
            get { if (instance == null) instance = new banAn_DAL(); return banAn_DAL.instance; }

            private set { banAn_DAL.instance = value; }
        }
        public List<DTO_banAn> GET()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                return connection.Query<DTO_banAn>($"select * from banAn").AsList();
            }
        }
    }
}
