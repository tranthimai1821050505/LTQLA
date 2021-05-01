using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTA.Models
{
    [Table("DanhMucs")]
    public class DanhMuc
    {
        [Key]
        public string MaDanhMuc { get; set; }
        [AllowHtml]
        public string TenDanhMuc { get; set; }
    }
}