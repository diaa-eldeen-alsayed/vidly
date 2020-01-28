namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSubscribedToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "isSubscribedTnNewsletters", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "isSubscribedTnNewsletters");
        }
    }
}
