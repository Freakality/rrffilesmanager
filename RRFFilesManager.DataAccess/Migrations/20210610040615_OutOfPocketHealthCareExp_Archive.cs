using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class OutOfPocketHealthCareExp_Archive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArchiveID",
                table: "OutOfPocketHealthCareExp",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OutOfPocketHealthCareExp_ArchiveID",
                table: "OutOfPocketHealthCareExp",
                column: "ArchiveID");

            migrationBuilder.AddForeignKey(
                name: "FK_OutOfPocketHealthCareExp_Archives_ArchiveID",
                table: "OutOfPocketHealthCareExp",
                column: "ArchiveID",
                principalTable: "Archives",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OutOfPocketHealthCareExp_Archives_ArchiveID",
                table: "OutOfPocketHealthCareExp");

            migrationBuilder.DropIndex(
                name: "IX_OutOfPocketHealthCareExp_ArchiveID",
                table: "OutOfPocketHealthCareExp");

            migrationBuilder.DropColumn(
                name: "ArchiveID",
                table: "OutOfPocketHealthCareExp");
        }
    }
}
