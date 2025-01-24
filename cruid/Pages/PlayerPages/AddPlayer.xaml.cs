using cruid.Controllers;
using cruid.database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
//using Database = cruid.database.Database;

namespace cruid.Pages
{
    public partial class AddPlayer : Page
    {

        private PlayersController playerController;
        private CountriesControllers countriesControlles;
        private playersEntities _context;

        public AddPlayer()
        {
            InitializeComponent();
            playerController = new PlayersController();
            countriesControlles = new CountriesControllers();
            _context = new playersEntities();

            CountrySelectComboBox.ItemsSource = countriesControlles.GetAllCountries();
            CountrySelectComboBox.DisplayMemberPath = "CountryName";
        }

        private void PlayerAdd(object sender, RoutedEventArgs e)
        {
            playerController.AddNewPlayerToDb(
            nameBox.Text,
            loginBox.Text,
            passwordBox.Text,
            int.Parse(ageBox.Text),
            ((Country)CountrySelectComboBox.SelectedItem).CountryID);

            int countryID2 = ((Country)CountrySelectComboBox.SelectedItem).CountryID;
            var playercount = _context.Country.Where(x => x.CountryID == countryID2).First().PlayerCount;
            ////_context.Country.First().PlayerCount++;
            var countryID = _context.Country.FirstOrDefault(p => p.CountryID == countryID2);

            if (countryID != null)
            {
                _context.Country.First().PlayerCount += 1;


                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Страна не найдена");
            }
            _context.SaveChanges();
        }
    }
}
