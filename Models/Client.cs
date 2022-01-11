using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AdminAPP.Models
{
    public class Client
    {

        public int ID { get; set; }
        string name;
        public string Name 
        {
            get { return name; }
            set { name = value.Trim(); }
        }
        string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value.Trim(); }
        }
        string secondName;
        public string SecondName
        {
            get { return secondName; }
            set { secondName = value.Trim(); }
        }
        string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value.Trim(); }
        }
        string email;
        public string Email
        {
            get { return email; }
            set { email = value.Trim(); }
        }

        public static Client getClientByID(SqlConnection connection, int id)
        {
            Client client = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "getClientByID";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@user_id", SqlDbType.Int).Value = id;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())
                        {
                            client = new Client
                            {
                                ID = (int)reader["id"],
                                Name = reader["name"] as string,
                                LastName = reader["last_name"] as string,
                                SecondName = reader["second_name"] as string,
                                Phone = reader["phone"] as string,
                                Email = reader["email"] as string,
                            };
                        }
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return client;
        }

        public static List<Client> selectAllClient(SqlConnection connection)
        {
            List<Client> clients = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "selectAllClient";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) // если есть данные
                    {
                        clients = new List<Client>();
                        while (reader.Read())
                        {
                            clients.Add(new Client
                            {
                                ID = (int)reader["id"],
                                Name = reader["name"] as string,
                                LastName = reader["last_name"] as string,
                                SecondName = reader["second_name"] as string,
                                Phone = reader["phone"] as string,
                                Email = reader["email"] as string,
                            });
                        }
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return clients;
        }
        public override string ToString()
        {
            return $"{Name} {LastName}";
        }
    }
}
