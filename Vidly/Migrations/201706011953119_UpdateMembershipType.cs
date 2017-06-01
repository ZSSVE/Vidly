namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes SET DiscountRate = 1 WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
