namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into MembershipTypes Values (1, 0, 0, 0)");
            Sql("Insert Into MembershipTypes Values (2, 30, 1, 10)");
            Sql("Insert Into MembershipTypes Values (3, 90, 3, 15)");
            Sql("Insert Into MembershipTypes Values (4, 300, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
