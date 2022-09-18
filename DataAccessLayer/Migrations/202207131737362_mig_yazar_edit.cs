namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_yazar_edit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Yazars", "YazarAciklama", c => c.String(maxLength: 175));
            AlterColumn("dbo.Yazars", "YazarMail", c => c.String(maxLength: 400));
            AlterColumn("dbo.Yazars", "YazarSifre", c => c.String(maxLength: 400));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Yazars", "YazarSifre", c => c.String(maxLength: 50));
            AlterColumn("dbo.Yazars", "YazarMail", c => c.String(maxLength: 50));
            DropColumn("dbo.Yazars", "YazarAciklama");
        }
    }
}
