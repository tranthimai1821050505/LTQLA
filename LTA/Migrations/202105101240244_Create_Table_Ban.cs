namespace LTA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Ban : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bans",
                c => new
                    {
                        SoBan = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.SoBan);
            
            CreateTable(
                "dbo.Cas",
                c => new
                    {
                        SoCa = c.String(nullable: false, maxLength: 128),
                        Ngay = c.String(),
                    })
                .PrimaryKey(t => t.SoCa);
            
            CreateTable(
                "dbo.PhuTrachs",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 128),
                        SoCa = c.String(),
                        SoBan = c.String(),
                    })
                .PrimaryKey(t => t.MaNhanVien);
            
            CreateTable(
                "dbo.QuanBans",
                c => new
                    {
                        MaQuan = c.String(nullable: false, maxLength: 128),
                        TenQuan = c.String(),
                    })
                .PrimaryKey(t => t.MaQuan);
            
            AddColumn("dbo.KhachHangs", "SoBan", c => c.String());
            AddColumn("dbo.PhieuThus", "MaKhachHang", c => c.String(unicode: false));
            AddColumn("dbo.ThanhToans", "MaQuan", c => c.String());
            DropColumn("dbo.PhieuThus", "SoKhach");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PhieuThus", "SoKhach", c => c.String(unicode: false));
            DropColumn("dbo.ThanhToans", "MaQuan");
            DropColumn("dbo.PhieuThus", "MaKhachHang");
            DropColumn("dbo.KhachHangs", "SoBan");
            DropTable("dbo.QuanBans");
            DropTable("dbo.PhuTrachs");
            DropTable("dbo.Cas");
            DropTable("dbo.Bans");
        }
    }
}
