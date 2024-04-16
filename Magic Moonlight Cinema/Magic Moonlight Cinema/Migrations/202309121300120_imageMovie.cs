namespace Magic_Moonlight_Cinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imageMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Image");
        }
    }
}
