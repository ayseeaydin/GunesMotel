namespace GunesMotel.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUserModel : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Users", "RoleID");
            CreateIndex("dbo.Users", "EmployeeID");
            AddForeignKey("dbo.Users", "EmployeeID", "dbo.Employees", "EmployeeID", cascadeDelete: true);
            AddForeignKey("dbo.Users", "RoleID", "dbo.Roles", "RoleID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RoleID", "dbo.Roles");
            DropForeignKey("dbo.Users", "EmployeeID", "dbo.Employees");
            DropIndex("dbo.Users", new[] { "EmployeeID" });
            DropIndex("dbo.Users", new[] { "RoleID" });
        }
    }
}
