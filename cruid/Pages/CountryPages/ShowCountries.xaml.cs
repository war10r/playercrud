﻿using cruid.database;
using System;
using System.Collections.Generic;
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

namespace cruid.Pages.CountryPages
{
    /// <summary>
    /// Логика взаимодействия для ShowCountries.xaml
    /// </summary>
    public partial class ShowCountries : Page
    {
        public ShowCountries()
        {
            InitializeComponent();

            var data = DbConnect.DbConnection.Country.ToList();
            CountriesGrid.ItemsSource = data;
        }
    }
}
