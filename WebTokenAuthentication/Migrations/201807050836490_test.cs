namespace WebTokenAuthentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tasks", "Project_ProjectId", "dbo.Projects");
            DropIndex("dbo.Tasks", new[] { "Project_ProjectId" });
            RenameColumn(table: "dbo.Tasks", name: "Project_ProjectId", newName: "ProjectId");
            AlterColumn("dbo.Tasks", "ProjectId", c => c.Int(nullable: false));
            CreateIndex("dbo.Tasks", "ProjectId");
            AddForeignKey("dbo.Tasks", "ProjectId", "dbo.Projects", "ProjectId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "ProjectId", "dbo.Projects");
            DropIndex("dbo.Tasks", new[] { "ProjectId" });
            AlterColumn("dbo.Tasks", "ProjectId", c => c.Int());
            RenameColumn(table: "dbo.Tasks", name: "ProjectId", newName: "Project_ProjectId");
            CreateIndex("dbo.Tasks", "Project_ProjectId");
            AddForeignKey("dbo.Tasks", "Project_ProjectId", "dbo.Projects", "ProjectId");
        }
    }
}
