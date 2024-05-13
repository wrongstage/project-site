namespace boutique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationdb4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "Date", c => c.Int(nullable: false));
        }
    }
}
