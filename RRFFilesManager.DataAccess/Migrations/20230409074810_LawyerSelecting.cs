using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class LawyerSelecting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FileLawyer",
                table: "Lawyers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ResponsibleLawyer",
                table: "Lawyers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileLawyer",
                table: "Lawyers");

            migrationBuilder.DropColumn(
                name: "ResponsibleLawyer",
                table: "Lawyers");
        }
    }
}
