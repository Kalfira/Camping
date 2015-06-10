namespace Day9Associations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DirectoryChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Director", c => c.String());
            DropColumn("dbo.Movies", "Directory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Directory", c => c.String());
            DropColumn("dbo.Movies", "Director");
        }
    }
}
