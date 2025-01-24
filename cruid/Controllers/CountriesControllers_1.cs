using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cruid.database;

namespace cruid.Controllers
{
    internal class CountriesControllers
    {
        private playersEntities dbConnection;

        public CountriesControllers()
        {
            dbConnection = DbConnect.DbConnection;
        }

        public List<Country> GetAllCountries()
        {
            return dbConnection.Country.ToList();
        }

        public void AddNewCountryToDb(string name)
        {
            var country = new Country()
            {
                CountryName = name,
            };

            dbConnection.Country.Add(country);
            dbConnection.SaveChanges();
        }

        public void RemoveCountryFromDb(int id)
        {
            var countries = dbConnection.Country.Where(ks => ks.CountryID == id).ToList();
            var country = dbConnection.Country.Find(id);


            if (countries.Any())
            {
                dbConnection.Country.RemoveRange(countries);
                dbConnection.SaveChanges();
            }

            dbConnection.SaveChangesAsync();
        }
    }
}
