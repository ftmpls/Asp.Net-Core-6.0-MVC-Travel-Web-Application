using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BitirmeProjesi.Migrations
{
    public partial class CreateGezilcekYerlersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GezilcekYerlers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnaBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResimUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TurID = table.Column<int>(type: "int", nullable: false),
                    TurlarID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GezilcekYerlers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GezilcekYerlers_Turlars_TurlarID",
                        column: x => x.TurlarID,
                        principalTable: "Turlars",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_GezilcekYerlers_TurlarID",
                table: "GezilcekYerlers",
                column: "TurlarID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GezilcekYerlers");
        }
    }
}
