using FrancisLibrary.Core;
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
using System.Xml.Linq;

namespace FrancisLibrary
{
    /// <summary>
    /// Interaction logic for AddItemWindow.xaml
    /// </summary>
    public partial class AddItemWindow : Window
    {

        public List<ComboData> genreOptions;
        public List<ComboData> itemTypeOptions;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public AddItemWindow()
        {
            InitializeComponent();
            Title = "Add Item";

            genreOptions = Enum.GetNames(typeof(Genre)).Select((enumName, index) => new ComboData { Id = index, Value = enumName }).ToList();
            GenreComboBox.ItemsSource = genreOptions;
            GenreComboBox.DisplayMemberPath = "Value";
            GenreComboBox.SelectedValuePath = "Id";
            GenreComboBox.SelectedValue = "0";

            itemTypeOptions = Enum.GetNames(typeof(ItemType)).Select((enumName, index) => new ComboData { Id = index, Value = enumName }).ToList();
            comboBoxItemType.ItemsSource = itemTypeOptions;
            comboBoxItemType.DisplayMemberPath = "Value";
            comboBoxItemType.SelectedValuePath = "Id";
            comboBoxItemType.SelectedValue = "0";
        }

        private void comboBoxItemType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;

            string bookOption = Enum.GetName(typeof(ItemType), 0);
            string journalOption = Enum.GetName(typeof(ItemType), 1);

            string selectedItemValue = (comboBoxItemType.SelectedItem as ComboData).Value;

            if (selectedItemValue == bookOption)
                ChangeVisibility(true);
            else if (selectedItemValue == journalOption)
                ChangeVisibility(false);
        }

        private void ChangeVisibility(bool visible)
        {
            Visibility bookVisibility = visible ? Visibility.Visible : Visibility.Hidden;
            Visibility journalVisibility = visible ? Visibility.Hidden : Visibility.Visible;
            

            AuthorTextBox.Visibility = bookVisibility;
            AuthorBox.Visibility = bookVisibility;
            PublisherTextBox.Visibility = bookVisibility;
            PublisherBox.Visibility = bookVisibility;
            CompanyTextBlock.Visibility = journalVisibility;
            CompanyTextBox.Visibility = journalVisibility;
        }

        private void AddItemButton_Click(object sender, RoutedEventArgs e)
        {

            int catalogID = int.Parse(CatalogIDTextBox.Text);            
            string title = TitleTextBox.Text;
            ItemType itemType = (ItemType)int.Parse(comboBoxItemType.SelectedValue.ToString());
            Genre genre = (Genre)int.Parse(GenreComboBox.SelectedValue.ToString());
            string author = AuthorTextBox.Text;
            string publisher = PublisherTextBox.Text;
            string company = CompanyTextBox.Text;
            try
            {
                ItemService.AddItem(title,catalogID, genre, itemType, author, publisher, company);
                MessageBox.Show("A new Item was created successfully!");
                ICollectionView view = CollectionViewSource.GetDefaultView(ItemService.items);
                view.Refresh();
                Close();
            }
            catch (ArgumentException )
            {
                MessageBox.Show("cannot create a new item try again");

            }
            
        }
    }
}
