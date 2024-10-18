namespace NavigatorProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IstorijaStatusas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Int(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        Kandidat_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kandidats", t => t.Kandidat_Id)
                .Index(t => t.Kandidat_Id);
            
            CreateTable(
                "dbo.Kandidats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(nullable: false),
                        Prezime = c.String(nullable: false),
                        JMBG = c.String(nullable: false, maxLength: 13),
                        DatumRodjenja = c.DateTime(nullable: false),
                        Email = c.String(nullable: false),
                        Telefon = c.Int(nullable: false),
                        Napomena = c.String(),
                        LastUpdate = c.DateTime(nullable: false),
                        PrilogCV = c.Binary(),
                        Slika = c.Binary(),
                        Ocena = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IstorijaStatusas", "Kandidat_Id", "dbo.Kandidats");
            DropIndex("dbo.IstorijaStatusas", new[] { "Kandidat_Id" });
            DropTable("dbo.Kandidats");
            DropTable("dbo.IstorijaStatusas");
        }
    }
}
