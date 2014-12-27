using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BatStats.Models
{
    [Table("PlayerStats")]
    public class PlayerStat
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid PlayerStatId { get; set; }
        public int Games { get; set; }
        public int AtBats { get; set; }
        public int Doubles { get; set; }
        public int Triples { get; set; }
        public int HomeRuns { get; set; }
        public int RBIs { get; set; }
        public decimal Average { get; set; }
        public string PlayerName { get; set; }
    }
}