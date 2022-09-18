namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_yazar_unvan_add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Yazars", "YazarUnvan", c => c.String(maxLength: 75));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Yazars", "YazarUnvan");
        }
    }
}
