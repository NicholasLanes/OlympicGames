using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicGames.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    SportId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.SportId);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SportId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LogoImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Teams_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teams_Sports_SportId",
                        column: x => x.SportId,
                        principalTable: "Sports",
                        principalColumn: "SportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Name" },
                values: new object[,]
                {
                    { "wint", "Winter Olympics" },
                    { "sum", "Summer Olympics" },
                    { "para", "Paralympics" },
                    { "y", "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "SportId", "Name" },
                values: new object[,]
                {
                    { "break", "Breakdancing/Indoor" },
                    { "can", "Canoe Sprint/Outdoor" },
                    { "arch", "Archery/Indoor" },
                    { "skate", "Skateboarding/Outdoor" },
                    { "div", "Diving/Indoor" },
                    { "bob", "Bobsleigh/Outdoor" },
                    { "cur", "Curling/Indoor" },
                    { "road", "Road Cycling/Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "GameId", "LogoImage", "Name", "SportId" },
                values: new object[,]
                {
                    { "thailand", "para", "thailand.png", "Thailand", "arch" },
                    { "finland", "y", "finland.png", "Finland", "skate" },
                    { "russia", "y", "russia.png", "Russia", "break" },
                    { "cyprus", "y", "cyprus.png", "Cyprus", "break" },
                    { "france", "y", "france.png", "France", "break" },
                    { "zimbabwe", "para", "zimbabwe.png", "Zimbabwe", "can" },
                    { "pakistan", "para", "pakistan.png", "Pakistan", "can" },
                    { "austria", "para", "austria.png", "Austria", "can" },
                    { "ukraine", "para", "ukraine.png", "Ukraine", "arch" },
                    { "uruguay", "para", "uruguay.png", "Uruguay", "arch" },
                    { "usa", "sum", "usa.png", "USA", "road" },
                    { "japan", "wint", "japan.png", "Japan", "bob" },
                    { "brazil", "sum", "brazil.png", "Brazil", "road" },
                    { "mexico", "sum", "mexico.png", "Mexico", "div" },
                    { "china", "sum", "china.png", "China", "div" },
                    { "germany", "sum", "germany.png", "Germany", "div" },
                    { "slovakia", "y", "slovakia.png", "Slovakia", "skate" },
                    { "italy", "wint", "italy.png", "Italy", "bob" },
                    { "jamaica", "wint", "jamaica.png", "Jamaica", "bob" },
                    { "gb", "wint", "gb.png", "Great Britain", "cur" },
                    { "sweden", "wint", "sweden.png", "Sweden", "cur" },
                    { "canada", "wint", "canada.png", "Canada", "cur" },
                    { "netherlands", "sum", "netherlands.png", "Netherlands", "road" },
                    { "portugal", "y", "portugal.png", "Portugal", "skate" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_GameId",
                table: "Teams",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_SportId",
                table: "Teams",
                column: "SportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Sports");
        }
    }
}
