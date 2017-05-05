namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGigDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Gigs", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Gigs", "DateTime", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
    }
}
