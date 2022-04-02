using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class BenefitCleanup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatementPeriodEnds",
                table: "StandardBenefitRows");

            migrationBuilder.AddColumn<string>(
                name: "InsuranceCompany",
                table: "Archives",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsuranceCompany",
                table: "Archives");

            migrationBuilder.AddColumn<DateTime>(
                name: "StatementPeriodEnds",
                table: "StandardBenefitRows",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
