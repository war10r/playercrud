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

        public List<country> GetAllCountries()
        {
            return dbConncetion.country.ToList();
        }
    }
}
