﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines_Тепляков.Classes
{
    public class TicketClass
    {
        public string price { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string time_start { get; set; }
        public string time_way { get; set;}

        public TicketClass(string price, string from, string to, string time_start, string time_way)
        {
            this.price = price;
            this.from = from;
            this.to = to;
            this.time_start = time_start;
            this.time_way = time_way;
        }
    }
}
