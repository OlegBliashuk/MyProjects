namespace WcfService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BaseMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Labels",
                c => new
                    {
                        LabelId = c.Int(nullable: false, identity: true),
                        Image = c.Binary(),
                        Information = c.String(),
                        Name = c.String(),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.LabelId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Labels");
        }
    }
}
