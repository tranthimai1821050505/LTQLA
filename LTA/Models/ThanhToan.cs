using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTA.Models
{
    [Table("ThanhToans")]
    public class ThanhToan
    {
        [Key]
        public string SoPhieuThanhToan { get; set; }
        public string MaNhanVien { get; set; }
        public string NgayThang { get; set; }
        public string TongTien { get; set; }
    }
}