namespace GameBlog1488.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        IdGenre = c.Int(nullable: false, identity: true),
                        NameGenre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdGenre);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                        TextComment = c.String(nullable: false),
                        CurrentDate = c.DateTime(nullable: false),
                        IdGenre = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.IdGenre, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.IdUser, cascadeDelete: true)
                .Index(t => t.IdUser)
                .Index(t => t.IdGenre);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nick = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "IdUser", "dbo.Users");
            DropForeignKey("dbo.Posts", "IdGenre", "dbo.Genres");
            DropIndex("dbo.Posts", new[] { "IdGenre" });
            DropIndex("dbo.Posts", new[] { "IdUser" });
            DropTable("dbo.Users");
            DropTable("dbo.Posts");
            DropTable("dbo.Genres");
        }
    }
}
