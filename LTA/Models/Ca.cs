using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTA.Models
{
    [Table("Cas")]
    public class Ca
    {
        [Key]
        public string SoCa { get; set; }
        public string Ngay { get; set; }
    }
}