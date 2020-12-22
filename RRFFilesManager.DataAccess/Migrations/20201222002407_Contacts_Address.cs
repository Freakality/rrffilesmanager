using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class Contacts_Address : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Street",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "Contacts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
