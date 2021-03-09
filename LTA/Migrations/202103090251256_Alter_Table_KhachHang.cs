namespace LTA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Table_KhachHang : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.KhachHangs");
            AddColumn("dbo.NhanViens", "SDTNhanVien", c => c.String(unicode: false));
            AlterColumn("dbo.KhachHangs", "TenKhachHang", c => c.String(unicode: false));
            AlterColumn("dbo.KhachHangs", "MaKhachHang", c => c.String(nullable: false, maxLength: 128, unicode: false));
            AddPrimaryKey("dbo.KhachHangs", "MaKhachHang");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.KhachHangs");
            AlterColumn("dbo.KhachHangs", "MaKhachHang", c => c.String(unicode: false));
            AlterColumn("dbo.KhachHangs", "TenKhachHang", c => c.String(nullable: false, maxLength: 128, unicode: false));
            DropColumn("dbo.NhanViens", "SDTNhanVien");
            AddPrimaryKey("dbo.KhachHangs", "TenKhachHang");
        }
    }
}
