using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BatStats.Models
{
    public class PlayerPositionViewModel
    {
        public Guid PlayerId { get; set; }
        public List<SelectListItem> Positions { get; set; }
        public List<DraftEntry> Picks { get; set; }
        public List<Player> Players { get; set; }
        public List<PlayerStat> PlayerStats { get; set; }
    }
}