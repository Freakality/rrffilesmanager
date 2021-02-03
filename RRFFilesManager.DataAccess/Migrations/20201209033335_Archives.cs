using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class Archives : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intakes_Files_FileID",
                table: "Intakes");

            migrationBuilder.DropIndex(
                name: "IX_Intakes_FileID",
                table: "Intakes");

            migrationBuilder.RenameColumn(
                name: "FileID",
                table: "Intakes",
                newName: "FileId");

            migrationBuilder.AlterColumn<int>(
                name: "FileId",
                table: "Intakes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Archives",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archives", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Archives_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Intakes_FileId",
                table: "Intakes",
                column: "FileId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Archives_FileId",
                table: "Archives",
                column: "FileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Intakes_Files_FileId",
                table: "Intakes",
                column: "FileId",
                principalTable: "Files",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intakes_Files_FileId",
                table: "Intakes");

            migrationBuilder.DropTable(
                name: "Archives");

            migrationBuilder.DropIndex(
                name: "IX_Intakes_FileId",
                table: "Intakes");

            migrationBuilder.RenameColumn(
                name: "FileId",
                table: "Intakes",
                newName: "FileID");

            migrationBuilder.AlterColumn<int>(
                name: "FileID",
                table: "Intakes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Intakes_FileID",
                table: "Intakes",
                column: "FileID");

            migrationBuilder.AddForeignKey(
                name: "FK_Intakes_Files_FileID",
                table: "Intakes",
                column: "FileID",
                principalTable: "Files",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
