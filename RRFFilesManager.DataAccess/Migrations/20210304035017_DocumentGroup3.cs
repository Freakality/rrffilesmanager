using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class DocumentGroup3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentCategories_DocumentFolders_DocumentGroupID",
                table: "DocumentCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DocumentFolders",
                table: "DocumentFolders");

            migrationBuilder.RenameTable(
                name: "DocumentFolders",
                newName: "DocumentGroups");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocumentGroups",
                table: "DocumentGroups",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentCategories_DocumentGroups_DocumentGroupID",
                table: "DocumentCategories",
                column: "DocumentGroupID",
                principalTable: "DocumentGroups",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentCategories_DocumentGroups_DocumentGroupID",
                table: "DocumentCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DocumentGroups",
                table: "DocumentGroups");

            migrationBuilder.RenameTable(
                name: "DocumentGroups",
                newName: "DocumentFolders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocumentFolders",
                table: "DocumentFolders",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentCategories_DocumentFolders_DocumentGroupID",
                table: "DocumentCategories",
                column: "DocumentGroupID",
                principalTable: "DocumentFolders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
