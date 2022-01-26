using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class File_Reviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FileReviews",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FRDate = table.Column<DateTime>(nullable: false),
                    FRLiabilityIssues = table.Column<string>(nullable: true),
                    FRCausationIssues = table.Column<string>(nullable: true),
                    FRDamagesIssues = table.Column<string>(nullable: true),
                    FRFileProgressionConsiderations = table.Column<string>(nullable: true),
                    FRProjectedSettlementDate = table.Column<DateTime>(nullable: false),
                    FRProjectedSettlementValue = table.Column<string>(nullable: true),
                    FRProjectedDisbursements = table.Column<string>(nullable: true),
                    FRCurrentDisbursements = table.Column<string>(nullable: true),
                    FRProjectedFees = table.Column<string>(nullable: true),
                    FRProjectedProfitMargin = table.Column<string>(nullable: true),
                    FROtherNotes = table.Column<string>(nullable: true),
                    FileID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileReviews", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FileReviews_Files_FileID",
                        column: x => x.FileID,
                        principalTable: "Files",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileReviews_FileID",
                table: "FileReviews",
                column: "FileID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileReviews");
        }
    }
}
