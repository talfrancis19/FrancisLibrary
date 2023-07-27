using FrancisLibrary.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for ReturnItemWindow.xaml
    /// </summary>
    public partial class ReturnItemWindow : Window
    {
        public ReturnItemWindow()
        {
            InitializeComponent();
        }

        private void ReturnItem_Click(object sender, RoutedEventArgs e)
        {
            string title = TitleTextBox.Text;
            try
            {
                ItemService.ReturnItem(title);
                MessageBox.Show("A new Item was Returned successfully!");
                ICollectionView viewListItems = CollectionViewSource.GetDefaultView(ItemService.items);
                ICollectionView viewListRentedItems = CollectionViewSource.GetDefaultView(ItemService.rentedItems);
                viewListItems.Refresh();
                viewListRentedItems.Refresh();
                Close();
            }
            catch (ArgumentException err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
