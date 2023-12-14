using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Airlines_Тепляков.Classes
{
    public class TicketContext : TicketClass
    {
        public TicketContext(int price, string from, string to, DateTime time_start, DateTime time_end, DateTime time_start_back, DateTime time_end_back) : base(price, from, to, time_start, time_end, time_start_back, time_end_back) { }
        public static List<TicketContext> AllTickets()
        {
            List<TicketContext> allTickets = new List<TicketContext>();
            MySqlConnection connection = WorkingBD.Connection.OpenConnection();
            MySqlDataReader ticketQuery = WorkingBD.Connection.Query("SELECT * FROM Airlines.Tickets", connection);
            while (ticketQuery.Read())
            {
                allTickets.Add(new TicketContext(
                    ticketQuery.GetInt32(3),
                    ticketQuery.GetString(1),
                    ticketQuery.GetString(2),
                    ticketQuery.GetDateTime(4),
                    ticketQuery.GetDateTime(5),
                    ticketQuery.GetDateTime(6),
                    ticketQuery.GetDateTime(7)));
            }
            connection.Close();
            MySqlConnection.ClearPool(connection);
            return allTickets;
        }
    }
}
