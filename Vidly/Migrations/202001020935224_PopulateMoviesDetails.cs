namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesDetails : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Movies (Name,GenereId,ReleaseDate,NumberInstocks) values ('Transformer',1,'20 Dec 2010',10)");
            Sql("Insert into Movies (Name,GenereId,ReleaseDate,NumberInstocks) values ('Matrix',2,'10 Dec 2010',12)");
            Sql("Insert into Movies (Name,GenereId,ReleaseDate,NumberInstocks) values ('Bahubali',3,'31 Dec 2010',15)");

        }
        
        
        public override void Down()
        {
        }
    }
}
