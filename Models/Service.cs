using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminAPP.Models
{
    public class Service
    {
        private static readonly string _getTitleByID = @"SELECT * FROM [dbo].[Service] WHERE [id] = @service_id";
        private static readonly string _selectAllService = @"SELECT * FROM [dbo].[Service]";
        public string Name { get; set; }
        public int ID { get; set; }

        public static Service getServiceByID(SqlConnection connection, int service_id)
        {
            Service serviceOrder = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _getTitleByID;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@service_id", SqlDbType.Int).Value = service_id;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())
                        {
                            serviceOrder = new Service
                            {
                                ID = (int)reader["id"],
                                Name = reader["name"] as string
                            };
                        }
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return serviceOrder;
        }

        public static List<Service> selectAllService(SqlConnection connection)
        {
            List<Service> services = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _selectAllService;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) // если есть данные
                    {
                        services = new List<Service>();
                        while (reader.Read())
                        {
                            services.Add(new Service
                            {
                                ID = (int)reader["id"],
                                Name = reader["name"] as string
                            });
                        }
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return services;
        }

    }
}
