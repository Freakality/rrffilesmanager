using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class ContigencyFee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ContigencyFee",
                table: "MatterTypes",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ContigencyFee",
                table: "ComissionSubTypes",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContigencyFee",
                table: "MatterTypes");

            migrationBuilder.DropColumn(
                name: "ContigencyFee",
                table: "ComissionSubTypes");
        }
    }
}
