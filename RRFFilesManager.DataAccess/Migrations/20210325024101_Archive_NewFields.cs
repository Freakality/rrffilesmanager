using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class Archive_NewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DocumentName",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameOfOrganization",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameOfParty",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeOfMotion",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeOfParty",
                table: "Archives",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentName",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "NameOfOrganization",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "NameOfParty",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "TypeOfMotion",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "TypeOfParty",
                table: "Archives");
        }
    }
}
