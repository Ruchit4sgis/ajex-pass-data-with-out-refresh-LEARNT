namespace async_learn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Student_detail",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        MemberId = c.String(),
                        Name = c.String(),
                        Standard = c.String(),
                        house = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Student_detail");
        }
    }
}
