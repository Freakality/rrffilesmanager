using Microsoft.EntityFrameworkCore.Migrations;

namespace RRFFilesManager.DataAccess.Migrations
{
    public partial class ADD_QuestionnaireFieldMapper_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionnaireFieldMappers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormFieldName = table.Column<string>(nullable: true),
                    FileFieldName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionnaireFieldMappers", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionnaireFieldMappers");
        }
    }
}
