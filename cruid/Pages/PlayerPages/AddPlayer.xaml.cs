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

        private readonly playersEntities _context;
        private Database dataBase;
        class ComboItem
        {
            public string Text { get; set; }
        }
        public AddPlayer()
        {
            InitializeComponent();

            var dbContext = new playersEntities();
            dataBase = new Database(dbContext);

            CountrySelectComboBox.ItemsSource = dbContext.country.ToList();
        }

        private async void PlayerAdd(object sender, RoutedEventArgs e)
        {
            string name = nameBox.Text;
            string login = loginBox.Text;
            string password = passwordBox.Text;
            int age = int.Parse(ageBox.Text);
            int countryID = ((country)CountrySelectComboBox.SelectedItem).countryID;

            await dataBase.SavePlayer(name, login, password, age, countryID);
        }
    }
}
