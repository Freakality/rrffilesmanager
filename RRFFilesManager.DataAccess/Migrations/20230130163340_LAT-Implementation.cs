using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class LATImplementation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LATDatas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileId = table.Column<int>(nullable: false),
                    LATNumber = table.Column<int>(nullable: false),
                    LATActualDateFiled = table.Column<DateTime>(nullable: false),
                    LATTribunalNumber = table.Column<string>(nullable: true),
                    LATCaseConfDate = table.Column<DateTime>(nullable: false),
                    LATCaseAdjudicator = table.Column<string>(nullable: true),
                    LATAdjuster = table.Column<string>(nullable: true),
                    LATInsurer = table.Column<string>(nullable: true),
                    LATInsurerCounsel = table.Column<string>(nullable: true),
                    LATInsurerFirm = table.Column<string>(nullable: true),
                    LATHearingType = table.Column<string>(nullable: true),
                    LATHearingDate = table.Column<DateTime>(nullable: false),
                    LATHearingAdjudicator = table.Column<string>(nullable: true),
                    LATDateSettled = table.Column<DateTime>(nullable: false),
                    LATAmountSettled = table.Column<double>(nullable: false),
                    LATIssue1 = table.Column<string>(nullable: true),
                    LATIssue2 = table.Column<string>(nullable: true),
                    LATIssue3 = table.Column<string>(nullable: true),
                    LATIssue4 = table.Column<string>(nullable: true),
                    LATIssue5 = table.Column<string>(nullable: true),
                    LATIssue6 = table.Column<string>(nullable: true),
                    LATIssue7 = table.Column<string>(nullable: true),
                    LATDueDateToDiscussPotentialLAT = table.Column<DateTime>(nullable: false),
                    LATDateMetWithLawyerReDenial = table.Column<DateTime>(nullable: false),
                    LATProposedDateToFileLAT = table.Column<DateTime>(nullable: false),
                    LATActualDateLATServedOnInsurer = table.Column<DateTime>(nullable: false),
                    LATInsurersResponseReceived = table.Column<DateTime>(nullable: false),
                    LATDeadlineToServeFileCaseConfSummary = table.Column<DateTime>(nullable: false),
                    LATDeadlineToDeliverProductionstoABCounsel = table.Column<DateTime>(nullable: false),
                    LATDeadlineToReceiveABProductions = table.Column<DateTime>(nullable: false),
                    LATDeadlineToFileAffidavitReportsEtc = table.Column<DateTime>(nullable: false),
                    LATDeadlineToReceiveAffidavitReportsEtc = table.Column<DateTime>(nullable: false),
                    LATDeadlineToFileHearingSubmissionsAndOrBriefs = table.Column<DateTime>(nullable: false),
                    LATDeadlineToReceiveInsurerSubmissions = table.Column<DateTime>(nullable: false),
                    LATDeadlineForReplySubmissionsOfTheApplicant = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LATDatas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LATDatas_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LATDatas_FileId",
                table: "LATDatas",
                column: "FileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LATDatas");
        }
    }
}
