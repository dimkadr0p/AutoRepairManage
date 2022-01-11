using System.Data;
using System.Data.SqlClient;

namespace AdminAPP.Models
{
     public class Company
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }

        public static Company getCompanyByID(SqlConnection connection, int id)
        {
            Company company = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "getCompanyByID";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@company_id", SqlDbType.Int).Value = id;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())
                        {
                            company = new Company
                            {
                                ID = (int)reader["id"],
                                Title = reader["title"] as string,
                                Location = reader["location"] as string,
                                Phone = reader["phone"] as string,
                            };
                        }
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return company;
        }
        public override string ToString()
        {
            return this.Title;
        }
    }
}
