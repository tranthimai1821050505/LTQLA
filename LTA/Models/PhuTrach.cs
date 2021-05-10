using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTA.Models
{
    [Table("PhuTrachs")]
    public class PhuTrach
    {
        [Key]
        public string MaNhanVien { get; set; }
        public string SoCa { get; set; }
        public string SoBan { get; set; }
    }
}