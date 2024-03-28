using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KintelaData.Migrations
{
    /// <inheritdoc />
    public partial class Crear_Tablas_Grupos_y_Discos_y_Seed_Grupos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearPublicacion = table.Column<int>(type: "int", nullable: false),
                    Caratula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discografica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Productor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrupoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discos_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Grupos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "The Beatles" },
                    { 2, "The Rolling Stones" },
                    { 3, "Tom Petty & The Heart Breakers" },
                    { 4, "Tom Petty" },
                    { 5, "Traveling Wilburys" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Discos_GrupoId",
                table: "Discos",
                column: "GrupoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discos");

            migrationBuilder.DropTable(
                name: "Grupos");
        }
    }
}
