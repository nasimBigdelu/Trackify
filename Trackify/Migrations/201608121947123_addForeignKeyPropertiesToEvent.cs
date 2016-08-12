namespace Trackify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addForeignKeyPropertiesToEvent : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Events", name: "Category_Id", newName: "CategoryId");
            RenameColumn(table: "dbo.Events", name: "Company_Id", newName: "CompanyId");
            RenameIndex(table: "dbo.Events", name: "IX_Company_Id", newName: "IX_CompanyId");
            RenameIndex(table: "dbo.Events", name: "IX_Category_Id", newName: "IX_CategoryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Events", name: "IX_CategoryId", newName: "IX_Category_Id");
            RenameIndex(table: "dbo.Events", name: "IX_CompanyId", newName: "IX_Company_Id");
            RenameColumn(table: "dbo.Events", name: "CompanyId", newName: "Company_Id");
            RenameColumn(table: "dbo.Events", name: "CategoryId", newName: "Category_Id");
        }
    }
}
