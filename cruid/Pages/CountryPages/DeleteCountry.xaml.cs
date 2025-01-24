using cruid.Controllers;
using cruid.database;
using System;
using System.Collections.Generic;
using System.Data.Common;
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

namespace cruid.Pages.CountryPages
{
    /// <summary>
    /// Логика взаимодействия для DeleteCountry.xaml
    /// </summary>
    public partial class DeleteCountry : Page
    {
        private CountriesControllers countriesControllers;
        public DeleteCountry()
        {
            InitializeComponent();

            var dbContext = new playersEntities();
            countriesControllers = new CountriesControllers();
        }

        private void CountryDelete(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(countrynameBox.Text);

            countriesControllers.RemoveCountryFromDb(id);
        }
    }
}
