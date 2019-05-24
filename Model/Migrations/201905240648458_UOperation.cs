namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UOperation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Operations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Processes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Processes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Operations");
        }
    }
}
