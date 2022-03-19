using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class Initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RSSIValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Bssid = table.Column<string>(type: "TEXT", nullable: true),
                    Signal_level = table.Column<string>(type: "TEXT", nullable: true),
                    Signal = table.Column<string>(type: "TEXT", nullable: true),
                    SSID = table.Column<string>(type: "TEXT", nullable: true),
                    WPA_AUTH = table.Column<string>(type: "TEXT", nullable: true),
                    WPA_CIPHER = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RSSIValues", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RSSIValues");
        }
    }
}
