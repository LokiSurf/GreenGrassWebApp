namespace GreenGrassWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_request_model1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TableHistoryRequests",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        LastName = c.String(),
                        Team = c.String(),
                        Manager = c.String(),
                        TypeReguest = c.String(),
                        Date = c.String(),
                        TakenDays = c.String(),
                        TotalTakenDays = c.String(),
                        TotalAvailableDays = c.String(),
                        ReguestStatus = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TableHistoryRequests");
        }
    }
}
