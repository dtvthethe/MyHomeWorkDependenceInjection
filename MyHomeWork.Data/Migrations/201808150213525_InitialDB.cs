namespace MyHomeWork.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        CatetegoryID = c.Int(nullable: false),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CatetegoryID, cascadeDelete: true)
                .Index(t => t.CatetegoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CatetegoryID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CatetegoryID" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
