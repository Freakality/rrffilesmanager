using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class DocumentGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentCategories_DocumentFolders_DocumentFolderID",
                table: "DocumentCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DocumentFolders",
                table: "DocumentFolders");

            migrationBuilder.RenameTable(
                name: "DocumentFolders",
                newName: "DocumentFolder");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocumentFolder",
                table: "DocumentFolder",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentCategories_DocumentFolder_DocumentFolderID",
                table: "DocumentCategories",
                column: "DocumentFolderID",
                principalTable: "DocumentFolder",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentCategories_DocumentFolder_DocumentFolderID",
                table: "DocumentCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DocumentFolder",
                table: "DocumentFolder");

            migrationBuilder.RenameTable(
                name: "DocumentFolder",
                newName: "DocumentFolders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocumentFolders",
                table: "DocumentFolders",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentCategories_DocumentFolders_DocumentFolderID",
                table: "DocumentCategories",
                column: "DocumentFolderID",
                principalTable: "DocumentFolders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
