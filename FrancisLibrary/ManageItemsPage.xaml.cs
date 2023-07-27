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
    /// Interaction logic for ManageItemsPage.xaml
    /// </summary>
    public partial class ManageItemsPage : Window
    { 

        public ManageItemsPage()
        {
            InitializeComponent();
            listViewItems.ItemsSource = ItemService.items;
        }
        private async Task BackToLibraryOptionsPage()
        {
            LibraryOptionPage libraryOptionPage = new LibraryOptionPage();
            await Task.Delay(0500);
            libraryOptionPage.Show();
            Close();
        }
        private async Task AddItemWindow()
        {
            AddItemWindow addItem= new AddItemWindow();
            await Task.Delay(500);
            addItem.Show();
            
        }
        private async Task RemoveItemWindow()
        {
            RemoveItemWindow addItem = new RemoveItemWindow();
            await Task.Delay(500);
            addItem.Show();

        }
        private async Task EditItemWindow()
        {
            EditItemWindow EditItemWindow = new EditItemWindow();
            await Task.Delay(0500);
            EditItemWindow.Show();
           
        }
        private async void backToLibraryOptionsPage_Click(object sender, RoutedEventArgs e)
        {
            await BackToLibraryOptionsPage();
        }

        private async void AddItemWindow_Click(object sender, RoutedEventArgs e)
        {
            await AddItemWindow();
        }
        private async void removeItemWindow_Click(object sender, RoutedEventArgs e)
        {
            await RemoveItemWindow();

        }
        private async void EditItemsWindow_Click(object sender, RoutedEventArgs e)
        {
           await EditItemWindow();
        }
    }
}
