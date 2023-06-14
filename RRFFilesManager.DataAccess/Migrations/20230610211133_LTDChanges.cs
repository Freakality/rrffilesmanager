using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class LTDChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PolDeniedSTPorLTD",
                table: "Intakes");

            migrationBuilder.AddColumn<string>(
                name: "EILEmployerName",
                table: "Intakes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EILEmploymentPosition",
                table: "Intakes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EILEssentialEmploymentDuties",
                table: "Intakes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LimConflictCheck",
                table: "Intakes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LimDateGivenToLawyer",
                table: "Intakes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LimDateOfDenial",
                table: "Intakes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PolAppealedInsurance",
                table: "Intakes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolBenefitsDeniedTerminated",
                table: "Intakes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolCertificateNumber",
                table: "Intakes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PolDateEligibleLTD",
                table: "Intakes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PolDateFirstBenefits",
                table: "Intakes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PolDeniedLTDBenefits",
                table: "Intakes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolDisabilityInsurerThirdParty",
                table: "Intakes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolInsuranceCaseManager",
                table: "Intakes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolLTDBenefitsTaxable",
                table: "Intakes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolMonthlyEntitledLTD",
                table: "Intakes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolPastOffWork",
                table: "Intakes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolPolicyNumber",
                table: "Intakes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolReasonWork",
                table: "Intakes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EILEmployerName",
                table: "Intakes");

            migrationBuilder.DropColumn(
                name: "EILEmploymentPosition",
                table: "Intakes");

            migrationBuilder.DropColumn(
                name: "EILEssentialEmploymentDuties",
                table: "Intakes");

            migrationBuilder.DropColumn(
                name: "LimConflictCheck",
                table: "Intakes");

            migrationBuilder.DropColumn(
                name: "LimDateGivenToLawyer",
                table: "Intakes");

            migrationBuilder.DropColumn(
                name: "LimDateOfDenial",
                table: "Intakes");

            migrationBuilder.DropColumn(
                name: "PolAppealedInsurance",
                table: "Intakes");

            migrationBuilder.DropColumn(
                name: "PolBenefitsDeniedTerminated",
                table: "Intakes");

            migrationBuilder.DropColumn(
                name: "PolCertificateNumber",
                table: "Intakes");

            migrationBuilder.DropColumn(
                name: "PolDateEligibleLTD",
                table: "Intakes");

            migrationBuilder.DropColumn(
                name: "PolDateFirstBenefits",
                table: "Intakes");

            migrationBuilder.DropColumn(
                name: "PolDeniedLTDBenefits",
                table: "Intakes");

            migrationBuilder.DropColumn(
                name: "PolDisabilityInsurerThirdParty",
                table: "Intakes");

            migrationBuilder.DropColumn(
                name: "PolInsuranceCaseManager",
                table: "Intakes");

            migrationBuilder.DropColumn(
                name: "PolLTDBenefitsTaxable",
                table: "Intakes");

            migrationBuilder.DropColumn(
                name: "PolMonthlyEntitledLTD",
                table: "Intakes");

            migrationBuilder.DropColumn(
                name: "PolPastOffWork",
                table: "Intakes");

            migrationBuilder.DropColumn(
                name: "PolPolicyNumber",
                table: "Intakes");

            migrationBuilder.DropColumn(
                name: "PolReasonWork",
                table: "Intakes");

            migrationBuilder.AddColumn<string>(
                name: "PolDeniedSTPorLTD",
                table: "Intakes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
