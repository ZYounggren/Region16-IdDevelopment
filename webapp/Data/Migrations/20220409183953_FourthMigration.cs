using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapp.Data.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    SessionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SessionTitle = table.Column<string>(type: "TEXT", nullable: true),
                    SessionDescription = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.SessionId);
                });

            migrationBuilder.CreateTable(
                name: "Attendees",
                columns: table => new
                {
                    AttendeeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Grade = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    Ethnicity = table.Column<string>(type: "TEXT", nullable: true),
                    SessionId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendees", x => x.AttendeeId);
                    table.ForeignKey(
                        name: "FK_Attendees_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "SessionId");
                });

            migrationBuilder.CreateTable(
                name: "Speakers",
                columns: table => new
                {
                    SpeakerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JobTitle = table.Column<string>(type: "TEXT", nullable: true),
                    SessionId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speakers", x => x.SpeakerId);
                    table.ForeignKey(
                        name: "FK_Speakers_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "SessionId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_SessionId",
                table: "Attendees",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Speakers_SessionId",
                table: "Speakers",
                column: "SessionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendees");

            migrationBuilder.DropTable(
                name: "Speakers");

            migrationBuilder.DropTable(
                name: "Sessions");
        }
    }
}
