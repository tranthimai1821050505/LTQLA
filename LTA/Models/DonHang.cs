using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTA.Models
{
    [Table("DonHangs")]
    public class DonHang
    {
        [Key]
        public string SoDon { get; set; }
        public string MaNhanVien { get; set; }
        public string NgayThang { get; set; }
        public string MaDanhMuc { get; set; }

    }
}