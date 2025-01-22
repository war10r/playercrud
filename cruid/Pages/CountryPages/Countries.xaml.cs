using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cruid.Pages.CountryPages;
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
    /// Логика взаимодействия для Countries.xaml
    /// </summary>
    public partial class Countries : Page
    {
        public Countries()
        {
            InitializeComponent();
        }

        private void AddCountry(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddCountry());
        }

        private void DeleteCountry(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DeleteCountry());
        }

        private void ShowCountries(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ShowCountries());
        }
    }
}
