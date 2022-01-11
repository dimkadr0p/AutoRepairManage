using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AdminAPP.Models
{
    public class Auto
    {
        public int ID { get; set; }
        public int modelID { get; set; }
        string modelName;
        public string ModelName
        {
                get { return modelName; }
                set { modelName = value.Trim(); }
        }
        string brandName;
        public string BrandName
        {
            get { return brandName; }
            set { brandName = value.Trim(); }
        }
        public DateTime Date { get; set; }
        public string VIN { get; set; }


        public static Auto getAutoByID(SqlConnection connection, int id)
        {
            Auto auto = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "getAutoByID";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@auto_id", SqlDbType.Int).Value = id;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())
                        {
                            auto = new Auto
                            {
                                ID = (int)reader["auto_id"],
                                modelID = (int)reader["model_id"],
                                ModelName = reader["model_name"] as string,
                                BrandName = reader["brand_name"] as string,
                                Date = Convert.ToDateTime(reader["buy_date"]),
                                VIN = reader["vin"] as string,
                            };
                        }
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return auto;
        }

        public static List<Auto> selectAllAutoes(SqlConnection connection)
        {
            List<Auto> autoes = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "selectAllAutoes";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) // если есть данные
                    {
                        autoes = new List<Auto>();
                        while (reader.Read())
                        {
                            autoes.Add(new Auto
                            {
                                ID = (int)reader["auto_id"],
                                modelID = (int)reader["model_id"],
                                ModelName = reader["model_name"] as string,
                                BrandName = reader["brand_name"] as string,
                                Date = Convert.ToDateTime(reader["buy_date"]),
                                VIN = reader["vin"] as string,
                            });
                        }
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return autoes;
        }

        public override string ToString()
        {
            return $"{brandName} {modelName}";
        }
    }
}
