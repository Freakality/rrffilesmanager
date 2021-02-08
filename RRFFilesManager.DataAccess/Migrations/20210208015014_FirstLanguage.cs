using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class FirstLanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstLenguage",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "FirstLanguage",
                table: "Contacts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstLanguage",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "FirstLenguage",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
