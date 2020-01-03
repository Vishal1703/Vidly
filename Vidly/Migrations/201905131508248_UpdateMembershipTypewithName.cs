namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypewithName : DbMigration
    {
        public override void Up()
        {
            Sql("update Membershiptypes set Name='Pay as You go' where DurationInMonths=0");
            Sql("update Membershiptypes set Name='Monthly' where DurationInMonths=1");
            Sql("update Membershiptypes set Name='Quarterly' where DurationInMonths=3");
            Sql("update Membershiptypes set Name='Annually' where DurationInMonths=12");
        }
        
        public override void Down()
        {
        }
    }
}
