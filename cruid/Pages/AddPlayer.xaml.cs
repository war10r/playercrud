using cruid.database;
using System;
using System.Collections.Generic;
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

namespace cruid.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddPlayer.xaml
    /// </summary>
    public partial class AddPlayer : Page
    {
        private Database dataBase;
        public AddPlayer()
        {
            InitializeComponent();

            var dbContext = new playersEntities();
            dataBase = new Database(dbContext);
        }

        private async void PlayerAdd(object sender, RoutedEventArgs e)
        {
            string name = nameBox.Text;
            string login = loginBox.Text;
            string password = passwordBox.Text;
            int age = int.Parse(ageBox.Text);


            await dataBase.SavePlayer(name, login, password, age);
        }
    
    }
}
