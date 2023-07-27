using FrancisLibrary.Core.Entities;
using FrancisLibrary.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

    public partial class AddMember : Window
    {

        public AddMember()
        {
            InitializeComponent();
        }



        private void AddNewMember_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            try
            {
                UserService.AddMemberFunc(username, password);
                MessageBox.Show("A new Member was created successfully!");
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
