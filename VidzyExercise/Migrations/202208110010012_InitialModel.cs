namespace VidzyExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VideoGenres",
                c => new
                    {
                        Video_Id = c.Int(nullable: false),
                        Genre_Id = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => new { t.Video_Id, t.Genre_Id })
                .ForeignKey("dbo.Videos", t => t.Video_Id, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.Genre_Id, cascadeDelete: true)
                .Index(t => t.Video_Id)
                .Index(t => t.Genre_Id);

            Sql(@"INSERT INTO dbo.Genres (Id, Name) VALUES (1, 'Comedy');
                INSERT INTO dbo.Genres (Id, Name) VALUES (2, 'Action');
                INSERT INTO dbo.Genres (Id, Name) VALUES (3, 'Horror');
                INSERT INTO dbo.Genres (Id, Name) VALUES (4, 'Thriller');
                INSERT INTO dbo.Genres (Id, Name) VALUES (5, 'Family');
                INSERT INTO dbo.Genres (Id, Name) VALUES (6, 'Romance');");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VideoGenres", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.VideoGenres", "Video_Id", "dbo.Videos");
            DropIndex("dbo.VideoGenres", new[] { "Genre_Id" });
            DropIndex("dbo.VideoGenres", new[] { "Video_Id" });
            DropTable("dbo.VideoGenres");
            DropTable("dbo.Videos");
            DropTable("dbo.Genres");
        }
    }
}
