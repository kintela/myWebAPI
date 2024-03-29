using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KintelaData.Migrations
{
    /// <inheritdoc />
    public partial class Cambiar_Ids_Seed_Discos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaReceta_Categorias_CategoriasId",
                table: "CategoriaReceta");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaReceta_Recetas_RecetasId",
                table: "CategoriaReceta");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuReceta_Menus_MenusId",
                table: "MenuReceta");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuReceta_Recetas_RecetasId",
                table: "MenuReceta");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Recetas",
                newName: "RecetaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Menus",
                newName: "MenuId");

            migrationBuilder.RenameColumn(
                name: "RecetasId",
                table: "MenuReceta",
                newName: "RecetasRecetaId");

            migrationBuilder.RenameColumn(
                name: "MenusId",
                table: "MenuReceta",
                newName: "MenusMenuId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuReceta_RecetasId",
                table: "MenuReceta",
                newName: "IX_MenuReceta_RecetasRecetaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Grupos",
                newName: "GrupoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Discos",
                newName: "DiscoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categorias",
                newName: "CategoriaId");

            migrationBuilder.RenameColumn(
                name: "RecetasId",
                table: "CategoriaReceta",
                newName: "RecetasRecetaId");

            migrationBuilder.RenameColumn(
                name: "CategoriasId",
                table: "CategoriaReceta",
                newName: "CategoriasCategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriaReceta_RecetasId",
                table: "CategoriaReceta",
                newName: "IX_CategoriaReceta_RecetasRecetaId");

            migrationBuilder.InsertData(
                table: "Discos",
                columns: new[] { "DiscoId", "Caratula", "Discografica", "GrupoId", "Nombre", "Productor", "YearPublicacion" },
                values: new object[,]
                {
                    { 1, "1.jpg", "Shelter Records", 3, "Tom Petty & The Heartbreakers", "Denny Cordell", 1976 },
                    { 2, "2.jpg", "Shelter Records", 3, "You're Gonna Get It!", "Denny Cordell, Noah Shark, Tom Petty", 1978 },
                    { 3, "3.jpg", "Backstreet Records", 3, "Damn the Torpedoes", "Jimmy Iovine, Tom Petty", 1979 },
                    { 4, "4.jpg", "Backstreet Records", 3, "Hard Promises", "Jimmy Iovine, Tom Petty", 1981 },
                    { 5, "5.jpg", "Backstreet Records", 3, "Long After Dark", "Jimmy Iovine, Tom Petty", 1982 },
                    { 6, "6.jpg", "MCA Records", 3, "Southern Accents", "Tom Petty, Dave Stewart, Jimmy Iovine, Robbie Robertson, Mike Campbell", 1985 },
                    { 7, "7.jpg", "MCA Records", 3, "Let Me Up (I've Had Enough)", "Tom Petty, Mike Campbell", 1987 },
                    { 8, "8.jpg", "MCA Records", 3, "Into the Great Wide Open", "Jeff Lynne, Tom Petty, Mike Campbell", 1991 },
                    { 9, "9.jpg", "Warner Bros. Records", 3, "Songs and Music from 'She's the One'", "Rick Rubin, Tom Petty, Mike Campbell", 1996 },
                    { 10, "10.jpg", "Warner Bros. Records", 3, "Echo", "Rick Rubin, Tom Petty, Mike Campbell", 1999 },
                    { 11, "11.jpg", "Warner Bros. Records", 3, "The Last DJ", "Tom Petty, Mike Campbell, George Drakoulias", 2002 },
                    { 12, "12.jpg", "Reprise Records", 3, "Mojo", "Tom Petty, Mike Campbell, Ryan Ulyate", 2010 },
                    { 13, "13.jpg", "Reprise Records", 3, "Hypnotic Eye", "Tom Petty, Mike Campbell, Ryan Ulyate", 2014 },
                    { 14, "14.jpg", "Warner Bros. Records", 4, "Wildflowers", "Rick Rubin, Tom Petty, Mike Campbell", 1994 },
                    { 15, "15.jpg", "American Recordings", 4, "Highway Companion", "Jeff Lynne, Tom Petty, Mike Campbell", 2006 },
                    { 16, "16.jpg", "Warner Bros. Records", 5, "Traveling Wilburys Vol. 1", "Jeff Lynne, George Harrison", 1998 },
                    { 17, "17.jpg", "Warner Bros. Records", 5, "Traveling Wilburys Vol. 3", "Jeff Lynne, George Harrison", 1998 },
                    { 18, "1.jpeg", "Parlophone", 1, "Please Please Me", "George Martin", 1963 },
                    { 19, "1.jpeg", "Parlophone", 1, "With The Beatles", "George Martin", 1963 },
                    { 20, "2.jpeg", "Parlophone", 1, "A Hard Day's Night", "George Martin", 1964 },
                    { 21, "3.jpeg", "Parlophone", 1, "Beatles for Sale", "George Martin", 1964 },
                    { 22, "4.jpeg", "Parlophone", 1, "Help!", "George Martin", 1965 },
                    { 23, "5.jpeg", "Parlophone", 1, "Rubber Soul", "George Martin", 1965 },
                    { 24, "6.jpeg", "Parlophone", 1, "Revolver", "George Martin", 1966 },
                    { 25, "7.jpeg", "Parlophone", 1, "Sgt. Pepper's Lonely Hearts Club Band", "George Martin", 1967 },
                    { 26, "8.jpeg", "Parlophone", 1, "Magical Mystery Tour", "George Martin", 1967 },
                    { 27, "9.png", "Parlophone", 1, "The Beatles (White Album)", "George Martin", 1968 },
                    { 28, "10.jpeg", "Parlophone", 1, "Yellow Submarine", "George Martin", 1969 },
                    { 29, "11.jpeg", "Parlophone", 1, "Abbey Road", "George Martin", 1969 },
                    { 30, "12.jpeg", "Parlophone", 1, "Let It Be", "George Martin", 1970 },
                    { 31, "31.jpeg", "Decca Records", 2, "The Rolling Stones", "Andrew Loog Oldham", 1964 },
                    { 32, "32.jpeg", "Decca Records", 2, "The Rolling Stones No. 2", "Andrew Loog Oldham", 1965 },
                    { 33, "33.jpeg", "Decca Records", 2, "Out of Our Heads", "Andrew Loog Oldham", 1965 },
                    { 34, "34.jpeg", "Decca Records", 2, "Aftermath", "Andrew Loog Oldham", 1966 },
                    { 35, "35.jpeg", "Decca Records", 2, "Between the Buttons", "Andrew Loog Oldham", 1967 },
                    { 36, "36.jpeg", "Decca Records", 2, "Their Satanic Majesties Request", "The Rolling Stones", 1967 },
                    { 37, "37.jpeg", "Decca Records", 2, "Beggar's Banquet", "Jimmy Miller", 1968 },
                    { 38, "38.jpeg", "Decca Records", 2, "Let It Bleed", "Jimmy Miller", 1969 },
                    { 39, "39.jpeg", "Rolling Stones Records", 2, "Sticky Fingers", "Jimmy Miller", 1971 },
                    { 40, "40.jpeg", "Rolling Stones Records", 2, "Exile on Main St", "Jimmy Miller", 1972 },
                    { 41, "41.jpeg", "Rolling Stones Records", 2, "Goats Head Soup", "Jimmy Miller", 1973 },
                    { 42, "42.jpeg", "Rolling Stones Records", 2, "It's Only Rock 'n Roll", "The Glimmer Twins", 1974 },
                    { 43, "43.jpeg", "Rolling Stones Records", 2, "Black and Blue", "The Glimmer Twins", 1976 },
                    { 44, "43.jpeg", "Rolling Stones Records", 2, "Some Girls", "The Glimmer Twins", 1978 },
                    { 45, "44.jpeg", "Rolling Stones Records", 2, "Emotional Rescue", "The Glimmer Twins", 1980 },
                    { 46, "45.jpeg", "Rolling Stones Records", 2, "Tatoo You", "The Glimmer Twins", 1981 },
                    { 47, "46.jpeg", "Rolling Stones Records", 2, "Undercover", "The Glimmer Twins, Chris Kimsey", 1983 },
                    { 48, "47.jpeg", "Rolling Stones Records", 2, "Dirty Work", "The Glimmer Twins, Steve Lilywhite", 1986 },
                    { 49, "48.jpeg", "Rolling Stones Records", 2, "Steel Wheels", "The Glimmer Twins, Chris Kimsey", 1989 },
                    { 50, "49.jpeg", "Virgin Records", 2, "Voodoo Lounge", "The Glimmer Twins, Don Was", 1994 },
                    { 51, "50.jpeg", "Virgin Records", 2, "Bridge to Babylon", "The Glimmer Twins. Don Was, Rob Fraboni, Danny Saber, Pierre de Beauport. The Dust Brothers", 1997 },
                    { 52, "51.jpeg", "Virgin Records", 2, "A Bigger Bang", "The Glimmer Twins, Don Was, Matt Clifford", 2005 },
                    { 53, "52.jpeg", "Polydor Records", 2, "Blue & Lonesome", "The Glimmer Twins, Don Was", 2016 },
                    { 54, "53.jpeg", "Geffen Records", 2, "Hackney Diamonds", "Andrew Watt", 2023 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriaReceta_Categorias_CategoriasCategoriaId",
                table: "CategoriaReceta",
                column: "CategoriasCategoriaId",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriaReceta_Recetas_RecetasRecetaId",
                table: "CategoriaReceta",
                column: "RecetasRecetaId",
                principalTable: "Recetas",
                principalColumn: "RecetaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuReceta_Menus_MenusMenuId",
                table: "MenuReceta",
                column: "MenusMenuId",
                principalTable: "Menus",
                principalColumn: "MenuId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuReceta_Recetas_RecetasRecetaId",
                table: "MenuReceta",
                column: "RecetasRecetaId",
                principalTable: "Recetas",
                principalColumn: "RecetaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaReceta_Categorias_CategoriasCategoriaId",
                table: "CategoriaReceta");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaReceta_Recetas_RecetasRecetaId",
                table: "CategoriaReceta");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuReceta_Menus_MenusMenuId",
                table: "MenuReceta");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuReceta_Recetas_RecetasRecetaId",
                table: "MenuReceta");

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Discos",
                keyColumn: "DiscoId",
                keyValue: 54);

            migrationBuilder.RenameColumn(
                name: "RecetaId",
                table: "Recetas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MenuId",
                table: "Menus",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RecetasRecetaId",
                table: "MenuReceta",
                newName: "RecetasId");

            migrationBuilder.RenameColumn(
                name: "MenusMenuId",
                table: "MenuReceta",
                newName: "MenusId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuReceta_RecetasRecetaId",
                table: "MenuReceta",
                newName: "IX_MenuReceta_RecetasId");

            migrationBuilder.RenameColumn(
                name: "GrupoId",
                table: "Grupos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DiscoId",
                table: "Discos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Categorias",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RecetasRecetaId",
                table: "CategoriaReceta",
                newName: "RecetasId");

            migrationBuilder.RenameColumn(
                name: "CategoriasCategoriaId",
                table: "CategoriaReceta",
                newName: "CategoriasId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriaReceta_RecetasRecetaId",
                table: "CategoriaReceta",
                newName: "IX_CategoriaReceta_RecetasId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriaReceta_Categorias_CategoriasId",
                table: "CategoriaReceta",
                column: "CategoriasId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriaReceta_Recetas_RecetasId",
                table: "CategoriaReceta",
                column: "RecetasId",
                principalTable: "Recetas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuReceta_Menus_MenusId",
                table: "MenuReceta",
                column: "MenusId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuReceta_Recetas_RecetasId",
                table: "MenuReceta",
                column: "RecetasId",
                principalTable: "Recetas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
