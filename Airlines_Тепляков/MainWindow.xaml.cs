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

namespace Airlines_Тепляков
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow mainWindow;
        public MainWindow()
        {
            InitializeComponent();
            mainWindow = this;
            OpenPages(pages.main);
        }

        public enum pages
        {
            main, ticket
        }

        public void OpenPages(pages _pages)
        {
            if (_pages == pages.main)
                frame.Navigate(new Pages.Main());
            if (_pages == pages.ticket)
                frame.Navigate(new Pages.Ticket());
        }
    }
}
