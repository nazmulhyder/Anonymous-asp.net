namespace Anonymous_311018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class databaseversion11addedtwopropertyaddedindepartmenttbl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "NumberofStudent", c => c.Int(nullable: false));
            AddColumn("dbo.Departments", "NumberofFaculty", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "NumberofFaculty");
            DropColumn("dbo.Departments", "NumberofStudent");
        }
    }
}
