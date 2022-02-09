namespace LoginEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        username = c.String(nullable: false, maxLength: 128),
                        passowrd = c.String(),
                    })
                .PrimaryKey(t => t.username);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
