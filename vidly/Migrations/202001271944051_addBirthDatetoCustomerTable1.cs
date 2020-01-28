namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBirthDatetoCustomerTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "birthdate", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "birthdate");
        }
    }
}
