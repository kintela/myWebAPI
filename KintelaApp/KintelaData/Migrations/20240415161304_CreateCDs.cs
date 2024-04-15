using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KintelaData.Migrations
{
    /// <inheritdoc />
    public partial class CreateCDs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CDs",
                columns: table => new
                {
                    CDId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearPublicacion = table.Column<int>(type: "int", nullable: true),
                    IsInSpotify = table.Column<bool>(type: "bit", nullable: true),
                    Etiqueta = table.Column<int>(type: "int", nullable: false),
                    caratula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firmado = table.Column<bool>(type: "bit", nullable: true),
                    GrupoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDs", x => x.CDId);
                    table.ForeignKey(
                        name: "FK_CDs_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "GrupoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Grupos",
                columns: new[] { "GrupoId", "Nombre" },
                values: new object[,]
                {
                    { 6, "Corey Harris" },
                    { 7, "Pearl Jam" },
                    { 8, "Eric Clapton" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CDs_GrupoId",
                table: "CDs",
                column: "GrupoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CDs");

            migrationBuilder.DeleteData(
                table: "Grupos",
                keyColumn: "GrupoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Grupos",
                keyColumn: "GrupoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Grupos",
                keyColumn: "GrupoId",
                keyValue: 8);
        }
    }
}
