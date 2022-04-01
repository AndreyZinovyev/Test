using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Test
{
    internal class SoccerContext: DbContext
    {
        public SoccerContext()
           : base("DBConnection")
        { }

        public DbSet<Player> Players { get; set; }
    }
}
