namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_mesajokunmasi_eklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mesajs", "MesajOkunmasi", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mesajs", "MesajOkunmasi");
        }
    }
}
