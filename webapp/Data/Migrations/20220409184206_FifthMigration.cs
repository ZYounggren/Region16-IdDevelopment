using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapp.Data.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Speakers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Speakers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Speakers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MailAddress",
                table: "Speakers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimaryPhoneNumber",
                table: "Speakers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Attendees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Attendees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Attendees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MailAddress",
                table: "Attendees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimaryPhoneNumber",
                table: "Attendees",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Speakers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Speakers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Speakers");

            migrationBuilder.DropColumn(
                name: "MailAddress",
                table: "Speakers");

            migrationBuilder.DropColumn(
                name: "PrimaryPhoneNumber",
                table: "Speakers");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "MailAddress",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "PrimaryPhoneNumber",
                table: "Attendees");
        }
    }
}
