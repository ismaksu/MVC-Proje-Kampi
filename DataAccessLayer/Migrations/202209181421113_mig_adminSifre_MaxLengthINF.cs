namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_adminSifre_MaxLengthINF : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "AdminSifre", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "AdminSifre", c => c.String(maxLength: 50));
        }
    }
}
