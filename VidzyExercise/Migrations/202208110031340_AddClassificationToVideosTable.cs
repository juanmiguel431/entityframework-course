namespace VidzyExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassificationToVideosTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "Classification", c => c.Byte(nullable: false, defaultValue: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "Classification");
        }
    }
}
