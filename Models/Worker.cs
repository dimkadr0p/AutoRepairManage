using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AdminAPP.Models
{
    public class Worker
    {
        private static readonly string _selectWorkerByIDCommand = @"SELECT * FROM [dbo].[Worker] WHERE [id] = @worker_id";
        private static readonly string _selectAllWorkerCommand = @"SELECT * FROM [dbo].[Worker]";
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public int PostID { get; set; }
        public int CompanyID { get; set; }
        public string Phone { get; set; }


        public static Worker getWorkerByID(SqlConnection connection, int id)
        {
            Worker worker = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _selectWorkerByIDCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@worker_id", SqlDbType.Int).Value = id;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())
                        {
                            worker = new Worker
                            {
                                ID = (int)reader["id"],
                                Name = reader["name"] as string,
                                LastName = reader["last_name"] as string,
                                SecondName = reader["second_name"] as string,
                                PostID = (int)reader["post_id"],
                                CompanyID = (int)reader["company_id"],
                                Phone = reader["phone"] as string
                            };
                        }
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return worker;
        }

        public static List<Worker> getAllWorker(SqlConnection connection)
        {
            List<Worker> worker = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _selectAllWorkerCommand;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) // если есть данные
                    {
                        worker = new List<Worker>();
                        while (reader.Read())
                        {
                            worker.Add(new Worker
                            {
                                ID = (int)reader["id"],
                                Name = reader["name"] as string,
                                LastName = reader["last_name"] as string,
                                SecondName = reader["second_name"] as string,
                                PostID = (int)reader["post_id"],
                                CompanyID = (int)reader["company_id"],
                                Phone = reader["phone"] as string
                            });
                        }
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return worker;
        }
    }
}
