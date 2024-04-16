namespace Magic_Moonlight_Cinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imageURLcinema : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cinemas", "ImageURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cinemas", "ImageURL");
        }
    }
}
