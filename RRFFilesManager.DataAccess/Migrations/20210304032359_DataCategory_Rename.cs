using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class DataCategory_Rename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentType",
                table: "Archives");

            migrationBuilder.AddColumn<string>(
                name: "DocumentCategory",
                table: "Archives",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentCategory",
                table: "Archives");

            migrationBuilder.AddColumn<string>(
                name: "DocumentType",
                table: "Archives",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
