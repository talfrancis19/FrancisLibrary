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
using System.Windows.Threading;

namespace FrancisLibrary
{
    /// <summary>
    /// Interaction logic for LibrarianMainPage.xaml
    /// </summary>
    public partial class LibrarianMainPage : Window
    {
        public LibrarianMainPage()
        {
            InitializeComponent();
            
            listViewUsers.ItemsSource = UserService.users;
            
        }


         
        private async Task MoveToLibraryOptionsPage()
        {
            LibraryOptionPage libraryOptionPage = new LibraryOptionPage();
            await Task.Delay(0500);
            libraryOptionPage.Show();
            Close();
        }
        private async Task MoveToAddMemberWindow()
        {
            AddMember addMember = new AddMember();
            await Task.Delay(500);
            addMember.Show();
        }
        private async Task MoveToRemoveMemberWindow()
        {
            RemoveMember removeMember = new RemoveMember();
            await Task.Delay(500);
            removeMember.Show();
        }

        private async void backToLibraryOptionsPage_Click(object sender, RoutedEventArgs e)
        {
            await MoveToLibraryOptionsPage();
        }
        private async void AddMemberWindow_Click(object sender, RoutedEventArgs e)
        {
            await MoveToAddMemberWindow();
        }

        private async void RemoveMemberWindow_Click(object sender, RoutedEventArgs e)
        {
            await MoveToRemoveMemberWindow();
        }
    }
}
