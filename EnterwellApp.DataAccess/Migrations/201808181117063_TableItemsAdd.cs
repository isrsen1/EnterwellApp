namespace EnterwellApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableItemsAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        UnitPriceNoTax = c.Double(nullable: false),
                        TotalPriceNoTax = c.Double(nullable: false),
                        Description = c.String(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Product_Id", "dbo.Products");
            DropIndex("dbo.Items", new[] { "Product_Id" });
            DropTable("dbo.Items");
        }
    }
}
