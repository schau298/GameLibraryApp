using Microsoft.EntityFrameworkCore.Migrations;

namespace GameLibraryApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Platform = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "ID", "Cost", "Genre", "Name", "Platform" },
                values: new object[,]
                {
                    { 1, 25, "Action RPG", "Cyberpunk", "Xbox" },
                    { 2, 7, "Adeventure", "Minecraft", "Mobile" },
                    { 3, 0, "Battle Royale", "Fortnite", "Playstation" },
                    { 4, 60, "Racing", "Mariokart", "Nintendo Consoles" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
