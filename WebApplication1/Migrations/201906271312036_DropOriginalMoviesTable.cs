namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropOriginalMoviesTable : DbMigration
    {
        public override void Up()
        {
            DropTable("Movies");
        }
        
        public override void Down()
        {
        }
    }
}
