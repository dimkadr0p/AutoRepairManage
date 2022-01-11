using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AdminAPP.Models
{
    public class ServiceOrder
    {
        public int ID { get; set; }
        public int orderID { get; set; }
        public int serviceID { get; set; }
        public int workerID { get; set; }
        public decimal Price { get; set; }

        public static List<ServiceOrder> getServiceByOrder(SqlConnection connection, int order_id)
        {
            List<ServiceOrder> serviceOrder = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "getServiceByOrder";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@order_id", SqlDbType.Char, 50).Value = order_id;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) // если есть данные
                    {
                        serviceOrder = new List<ServiceOrder>();
                        while (reader.Read())
                        {
                            serviceOrder.Add(new ServiceOrder
                            {
                                ID = (int)reader["id"],
                                orderID = (int)reader["order_id"],
                                serviceID = (int)reader["service_id"],
                                Price = (decimal)reader["price"],
                                workerID = (int)reader["worker_id"]
                            });
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
        public static void insertServiceCommand(SqlConnection connection, ServiceOrder serviceOrder)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "insertServiceCommand";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@order_id", SqlDbType.Int).Value = serviceOrder.orderID;
                    command.Parameters.Add("@service_id", SqlDbType.Int).Value = serviceOrder.serviceID;
                    command.Parameters.Add("@worker_id", SqlDbType.Int).Value = serviceOrder.workerID;
                    command.Parameters.Add("@price", SqlDbType.Int).Value = serviceOrder.Price;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }
        public static void updateServiceCommand(SqlConnection connection, ServiceOrder serviceOrder)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "updateServiceCommand";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@order_id", SqlDbType.Int).Value = serviceOrder.orderID;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = serviceOrder.ID;
                    command.Parameters.Add("@service_id", SqlDbType.Int).Value = serviceOrder.serviceID;
                    command.Parameters.Add("@worker_id", SqlDbType.Int).Value = serviceOrder.workerID;
                    command.Parameters.Add("@price", SqlDbType.Int).Value = serviceOrder.Price;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }
        public static void deleteServiceOrderCommand(SqlConnection connection, ServiceOrder serviceOrder)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "deleteServiceOrderCommand";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = serviceOrder.ID;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }
    }
}
