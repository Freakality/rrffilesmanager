using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class Lawyer_NumberID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberID",
                table: "Lawyers");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Lawyers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Lawyers");

            migrationBuilder.AddColumn<int>(
                name: "NumberID",
                table: "Lawyers",
                type: "int",
                nullable: true);
        }
    }
}
