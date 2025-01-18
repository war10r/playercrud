﻿using cruid.database;
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
    /// <summary>
    /// Логика взаимодействия для AddCountry.xaml
    /// </summary>


    public partial class AddCountry : Page
    {
    private Database dataBase;
        public AddCountry()
        {
            InitializeComponent();
            
            var dbContext = new playersEntities();
            dataBase = new Database(dbContext);
        }

        private async void CountryAdd(object sender, RoutedEventArgs e)
        {
            string name = countrynameBox.Text;

            await dataBase.AddCountry(name);
            countrynameBox.Clear();
        }
    }
}
