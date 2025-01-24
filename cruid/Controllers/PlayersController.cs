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
        private playersEntities dbConnection;

        public PlayersController()
        {
            dbConnection = DbConnect.DbConnection;
        }

        public void AddNewPlayerToDb(string login, string password, string name, int age, int countryID)
        {
            var player = new Players()
            {
                Name = name,
                Login = login,
                Password = password,
                CountryID_Player = countryID,
                Age = age,
            };

            dbConnection.Players.Add(player);
            dbConnection.SaveChanges();
        }

        public void DeletePlayerFromDb(int id)
        {
            var players = dbConnection.Players.Where(ks => ks.PlayerID == id).ToList();
            var player = dbConnection.Players.Find(id);

            if (players.Any())
            {
                dbConnection.Players.RemoveRange(players);
                dbConnection.SaveChanges();
            }


            dbConnection.Players.Remove(player);
            dbConnection.SaveChangesAsync();
        }
    }
}
