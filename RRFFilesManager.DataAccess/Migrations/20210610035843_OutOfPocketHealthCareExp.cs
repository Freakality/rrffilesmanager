using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class OutOfPocketHealthCareExp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OutOfPocketHealthCareExp",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileID = table.Column<int>(nullable: true),
                    PharmacyID = table.Column<int>(nullable: true),
                    RxFillDate = table.Column<DateTime>(nullable: false),
                    DispenseQuantity = table.Column<int>(nullable: false),
                    DrugID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutOfPocketHealthCareExp", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OutOfPocketHealthCareExp_Drugs_DrugID",
                        column: x => x.DrugID,
                        principalTable: "Drugs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutOfPocketHealthCareExp_Files_FileID",
                        column: x => x.FileID,
                        principalTable: "Files",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutOfPocketHealthCareExp_Pharmacies_PharmacyID",
                        column: x => x.PharmacyID,
                        principalTable: "Pharmacies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OutOfPocketHealthCareExp_DrugID",
                table: "OutOfPocketHealthCareExp",
                column: "DrugID");

            migrationBuilder.CreateIndex(
                name: "IX_OutOfPocketHealthCareExp_FileID",
                table: "OutOfPocketHealthCareExp",
                column: "FileID");

            migrationBuilder.CreateIndex(
                name: "IX_OutOfPocketHealthCareExp_PharmacyID",
                table: "OutOfPocketHealthCareExp",
                column: "PharmacyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OutOfPocketHealthCareExp");
        }
    }
}
