using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cruid.database
{
    static class DbConnect
    {
        public static playersEntities DbConnection
        {
            get
            {
                return new playersEntities();
            }
        }
    }
}
