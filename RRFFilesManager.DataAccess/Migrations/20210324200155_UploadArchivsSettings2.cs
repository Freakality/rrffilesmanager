using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class UploadArchivsSettings2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "UploadArchivesSettings");

            migrationBuilder.AddColumn<string>(
                name: "OutputFolder",
                table: "UploadArchivesSettings",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FilePath",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(nullable: true),
                    UploadArchivesSettingsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilePath", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FilePath_UploadArchivesSettings_UploadArchivesSettingsID",
                        column: x => x.UploadArchivesSettingsID,
                        principalTable: "UploadArchivesSettings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilePath_UploadArchivesSettingsID",
                table: "FilePath",
                column: "UploadArchivesSettingsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilePath");

            migrationBuilder.DropColumn(
                name: "OutputFolder",
                table: "UploadArchivesSettings");

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "UploadArchivesSettings",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
