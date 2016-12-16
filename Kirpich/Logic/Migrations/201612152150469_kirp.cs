namespace Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kirp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameOfDish = c.String(),
                        Price = c.Int(nullable: false),
                        Availability = c.String(),
                        MenuChapterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MenuChapters", t => t.MenuChapterId, cascadeDelete: true)
                .Index(t => t.MenuChapterId);
            
            CreateTable(
                "dbo.MenuChapters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Menus", "MenuChapterId", "dbo.MenuChapters");
            DropIndex("dbo.Menus", new[] { "MenuChapterId" });
            DropTable("dbo.MenuChapters");
            DropTable("dbo.Menus");
        }
    }
}
