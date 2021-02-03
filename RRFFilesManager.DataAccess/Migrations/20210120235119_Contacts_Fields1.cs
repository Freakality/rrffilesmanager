using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class Contacts_Fields1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupID",
                table: "Contacts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_GroupID",
                table: "Contacts",
                column: "GroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Groups_GroupID",
                table: "Contacts",
                column: "GroupID",
                principalTable: "Groups",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Groups_GroupID",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_GroupID",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "GroupID",
                table: "Contacts");
        }
    }
}
