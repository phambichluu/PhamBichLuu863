using Microsoft.EntityFrameworkCore.Migrations;

namespace PhamBichLuu863.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonPBL863",
                columns: table => new
                {
                    PersonID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PersonName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonPBL863", x => x.PersonID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonPBL863");
        }
    }
}
