namespace LTA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Table_NhanVien : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.NhanViens");
            AlterColumn("dbo.NhanViens", "TenNhanVien", c => c.String(unicode: false));
            AlterColumn("dbo.NhanViens", "MaNhanVien", c => c.String(nullable: false, maxLength: 128, unicode: false));
            AddPrimaryKey("dbo.NhanViens", "MaNhanVien");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.NhanViens");
            AlterColumn("dbo.NhanViens", "MaNhanVien", c => c.String(unicode: false));
            AlterColumn("dbo.NhanViens", "TenNhanVien", c => c.String(nullable: false, maxLength: 128, unicode: false));
            AddPrimaryKey("dbo.NhanViens", "TenNhanVien");
        }
    }
}
