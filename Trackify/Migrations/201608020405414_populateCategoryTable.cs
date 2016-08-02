namespace Trackify.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class populateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (Id, Name) VALUES (1,'Job Fair')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (2,'Tech Meetup')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (3,'Info Session')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Categories WHERE Id IN (1,2,3)");
        }
    }
}
