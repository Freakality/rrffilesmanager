using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class ArchiveNewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdditionalInfo",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BenefitType",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentType",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FacilityName",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HHPaidToDate",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HealthcarePractitioner",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreparedBy",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recipient",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sender",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TreatmentAmount",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeOfAssessment",
                table: "Archives",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalInfo",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "BenefitType",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "DocumentType",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "FacilityName",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "HHPaidToDate",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "HealthcarePractitioner",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "PreparedBy",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "Recipient",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "Sender",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "TreatmentAmount",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "TypeOfAssessment",
                table: "Archives");
        }
    }
}
