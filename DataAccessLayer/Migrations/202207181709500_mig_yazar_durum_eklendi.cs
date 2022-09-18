namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_yazar_durum_eklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Yazars", "YazarDurum", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Yazars", "YazarDurum");
        }
    }
}
