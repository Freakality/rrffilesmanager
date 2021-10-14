using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class ComissionSubTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComissionSubTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatterTypeID = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ProjectedSettlementDays = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComissionSubTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ComissionSubTypes_MatterTypes_MatterTypeID",
                        column: x => x.MatterTypeID,
                        principalTable: "MatterTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComissionSubTypes_MatterTypeID",
                table: "ComissionSubTypes",
                column: "MatterTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComissionSubTypes");
        }
    }
}
