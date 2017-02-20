namespace ShowList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class models : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Episodes",
                c => new
                    {
                        ShowID = c.Int(nullable: false),
                        SeasonID = c.Int(nullable: false),
                        EpisodeID = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                        AirDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.ShowID, t.SeasonID, t.EpisodeID })
                .ForeignKey("dbo.Seasons", t => new { t.ShowID, t.SeasonID }, cascadeDelete: true)
                .Index(t => new { t.ShowID, t.SeasonID });
            
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        ShowID = c.Int(nullable: false),
                        SeasonID = c.Int(nullable: false),
                        SeasonYear = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ShowID, t.SeasonID })
                .ForeignKey("dbo.Shows", t => t.ShowID, cascadeDelete: true)
                .Index(t => t.ShowID);
            
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        ShowID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Network = c.String(nullable: false),
                        PrimaryGenre = c.String(nullable: false),
                        SencondaryGenre = c.String(),
                        RunYears = c.String(nullable: false),
                        Summary = c.String(nullable: false),
                        Status = c.String(nullable: false),
                        Rating = c.String(nullable: false),
                        TotalEp = c.Int(nullable: false),
                        NextEpisode = c.DateTime(),
                    })
                .PrimaryKey(t => t.ShowID);
            
            CreateTable(
                "dbo.UserShows",
                c => new
                    {
                        UserID = c.String(nullable: false, maxLength: 128),
                        ShowID = c.Int(nullable: false),
                        ShowName = c.String(nullable: false),
                        Status = c.String(nullable: false),
                        CurrentEp = c.Int(nullable: false),
                        TotalEp = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.ShowID })
                .ForeignKey("dbo.Shows", t => t.ShowID, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.ShowID);
            
            AddColumn("dbo.AspNetUsers", "DisplayName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Gender", c => c.Boolean());
            AddColumn("dbo.AspNetUsers", "Location", c => c.String());
            AddColumn("dbo.AspNetUsers", "AboutMe", c => c.String());
            AddColumn("dbo.AspNetUsers", "DefaultTab", c => c.String());
            AddColumn("dbo.AspNetUsers", "MissedEp", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "Messages", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserShows", "UserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserShows", "ShowID", "dbo.Shows");
            DropForeignKey("dbo.Seasons", "ShowID", "dbo.Shows");
            DropForeignKey("dbo.Episodes", new[] { "ShowID", "SeasonID" }, "dbo.Seasons");
            DropIndex("dbo.UserShows", new[] { "ShowID" });
            DropIndex("dbo.UserShows", new[] { "UserID" });
            DropIndex("dbo.Seasons", new[] { "ShowID" });
            DropIndex("dbo.Episodes", new[] { "ShowID", "SeasonID" });
            DropColumn("dbo.AspNetUsers", "Messages");
            DropColumn("dbo.AspNetUsers", "MissedEp");
            DropColumn("dbo.AspNetUsers", "DefaultTab");
            DropColumn("dbo.AspNetUsers", "AboutMe");
            DropColumn("dbo.AspNetUsers", "Location");
            DropColumn("dbo.AspNetUsers", "Gender");
            DropColumn("dbo.AspNetUsers", "DisplayName");
            DropTable("dbo.UserShows");
            DropTable("dbo.Shows");
            DropTable("dbo.Seasons");
            DropTable("dbo.Episodes");
        }
    }
}
