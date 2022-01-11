using System;
using System.Data;
using System.Data.SqlClient;

namespace AdminAPP.Models
{
    public class User
    {
        int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int WorkerID { get; set; }

        public static User getPermissionInfoUser(SqlConnection connection, string login)
        {
            User user = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "getPermissionInfoUser";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@login", SqlDbType.Char, 50).Value = login;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())
                        {
                            user = new User
                            {
                                ID = (int)reader["id"],
                                Username = reader["username"] as string,
                                Password = reader["password"] as string,
                                WorkerID = (int)reader["worker_id"]

                            };
                        }
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return user;
        }
    }
}
