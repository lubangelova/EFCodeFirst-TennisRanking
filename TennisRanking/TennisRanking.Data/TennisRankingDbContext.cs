using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisRanking.Models;

namespace TennisRanking.Data
{
    public class TennisRankingDbContext : DbContext
    {
        public TennisRankingDbContext()
            :base("TennisRankingConnection")
        {    
        }
        public DbSet<Country> Countries { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Ranking> Rankings { get; set; }

        public DbSet<Tournament> Tournaments { get; set; }
    }
}
