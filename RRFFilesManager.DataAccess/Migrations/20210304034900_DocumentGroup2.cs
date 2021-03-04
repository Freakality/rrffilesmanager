using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class DocumentGroup2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentCategories_DocumentFolder_DocumentFolderID",
                table: "DocumentCategories");

            migrationBuilder.DropTable(
                name: "DocumentFolder");

            migrationBuilder.DropIndex(
                name: "IX_DocumentCategories_DocumentFolderID",
                table: "DocumentCategories");

            migrationBuilder.DropColumn(
                name: "DocumentFolderID",
                table: "DocumentCategories");

            migrationBuilder.AddColumn<int>(
                name: "DocumentGroupID",
                table: "DocumentCategories",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DocumentFolders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentFolders", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DocumentCategories_DocumentGroupID",
                table: "DocumentCategories",
                column: "DocumentGroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentCategories_DocumentFolders_DocumentGroupID",
                table: "DocumentCategories",
                column: "DocumentGroupID",
                principalTable: "DocumentFolders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentCategories_DocumentFolders_DocumentGroupID",
                table: "DocumentCategories");

            migrationBuilder.DropTable(
                name: "DocumentFolders");

            migrationBuilder.DropIndex(
                name: "IX_DocumentCategories_DocumentGroupID",
                table: "DocumentCategories");

            migrationBuilder.DropColumn(
                name: "DocumentGroupID",
                table: "DocumentCategories");

            migrationBuilder.AddColumn<int>(
                name: "DocumentFolderID",
                table: "DocumentCategories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DocumentFolder",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentFolder", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DocumentCategories_DocumentFolderID",
                table: "DocumentCategories",
                column: "DocumentFolderID");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentCategories_DocumentFolder_DocumentFolderID",
                table: "DocumentCategories",
                column: "DocumentFolderID",
                principalTable: "DocumentFolder",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
