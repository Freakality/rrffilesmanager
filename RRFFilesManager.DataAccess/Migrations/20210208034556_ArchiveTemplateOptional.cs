using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class ArchiveTemplateOptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Archives_Templates_TemplateId",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "ExcelFile",
                table: "Intakes");

            migrationBuilder.DropColumn(
                name: "WordFile",
                table: "Intakes");

            migrationBuilder.AlterColumn<int>(
                name: "TemplateId",
                table: "Archives",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Archives_Templates_TemplateId",
                table: "Archives",
                column: "TemplateId",
                principalTable: "Templates",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Archives_Templates_TemplateId",
                table: "Archives");

            migrationBuilder.AddColumn<string>(
                name: "ExcelFile",
                table: "Intakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WordFile",
                table: "Intakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TemplateId",
                table: "Archives",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Archives_Templates_TemplateId",
                table: "Archives",
                column: "TemplateId",
                principalTable: "Templates",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
