namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testpassport : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Passports",
                c => new
                    {
                        PassportNumber = c.Int(nullable: false),
                        IssuingCountry = c.String(nullable: false, maxLength: 128),
                        Issued = c.DateTime(nullable: false),
                        Expires = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.PassportNumber, t.IssuingCountry });
            
            CreateTable(
                "dbo.PassportStamps",
                c => new
                    {
                        PassportNumber = c.Int(nullable: false),
                        IssuingCountry = c.String(maxLength: 128),
                        StampId = c.Int(nullable: false, identity: true),
                        Stamped = c.DateTime(nullable: false),
                        StampingCountry = c.String(),
                        Title = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StampId)
                .ForeignKey("dbo.Passports", t => new { t.PassportNumber, t.IssuingCountry })
                .Index(t => new { t.PassportNumber, t.IssuingCountry });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PassportStamps", new[] { "PassportNumber", "IssuingCountry" }, "dbo.Passports");
            DropIndex("dbo.PassportStamps", new[] { "PassportNumber", "IssuingCountry" });
            DropTable("dbo.PassportStamps");
            DropTable("dbo.Passports");
        }
    }
}
