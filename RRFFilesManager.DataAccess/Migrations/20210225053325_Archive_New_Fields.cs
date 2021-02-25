using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class Archive_New_Fields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ACPaidToDate",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ACRemaining",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateRangeFrom",
                table: "Archives",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateRangeTo",
                table: "Archives",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DocumentDate",
                table: "Archives",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DocumentFolder",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentType",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IEAssessPdToDate",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MRACPaidToDate",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MRACRemaining",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MRPaidToDate",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MRRemaining",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolicyClaimLimit",
                table: "Archives",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StatementPeriodFrom",
                table: "Archives",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StatementPeriodTo",
                table: "Archives",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ACPaidToDate",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "ACRemaining",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "DateRangeFrom",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "DateRangeTo",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "DocumentDate",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "DocumentFolder",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "DocumentType",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "IEAssessPdToDate",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "MRACPaidToDate",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "MRACRemaining",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "MRPaidToDate",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "MRRemaining",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "PolicyClaimLimit",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "StatementPeriodFrom",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "StatementPeriodTo",
                table: "Archives");
        }
    }
}
