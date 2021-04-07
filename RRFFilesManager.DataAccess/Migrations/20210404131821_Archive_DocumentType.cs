using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class Archive_DocumentType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentType",
                table: "Archives");

            migrationBuilder.AddColumn<int>(
                name: "DocumentTypeID",
                table: "Archives",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Archives_DocumentTypeID",
                table: "Archives",
                column: "DocumentTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Archives_DocumentTypes_DocumentTypeID",
                table: "Archives",
                column: "DocumentTypeID",
                principalTable: "DocumentTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Archives_DocumentTypes_DocumentTypeID",
                table: "Archives");

            migrationBuilder.DropIndex(
                name: "IX_Archives_DocumentTypeID",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "DocumentTypeID",
                table: "Archives");

            migrationBuilder.AddColumn<string>(
                name: "DocumentType",
                table: "Archives",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
