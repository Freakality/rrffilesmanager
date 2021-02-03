using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class Contacts_Fields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DirectPhoneExtension",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "DirectPhoneNumber",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Initials",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Memo",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "OfficePhoneExtension",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "OfficePhoneNumber",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "Cell",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DirectExtension",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DirectNumber",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstLenguage",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HealthCard",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficeExtension",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficeNumber",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Relationship",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SIN",
                table: "Contacts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cell",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "DirectExtension",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "DirectNumber",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "FirstLenguage",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "HealthCard",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "OfficeExtension",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "OfficeNumber",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Relationship",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "SIN",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "DirectPhoneExtension",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DirectPhoneNumber",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Initials",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Memo",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficePhoneExtension",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficePhoneNumber",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
