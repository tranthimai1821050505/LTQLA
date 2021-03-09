using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTA.Models
{
    [Table("DonThanhToans")]
    public class DonThanhToan
    {
        [Key]
        public string SoPhieuThanhToan { get; set; }
        public string MaDanhMuc { get; set; }
        public string TienDanhMuc { get; set; }
        public string SoDon { get; set; }
    }
}