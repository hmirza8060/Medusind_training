namespace Assignment_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MId = c.Int(nullable: false, identity: true),
                        MovieName = c.String(nullable: false),
                        Dateofrelease = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
