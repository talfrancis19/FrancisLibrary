using FrancisLibrary.Core.Services;
using FrancisLibrary.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
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
    /// Interaction logic for RentItemWindow.xaml
    /// </summary>
    public partial class RentItemWindow : Window
    {
        public RentItemWindow()
        {
            InitializeComponent();
        }

        private void RentItem_Click(object sender, RoutedEventArgs e)
        {
            string title = TitleTextBox.Text;
            try
            {
                ItemService.RentItem(title);
                MessageBox.Show("A new Item was Rented successfully!");
                ICollectionView viewListItems = CollectionViewSource.GetDefaultView(ItemService.items);
                ICollectionView viewListRentedItems = CollectionViewSource.GetDefaultView(ItemService.rentedItems);
                viewListItems.Refresh();
                viewListRentedItems.Refresh();
                Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
