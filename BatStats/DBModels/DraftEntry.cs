using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BatStats.Models
{
    [Table("DraftEntries")]
    public class DraftEntry
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid DraftEntryId { get; set; }
        public string Position { get; set; }
        public string PlayerName { get; set; }
        public string TeamName { get; set; }
    }
}