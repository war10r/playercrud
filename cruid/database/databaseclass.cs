//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace cruid.database
//{
//    internal class Database
//    {
//        private readonly playersEntities _context;

//        public Database(playersEntities context)
//        {
//            _context = context;
//        }
//        public async Task SavePlayer(string name, string login, string password, int age, int countryID)
//        {
//            using (var dbContext = new playersEntities())
//            {
//                var player = new Players()
//                {
//                    Name = name,
//                    Login = login,
//                    Password = password,
//                    CountryID_Player = countryID,
//                    Age = age,
//                };

//                dbContext.Players.Add(player);
//                await dbContext.SaveChangesAsync();
//            }
//        }

//        public async Task DeletePlayer(int id)
//        {
//            var players = _context.Players.Where(ks => ks.PlayerID == id).ToList();
//            var player = _context.Players.Find(id);

//            if (players.Any())
//            {
//                _context.Players.RemoveRange(players);
//                _context.SaveChanges();
//            }


//            _context.Players.Remove(player);
//            await _context.SaveChangesAsync();
//        }

//        //public async Task AddCountry(string name)
//        //{
//        //    using (var dbContext = new playersEntities())
//        //    {
//        //        var country = new Country()
//        //        {
//        //            CountryName = name,
//        //        };

//        //        dbContext.Country.Add(country);
//        //        await dbContext.SaveChangesAsync();
//        //    }
//        //}
//        public async Task DeleteCountry(int id)
//        {
//            var countries = _context.Country.Where(ks => ks.CountryID == id).ToList();
//            var country = _context.Country.Find(id);


//            if (countries.Any())
//            {
//                _context.Country.RemoveRange(countries);
//                _context.SaveChanges();
//            }

//            await _context.SaveChangesAsync();
//        }

//    }
//}

