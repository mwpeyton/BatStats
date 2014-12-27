using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BatStats.Models
{
    public class BatStatsDb : DbContext
    {
        public BatStatsDb()
            : base("name=BatStatsDb")
        {

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerStat> PlayerStats { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<DraftEntry> DraftEntries { get; set; }
    }
}