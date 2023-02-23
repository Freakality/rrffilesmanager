using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class Denials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DenialBenefits",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DenialBenefits", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DenialStatus",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DenialStatus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Denials",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileId = table.Column<int>(nullable: false),
                    DenialBenefitID = table.Column<int>(nullable: true),
                    AmountInDispute = table.Column<decimal>(nullable: false),
                    TreatmentPlanDate = table.Column<DateTime>(nullable: false),
                    DateDenied = table.Column<DateTime>(nullable: false),
                    ServiceProvider = table.Column<string>(nullable: true),
                    ServiceType = table.Column<string>(nullable: true),
                    RangeFrom = table.Column<string>(nullable: true),
                    RangeTo = table.Column<string>(nullable: true),
                    DisputeRelatedTo = table.Column<string>(nullable: true),
                    LimitationDate = table.Column<DateTime>(nullable: false),
                    DenialStatusID = table.Column<int>(nullable: true),
                    DenialNotes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Denials", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Denials_DenialBenefits_DenialBenefitID",
                        column: x => x.DenialBenefitID,
                        principalTable: "DenialBenefits",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Denials_DenialStatus_DenialStatusID",
                        column: x => x.DenialStatusID,
                        principalTable: "DenialStatus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Denials_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Denials_DenialBenefitID",
                table: "Denials",
                column: "DenialBenefitID");

            migrationBuilder.CreateIndex(
                name: "IX_Denials_DenialStatusID",
                table: "Denials",
                column: "DenialStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Denials_FileId",
                table: "Denials",
                column: "FileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Denials");

            migrationBuilder.DropTable(
                name: "DenialBenefits");

            migrationBuilder.DropTable(
                name: "DenialStatus");
        }
    }
}
