using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingBD
{
    public class Connection
    {
        static readonly string connection = "server=localhost;database=Airlines;uid=root;";
        public static MySqlConnection OpenConnection()
        {
            MySqlConnection Connection = new MySqlConnection(connection);
            Connection.Open();

            return Connection;
        }

        public static MySqlDataReader Query(string Sql, MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand(Sql, connection);
            return command.ExecuteReader();
        }

        public static void CloseConnection(MySqlConnection connection)
        {
            connection.Close();
            MySqlConnection.ClearPool(connection);
        }
    }
}
