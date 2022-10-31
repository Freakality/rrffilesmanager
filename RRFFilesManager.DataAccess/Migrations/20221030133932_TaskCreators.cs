using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class TaskCreators : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByID",
                table: "Tasks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CreatedByID",
                table: "Tasks",
                column: "CreatedByID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Lawyers_CreatedByID",
                table: "Tasks",
                column: "CreatedByID",
                principalTable: "Lawyers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Lawyers_CreatedByID",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_CreatedByID",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "CreatedByID",
                table: "Tasks");
        }
    }
}
