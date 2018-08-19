namespace EnterwellApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemsProductsUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "UnitPriceNoTax", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "User", c => c.String());
            DropColumn("dbo.Items", "UnitPriceNoTax");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "UnitPriceNoTax", c => c.Double(nullable: false));
            DropColumn("dbo.Products", "User");
            DropColumn("dbo.Products", "UnitPriceNoTax");
        }
    }
}
