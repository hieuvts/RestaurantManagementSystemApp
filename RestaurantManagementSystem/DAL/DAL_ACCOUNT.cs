using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;
using Dapper;

namespace DAL
{
    public class DAL_ACCOUNT
    {
        public DataSet GetData()
        {
            DataSet data = new DataSet();
            string Select_all = "SELECT * FROM ACCOUNT";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Select_all, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public List<DTO_ACCOUNT> GET()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                return connection.Query<DTO_ACCOUNT>($"select * from PRODUCT").AsList();
            }
        }

        public void DeleteData(string query)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Execute(query);
            }
        }
        public object ExecuteQr(string query)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                DataTable data = new DataTable();

                SqlCommand sc = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(sc);
                adapter.Fill(data);
                object id = sc.ExecuteScalar();
                connection.Close();
                return id;
            }
        }

        public void InsertData(string query)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Execute(query);
            }
        }

        public void UpdateData(string query)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Execute(query);
            }
        }

        public DataSet LoadData(string query)
        {
            DataSet data = new DataSet();

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
