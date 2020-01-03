namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomersBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("update customers set Birthdate='01/01/1900 12:00:00' where Id=3");
        }
        
        public override void Down()
        {
        }
    }
}
