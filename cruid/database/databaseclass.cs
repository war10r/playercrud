using cruid.Pages;
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
        public async Task SavePlayer(string name, string login, string password, int age)
        {
            using (var dbContext = new playersEntities())
            {
                var player = new player()
                {
                    name = name,
                    login = login,
                    password = password,
                    age = age,
                };

                dbContext.player.Add(player);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task DeletePlayer(int id)
        {
            var players = _context.player.Where(ks => ks.playerID == id).ToList();
            var player = _context.player.Find(id);

            if (players.Any())
            {
                _context.player.RemoveRange(players);
                _context.SaveChanges();
            }


            _context.player.Remove(player);
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
    }
    
}
