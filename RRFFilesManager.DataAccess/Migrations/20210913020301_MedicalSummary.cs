using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class MedicalSummary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicalSummaries",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileId = table.Column<int>(nullable: false),
                    ArchiveID = table.Column<int>(nullable: true),
                    DocumentGroupID = table.Column<int>(nullable: true),
                    DocumentCategoryID = table.Column<int>(nullable: true),
                    DocumentTypeID = table.Column<int>(nullable: true),
                    DocumentDate = table.Column<DateTime>(nullable: false),
                    DocumentSummary = table.Column<string>(nullable: true),
                    ClientPostalCode = table.Column<string>(nullable: true),
                    TreatmentCentrePostalCode = table.Column<string>(nullable: true),
                    DistanceKilometres = table.Column<double>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalSummaries", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MedicalSummaries_Archives_ArchiveID",
                        column: x => x.ArchiveID,
                        principalTable: "Archives",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalSummaries_DocumentCategories_DocumentCategoryID",
                        column: x => x.DocumentCategoryID,
                        principalTable: "DocumentCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalSummaries_DocumentGroups_DocumentGroupID",
                        column: x => x.DocumentGroupID,
                        principalTable: "DocumentGroups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalSummaries_DocumentTypes_DocumentTypeID",
                        column: x => x.DocumentTypeID,
                        principalTable: "DocumentTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalSummaries_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalSummaries_ArchiveID",
                table: "MedicalSummaries",
                column: "ArchiveID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalSummaries_DocumentCategoryID",
                table: "MedicalSummaries",
                column: "DocumentCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalSummaries_DocumentGroupID",
                table: "MedicalSummaries",
                column: "DocumentGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalSummaries_DocumentTypeID",
                table: "MedicalSummaries",
                column: "DocumentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalSummaries_FileId",
                table: "MedicalSummaries",
                column: "FileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalSummaries");
        }
    }
}
