using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using cruid.database;

namespace cruid.Controllers
{
    internal class PlayersController
    {
        private playersEntities dbConncetion;

        public PlayersController()
        {
            dbConncetion = DbConnect.DbConnection;
        }

        public void AddNewPlayerToDb(string login, string password, string name, int age, int countryID)
        {
            var player = new players()
            {
                name = name,
                login = login,
                password = password,
                countryID_player = countryID,
                age = age,
            };

            dbConncetion.players.Add(player);
            dbConncetion.SaveChanges();
        }
    }
}
