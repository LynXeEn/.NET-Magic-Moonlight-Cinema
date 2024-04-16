namespace Magic_Moonlight_Cinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userTicketInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TicketCode = c.String(nullable: false),
                        SeatNumber = c.Int(nullable: false),
                        Showtime = c.String(),
                        BookingDate = c.String(),
                        PaymentMethod = c.String(),
                        user_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.user_Id)
                .Index(t => t.user_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        NewsletterSubscription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "user_Id", "dbo.Users");
            DropIndex("dbo.Tickets", new[] { "user_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Tickets");
        }
    }
}
