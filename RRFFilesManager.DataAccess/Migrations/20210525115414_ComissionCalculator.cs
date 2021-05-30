using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class ComissionCalculator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComissionCalculators",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatterTypeID = table.Column<int>(nullable: true),
                    ComissionSubType = table.Column<string>(nullable: true),
                    FileLawyerID = table.Column<int>(nullable: true),
                    ResponsibleLawyerID = table.Column<int>(nullable: true),
                    ContractTerm = table.Column<string>(nullable: true),
                    DeductibleAchieved = table.Column<bool>(nullable: false),
                    FLBaseComissionMultiplier = table.Column<double>(nullable: true),
                    RLBaseComissionMultiplier = table.Column<double>(nullable: true),
                    RPBaseComissionMultiplier = table.Column<double>(nullable: true),
                    RLDeductibleAchievedx1d5Multiplier = table.Column<double>(nullable: true),
                    RLDeductibleAchievedx2Multiplier = table.Column<double>(nullable: true),
                    RPDeductibleAchievedx1d5Multiplier = table.Column<double>(nullable: true),
                    RPDeductibleAchievedx2Multiplier = table.Column<double>(nullable: true),
                    MatterProceededToTrialMultiplier = table.Column<double>(nullable: true),
                    MatterProceededToHearingMultiplier = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComissionCalculators", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ComissionCalculators_Lawyers_FileLawyerID",
                        column: x => x.FileLawyerID,
                        principalTable: "Lawyers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComissionCalculators_MatterTypes_MatterTypeID",
                        column: x => x.MatterTypeID,
                        principalTable: "MatterTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComissionCalculators_Lawyers_ResponsibleLawyerID",
                        column: x => x.ResponsibleLawyerID,
                        principalTable: "Lawyers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComissionCalculators_FileLawyerID",
                table: "ComissionCalculators",
                column: "FileLawyerID");

            migrationBuilder.CreateIndex(
                name: "IX_ComissionCalculators_MatterTypeID",
                table: "ComissionCalculators",
                column: "MatterTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ComissionCalculators_ResponsibleLawyerID",
                table: "ComissionCalculators",
                column: "ResponsibleLawyerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComissionCalculators");
        }
    }
}
