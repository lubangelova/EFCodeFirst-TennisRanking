namespace TennisRanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTournamentsToPlayer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Players", "Tournament_Id", "dbo.Tournaments");
            DropIndex("dbo.Players", new[] { "Tournament_Id" });
            CreateTable(
                "dbo.PlayerTournaments",
                c => new
                    {
                        Player_Id = c.Int(nullable: false),
                        Tournament_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Player_Id, t.Tournament_Id })
                .ForeignKey("dbo.Players", t => t.Player_Id, cascadeDelete: true)
                .ForeignKey("dbo.Tournaments", t => t.Tournament_Id, cascadeDelete: true)
                .Index(t => t.Player_Id)
                .Index(t => t.Tournament_Id);
            
            DropColumn("dbo.Players", "Tournament_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "Tournament_Id", c => c.Int());
            DropForeignKey("dbo.PlayerTournaments", "Tournament_Id", "dbo.Tournaments");
            DropForeignKey("dbo.PlayerTournaments", "Player_Id", "dbo.Players");
            DropIndex("dbo.PlayerTournaments", new[] { "Tournament_Id" });
            DropIndex("dbo.PlayerTournaments", new[] { "Player_Id" });
            DropTable("dbo.PlayerTournaments");
            CreateIndex("dbo.Players", "Tournament_Id");
            AddForeignKey("dbo.Players", "Tournament_Id", "dbo.Tournaments", "Id");
        }
    }
}
