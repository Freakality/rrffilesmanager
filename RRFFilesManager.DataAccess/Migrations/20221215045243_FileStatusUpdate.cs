using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class FileStatusUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddedByID",
                table: "FileTasks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentStatusID",
                table: "Files",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfStatusChange",
                table: "Files",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PreviousStatusID",
                table: "Files",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FileStatus",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileStatus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LawyerTasks",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(nullable: false),
                    LawyerId = table.Column<int>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    DeferUntilDate = table.Column<DateTime>(nullable: false),
                    TaskStartedDate = table.Column<DateTime>(nullable: false),
                    WorkedOnDate1 = table.Column<DateTime>(nullable: false),
                    WorkedOnDate2 = table.Column<DateTime>(nullable: false),
                    WorkedOnDate3 = table.Column<DateTime>(nullable: false),
                    NotifiedRRFDate = table.Column<DateTime>(nullable: false),
                    CompletedDate = table.Column<DateTime>(nullable: false),
                    StateID = table.Column<int>(nullable: true),
                    AddedByID = table.Column<int>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LawyerTasks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LawyerTasks_Lawyers_AddedByID",
                        column: x => x.AddedByID,
                        principalTable: "Lawyers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LawyerTasks_Lawyers_LawyerId",
                        column: x => x.LawyerId,
                        principalTable: "Lawyers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LawyerTasks_TaskStates_StateID",
                        column: x => x.StateID,
                        principalTable: "TaskStates",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LawyerTasks_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileTasks_AddedByID",
                table: "FileTasks",
                column: "AddedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Files_CurrentStatusID",
                table: "Files",
                column: "CurrentStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Files_PreviousStatusID",
                table: "Files",
                column: "PreviousStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_LawyerTasks_AddedByID",
                table: "LawyerTasks",
                column: "AddedByID");

            migrationBuilder.CreateIndex(
                name: "IX_LawyerTasks_LawyerId",
                table: "LawyerTasks",
                column: "LawyerId");

            migrationBuilder.CreateIndex(
                name: "IX_LawyerTasks_StateID",
                table: "LawyerTasks",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_LawyerTasks_TaskId",
                table: "LawyerTasks",
                column: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_FileStatus_CurrentStatusID",
                table: "Files",
                column: "CurrentStatusID",
                principalTable: "FileStatus",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_FileStatus_PreviousStatusID",
                table: "Files",
                column: "PreviousStatusID",
                principalTable: "FileStatus",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FileTasks_Lawyers_AddedByID",
                table: "FileTasks",
                column: "AddedByID",
                principalTable: "Lawyers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_FileStatus_CurrentStatusID",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_FileStatus_PreviousStatusID",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_FileTasks_Lawyers_AddedByID",
                table: "FileTasks");

            migrationBuilder.DropTable(
                name: "FileStatus");

            migrationBuilder.DropTable(
                name: "LawyerTasks");

            migrationBuilder.DropIndex(
                name: "IX_FileTasks_AddedByID",
                table: "FileTasks");

            migrationBuilder.DropIndex(
                name: "IX_Files_CurrentStatusID",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_PreviousStatusID",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "AddedByID",
                table: "FileTasks");

            migrationBuilder.DropColumn(
                name: "CurrentStatusID",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "DateOfStatusChange",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "PreviousStatusID",
                table: "Files");
        }
    }
}
