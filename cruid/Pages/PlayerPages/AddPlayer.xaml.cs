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
        }

        private async void PlayerAdd(object sender, RoutedEventArgs e)
        {
            //int id = 0;
            //string cntrName = CountrySelectComboBox.Text;
            //var countries = _context.country.Where(ks => ks.countryID == id).ToList();
            //var country = _context.country.Find(id);

            //int id = (from players in playersEntities select players.Id);

            string name = nameBox.Text;
            string login = loginBox.Text;
            string password = passwordBox.Text;
            int age = int.Parse(ageBox.Text);
            int countryID = 0;

            await dataBase.SavePlayer(name, login, password, age, countryID);
        }
    }
}
