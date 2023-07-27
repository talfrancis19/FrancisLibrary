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

namespace FrancisLibrary
{
    /// <summary>
    /// Interaction logic for EditItemWindow.xaml
    /// </summary>
    public partial class EditItemWindow : Window
    {
        public List<Item> itemsAvailable;
        public List<ComboData> genreOptions;
        public List<ComboData> itemTypeOptions;


        public EditItemWindow()
        {
            InitializeComponent();
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

        private void EditItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
