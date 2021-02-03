using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class CompanyAddresses_ContactsFax : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Street",
                table: "Companies");

            migrationBuilder.AddColumn<string>(
                name: "Extension",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fax",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "Companies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Extension",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Fax",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "Companies");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
