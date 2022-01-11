using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AdminAPP.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public int AutoID { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public int CompanyID { get; set; }

        public static void deleteOrderByID(SqlConnection connection, int order_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "deleteOrderByID";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@order_id", SqlDbType.Int).Value = order_id;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static Order getOrderByID(SqlConnection connection, int order_id)
        {
            Order order = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "getOrderByID";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@order_id", SqlDbType.Int).Value = order_id;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())
                        {
                            order = new Order
                            {
                                ID = (int)reader["id"],
                                ClientID = (int)reader["client_id"],
                                AutoID = (int)reader["auto_id"],
                                CompanyID = (int)reader["company_id"],
                                Date = Convert.ToDateTime(reader["date"]),
                                Status = Convert.ToBoolean(reader["status"]),
                            };
                        }
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return order;
        }

        public static int insertOrderCommand(SqlConnection connection, Order order)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "insertOrderCommand";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@client_id", SqlDbType.Int).Value = order.ClientID;
                    command.Parameters.Add("@auto_id", SqlDbType.Int).Value = order.AutoID;
                    command.Parameters.Add("@NewId", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@date", SqlDbType.DateTime).Value = order.Date;
                    command.Parameters.Add("@status", SqlDbType.Bit).Value = order.Status;
                    command.Parameters.Add("@company_id", SqlDbType.Int).Value = order.CompanyID;
                    connection.Open();
                    command.ExecuteNonQuery();
                    return Convert.ToInt32(command.Parameters["@NewId"].Value);
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void updateOrderCommand(SqlConnection connection, Order order)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "updateOrderCommand";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@order_id", SqlDbType.Int).Value = order.ID;
                    command.Parameters.Add("@client_id", SqlDbType.Int).Value = order.ClientID;
                    command.Parameters.Add("@auto_id", SqlDbType.Int).Value = order.AutoID;
                    command.Parameters.Add("@date", SqlDbType.DateTime).Value = order.Date;
                    command.Parameters.Add("@status", SqlDbType.Bit).Value = order.Status;
                    command.Parameters.Add("@company_id", SqlDbType.Int).Value = order.CompanyID;
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
