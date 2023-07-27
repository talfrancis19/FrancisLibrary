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
using FrancisLibrary.Core.Services;
namespace FrancisLibrary
{
    /// <summary>
    /// Interaction logic for MemberPage.xaml
    /// </summary>
    public partial class MemberPage : Window
    {
        public MemberPage()
        {
            InitializeComponent();
            listViewItems.ItemsSource = ItemService.items;
            listViewRentedItems.ItemsSource = ItemService.rentedItems;
        }
        private async Task BackToWelcomePage()
        {
            MainWindow mainWindow = new MainWindow();
            await Task.Delay(0500);
            mainWindow.Show();
            Close();
        }
        private async Task RentItemWindow()
        {
            RentItemWindow rentItemWindow = new RentItemWindow();
            await Task.Delay(0500);
            rentItemWindow.Show();
            
        }
        private async Task ReturnItemWindow()
        {
            ReturnItemWindow returnItemWindow= new ReturnItemWindow();
            await Task.Delay(500);
            returnItemWindow.Show();
        }
        private async void backToWelcomePage_Click(object sender, RoutedEventArgs e)
        {
            await BackToWelcomePage();
        }

        private async void RentItemWindow_Click(object sender, RoutedEventArgs e)
        {
            await RentItemWindow();
        }

        private async void ReturnItemWindow_Click(object sender, RoutedEventArgs e)
        {
            await ReturnItemWindow();
        }
    }
}
