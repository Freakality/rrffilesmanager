using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class Archive_NewFields2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DocumentForm",
                table: "DocumentGroups",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DocumentForm",
                table: "DocumentCategories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentForm",
                table: "DocumentGroups");

            migrationBuilder.DropColumn(
                name: "DocumentForm",
                table: "DocumentCategories");
        }
    }
}
