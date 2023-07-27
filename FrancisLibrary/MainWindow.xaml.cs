using System.Threading.Tasks;
using System.Windows;
using FrancisLibrary.Core.Entities;
using FrancisLibrary.Core.Services;
using FrancisLibrary.Core.Utils;

namespace FrancisLibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
           
            
            
        }
        private async Task MoveToLibraryOptionPage()
        {
            LibraryOptionPage libraryOptionPage = new LibraryOptionPage();
            await Task.Delay(500);
            libraryOptionPage.Show();
            Close();
        }
        private async Task MoveToMemberPage()
        {
            MemberPage memberPage = new MemberPage();
            await Task.Delay(500);
            memberPage.Show();
            Close();
        }
        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;
            User user = UserService.Login(username, password);
            if (user == null)
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }
            MessageBox.Show("Login successful!");
            if (user is Librarian)
            {
                await MoveToLibraryOptionPage();
            }

            else if (user is Member)
            {
                await MoveToMemberPage();
            }
        }

        private async void Temp_Click(object sender, RoutedEventArgs e)
        {
            await MoveToLibraryOptionPage();
        }

        
    }
}


