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
    /// Interaction logic for RemoveItemWindow.xaml
    /// </summary>
    public partial class RemoveItemWindow : Window
    {
        public RemoveItemWindow()
        {
            InitializeComponent();
        }

        private void RemoveItem_Click(object sender, RoutedEventArgs e)
        {
            string title = TitleTextBox.Text;
            try
            {
                ItemService.RemoveItem(title);
                MessageBox.Show("A new Item was Removed successfully!");
                ICollectionView view = CollectionViewSource.GetDefaultView(ItemService.items);
                view.Refresh();
                Close();
            }
            catch (ArgumentException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        
    }
}
