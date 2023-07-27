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
using System.Windows.Shapes;

namespace FrancisLibrary
{
    /// <summary>
    /// Interaction logic for LibraryOptionPage.xaml
    /// </summary>
    public partial class LibraryOptionPage : Window
    {
        public LibraryOptionPage()
        {
            InitializeComponent();
        }

        private async void enterLibrarianPage_Click(object sender, RoutedEventArgs e)
        {
            LibrarianMainPage librarianMainPage = new LibrarianMainPage();
            await Task.Delay(0500);
            librarianMainPage.Show();
            Close();
        }

        private async void manageItemPage_Click(object sender, RoutedEventArgs e)
        {
            ManageItemsPage manageItemsPage = new ManageItemsPage();
            await Task.Delay(0500);
            manageItemsPage.Show();
            Close();

        }

        private async void backToWelcomePage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main= new MainWindow();
            await Task.Delay(0500);
            main.Show();
            Close();
        
        }

        private async void DailyReportWindow_Click(object sender, RoutedEventArgs e)
        {
            DailyReportWindow dailyReportWindow = new DailyReportWindow();
            await Task.Delay(0500);
            dailyReportWindow.Show();
            Close();
            
        }
    }
}
