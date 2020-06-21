namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ePlayers",
                c => new
                    {
                        maCauThu = c.String(nullable: false, maxLength: 128),
                        tenCauThu = c.String(),
                        soDT = c.String(),
                        email = c.String(),
                        maDoiBong = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.maCauThu)
                .ForeignKey("dbo.eTeams", t => t.maDoiBong)
                .Index(t => t.maDoiBong);
            
            CreateTable(
                "dbo.eTeams",
                c => new
                    {
                        maDoiBong = c.String(nullable: false, maxLength: 128),
                        tenDoiBong = c.String(),
                    })
                .PrimaryKey(t => t.maDoiBong);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ePlayers", "maDoiBong", "dbo.eTeams");
            DropIndex("dbo.ePlayers", new[] { "maDoiBong" });
            DropTable("dbo.eTeams");
            DropTable("dbo.ePlayers");
        }
    }
}
