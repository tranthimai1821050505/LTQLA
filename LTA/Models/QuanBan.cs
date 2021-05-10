using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTA.Models
{
    [Table("QuanBans")]
    public class QuanBan
    {
        [Key]
        public string MaQuan { get; set; }
        public string TenQuan { get; set; }
    }
}