namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Headings", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Headings", new[] { "CategoryID" });
            AlterColumn("dbo.Headings", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Headings", "CategoryID");
            AddForeignKey("dbo.Headings", "CategoryID", "dbo.Categories", "CategoryID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Headings", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Headings", new[] { "CategoryID" });
            AlterColumn("dbo.Headings", "CategoryID", c => c.Int());
            CreateIndex("dbo.Headings", "CategoryID");
            AddForeignKey("dbo.Headings", "CategoryID", "dbo.Categories", "CategoryID");
        }
    }
}
