namespace boutique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationdb3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Dates", c => c.Int(nullable: false));
            DropColumn("dbo.Items", "Data");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Data", c => c.Int(nullable: false));
            DropColumn("dbo.Items", "Dates");
        }
    }
}
