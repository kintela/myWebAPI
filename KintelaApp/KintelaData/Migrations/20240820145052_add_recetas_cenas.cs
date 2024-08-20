using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KintelaData.Migrations
{
    /// <inheritdoc />
    public partial class add_recetas_cenas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecetaCenaDomingo",
                table: "MenuSemanal",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaCenaJueves",
                table: "MenuSemanal",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaCenaLunes",
                table: "MenuSemanal",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaCenaMartes",
                table: "MenuSemanal",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaCenaMiercoles",
                table: "MenuSemanal",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaCenaSabado",
                table: "MenuSemanal",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecetaCenaViernes",
                table: "MenuSemanal",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecetaCenaDomingo",
                table: "MenuSemanal");

            migrationBuilder.DropColumn(
                name: "RecetaCenaJueves",
                table: "MenuSemanal");

            migrationBuilder.DropColumn(
                name: "RecetaCenaLunes",
                table: "MenuSemanal");

            migrationBuilder.DropColumn(
                name: "RecetaCenaMartes",
                table: "MenuSemanal");

            migrationBuilder.DropColumn(
                name: "RecetaCenaMiercoles",
                table: "MenuSemanal");

            migrationBuilder.DropColumn(
                name: "RecetaCenaSabado",
                table: "MenuSemanal");

            migrationBuilder.DropColumn(
                name: "RecetaCenaViernes",
                table: "MenuSemanal");
        }
    }
}
