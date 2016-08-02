namespace Trackify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForEventAndCategory : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Events", "Company_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Events", new[] { "Category_Id" });
            DropIndex("dbo.Events", new[] { "Company_Id" });
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Events", "Venue", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Events", "Category_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Events", "Company_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Events", "Category_Id");
            CreateIndex("dbo.Events", "Company_Id");
            AddForeignKey("dbo.Events", "Category_Id", "dbo.Categories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Events", "Company_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Company_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Events", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Events", new[] { "Company_Id" });
            DropIndex("dbo.Events", new[] { "Category_Id" });
            AlterColumn("dbo.Events", "Company_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Events", "Category_Id", c => c.Byte());
            AlterColumn("dbo.Events", "Venue", c => c.String());
            AlterColumn("dbo.Categories", "Name", c => c.String());
            CreateIndex("dbo.Events", "Company_Id");
            CreateIndex("dbo.Events", "Category_Id");
            AddForeignKey("dbo.Events", "Company_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Events", "Category_Id", "dbo.Categories", "Id");
        }
    }
}
