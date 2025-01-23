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
//using Database = cruid.database.Database;


namespace cruid.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddCountry.xaml
    /// </summary>


    public partial class AddCountry : Page
    {
        private PlayersController playerController;
        private CountriesControlles countriesControlles;

        public AddCountry()
        {
            InitializeComponent();

            playerController = new PlayersController();
            countriesControlles = new CountriesControlles();
        }

        private void CountryAdd(object sender, RoutedEventArgs e)
        {
            countriesControlles.AddNewCountryToDb(
                countrynameBox.Text);


        }
    }
}
