using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class OutOfPocketHealthCareExp_Properties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "MiscExpenses",
                table: "OutOfPocketHealthCareExp",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ParkingExpenses",
                table: "OutOfPocketHealthCareExp",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TreatmentExpenses",
                table: "OutOfPocketHealthCareExp",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MiscExpenses",
                table: "OutOfPocketHealthCareExp");

            migrationBuilder.DropColumn(
                name: "ParkingExpenses",
                table: "OutOfPocketHealthCareExp");

            migrationBuilder.DropColumn(
                name: "TreatmentExpenses",
                table: "OutOfPocketHealthCareExp");
        }
    }
}
