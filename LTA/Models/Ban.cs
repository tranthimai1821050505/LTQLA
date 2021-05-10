using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTA.Models
{
    [Table("Bans")]
    public class Ban
    {
        [Key]
        public string SoBan { get; set; }
    }
}