namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGeneres : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres(Name) values ('Comedy')");
            Sql("Insert into Genres(Name) values ('Drama')");
            Sql("Insert into Genres(Name) values ('Horror')");

        }
        
        public override void Down()
        {
        }
    }
}
