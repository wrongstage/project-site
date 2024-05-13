namespace boutique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationdb2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Date", c => c.Int(nullable: false));
            DropColumn("dbo.Items", "Dates");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Dates", c => c.Int(nullable: false));
            DropColumn("dbo.Items", "Date");
        }
    }
}
