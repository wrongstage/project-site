namespace boutique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeOfClothes = c.String(),
                        Date = c.Int(nullable: false),
                        Model = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Dogs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Dogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Breed = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Items");
        }
    }
}
