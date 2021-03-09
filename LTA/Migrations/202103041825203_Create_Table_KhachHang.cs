namespace LTA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_KhachHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        TenKhachHang = c.String(nullable: false, maxLength: 128, unicode: false),
                        MaKhachHang = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.TenKhachHang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KhachHang");
        }
    }
}
