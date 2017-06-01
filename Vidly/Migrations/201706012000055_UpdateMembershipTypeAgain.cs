namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeAgain : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes SET DiscountRate = 10 WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
