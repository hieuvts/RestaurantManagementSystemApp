using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;
using Dapper;
using System.Windows.Forms;
using System;

namespace DAL
{
    public class DAL_nguyenLieu
    {
        public DataSet GetData()
        {
            DataSet data = new DataSet();
            string Select_all = "select * from nguyenLieu";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Select_all, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public void Delete(int idnguyenlieu)
        {
            string Delete_from = "DELETE FROM nguyenLieu WHERE IDnguyenLieu=@idnguyenlieu";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(Delete_from, connection);
                    cmdInsert.Parameters.Add("@idnguyenlieu", SqlDbType.Int).Value = idnguyenlieu;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Xoá thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xoá thông tin , xin vui lòng thử lại!", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        public void InsertData(string tennguyenlieu,int soluong)
        {
            string Insert_into = "INSERT INTO nguyenLieu VALUES (@tennguyenlieu,@soluong)";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("SET DATEFORMAT DMY", connection);
                    cmdSetDateFormat.ExecuteNonQuery();
                    SqlCommand cmdInsert = new SqlCommand(Insert_into, connection);
                    cmdInsert.Parameters.Add("@tennguyenlieu", SqlDbType.NVarChar).Value = tennguyenlieu;
                    cmdInsert.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
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

        public void UpdateData(int IDnguyenLieu, string tenguyenlieu,int soluong)
        {
            string Update_set = "UPDATE nguyenLieu SET tenNguyenLieu=@tenNguyenlieu, soLuong=@soluong where IDnguyenLieu=@idnguyenlieu ";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("SET DATEFORMAT DMY", connection);
                    cmdSetDateFormat.ExecuteNonQuery();
                    SqlCommand cmdInsert = new SqlCommand(Update_set, connection);
                    cmdInsert.Parameters.Add("@idnguyenlieu", SqlDbType.Int).Value = IDnguyenLieu;
                    cmdInsert.Parameters.Add("@tennguyenlieu", SqlDbType.NVarChar).Value = tenguyenlieu;
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
    }
}
