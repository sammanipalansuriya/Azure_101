namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addprofileimage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "ProfileImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "ProfileImage");
        }
    }
}
