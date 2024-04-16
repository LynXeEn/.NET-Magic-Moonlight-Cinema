namespace Magic_Moonlight_Cinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class moviecinema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cinemas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                        Capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        ReleaseDate = c.String(),
                        Genre = c.String(),
                        Duration = c.Int(nullable: false),
                        CinemaBroadcast_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cinemas", t => t.CinemaBroadcast_Id)
                .Index(t => t.CinemaBroadcast_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "CinemaBroadcast_Id", "dbo.Cinemas");
            DropIndex("dbo.Movies", new[] { "CinemaBroadcast_Id" });
            DropTable("dbo.Movies");
            DropTable("dbo.Cinemas");
        }
    }
}
