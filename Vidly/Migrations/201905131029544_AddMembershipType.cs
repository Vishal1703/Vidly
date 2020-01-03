namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberShipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Signupfree = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "MembershiptypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MembershiptypeId");
            AddForeignKey("dbo.Customers", "MembershiptypeId", "dbo.MemberShipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershiptypeId", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MembershiptypeId" });
            DropColumn("dbo.Customers", "MembershiptypeId");
            DropTable("dbo.MemberShipTypes");
        }
    }
}
