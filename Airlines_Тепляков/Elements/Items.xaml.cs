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
            fromTime.Content = "Вылет: " + item.time_start.ToString("HH:mm");
            fromTime_back.Content = "Вылет: " + item.time_start_back.ToString("HH:mm");
            IFrom_ITo.Content = item.from + "-" + item.to;
            fromDate.Content = item.time_start.ToString("MM.dd.yyyy");
            toTime.Content = "Прилет: " + item.time_end.ToString("HH:mm");
            toTime_back.Content = "Прилет: " + item.time_end_back.ToString("HH:mm");
            IFrom_ITo_back.Content = item.to + "-" + item.from;
            fromDate_back.Content = item.time_end_back.ToString("MM.dd.yyyy");
            TimeSpan tS = item.time_end.Subtract(item.time_start);
            TimeSpan tS_back = item.time_end_back.Subtract(item.time_start_back);
            string hours = tS.Hours.ToString();
            string minute = tS.Minutes.ToString();
            string hours_back = tS_back.Hours.ToString();
            string minute_back = tS_back.Minutes.ToString();
            if (tS.Hours < 10) hours = "0" + hours;
            if (tS.Minutes < 10) minute = "0" + minute;
            if (tS_back.Hours < 10) hours_back = "0" + hours_back;
            if (tS_back.Minutes < 10) minute_back = "0" + minute_back;
            time_way.Content = "В пути (туда): " + hours + "ч. " + minute + "мин.";
            time_way_back.Content = "В пути (обратно): " + hours_back + "ч. " + minute_back + "мин.";
        }
    }
}
