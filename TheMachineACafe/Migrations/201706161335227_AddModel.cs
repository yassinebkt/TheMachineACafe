namespace TheMachineACafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boissons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Selections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BoissonId = c.Int(nullable: false),
                        Sucre = c.Int(nullable: false),
                        HasMuge = c.Boolean(nullable: false),
                        UserId_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Boissons", t => t.BoissonId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId_Id)
                .Index(t => t.BoissonId)
                .Index(t => t.UserId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Selections", "UserId_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Selections", "BoissonId", "dbo.Boissons");
            DropIndex("dbo.Selections", new[] { "UserId_Id" });
            DropIndex("dbo.Selections", new[] { "BoissonId" });
            DropTable("dbo.Selections");
            DropTable("dbo.Boissons");
        }
    }
}
