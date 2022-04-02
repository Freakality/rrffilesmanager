using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class ArchiveStandardBenefitUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CGPaidToDate",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IRBPaidToDate",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NonEarnerPdToDate",
                table: "Archives",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CGPaidToDate",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "IRBPaidToDate",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "NonEarnerPdToDate",
                table: "Archives");
        }
    }
}
