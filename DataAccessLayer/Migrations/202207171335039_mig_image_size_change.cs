namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_image_size_change : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Yazars", "YazarResim", c => c.String(maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Yazars", "YazarResim", c => c.String(maxLength: 175));
        }
    }
}
