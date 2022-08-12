namespace VidzyExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TagsTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VideoTags",
                c => new
                    {
                        TagId = c.Int(nullable: false),
                        VideoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TagId, t.VideoId })
                .ForeignKey("dbo.Tags", t => t.TagId, cascadeDelete: true)
                .ForeignKey("dbo.Videos", t => t.VideoId, cascadeDelete: true)
                .Index(t => t.TagId)
                .Index(t => t.VideoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VideoTags", "VideoId", "dbo.Videos");
            DropForeignKey("dbo.VideoTags", "TagId", "dbo.Tags");
            DropIndex("dbo.VideoTags", new[] { "VideoId" });
            DropIndex("dbo.VideoTags", new[] { "TagId" });
            DropTable("dbo.VideoTags");
            DropTable("dbo.Tags");
        }
    }
}
