using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BitirmeProjesi.Migrations
{
    public partial class TravelMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anasayfas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoTourResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkimizdaYazisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriResmiUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriYorum = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anasayfas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hakkimizdas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HakkimizdaSayfaYazisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcenteIsim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcenteResimUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkimizdas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Iletisims",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KisiResimUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisims", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Turlars",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UlkeIsim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SehirIsim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlkeResimUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TurKacGun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TurFiyat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turlars", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anasayfas");

            migrationBuilder.DropTable(
                name: "Hakkimizdas");

            migrationBuilder.DropTable(
                name: "Iletisims");

            migrationBuilder.DropTable(
                name: "Turlars");
        }
    }
}
