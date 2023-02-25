using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class TimelineMissingFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "MediationResolutionDate",
                table: "Timelines",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "MemoToBeServedDate",
                table: "Timelines",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PreMedSttleMeetingDate",
                table: "Timelines",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PrePreTrialMeetingDate",
                table: "Timelines",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PreTrialResolutionDate",
                table: "Timelines",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PreTrialToBeServedDate",
                table: "Timelines",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TrialDate",
                table: "Timelines",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MediationResolutionDate",
                table: "Timelines");

            migrationBuilder.DropColumn(
                name: "MemoToBeServedDate",
                table: "Timelines");

            migrationBuilder.DropColumn(
                name: "PreMedSttleMeetingDate",
                table: "Timelines");

            migrationBuilder.DropColumn(
                name: "PrePreTrialMeetingDate",
                table: "Timelines");

            migrationBuilder.DropColumn(
                name: "PreTrialResolutionDate",
                table: "Timelines");

            migrationBuilder.DropColumn(
                name: "PreTrialToBeServedDate",
                table: "Timelines");

            migrationBuilder.DropColumn(
                name: "TrialDate",
                table: "Timelines");
        }
    }
}
