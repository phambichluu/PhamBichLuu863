using Microsoft.EntityFrameworkCore.Migrations;

namespace PhamBichLuu863.Migrations
{
    public partial class Create_Table_PBL863 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PBL863",
                columns: table => new
                {
                    PBLID = table.Column<string>(type: "varchar(20)", nullable: false),
                    PBLName = table.Column<string>(type: "varchar(50)", nullable: true),
                    PBLGender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PBL863", x => x.PBLID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PBL863");
        }
    }
}
