using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class No_cas_patr_Equi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Patrocinadores_PatrocinadorId",
                table: "Equipos");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Patrocinadores_PatrocinadorId",
                table: "Equipos",
                column: "PatrocinadorId",
                principalTable: "Patrocinadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Patrocinadores_PatrocinadorId",
                table: "Equipos");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Patrocinadores_PatrocinadorId",
                table: "Equipos",
                column: "PatrocinadorId",
                principalTable: "Patrocinadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
