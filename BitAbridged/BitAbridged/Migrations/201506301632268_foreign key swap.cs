namespace BitAbridged.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foreignkeyswap : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Languages", "DetailsId", "dbo.Details");
            DropIndex("dbo.Languages", new[] { "DetailsId" });
            AddColumn("dbo.Details", "LanguageId", c => c.Int(nullable: false));
            CreateIndex("dbo.Details", "LanguageId");
            AddForeignKey("dbo.Details", "LanguageId", "dbo.Languages", "Id", cascadeDelete: true);
            DropColumn("dbo.Languages", "DetailsId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Languages", "DetailsId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Details", "LanguageId", "dbo.Languages");
            DropIndex("dbo.Details", new[] { "LanguageId" });
            DropColumn("dbo.Details", "LanguageId");
            CreateIndex("dbo.Languages", "DetailsId");
            AddForeignKey("dbo.Languages", "DetailsId", "dbo.Details", "Id", cascadeDelete: true);
        }
    }
}
