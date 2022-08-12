namespace VidzyExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FieldsAreNotRequiredInVideosTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "Genre_Id" });
            AlterColumn("dbo.Videos", "Name", c => c.String());
            AlterColumn("dbo.Videos", "Genre_Id", c => c.Byte());
            CreateIndex("dbo.Videos", "Genre_Id");
            AddForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "Genre_Id" });
            AlterColumn("dbo.Videos", "Genre_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Videos", "Name", c => c.String(nullable: false));
            CreateIndex("dbo.Videos", "Genre_Id");
            AddForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
