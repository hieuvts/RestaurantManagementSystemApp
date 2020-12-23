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
    public class DAL_chiTietBanAn
    {
        public DataSet GetData(int idbanan)
        {
            DataSet data = new DataSet();
            string Select_all = "select chiTietBanAn.IDbanAn, chiTietBanAn.IDMonAn,monAn.tenMonAn, monAn.danhmuc,monAn.giaMonAn,chiTietBanAn.soLuong from chiTietBanAn, monAn where chiTietBanAn.idmonAn = monAn.IDmonAn and chiTietBanAn.idbanAn = @idbanan";
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
        public void InsertData(int idbanan,int idmonan,int soluong)
        {
            string Insert_into = "insert into chiTietBanAn values (@idbanan,@idmonan,@soluong)";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                //try
                //{
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("SET DATEFORMAT DMY", connection);
                    cmdSetDateFormat.ExecuteNonQuery();
                    SqlCommand cmdInsert = new SqlCommand(Insert_into, connection);
                    cmdInsert.Parameters.Add("@idbanan", SqlDbType.Int).Value = idbanan;
                    cmdInsert.Parameters.Add("@idmonan", SqlDbType.Int).Value = idmonan;
                    cmdInsert.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Thêm dữ liệu thành công!");
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Không thể thêm thông tin cơ sở vật chất, xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }
        public void UpdateCountWhenExist(int idbanan, int idmonan,int soluong)
        {
            string Update_set = "UPDATE chiTietBanAn SET soLuong+=@soluong WHERE IDmonAn=@idmonan and IDbanAn=@idbanan";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("SET DATEFORMAT DMY", connection);
                    cmdSetDateFormat.ExecuteNonQuery();
                    SqlCommand cmdInsert = new SqlCommand(Update_set, connection);
                    cmdInsert.Parameters.Add("@idmonan", SqlDbType.Int).Value = idmonan;
                    cmdInsert.Parameters.Add("@idbanan", SqlDbType.Int).Value = idbanan;
                    cmdInsert.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Sửa dữ liệu thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể thay đổi thông tin , xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Delete(int idbanan,int idmonan)
        {
            string Delete_from = "DELETE FROM chiTietBanAn WHERE IDbanAn=@idbanan and IDmonAn=@idmonan";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(Delete_from, connection);
                    cmdInsert.Parameters.Add("@idmonan", SqlDbType.Int).Value = idmonan;
                    cmdInsert.Parameters.Add("@idbanan", SqlDbType.Int).Value = idbanan;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Xoá thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xoá thông tin , xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        public void DeleteAll(int idbanan)
        {
            string Delete_from = "DELETE FROM chiTietBanAn WHERE IDbanAn=@idbanan";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(Delete_from, connection);
                    
                    cmdInsert.Parameters.Add("@idbanan", SqlDbType.Int).Value = idbanan;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Thanh toán thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xoá thông tin , xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
