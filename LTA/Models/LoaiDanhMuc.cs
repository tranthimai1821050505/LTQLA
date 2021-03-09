using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTA.Models
{
    [Table("LoaiDanhMucs")]
    public class LoaiDanhMuc
    {
        [Key]
        public string MaLoaiDanhMuc { get; set; }
        public string TenLoaiDanhMuc { get; set; }
        public bool TrangThai { get; set; }
    }
}