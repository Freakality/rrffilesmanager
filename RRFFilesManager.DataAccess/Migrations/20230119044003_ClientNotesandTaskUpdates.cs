using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class ClientNotesandTaskUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TaskIDNumber",
                table: "Tasks",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClientNotes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileID = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    LawyerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientNotes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClientNotes_Files_FileID",
                        column: x => x.FileID,
                        principalTable: "Files",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientNotes_Lawyers_LawyerID",
                        column: x => x.LawyerID,
                        principalTable: "Lawyers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientNotes_FileID",
                table: "ClientNotes",
                column: "FileID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientNotes_LawyerID",
                table: "ClientNotes",
                column: "LawyerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientNotes");

            migrationBuilder.DropColumn(
                name: "TaskIDNumber",
                table: "Tasks");
        }
    }
}
