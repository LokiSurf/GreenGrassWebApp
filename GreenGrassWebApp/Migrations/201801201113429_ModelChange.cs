namespace GreenGrassWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Requests", "TakenDays", c => c.String());
            DropColumn("dbo.Requests", "Days");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Requests", "Days", c => c.String());
            DropColumn("dbo.Requests", "TakenDays");
        }
    }
}
