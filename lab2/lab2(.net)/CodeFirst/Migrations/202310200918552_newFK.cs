namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newFK : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Players", "TeamId", c => c.Int());
            CreateIndex("dbo.Players", "TeamId");
            AddForeignKey("dbo.Players", "TeamId", "dbo.Teams", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "TeamId" });
            AlterColumn("dbo.Players", "TeamId", c => c.Int(nullable: false));
        }
    }
}
