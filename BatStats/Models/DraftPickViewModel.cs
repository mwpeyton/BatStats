using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BatStats.Models
{
    public class DraftPickViewModel
    {
        public int PickNumber { get; set; }
        List<PlayerPositionViewModel> DraftPicks { get; set; }
    }
}