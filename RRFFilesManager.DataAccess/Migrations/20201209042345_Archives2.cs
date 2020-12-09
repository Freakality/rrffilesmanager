using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class Archives2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Archives",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TemplateId",
                table: "Archives",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Archives_TemplateId",
                table: "Archives",
                column: "TemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Archives_Templates_TemplateId",
                table: "Archives",
                column: "TemplateId",
                principalTable: "Templates",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Archives_Templates_TemplateId",
                table: "Archives");

            migrationBuilder.DropIndex(
                name: "IX_Archives_TemplateId",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Archives");

            migrationBuilder.DropColumn(
                name: "TemplateId",
                table: "Archives");
        }
    }
}
