namespace LTA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_DanhMuc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DanhMucs",
                c => new
                    {
                        MaDanhMuc = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenDanhMuc = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.MaDanhMuc);
            
            CreateTable(
                "dbo.DonHangs",
                c => new
                    {
                        SoDon = c.String(nullable: false, maxLength: 128, unicode: false),
                        MaNhanVien = c.String(unicode: false),
                        NgayThang = c.String(unicode: false),
                        MaDanhMuc = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.SoDon);
            
            CreateTable(
                "dbo.DonPhieuThus",
                c => new
                    {
                        SoPhieuThu = c.String(nullable: false, maxLength: 128, unicode: false),
                        MaDanhMuc = c.String(unicode: false),
                        TienDanhMuc = c.String(unicode: false),
                        DonGiaDanhMuc = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.SoPhieuThu);
            
            CreateTable(
                "dbo.DonThanhToans",
                c => new
                    {
                        SoPhieuThanhToan = c.String(nullable: false, maxLength: 128, unicode: false),
                        MaDanhMuc = c.String(unicode: false),
                        TienDanhMuc = c.String(unicode: false),
                        SoDon = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.SoPhieuThanhToan);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DonThanhToans");
            DropTable("dbo.DonPhieuThus");
            DropTable("dbo.DonHangs");
            DropTable("dbo.DanhMucs");
        }
    }
}
