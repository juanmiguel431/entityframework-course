namespace CodeFirstExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCategoriesTable : DbMigration
    {
        public override void Up()
        {
            RenameTable("dbo.Categories", "dbo._Categories");
            //DropTable("dbo.Categories");
        }
        
        public override void Down()
        {
            RenameTable("dbo._Categories", "dbo.Categories");
            //CreateTable(
            //    "dbo.Categories",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Name = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
        }
    }
}
