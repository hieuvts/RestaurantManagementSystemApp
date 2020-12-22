﻿using System;
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
        public DataSet GetDataByIDbanAN(int idbanan)
        {
            DataSet data = new DataSet();
            string Select_all = "select * from banAn where IDbanAn=@idbanan";
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
        public DataSet GetTrangThai()
        {
            DataSet data = new DataSet();
            string Select_all = "SELECT distinct tinhTrang FROM banAn";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Select_all, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
