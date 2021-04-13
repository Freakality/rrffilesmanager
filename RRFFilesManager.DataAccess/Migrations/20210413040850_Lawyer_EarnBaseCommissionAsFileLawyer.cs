using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class Lawyer_EarnBaseCommissionAsFileLawyer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EarnBaseCommissionAsFileLawyer",
                table: "Lawyers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EarnBaseCommissionAsFileLawyer",
                table: "Lawyers");
        }
    }
}
