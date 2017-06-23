namespace async_learn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.employee_details",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        MemberId = c.String(),
                        Name = c.String(),
                        salary = c.String(),
                        expirence = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.employee_details");
        }
    }
}
