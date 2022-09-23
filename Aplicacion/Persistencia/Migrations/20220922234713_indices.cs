using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class indices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Torneos_Nombre",
                table: "Torneos",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entrenadores_Documento",
                table: "Entrenadores",
                column: "Documento",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Torneos_Nombre",
                table: "Torneos");

            migrationBuilder.DropIndex(
                name: "IX_Entrenadores_Documento",
                table: "Entrenadores");
        }
    }
}
