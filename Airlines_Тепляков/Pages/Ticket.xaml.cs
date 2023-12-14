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

namespace Airlines_Тепляков.Pages
{
    /// <summary>
    /// Логика взаимодействия для Ticket.xaml
    /// </summary>
    public partial class Ticket : Page
    {
        public List<TicketContext> AllTickets;
        public Ticket(string From, string To, string Date, string Date_Back)
        {
            InitializeComponent();
            DateTime date = String.IsNullOrEmpty(Date) ? DateTime.MinValue : Convert.ToDateTime(Date);
            DateTime dateBack = String.IsNullOrEmpty(Date_Back) ? DateTime.MinValue : Convert.ToDateTime(Date_Back);
            AllTickets = TicketContext.AllTickets().FindAll(x =>
                (x.from == From || String.IsNullOrEmpty(From)) &&
                (x.to == To || String.IsNullOrEmpty(To)) &&
                (x.time_start.Date == date.Date || date == DateTime.MinValue) &&
                (x.time_start_back.Date == dateBack.Date || dateBack == DateTime.MinValue)
            );
            CreateUI();
        }


        public void CreateUI()
        {
            parrent.Children.Clear();
            foreach (TicketContext item in AllTickets) 
            {
                parrent.Children.Add(new Elements.Items(item));
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow.mainWindow.OpenPages(new Pages.Main());
        }
    }
}
