using Airlines_Тепляков.Classes;
using Airlines_Тепляков.Pages;
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
        public List<TicketContext> AllTickets_date;
        public List<TicketContext> AllTickets_date_back;
        public List<TicketContext> AllTickets_back;

        public Ticket(string From, string To, string Date, string Date_Back)
        {
            InitializeComponent();
            DateTime date = String.IsNullOrEmpty(Date) ? DateTime.MinValue : Convert.ToDateTime(Date);
            DateTime dateBack = String.IsNullOrEmpty(Date_Back) ? DateTime.MinValue : Convert.ToDateTime(Date_Back);
            AllTickets = TicketContext.AllTickets().FindAll(x => (x.from == From && x.to == "") || (x.to == To && x.from == "") || (x.from == From && x.to == To) || (x.from == To && x.to == From));
            AllTickets_date = AllTickets.FindAll(x => x.time_start.ToString("MM.dd.yyyy") == date.ToString("MM.dd.yyyy"));
            AllTickets_back = AllTickets.FindAll(x => (x.to == From && x.from == To) || To == "");
            AllTickets_date_back = AllTickets_back.FindAll(x => x.time_end.ToString("MM.dd.yyyy") == dateBack.ToString("MM.dd.yyyy"));
            CreateUI();
        }

        public void CreateUI()
        {
            parrent.Children.Clear();
            foreach (TicketContext item_1 in AllTickets_date) 
            {
                parrent.Children.Add(new Elements.Items(item_1));
                foreach(TicketContext item_2 in AllTickets_date_back)
                {
                    parrent.Children.Add(new Elements.Items(item_2));
                }
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow.mainWindow.OpenPages(new Pages.Main());
        }
    }
}