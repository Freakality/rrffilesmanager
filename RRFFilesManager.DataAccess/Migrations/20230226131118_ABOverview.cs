using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class ABOverview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ABOverviews",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileId = table.Column<int>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: false),
                    PolicyPreJune1st2016 = table.Column<string>(nullable: true),
                    PolicyOptionalBenefits = table.Column<string>(nullable: true),
                    PolicyABCounsel = table.Column<string>(nullable: true),
                    IncomeBenefitsApplied = table.Column<string>(nullable: true),
                    IncomeBenefitsType = table.Column<string>(nullable: true),
                    IncomeBenefitsLatestOCF3 = table.Column<DateTime>(nullable: false),
                    IncomeBenefitsWeeklyAmount = table.Column<decimal>(nullable: false),
                    IncomeBenefitsDenied = table.Column<string>(nullable: true),
                    IncomeBenefitsFiledForLAT = table.Column<string>(nullable: true),
                    MedicalRehabBenefitsCurrentLevel = table.Column<string>(nullable: true),
                    MedicalRehabBenefitsEnd = table.Column<DateTime>(nullable: false),
                    MedicalRehabBenefitsAmountPaidToDate = table.Column<decimal>(nullable: false),
                    CollateralsInsured = table.Column<string>(nullable: true),
                    CollateralsFamily = table.Column<string>(nullable: true),
                    AttendantCareBenefitsInitiallyApproved = table.Column<string>(nullable: true),
                    AttendantCareBenefitsInitialAmount = table.Column<decimal>(nullable: false),
                    AttendantCareBenefitsACBeingIncurred = table.Column<string>(nullable: true),
                    AttendantCareBenefitsWhosFunding = table.Column<string>(nullable: true),
                    AttendantCareBenefitsLatestForm1 = table.Column<DateTime>(nullable: false),
                    AttendantCareBenefitsAmountPaidToDate = table.Column<decimal>(nullable: false),
                    PotentialOffSetsGovtOntario = table.Column<string>(nullable: true),
                    PotentialOffSetsGovtFederal = table.Column<string>(nullable: true),
                    PotentialOffSetsGroupPrivate = table.Column<string>(nullable: true),
                    PotentialCATApplied = table.Column<string>(nullable: true),
                    PotentialCATCriteria = table.Column<string>(nullable: true),
                    PotentialCATIEsScheduled = table.Column<string>(nullable: true),
                    PotentialCATResult = table.Column<string>(nullable: true),
                    PotentialCATLATFiled = table.Column<string>(nullable: true),
                    StatementBenefitsStatementDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABOverviews", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ABOverviews_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ABOverviews_FileId",
                table: "ABOverviews",
                column: "FileId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ABOverviews");
        }
    }
}
