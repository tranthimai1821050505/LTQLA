using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTA.Models
{
    [Table("PhieuThus")]
    public class PhieuThu
    {
        [Key]
        public string SoPhieuThu { get; set; }
        public string MaNhanVien { get; set; }
        public string NgayThang { get; set; }
        public string MaKhachHang { get; set; }
        public string TongTien { get; set; }
    }
}