using cruid.Controllers;
using cruid.database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Database = cruid.database.Database;

namespace cruid.Pages
{
    public partial class AddPlayer : Page
    {

        private PlayersController playerController;
        private CountriesControlles countriesControlles;

        public AddPlayer()
        {
            InitializeComponent();
            playerController = new PlayersController();
            countriesControlles = new CountriesControlles();

            CountrySelectComboBox.ItemsSource = countriesControlles.GetAllCountries();
            CountrySelectComboBox.DisplayMemberPath = "countryname";
        }

        private void PlayerAdd(object sender, RoutedEventArgs e)
        {
            playerController.AddNewPlayerToDb(
                nameBox.Text,
                loginBox.Text, 
                passwordBox.Text,
                int.Parse(ageBox.Text),
                ((country)CountrySelectComboBox.SelectedItem).countryID
                );
        }
    }
}
