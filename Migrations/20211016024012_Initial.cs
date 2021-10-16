using Microsoft.EntityFrameworkCore.Migrations;

namespace GameLibraryApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Creators",
                columns: table => new
                {
                    CreatorId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creators", x => x.CreatorId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Genre = table.Column<string>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Platform = table.Column<string>(nullable: false),
                    CreatorId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Games_Creators_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Creators",
                        principalColumn: "CreatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Creators",
                columns: new[] { "CreatorId", "Name" },
                values: new object[,]
                {
                    { "EG", "Epic Games" },
                    { "CD", "CD Projekt Red" },
                    { "MJ", "Mojang Studios" },
                    { "NE", "Nintendo Entertainment" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "ID", "Cost", "CreatorId", "Genre", "Name", "Platform" },
                values: new object[,]
                {
                    { 3, 0, "EG", "Battle Royale", "Fortnite", "Playstation" },
                    { 1, 25, "CD", "Action RPG", "Cyberpunk", "Xbox" },
                    { 2, 7, "MJ", "Adeventure", "Minecraft", "Mobile" },
                    { 4, 60, "NE", "Racing", "Mariokart", "Nintendo Consoles" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_CreatorId",
                table: "Games",
                column: "CreatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Creators");
        }
    }
}
