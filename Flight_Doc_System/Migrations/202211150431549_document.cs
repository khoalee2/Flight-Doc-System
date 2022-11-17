namespace Flight_Doc_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class document1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        DocumentName = c.String(nullable: false, maxLength: 128),
                        Type = c.String(),
                        FlightNo = c.String(),
                        DepartureDate = c.DateTime(nullable: false),
                        Creator = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DocumentName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Documents");
        }
    }
}
