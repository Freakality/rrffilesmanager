using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class FileTaskLawyer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LawyerID",
                table: "FileTasks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FileTasks_LawyerID",
                table: "FileTasks",
                column: "LawyerID");

            migrationBuilder.AddForeignKey(
                name: "FK_FileTasks_Lawyers_LawyerID",
                table: "FileTasks",
                column: "LawyerID",
                principalTable: "Lawyers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileTasks_Lawyers_LawyerID",
                table: "FileTasks");

            migrationBuilder.DropIndex(
                name: "IX_FileTasks_LawyerID",
                table: "FileTasks");

            migrationBuilder.DropColumn(
                name: "LawyerID",
                table: "FileTasks");
        }
    }
}
