using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTA.Models
{
    [Table("DonPhieuThus")]
    public class DonPhieuThu
    {
        [Key]
        public string SoPhieuThu { get; set; }
        public string MaDanhMuc { get; set; }
        public string TienDanhMuc { get; set; }
        public string DonGiaDanhMuc { get; set; }
    }
}