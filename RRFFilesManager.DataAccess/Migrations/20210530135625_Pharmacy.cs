using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class Pharmacy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pharmacies",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ProvinceID = table.Column<int>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    PhoneNumber1 = table.Column<string>(nullable: true),
                    PhoneNumber2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pharmacies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pharmacies_Provinces_ProvinceID",
                        column: x => x.ProvinceID,
                        principalTable: "Provinces",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pharmacies_ProvinceID",
                table: "Pharmacies",
                column: "ProvinceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pharmacies");
        }
    }
}
