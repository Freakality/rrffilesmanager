using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class AddedTimelines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Timelines",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileId = table.Column<int>(nullable: false),
                    LiabilityMeetingDate = table.Column<DateTime>(nullable: false),
                    ProposedDateIssueSOC = table.Column<DateTime>(nullable: false),
                    PrePleadingsMeetingDate = table.Column<DateTime>(nullable: false),
                    ActualDateSOCIssued = table.Column<DateTime>(nullable: false),
                    MedicalSummariesPreDiscDueDate = table.Column<DateTime>(nullable: false),
                    ProposedDateToServeSOC = table.Column<DateTime>(nullable: false),
                    ActualDateSOCServed = table.Column<DateTime>(nullable: false),
                    DateToFileTrialRecordBy = table.Column<DateTime>(nullable: false),
                    PreDiscoveryMeetingDate = table.Column<DateTime>(nullable: false),
                    DefendantAODRequest = table.Column<DateTime>(nullable: false),
                    DateOfPlaintiffDiscovery = table.Column<DateTime>(nullable: false),
                    PlaintiffAODSent = table.Column<DateTime>(nullable: false),
                    DateOfDefendantDiscovery = table.Column<DateTime>(nullable: false),
                    DateTrialRecordFiled = table.Column<DateTime>(nullable: false),
                    DatePlaintiffUndertakingComplete = table.Column<DateTime>(nullable: false),
                    AllDefendantUndertakingRecd = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timelines", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Timelines_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Timelines_FileId",
                table: "Timelines",
                column: "FileId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Timelines");
        }
    }
}
