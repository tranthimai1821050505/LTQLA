using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTA.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        public string TenKhachHang { get; set; }
        public string MaKhachHang { get; set; }

    }
}