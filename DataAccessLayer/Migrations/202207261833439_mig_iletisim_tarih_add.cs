namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_iletisim_tarih_add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Iletisims", "IletisimTarih", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Iletisims", "IletisimTarih");
        }
    }
}
