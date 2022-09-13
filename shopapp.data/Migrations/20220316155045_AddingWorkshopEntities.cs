using Microsoft.EntityFrameworkCore.Migrations;

namespace shopapp.data.Migrations
{
    public partial class AddingWorkshopEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Workshops",
                columns: table => new
                {
                    workshopId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    wName = table.Column<string>(nullable: true),
                    wUrl = table.Column<string>(nullable: true),
                    wDescription = table.Column<string>(nullable: true),
                    wImageUrl = table.Column<string>(nullable: true),
                    wIsApproved = table.Column<bool>(nullable: false),
                    wIsHome = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workshops", x => x.workshopId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Workshops");
        }
    }
}
