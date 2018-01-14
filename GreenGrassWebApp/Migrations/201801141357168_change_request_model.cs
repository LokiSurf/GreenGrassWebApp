namespace GreenGrassWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_request_model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RequestHistories",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        TypeReguest = c.String(),
                        Date = c.String(),
                        Days = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        LastName = c.String(),
                        Team = c.String(),
                        Manager = c.String(),
                        EmailManager = c.String(),
                        EmailHR = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.HolidayRequests");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.HolidayRequests",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        TypeReguest = c.String(),
                        Name = c.String(),
                        LastName = c.String(),
                        Team = c.String(),
                        Date = c.String(),
                        Days = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.UserProfiles");
            DropTable("dbo.Requests");
            DropTable("dbo.RequestHistories");
        }
    }
}
