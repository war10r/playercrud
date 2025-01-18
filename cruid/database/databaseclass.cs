using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cruid.database
{
    internal class Database
    {
        private readonly playersEntities _context;

        public Database(playersEntities context)
        {
            _context = context;
        }
        public async Task SavePlayer(string name, string login, string password, int age, int countryID)
        {
            using (var dbContext = new playersEntities())
            {
                var player = new players()
                {
                    name = name,
                    login = login,
                    password = password,
                    countryID_player = countryID,
                    age = age,
                };

                dbContext.players.Add(player);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task DeletePlayer(int id)
        {
            var players = _context.players.Where(ks => ks.playerID == id).ToList();
            var player = _context.players.Find(id);

            if (players.Any())
            {
                _context.players.RemoveRange(players);
                _context.SaveChanges();
            }


            _context.players.Remove(player);
            await _context.SaveChangesAsync();
        }

        public async Task AddCountry(string name)
        {
            using (var dbContext = new playersEntities())
            {
                var country = new country()
                {
                    countryname = name,
                };

                dbContext.country.Add(country);
                await dbContext.SaveChangesAsync();
            }
        }
        public async Task DeleteCountry(int id)
        {
            var countries = _context.country.Where(ks => ks.countryID == id).ToList();
            var country = _context.country.Find(id);


            if (countries.Any())
            {
                _context.country.RemoveRange(countries);
                _context.SaveChanges();
            }

            await _context.SaveChangesAsync();
        }

    }
}

