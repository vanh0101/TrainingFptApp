﻿using Microsoft.Data.SqlClient;

namespace TrainingFPTCo
{
    public class Database
    {
        public static string GetStrConnection()
        {
            string strConnection = @"Data Source=LAPTOP-NGJ25SUJ\VIETANH;Initial Catalog=Training;Integrated Security=True;Trust Server Certificate=True";
            return strConnection;
        }

        public static SqlConnection GetSqlConnection() 
        {
            string strConnection = Database.GetStrConnection();
            SqlConnection conn = new SqlConnection(strConnection);
            return conn;
        }
    }
}
