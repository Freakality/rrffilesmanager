using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class Clients_Contacts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Clients_ClientID",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "Extension",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Contacts");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DirectPhoneExtension",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DirectPhoneNumber",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailToText",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeNumber",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileCarrier",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficePhoneExtension",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficePhoneNumber",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkNumber",
                table: "Contacts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Contacts_ClientID",
                table: "Files",
                column: "ClientID",
                principalTable: "Contacts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Contacts_ClientID",
                table: "Files");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "DirectPhoneExtension",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "DirectPhoneNumber",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "EmailToText",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "HomeNumber",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "MobileCarrier",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "OfficePhoneExtension",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "OfficePhoneNumber",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "WorkNumber",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "Extension",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Clients_ClientID",
                table: "Files",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
