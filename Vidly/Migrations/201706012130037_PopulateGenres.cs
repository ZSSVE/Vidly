namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Comedy'), (2, 'Action'), (3, 'Family'), (4, 'Romance'), (5, 'Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
