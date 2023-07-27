using FrancisLibrary.Core.Services;
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
    /// Interaction logic for DailyReportWindow.xaml
    /// </summary>
    public partial class DailyReportWindow : Window
    {
        public static int counterItems = ItemService.items.Count;
        public DailyReportWindow()
        {
            InitializeComponent();
            listViewItems.ItemsSource = ItemService.items;
            listViewRentedItems.ItemsSource = ItemService.rentedItems;
        }
        private async Task BackToLibraryOptionsPage()
        {
            LibraryOptionPage libraryOptionPage = new LibraryOptionPage();
            await Task.Delay(0700);
            libraryOptionPage.Show();
            Close();
        }
        private void allAvailableItemsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private async void backToLibraryOptionsPage_Click(object sender, RoutedEventArgs e)
        {
            await BackToLibraryOptionsPage();
        }

        

    }
}
