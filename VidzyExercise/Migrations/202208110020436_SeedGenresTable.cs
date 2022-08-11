namespace VidzyExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO dbo.Genres (Id, Name) VALUES (1, 'Comedy');
                INSERT INTO dbo.Genres (Id, Name) VALUES (2, 'Action');
                INSERT INTO dbo.Genres (Id, Name) VALUES (3, 'Horror');
                INSERT INTO dbo.Genres (Id, Name) VALUES (4, 'Thriller');
                INSERT INTO dbo.Genres (Id, Name) VALUES (5, 'Family');
                INSERT INTO dbo.Genres (Id, Name) VALUES (6, 'Romance');");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM dbo.Genres WHERE Id IN (1, 2, 3, 4, 5, 6)");
        }
    }
}
