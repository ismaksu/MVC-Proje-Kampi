namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_resimdosya_class : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ResimDosyas",
                c => new
                    {
                        ResimID = c.Int(nullable: false, identity: true),
                        ResimAd = c.String(maxLength: 100),
                        ResimKonum = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.ResimID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ResimDosyas");
        }
    }
}
