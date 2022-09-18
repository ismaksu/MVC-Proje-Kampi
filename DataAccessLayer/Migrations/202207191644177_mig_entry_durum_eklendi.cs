namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_entry_durum_eklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Entries", "EntryDurum", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Entries", "EntryDurum");
        }
    }
}
