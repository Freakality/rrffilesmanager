using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class PolicyParticulars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PolicyParticulars",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileId = table.Column<int>(nullable: false),
                    TermOfPolicyFrom = table.Column<DateTime>(nullable: false),
                    TermOfPolicyTo = table.Column<DateTime>(nullable: false),
                    OPCF44R = table.Column<string>(nullable: true),
                    OPCF44RLiabilityLimits = table.Column<decimal>(nullable: false),
                    UmbrellaViaAuto = table.Column<string>(nullable: true),
                    UmbrellaViaAutoLiabilityLimits = table.Column<decimal>(nullable: false),
                    OptionalBenefitsPurchased = table.Column<string>(nullable: true),
                    OptionalBenefitsPurchasedDetails = table.Column<string>(nullable: true),
                    ExcessHomeInsurerID = table.Column<int>(nullable: true),
                    ExcessUmbrellaCoverage = table.Column<string>(nullable: true),
                    ExcessCopyOfPolicyInFile = table.Column<string>(nullable: true),
                    ExcessCoverageAmount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyParticulars", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PolicyParticulars_DisabilityInsuranceCompanies_ExcessHomeInsurerID",
                        column: x => x.ExcessHomeInsurerID,
                        principalTable: "DisabilityInsuranceCompanies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicyParticulars_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PolicyParticulars_ExcessHomeInsurerID",
                table: "PolicyParticulars",
                column: "ExcessHomeInsurerID");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyParticulars_FileId",
                table: "PolicyParticulars",
                column: "FileId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PolicyParticulars");
        }
    }
}
