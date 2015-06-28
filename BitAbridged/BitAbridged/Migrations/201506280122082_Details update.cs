namespace BitAbridged.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Detailsupdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Details",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fact1 = c.String(),
                        Fact2 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Languages", "DetailsId", c => c.Int(nullable: false));
            CreateIndex("dbo.Languages", "DetailsId");
            AddForeignKey("dbo.Languages", "DetailsId", "dbo.Details", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Languages", "DetailsId", "dbo.Details");
            DropIndex("dbo.Languages", new[] { "DetailsId" });
            DropColumn("dbo.Languages", "DetailsId");
            DropTable("dbo.Details");
        }
    }
}
