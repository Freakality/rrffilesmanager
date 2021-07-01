using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class OutOfPocketHealthCareExp_Ditance_Expenses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ReturnKilometresTraveled",
                table: "OutOfPocketHealthCareExp",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TravelExpenses",
                table: "OutOfPocketHealthCareExp",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReturnKilometresTraveled",
                table: "OutOfPocketHealthCareExp");

            migrationBuilder.DropColumn(
                name: "TravelExpenses",
                table: "OutOfPocketHealthCareExp");
        }
    }
}
