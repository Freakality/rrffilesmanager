using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class TasksLogsAndUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClearanceLevel",
                table: "Lawyers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Lawyers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Lawyers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LogItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    LawyerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LogItems_Lawyers_LawyerID",
                        column: x => x.LawyerID,
                        principalTable: "Lawyers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskCategories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TaskStates",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskStates", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    DueBy = table.Column<int>(nullable: false),
                    DeferBy = table.Column<int>(nullable: false),
                    LawyerID = table.Column<int>(nullable: true),
                    LockDueDate = table.Column<bool>(nullable: false),
                    IsMasterTask = table.Column<bool>(nullable: false),
                    TaskCategoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tasks_Lawyers_LawyerID",
                        column: x => x.LawyerID,
                        principalTable: "Lawyers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tasks_TaskCategories_TaskCategoryID",
                        column: x => x.TaskCategoryID,
                        principalTable: "TaskCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FileTasks",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(nullable: false),
                    FileId = table.Column<int>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    DeferUntilDate = table.Column<DateTime>(nullable: false),
                    TaskStartedDate = table.Column<DateTime>(nullable: false),
                    WorkedOnDate1 = table.Column<DateTime>(nullable: false),
                    WorkedOnDate2 = table.Column<DateTime>(nullable: false),
                    WorkedOnDate3 = table.Column<DateTime>(nullable: false),
                    NotifiedRRFDate = table.Column<DateTime>(nullable: false),
                    CompletedDate = table.Column<DateTime>(nullable: false),
                    StateID = table.Column<int>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileTasks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FileTasks_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileTasks_TaskStates_StateID",
                        column: x => x.StateID,
                        principalTable: "TaskStates",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FileTasks_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskDependencies",
                columns: table => new
                {
                    TaskId = table.Column<int>(nullable: false),
                    DependencyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskDependencies", x => new { x.TaskId, x.DependencyId });
                    table.ForeignKey(
                        name: "FK_TaskDependencies_Tasks_DependencyId",
                        column: x => x.DependencyId,
                        principalTable: "Tasks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskDependencies_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileTasks_FileId",
                table: "FileTasks",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_FileTasks_StateID",
                table: "FileTasks",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_FileTasks_TaskId",
                table: "FileTasks",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_LogItems_LawyerID",
                table: "LogItems",
                column: "LawyerID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDependencies_DependencyId",
                table: "TaskDependencies",
                column: "DependencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_LawyerID",
                table: "Tasks",
                column: "LawyerID");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskCategoryID",
                table: "Tasks",
                column: "TaskCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileTasks");

            migrationBuilder.DropTable(
                name: "LogItems");

            migrationBuilder.DropTable(
                name: "TaskDependencies");

            migrationBuilder.DropTable(
                name: "TaskStates");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "TaskCategories");

            migrationBuilder.DropColumn(
                name: "ClearanceLevel",
                table: "Lawyers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Lawyers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Lawyers");
        }
    }
}
