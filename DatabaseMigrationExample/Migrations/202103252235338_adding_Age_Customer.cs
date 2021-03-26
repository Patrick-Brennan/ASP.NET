namespace DatabaseMigrationExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adding_Age_Customer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Age");
        }
    }
}
