using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class StandardBenefitChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ACRemaining",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "MRACRemaining",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "MRRemaining",
                table: "Archives");

            migrationBuilder.CreateTable(
                name: "StandardBenefitRows",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArchiveId = table.Column<int>(nullable: false),
                    RowNumber = table.Column<int>(nullable: false),
                    Payee = table.Column<string>(nullable: true),
                    MRGSAProvided = table.Column<string>(nullable: true),
                    DatePaid = table.Column<DateTime>(nullable: false),
                    StatementPeriodEnds = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    IEAmount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandardBenefitRows", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StandardBenefitRows_Archives_ArchiveId",
                        column: x => x.ArchiveId,
                        principalTable: "Archives",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StandardBenefitRows_ArchiveId",
                table: "StandardBenefitRows",
                column: "ArchiveId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StandardBenefitRows");

            migrationBuilder.AddColumn<string>(
                name: "ACRemaining",
                table: "Archives",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MRACRemaining",
                table: "Archives",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MRRemaining",
                table: "Archives",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
