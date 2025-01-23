using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cruid.database;

namespace cruid.Controllers
{
    internal class CountriesControlles
    {
        private playersEntities dbConncetion;

        public CountriesControlles()
        {
            dbConncetion = DbConnect.DbConnection;
        }

        public List<Country> GetAllCountries()
        {
            return dbConncetion.Country.ToList();
        }

        public void AddNewCountryToDb(string name)
        {
            var country = new Country()
            {
                CountryName = name,
            };

            dbConncetion.Country.Add(country);
            dbConncetion.SaveChanges();
        }
    }
}
