namespace Login_forme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMoreModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Komentars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        KorisnikID = c.Int(nullable: false),
                        Napisan = c.DateTime(nullable: false),
                        Modifikovan = c.DateTime(nullable: false, defaultValue: null),
                        TemaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Korisniks", t => t.KorisnikID, cascadeDelete: true)
                .ForeignKey("dbo.Temas", t => t.TemaID, cascadeDelete: true)
                .Index(t => t.KorisnikID)
                .Index(t => t.TemaID);
            
            CreateTable(
                "dbo.Temas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naslov = c.String(),
                        Text = c.String(),
                        KorisnikID = c.Int(nullable: false),
                        Napravljena = c.DateTime(nullable: false),
                        Modifikovana = c.DateTime(nullable: false, defaultValue: null),
                        BrojKomentara = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Korisniks", t => t.KorisnikID, cascadeDelete: false)
                .Index(t => t.KorisnikID);
            
            AddColumn("dbo.Korisniks", "Uloga", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Komentars", "TemaID", "dbo.Temas");
            DropForeignKey("dbo.Temas", "KorisnikID", "dbo.Korisniks");
            DropForeignKey("dbo.Komentars", "KorisnikID", "dbo.Korisniks");
            DropIndex("dbo.Temas", new[] { "KorisnikID" });
            DropIndex("dbo.Komentars", new[] { "TemaID" });
            DropIndex("dbo.Komentars", new[] { "KorisnikID" });
            DropColumn("dbo.Korisniks", "Uloga");
            DropTable("dbo.Temas");
            DropTable("dbo.Komentars");
        }
    }
}
