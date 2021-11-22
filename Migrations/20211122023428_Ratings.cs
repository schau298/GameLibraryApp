using Microsoft.EntityFrameworkCore.Migrations;

namespace GameLibraryApp.Migrations
{
    public partial class Ratings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Rating = table.Column<string>(nullable: false),
                    RatingValue = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    GamesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Rating);
                    table.ForeignKey(
                        name: "FK_Ratings_Games_GamesID",
                        column: x => x.GamesID,
                        principalTable: "Games",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Rating", "GamesID", "Name", "RatingValue" },
                values: new object[,]
                {
                    { "It's got decent graphics and a fun, open world map to play on. Story missions can be buggy at times.", null, "Cyberpunk", 7 },
                    { "A wonderful game where you can let your creativity run wild. You can build whatever you want, explore, and survive.", null, "Minecraft", 10 },
                    { "Nice graphics and combat but the skill differnce between players can make the game exhausting.", null, "Fortnite", 6 },
                    { "Classic Racing game and is defintiely a must play for anyone who enjoys mario or racing games.", null, "Mariokart", 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_GamesID",
                table: "Ratings",
                column: "GamesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");
        }
    }
}
