namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMoviesTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                {
                    id = c.Byte(nullable: false),
                    Name = c.String(nullable: false, maxLength: 255),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.Movies",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 255),
                    ReleaseDate = c.DateTime(nullable: false),
                    DataAdd = c.DateTime(nullable: false),
                    NumberinStock = c.Byte(nullable: false),
                    GenreId = c.Byte(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateIndex("dbo.Movies", "GenreId");
            AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
        }
    }
}
