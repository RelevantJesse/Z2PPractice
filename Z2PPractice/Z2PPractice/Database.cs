using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Z2PPractice
{
    static class Database
    {
        private static string _connectionString = "Server=localhost;Database=Test;Trusted_Connection=True;";
        public static string GetAllUsers()
        {
            StringBuilder sb = new StringBuilder();
            using(SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT u.id, u.first_name, c.name FROM Users u JOIN Companies c ON c.id = u.company_id", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    sb.AppendLine($"{reader.GetInt32(0)}, {reader.GetString(1)}, {reader.GetString(2)}");
                }
            }

            return sb.ToString();
        }
    }
}
