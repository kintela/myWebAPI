using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KintelaData.Migrations
{
    /// <inheritdoc />
    public partial class AddUsuariosYEditarMenus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Menus",
                newName: "FechaCreacion");

            migrationBuilder.AddColumn<int>(
                name: "RecetaPostreDomingo",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaPostreJueves",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaPostreLunes",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaPostreMartes",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaPostreMiercoles",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaPostreSabado",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaPostreViernes",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaPrimerPlatoDomingo",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaPrimerPlatoJueves",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaPrimerPlatoLunes",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaPrimerPlatoMartes",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaPrimerPlatoMiercoles",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaPrimerPlatoSabado",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaPrimerPlatoViernes",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaSegundoPlatoDomingo",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaSegundoPlatoJueves",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaSegundoPlatoLunes",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaSegundoPlatoMartes",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaSegundoPlatoMiercoles",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaSegundoPlatoSabado",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaSegundoPlatoViernes",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Menus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Menus_UsuarioId",
                table: "Menus",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Usuario_UsuarioId",
                table: "Menus",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Usuario_UsuarioId",
                table: "Menus");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Menus_UsuarioId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaPostreDomingo",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaPostreJueves",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaPostreLunes",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaPostreMartes",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaPostreMiercoles",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaPostreSabado",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaPostreViernes",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaPrimerPlatoDomingo",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaPrimerPlatoJueves",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaPrimerPlatoLunes",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaPrimerPlatoMartes",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaPrimerPlatoMiercoles",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaPrimerPlatoSabado",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaPrimerPlatoViernes",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaSegundoPlatoDomingo",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaSegundoPlatoJueves",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaSegundoPlatoLunes",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaSegundoPlatoMartes",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaSegundoPlatoMiercoles",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaSegundoPlatoSabado",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "RecetaSegundoPlatoViernes",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Menus");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                table: "Menus",
                newName: "Fecha");
        }
    }
}
