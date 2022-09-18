namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_mesaj_class : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mesajs",
                c => new
                    {
                        MesajID = c.Int(nullable: false, identity: true),
                        GonderenMail = c.String(maxLength: 50),
                        AliciMail = c.String(maxLength: 50),
                        Konu = c.String(maxLength: 100),
                        MesajIcerik = c.String(),
                        MesajTarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MesajID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Mesajs");
        }
    }
}
