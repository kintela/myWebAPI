using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KintelaData.Migrations
{
    /// <inheritdoc />
    public partial class RenameMenuSemanal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuReceta");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.CreateTable(
                name: "MenuSemanal",
                columns: table => new
                {
                    MenuSemanalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateOnly>(type: "date", nullable: false),
                    RecetaPrimerPlatoLunes = table.Column<int>(type: "int", nullable: true),
                    RecetaSegundoPlatoLunes = table.Column<int>(type: "int", nullable: true),
                    RecetaPostreLunes = table.Column<int>(type: "int", nullable: true),
                    RecetaPrimerPlatoMartes = table.Column<int>(type: "int", nullable: true),
                    RecetaSegundoPlatoMartes = table.Column<int>(type: "int", nullable: true),
                    RecetaPostreMartes = table.Column<int>(type: "int", nullable: true),
                    RecetaPrimerPlatoMiercoles = table.Column<int>(type: "int", nullable: true),
                    RecetaSegundoPlatoMiercoles = table.Column<int>(type: "int", nullable: true),
                    RecetaPostreMiercoles = table.Column<int>(type: "int", nullable: true),
                    RecetaPrimerPlatoJueves = table.Column<int>(type: "int", nullable: true),
                    RecetaSegundoPlatoJueves = table.Column<int>(type: "int", nullable: true),
                    RecetaPostreJueves = table.Column<int>(type: "int", nullable: true),
                    RecetaPrimerPlatoViernes = table.Column<int>(type: "int", nullable: true),
                    RecetaSegundoPlatoViernes = table.Column<int>(type: "int", nullable: true),
                    RecetaPostreViernes = table.Column<int>(type: "int", nullable: true),
                    RecetaPrimerPlatoSabado = table.Column<int>(type: "int", nullable: true),
                    RecetaSegundoPlatoSabado = table.Column<int>(type: "int", nullable: true),
                    RecetaPostreSabado = table.Column<int>(type: "int", nullable: true),
                    RecetaPrimerPlatoDomingo = table.Column<int>(type: "int", nullable: true),
                    RecetaSegundoPlatoDomingo = table.Column<int>(type: "int", nullable: true),
                    RecetaPostreDomingo = table.Column<int>(type: "int", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuSemanal", x => x.MenuSemanalId);
                    table.ForeignKey(
                        name: "FK_MenuSemanal_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuSemanalReceta",
                columns: table => new
                {
                    MenuSemanalId = table.Column<int>(type: "int", nullable: false),
                    RecetasRecetaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuSemanalReceta", x => new { x.MenuSemanalId, x.RecetasRecetaId });
                    table.ForeignKey(
                        name: "FK_MenuSemanalReceta_MenuSemanal_MenuSemanalId",
                        column: x => x.MenuSemanalId,
                        principalTable: "MenuSemanal",
                        principalColumn: "MenuSemanalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuSemanalReceta_Recetas_RecetasRecetaId",
                        column: x => x.RecetasRecetaId,
                        principalTable: "Recetas",
                        principalColumn: "RecetaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuSemanal_UsuarioId",
                table: "MenuSemanal",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuSemanalReceta_RecetasRecetaId",
                table: "MenuSemanalReceta",
                column: "RecetasRecetaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuSemanalReceta");

            migrationBuilder.DropTable(
                name: "MenuSemanal");

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateOnly>(type: "date", nullable: false),
                    RecetaPostreDomingo = table.Column<int>(type: "int", nullable: true),
                    RecetaPostreJueves = table.Column<int>(type: "int", nullable: true),
                    RecetaPostreLunes = table.Column<int>(type: "int", nullable: true),
                    RecetaPostreMartes = table.Column<int>(type: "int", nullable: true),
                    RecetaPostreMiercoles = table.Column<int>(type: "int", nullable: true),
                    RecetaPostreSabado = table.Column<int>(type: "int", nullable: true),
                    RecetaPostreViernes = table.Column<int>(type: "int", nullable: true),
                    RecetaPrimerPlatoDomingo = table.Column<int>(type: "int", nullable: true),
                    RecetaPrimerPlatoJueves = table.Column<int>(type: "int", nullable: true),
                    RecetaPrimerPlatoLunes = table.Column<int>(type: "int", nullable: true),
                    RecetaPrimerPlatoMartes = table.Column<int>(type: "int", nullable: true),
                    RecetaPrimerPlatoMiercoles = table.Column<int>(type: "int", nullable: true),
                    RecetaPrimerPlatoSabado = table.Column<int>(type: "int", nullable: true),
                    RecetaPrimerPlatoViernes = table.Column<int>(type: "int", nullable: true),
                    RecetaSegundoPlatoDomingo = table.Column<int>(type: "int", nullable: true),
                    RecetaSegundoPlatoJueves = table.Column<int>(type: "int", nullable: true),
                    RecetaSegundoPlatoLunes = table.Column<int>(type: "int", nullable: true),
                    RecetaSegundoPlatoMartes = table.Column<int>(type: "int", nullable: true),
                    RecetaSegundoPlatoMiercoles = table.Column<int>(type: "int", nullable: true),
                    RecetaSegundoPlatoSabado = table.Column<int>(type: "int", nullable: true),
                    RecetaSegundoPlatoViernes = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                    table.ForeignKey(
                        name: "FK_Menus_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuReceta",
                columns: table => new
                {
                    MenusMenuId = table.Column<int>(type: "int", nullable: false),
                    RecetasRecetaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuReceta", x => new { x.MenusMenuId, x.RecetasRecetaId });
                    table.ForeignKey(
                        name: "FK_MenuReceta_Menus_MenusMenuId",
                        column: x => x.MenusMenuId,
                        principalTable: "Menus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuReceta_Recetas_RecetasRecetaId",
                        column: x => x.RecetasRecetaId,
                        principalTable: "Recetas",
                        principalColumn: "RecetaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuReceta_RecetasRecetaId",
                table: "MenuReceta",
                column: "RecetasRecetaId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_UsuarioId",
                table: "Menus",
                column: "UsuarioId");
        }
    }
}
