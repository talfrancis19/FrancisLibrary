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
    /// Interaction logic for RemoveMember.xaml
    /// </summary>
    public partial class RemoveMember : Window
    {
        public RemoveMember()
        {
            InitializeComponent();
        }

        private void RemoveMember_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameBox.Text;
            try
            {
                UserService.RemoveMemberFunc(username);
                MessageBox.Show("A Member was successfully removed!");
                ICollectionView view = CollectionViewSource.GetDefaultView(UserService.users);
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
