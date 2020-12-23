using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_hoaDon
    {
        public DataSet GetData()
        {
            DataSet data = new DataSet();
            string Select_all = "select * from hoaDon";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Select_all, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public void InsertData(float giatri, DateTime ngaylaphoadon)
        {
            string Insert_into = "INSERT INTO hoaDon VALUES (@giatrihoadon,@ngaylaphoadon)";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("SET DATEFORMAT DMY", connection);
                    cmdSetDateFormat.ExecuteNonQuery();
                    SqlCommand cmdInsert = new SqlCommand(Insert_into, connection);
                    cmdInsert.Parameters.Add("@giatrihoadon", SqlDbType.Float).Value = giatri;
                    cmdInsert.Parameters.Add("@ngaylaphoadon", SqlDbType.DateTime).Value = ngaylaphoadon;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Thanh toán thành công");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể thanh toán!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
