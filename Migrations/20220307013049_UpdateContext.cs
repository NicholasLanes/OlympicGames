using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicGames.Migrations
{
    public partial class UpdateContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "austria",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "para", "austria.png", "can" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "brazil",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "sum", "brazil.png", "road" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "canada",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "wint", "canada.png", "cur" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "china",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "sum", "china.png", "div" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "cyprus",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "y", "cyprus.png", "break" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "finland",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "y", "finland.png", "skate" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "france",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "y", "france.png", "break" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "gb",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "wint", "gb.png", "cur" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "germany",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "sum", "germany.png", "div" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "italy",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "wint", "italy.png", "bob" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "jamaica",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "wint", "jamaica.png", "bob" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "japan",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "wint", "japan.png", "bob" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "mexico",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "sum", "mexico.png", "div" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "netherlands",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "sum", "netherlands.png", "road" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "pakistan",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "para", "pakistan.png", "can" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "portugal",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "y", "portugal.png", "skate" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "russia",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "y", "russia.png", "break" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "slovakia",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "y", "slovakia.png", "skate" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "sweden",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "wint", "sweden.png", "cur" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "thailand",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "para", "thailand.png", "arch" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "ukraine",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "para", "ukraine.png", "arch" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "uruguay",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "para", "uruguay.png", "arch" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "usa",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "sum", "usa.png", "road" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "zimbabwe",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { "para", "zimbabwe.png", "can" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "austria",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "brazil",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "canada",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "china",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "cyprus",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "finland",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "france",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "gb",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "germany",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "italy",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "jamaica",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "japan",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "mexico",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "netherlands",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "pakistan",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "portugal",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "russia",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "slovakia",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "sweden",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "thailand",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "ukraine",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "uruguay",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "usa",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: "zimbabwe",
                columns: new[] { "GameId", "LogoImage", "SportId" },
                values: new object[] { null, null, null });
        }
    }
}
