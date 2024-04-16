namespace Magic_Moonlight_Cinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class requiredCinema : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cinemas", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cinemas", "Name", c => c.String());
        }
    }
}
