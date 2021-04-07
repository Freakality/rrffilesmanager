using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class Archive_DocumentCategoryAndGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentCategory",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "DocumentFolder",
                table: "Archives");

            migrationBuilder.AddColumn<int>(
                name: "DocumentCategoryID",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DocumentGroupID",
                table: "Archives",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Archives_DocumentCategoryID",
                table: "Archives",
                column: "DocumentCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Archives_DocumentGroupID",
                table: "Archives",
                column: "DocumentGroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_Archives_DocumentCategories_DocumentCategoryID",
                table: "Archives",
                column: "DocumentCategoryID",
                principalTable: "DocumentCategories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Archives_DocumentGroups_DocumentGroupID",
                table: "Archives",
                column: "DocumentGroupID",
                principalTable: "DocumentGroups",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Archives_DocumentCategories_DocumentCategoryID",
                table: "Archives");

            migrationBuilder.DropForeignKey(
                name: "FK_Archives_DocumentGroups_DocumentGroupID",
                table: "Archives");

            migrationBuilder.DropIndex(
                name: "IX_Archives_DocumentCategoryID",
                table: "Archives");

            migrationBuilder.DropIndex(
                name: "IX_Archives_DocumentGroupID",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "DocumentCategoryID",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "DocumentGroupID",
                table: "Archives");

            migrationBuilder.AddColumn<string>(
                name: "DocumentCategory",
                table: "Archives",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentFolder",
                table: "Archives",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
