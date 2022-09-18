namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_baslik_durum_eklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Basliks", "BaslikDurum", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Basliks", "BaslikDurum");
        }
    }
}
