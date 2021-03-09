namespace LTA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_LoaiDanhMuc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoaiDanhMucs",
                c => new
                    {
                        MaLoaiDanhMuc = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenLoaiDanhMuc = c.String(unicode: false),
                        TrangThai = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaLoaiDanhMuc);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LoaiDanhMucs");
        }
    }
}
