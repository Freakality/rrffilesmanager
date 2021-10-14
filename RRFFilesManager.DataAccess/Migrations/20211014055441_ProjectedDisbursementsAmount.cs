using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class ProjectedDisbursementsAmount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ProjectedDisbursementsAmount",
                table: "MatterTypes",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ProjectedDisbursementsAmount",
                table: "ComissionSubTypes",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectedDisbursementsAmount",
                table: "MatterTypes");

            migrationBuilder.DropColumn(
                name: "ProjectedDisbursementsAmount",
                table: "ComissionSubTypes");
        }
    }
}
