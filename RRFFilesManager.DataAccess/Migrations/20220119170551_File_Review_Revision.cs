using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class File_Review_Revision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubTypeCategoryID",
                table: "Files",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "FRActionABenefitsStatus",
                table: "FileReviews",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateIndex(
                name: "IX_Files_SubTypeCategoryID",
                table: "Files",
                column: "SubTypeCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_ComissionSubTypes_SubTypeCategoryID",
                table: "Files",
                column: "SubTypeCategoryID",
                principalTable: "ComissionSubTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_ComissionSubTypes_SubTypeCategoryID",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_SubTypeCategoryID",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "SubTypeCategoryID",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "FRActionABenefitsStatus",
                table: "FileReviews");
        }
    }
}
