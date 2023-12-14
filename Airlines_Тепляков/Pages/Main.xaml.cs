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
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow.mainWindow.Close();
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            string date_text = date.Text; 
            string date_text_back = date_back.Text;
            if (date.Text == "" && date_back.Text == "")
                MainWindow.mainWindow.OpenPages(new Pages.Ticket(from.Text, to.Text, "", ""));
            if (date.Text != "" && date_back.Text == "")
                MainWindow.mainWindow.OpenPages(new Pages.Ticket(from.Text, to.Text, date_text, "")); 
            if (date.Text == "" && date_back.Text != "")
                MainWindow.mainWindow.OpenPages(new Pages.Ticket(from.Text, to.Text, "", date_text_back));
            if (date.Text != "" && date_back.Text != "")
                MainWindow.mainWindow.OpenPages(new Pages.Ticket(from.Text, to.Text, date_text, date_text_back));
        }
    }
}
