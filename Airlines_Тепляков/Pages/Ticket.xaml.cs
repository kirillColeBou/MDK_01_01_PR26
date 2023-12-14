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
        public Ticket(string From, string To)
        {
            InitializeComponent();
            AllTickets = TicketContext.AllTickets().FindAll(x => (x.from == From && To == "") || (From == "" && x.to == To) || (x.from == From && x.to == To));
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
