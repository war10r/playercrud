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

namespace cruid.Pages.CountryPages
{
    /// <summary>
    /// Логика взаимодействия для DeleteCountry.xaml
    /// </summary>
    public partial class DeleteCountry : Page
    {
        //private Database dataBase;
        public DeleteCountry()
        {
            InitializeComponent();

            var dbContext = new playersEntities();
            //dataBase = new Database(dbContext);
        }

        private async void CountryDelete(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(countrynameBox.Text);

            //await dataBase.DeleteCountry(id);
        }
    }
}
