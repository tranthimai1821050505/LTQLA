namespace LTA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanVien : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.KhachHang", newName: "KhachHangs");
            CreateTable(
                "dbo.Ngays",
                c => new
                    {
                        NgayThang = c.String(nullable: false, maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.NgayThang);
            
            CreateTable(
                "dbo.PhieuThus",
                c => new
                    {
                        SoPhieuThu = c.String(nullable: false, maxLength: 128, unicode: false),
                        MaNhanVien = c.String(unicode: false),
                        NgayThang = c.String(unicode: false),
                        SoKhach = c.String(unicode: false),
                        TongTien = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.SoPhieuThu);
            
            CreateTable(
                "dbo.ThanhToans",
                c => new
                    {
                        SoPhieuThanhToan = c.String(nullable: false, maxLength: 128, unicode: false),
                        MaNhanVien = c.String(unicode: false),
                        NgayThang = c.String(unicode: false),
                        TongTien = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.SoPhieuThanhToan);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ThanhToans");
            DropTable("dbo.PhieuThus");
            DropTable("dbo.Ngays");
            RenameTable(name: "dbo.KhachHangs", newName: "KhachHang");
        }
    }
}
