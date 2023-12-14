using System;

namespace Airlines_Тепляков.Classes
{
    public class TicketClass
    {
        public int price { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public DateTime time_start { get; set; }
        public DateTime time_end { get; set;}

        public TicketClass() { }

        public TicketClass(int price, string from, string to, DateTime time_start, DateTime time_end)
        {
            this.price = price;
            this.from = from;
            this.to = to;
            this.time_start = time_start;
            this.time_end = time_end;
        }
    }
}
