using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class Contacts_OCI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Contact1Id",
                table: "Contacts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Contact2Id",
                table: "Contacts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_Contact1Id",
                table: "Contacts",
                column: "Contact1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_Contact2Id",
                table: "Contacts",
                column: "Contact2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Contacts_Contact1Id",
                table: "Contacts",
                column: "Contact1Id",
                principalTable: "Contacts",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Contacts_Contact2Id",
                table: "Contacts",
                column: "Contact2Id",
                principalTable: "Contacts",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Contacts_Contact1Id",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Contacts_Contact2Id",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_Contact1Id",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_Contact2Id",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Contact1Id",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Contact2Id",
                table: "Contacts");
        }
    }
}
