using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_chiTietBanAn
    {
        public DataSet GetData(int idbanan)
        {
            DataSet data = new DataSet();
            string Select_all = "select monAn.tenMonAn, monAn.danhmuc,monAn.giaMonAn,chiTietBanAn.soLuong from chiTietBanAn, monAn where chiTietBanAn.idmonAn = monAn.IDmonAn and chiTietBanAn.idbanAn = @idbanan";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand cmdInsert = new SqlCommand(Select_all, connection);
                cmdInsert.Parameters.Add("@idbanan", SqlDbType.Int).Value = idbanan;
                SqlDataAdapter adapter = new SqlDataAdapter(cmdInsert);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
