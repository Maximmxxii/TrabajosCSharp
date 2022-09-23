using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class IndexEquip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Municipios_Nombre",
                table: "Municipios",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_Nombre",
                table: "Equipos",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deportistas_Documento",
                table: "Deportistas",
                column: "Documento",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Municipios_Nombre",
                table: "Municipios");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_Nombre",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Deportistas_Documento",
                table: "Deportistas");
        }
    }
}
