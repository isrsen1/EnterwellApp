namespace EnterwellApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableInvoicesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InvoiceCreationDate = c.DateTime(nullable: false),
                        InvoiceDueDate = c.DateTime(nullable: false),
                        TotalPriceNoTax = c.Double(nullable: false),
                        TotalPriceWithTax = c.Double(nullable: false),
                        InvoiceCreator = c.String(),
                        InvoiceRecipient = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Items", "Invoice_Id", c => c.Int());
            CreateIndex("dbo.Items", "Invoice_Id");
            AddForeignKey("dbo.Items", "Invoice_Id", "dbo.Invoices", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Invoice_Id", "dbo.Invoices");
            DropIndex("dbo.Items", new[] { "Invoice_Id" });
            DropColumn("dbo.Items", "Invoice_Id");
            DropTable("dbo.Invoices");
        }
    }
}
