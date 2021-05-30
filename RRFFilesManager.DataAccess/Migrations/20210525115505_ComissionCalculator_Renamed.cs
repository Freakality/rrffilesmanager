using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class ComissionCalculator_Renamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComissionCalculators_Lawyers_FileLawyerID",
                table: "ComissionCalculators");

            migrationBuilder.DropForeignKey(
                name: "FK_ComissionCalculators_MatterTypes_MatterTypeID",
                table: "ComissionCalculators");

            migrationBuilder.DropForeignKey(
                name: "FK_ComissionCalculators_Lawyers_ResponsibleLawyerID",
                table: "ComissionCalculators");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComissionCalculators",
                table: "ComissionCalculators");

            migrationBuilder.RenameTable(
                name: "ComissionCalculators",
                newName: "ComissionCalculator");

            migrationBuilder.RenameIndex(
                name: "IX_ComissionCalculators_ResponsibleLawyerID",
                table: "ComissionCalculator",
                newName: "IX_ComissionCalculator_ResponsibleLawyerID");

            migrationBuilder.RenameIndex(
                name: "IX_ComissionCalculators_MatterTypeID",
                table: "ComissionCalculator",
                newName: "IX_ComissionCalculator_MatterTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_ComissionCalculators_FileLawyerID",
                table: "ComissionCalculator",
                newName: "IX_ComissionCalculator_FileLawyerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComissionCalculator",
                table: "ComissionCalculator",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ComissionCalculator_Lawyers_FileLawyerID",
                table: "ComissionCalculator",
                column: "FileLawyerID",
                principalTable: "Lawyers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ComissionCalculator_MatterTypes_MatterTypeID",
                table: "ComissionCalculator",
                column: "MatterTypeID",
                principalTable: "MatterTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ComissionCalculator_Lawyers_ResponsibleLawyerID",
                table: "ComissionCalculator",
                column: "ResponsibleLawyerID",
                principalTable: "Lawyers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComissionCalculator_Lawyers_FileLawyerID",
                table: "ComissionCalculator");

            migrationBuilder.DropForeignKey(
                name: "FK_ComissionCalculator_MatterTypes_MatterTypeID",
                table: "ComissionCalculator");

            migrationBuilder.DropForeignKey(
                name: "FK_ComissionCalculator_Lawyers_ResponsibleLawyerID",
                table: "ComissionCalculator");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComissionCalculator",
                table: "ComissionCalculator");

            migrationBuilder.RenameTable(
                name: "ComissionCalculator",
                newName: "ComissionCalculators");

            migrationBuilder.RenameIndex(
                name: "IX_ComissionCalculator_ResponsibleLawyerID",
                table: "ComissionCalculators",
                newName: "IX_ComissionCalculators_ResponsibleLawyerID");

            migrationBuilder.RenameIndex(
                name: "IX_ComissionCalculator_MatterTypeID",
                table: "ComissionCalculators",
                newName: "IX_ComissionCalculators_MatterTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_ComissionCalculator_FileLawyerID",
                table: "ComissionCalculators",
                newName: "IX_ComissionCalculators_FileLawyerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComissionCalculators",
                table: "ComissionCalculators",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ComissionCalculators_Lawyers_FileLawyerID",
                table: "ComissionCalculators",
                column: "FileLawyerID",
                principalTable: "Lawyers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ComissionCalculators_MatterTypes_MatterTypeID",
                table: "ComissionCalculators",
                column: "MatterTypeID",
                principalTable: "MatterTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ComissionCalculators_Lawyers_ResponsibleLawyerID",
                table: "ComissionCalculators",
                column: "ResponsibleLawyerID",
                principalTable: "Lawyers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
