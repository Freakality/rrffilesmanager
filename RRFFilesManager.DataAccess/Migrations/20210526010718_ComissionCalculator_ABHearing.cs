using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class ComissionCalculator_ABHearing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MatterProceededToHearingMultiplier",
                table: "ComissionCalculator");

            migrationBuilder.AddColumn<double>(
                name: "RLMatterProceededToABHearingMultiplier",
                table: "ComissionCalculator",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RPMatterProceededToABHearingMultiplier",
                table: "ComissionCalculator",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RLMatterProceededToABHearingMultiplier",
                table: "ComissionCalculator");

            migrationBuilder.DropColumn(
                name: "RPMatterProceededToABHearingMultiplier",
                table: "ComissionCalculator");

            migrationBuilder.AddColumn<double>(
                name: "MatterProceededToHearingMultiplier",
                table: "ComissionCalculator",
                type: "float",
                nullable: true);
        }
    }
}
