namespace Magic_Moonlight_Cinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class maybeLast : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Tickets", new[] { "user_Id" });
            AddColumn("dbo.Tickets", "film", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "Movie_Id", c => c.Int());
            CreateIndex("dbo.Tickets", "Movie_Id");
            CreateIndex("dbo.Tickets", "User_Id");
            AddForeignKey("dbo.Tickets", "Movie_Id", "dbo.Movies", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Tickets", new[] { "User_Id" });
            DropIndex("dbo.Tickets", new[] { "Movie_Id" });
            DropColumn("dbo.Tickets", "Movie_Id");
            DropColumn("dbo.Tickets", "film");
            CreateIndex("dbo.Tickets", "user_Id");
        }
    }
}
