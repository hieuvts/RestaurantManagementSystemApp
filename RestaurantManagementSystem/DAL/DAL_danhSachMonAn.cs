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
   public class DAL_danhSachMonAn
    {
        public DataSet GetData()
        {
            DataSet data = new DataSet();
            string Select_all = "select idMonan,tenMonAn, danhmuc, giaMonAn from monAn";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Select_all, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public DataSet GetDanhmuc()
        {
            DataSet data = new DataSet();
            string Select_all = "select distinct danhmuc from monAn";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Select_all, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public DataSet GetMonAnByDanhMuc(string danhmuc)
        {
            DataSet data = new DataSet();
            string Select_all = "select * from monAn where danhmuc like @danhmuc";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(Select_all, connection);
                    cmdInsert.Parameters.Add("@danhmuc", SqlDbType.NVarChar).Value = danhmuc;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmdInsert);
                    adapter.Fill(data);
                    connection.Close();
                }
                catch(Exception)
                {

                }
            }
            return data;
        }
        public void Delete(int idmonan)
        {
            string Delete_from = "DELETE FROM monAn WHERE IDmonAn=@idmonan";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(Delete_from, connection);
                    cmdInsert.Parameters.Add("@idmonan", SqlDbType.Int).Value = idmonan;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Xoá thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xoá thông tin , xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        public void InsertData(string tenmonan, string danhmuc, float giamoan)
        {
            string Insert_into = "INSERT INTO monAn VALUES (@tenmonan,@danhmuc, @giamonan)";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("SET DATEFORMAT DMY", connection);
                    cmdSetDateFormat.ExecuteNonQuery();
                    SqlCommand cmdInsert = new SqlCommand(Insert_into, connection);
                    cmdInsert.Parameters.Add("@tenmonan", SqlDbType.NVarChar).Value = tenmonan;
                    cmdInsert.Parameters.Add("@danhmuc", SqlDbType.NVarChar).Value = danhmuc;
                    cmdInsert.Parameters.Add("@giamonan", SqlDbType.Float).Value = giamoan;
                    
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể thêm thông tin cơ sở vật chất, xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void UpdateData(int idmonan, string tenmonan,string danhmuc, float giamoan)
        {
            string Update_set = "UPDATE monAn SET tenMonAn=@tenmonan," +
                "danhmuc=@danhmuc," +
                "giaMonAn=@giamonan WHERE IDmonAn=@idmonan";
            
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("SET DATEFORMAT DMY", connection);
                    cmdSetDateFormat.ExecuteNonQuery();
                    SqlCommand cmdInsert = new SqlCommand(Update_set, connection);
                    cmdInsert.Parameters.Add("@idmonan", SqlDbType.Int).Value = idmonan;
                    cmdInsert.Parameters.Add("@tenmonan", SqlDbType.NVarChar).Value = tenmonan;
                    cmdInsert.Parameters.Add("@danhmuc", SqlDbType.NVarChar).Value = danhmuc;
                    cmdInsert.Parameters.Add("@giamonan", SqlDbType.Float).Value = giamoan;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Sửa dữ liệu thành công!");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
    }
}
