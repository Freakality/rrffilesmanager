using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class Archive_NewFields3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DocumentNameType",
                table: "DocumentGroups",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DocumentNameType",
                table: "DocumentCategories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentNameType",
                table: "DocumentGroups");

            migrationBuilder.DropColumn(
                name: "DocumentNameType",
                table: "DocumentCategories");
        }
    }
}
