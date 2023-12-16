using Airlines_Тепляков.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Airlines_Тепляков.Elements
{
    /// <summary>
    /// Логика взаимодействия для Items.xaml
    /// </summary>
    public partial class Items : UserControl
    {
        public Items(TicketContext item)
        {
            InitializeComponent();
            IPrice.Content = item.price + " ₽";
            fromTime.Content = item.time_start.ToString("HH:mm");
            fromDate.Content = item.time_start.ToString("MM.dd.yyyy");
            toTime.Content = item.time_end.ToString("HH:mm");
            toDate.Content = item.time_end.ToString("MM.dd.yyyy");
            IFrom.Content = item.from + "-" + item.to;
            ITo.Content = item.from + "-" + item.to;
            TimeSpan tS = item.time_end.Subtract(item.time_start);
            string hours = tS.Hours.ToString();
            string minute = tS.Minutes.ToString();
            if (tS.Hours < 10) hours = "0" + hours;
            if (tS.Minutes < 10) minute = "0" + minute;
            time_way.Content = "В пути (туда): " + hours + "ч. " + minute + "мин.";
        }
    }
}
