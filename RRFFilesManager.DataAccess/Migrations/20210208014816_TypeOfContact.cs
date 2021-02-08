using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class TypeOfContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "TypeOfContact",
                table: "Contacts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeOfContact",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
