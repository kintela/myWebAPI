using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KintelaData.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    GrupoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.GrupoId);
                });

            migrationBuilder.CreateTable(
                name: "Recetas",
                columns: table => new
                {
                    RecetaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingredientes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preparacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Presentacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comensales = table.Column<int>(type: "int", nullable: true),
                    EnlaceVideo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recetas", x => x.RecetaId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

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

            migrationBuilder.CreateTable(
                name: "Discos",
                columns: table => new
                {
                    DiscoId = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Discos", x => x.DiscoId);
                    table.ForeignKey(
                        name: "FK_Discos_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "GrupoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaReceta",
                columns: table => new
                {
                    CategoriasCategoriaId = table.Column<int>(type: "int", nullable: false),
                    RecetasRecetaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaReceta", x => new { x.CategoriasCategoriaId, x.RecetasRecetaId });
                    table.ForeignKey(
                        name: "FK_CategoriaReceta_Categorias_CategoriasCategoriaId",
                        column: x => x.CategoriasCategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaReceta_Recetas_RecetasRecetaId",
                        column: x => x.RecetasRecetaId,
                        principalTable: "Recetas",
                        principalColumn: "RecetaId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Nombre" },
                values: new object[,]
                {
                    { 1, "Carne" },
                    { 2, "Ensalada" },
                    { 3, "Huevos" },
                    { 4, "Legumbres" },
                    { 5, "Pasta" },
                    { 6, "Patatas" },
                    { 7, "Pescado" },
                    { 8, "Postre" },
                    { 9, "Sandwich" },
                    { 10, "Sopa" },
                    { 11, "Tortilla" },
                    { 12, "Verdura" }
                });

            migrationBuilder.InsertData(
                table: "Grupos",
                columns: new[] { "GrupoId", "Nombre" },
                values: new object[,]
                {
                    { 1, "The Beatles" },
                    { 2, "The Rolling Stones" },
                    { 3, "Tom Petty & The Heart Breakers" },
                    { 4, "Tom Petty" },
                    { 5, "Traveling Wilburys" },
                    { 6, "Corey Harris" },
                    { 7, "Pearl Jam" },
                    { 8, "Eric Clapton" }
                });

            migrationBuilder.InsertData(
                table: "Recetas",
                columns: new[] { "RecetaId", "Comensales", "EnlaceVideo", "Imagen", "Ingredientes", "Nombre", "Preparacion", "Presentacion" },
                values: new object[,]
                {
                    { 1, null, "https://www.hogarmania.com/cocina/recetas/pescados-mariscos/langostinos-horno-perejil-karlos-arguinano.html?utm_source=TwitterKarlos&utm_medium=social&utm_campaign=langostinos-horno-perejil-karlos-arguinano", "1.jpg", "[\"24 langostinos\",\"1 lim\\u00F3n\",\"40 ml de whisky\",\"sal\",\"2 dientes de ajo\",\"1/2 guindilla\",\"aceite de oliva virgen extra\",\"perejil\"]", "Langostinos al horno", "[\"Para hacer esta original versi\\u00F3n de la salsa de ajo y perejil, pela y pica los dientes de ajo en daditos, y ponlos en un bol. Pica tambi\\u00E9n la guindilla y un manojo de perejil (necesitamos una cucharada de perejil) y agr\\u00E9galos. Vierte el whisky y 60 ml de aceite, y mezcla bien\",\"Pela los langostinos dej\\u00E1ndoles la cabeza y la punta de la cola, sin pelar. Col\\u00F3calos en una bandeja de horno, sazona y ader\\u00E9zalos con la mezcla de aceite, whisky, ajo, guindilla y perejil.\",\"Hornea los langostinos (con el horno precalentado) a 220\\u00BAC durante 4-5 minutos\"]", "[\"Sirve 6 langostinos en cada plato y ri\\u00E9galos con el l\\u00EDquido de la bandeja del horno.\",\"Lava el lim\\u00F3n, c\\u00F3rtalo en 4 y coloca un trozo en cada plato. Dec\\u00F3ralos con unas hojas de perejil fresco\"]" },
                    { 2, null, null, "16.jpg", null, "Tortilla de Patatas", null, null },
                    { 3, null, null, null, null, "Garbanzos con chorizo y Zanquarrón", null, null },
                    { 4, null, null, null, "[\"1 cola de merluza grandecita\",\"500 gr de cebolla\",\"2 patatas cocidas\",\"75 gr de aceite de oliva virgen extra\",\"5 gr de piment\\u00F3n\",\"50 gr de aceite de oliva (refrito): aceite donde has dorado unos ajos\",\"20 gr de vinagre de sidra\",\"1 cayena\",\"16 gr de ajo laminado\",\"perejil picado\",\"una pizca de sal\"]", "Merluza al Horno", "[\"Precalentar el horno a 180\\u00BA\",\"Se corta la cebolla en juliana y se frie en una sart\\u00E9n con los 75 gr de aceite de oliva durante unos 30 o 40 minutos hasta que est\\u00E9 muy pochada\",\"Se agrega el piment\\u00F3n de la vera en la sart\\u00E9n, se mueve bien el conjunto y cuando est\\u00E9 ligado se extiende sobre una placa del horno\",\"Se colocan encima las patatas cocidas cortadas en rodajas de medio centr\\u00EDmetro de grosor y se corona el conjunto con la cola de merluza, abierta en libro y perfectamente desespinada, con la piel hacia abajo en contacto con las patatas\",\"Se mete la placa en el horno y se cocina entorno a 8 minutos\"]", "[\"Se ponen los 50 gr de aceite de oliva refrito en una sart\\u00E9n junto al ajo y la cayena\",\"Cuando los ajos empiecen a bailar y tomen color se vierte el conjunto sobre la merluza y las patatas que previamente habremos sacado del horno\",\"Se echa el vinagre sobre la misma sart\\u00E9n, se deja que de un hervor y se vierte de nuevo sobre la merluza\",\"Se escurre todo el jugo de la bandeja de hornear sobre la sart\\u00E9n y se lleva a ebullici\\u00F3n.\",\"Se vierte de nuevo sobre la merluza y se repite este paso 3 veces en total\",\"Se espolvorea con perejil y se sirve inmediatamente\"]" },
                    { 5, null, null, "5.jpg", null, "Brócoli con gulas", null, null },
                    { 6, null, null, null, null, "Pechugas a la plancha", null, null },
                    { 7, 4, "https://www.hogarmania.com/cocina/recetas/ensaladas-verduras/patatas-riojana-3737.html", "2.jpg", "[\"3 chorizos\",\"1 pimiento verde\",\"1 cabeza de ajos\",\"aceite de oliva\",\"2 hojas de laurel\",\"perejil (para decorar)\",\"6 patatas\",\"1 cebolla\",\"2 pimientos choriceros\",\"agua\",\"sal\",\"1 guindilla\"]", "Patatas a la riojana", "[\"Pica la cebolla y el pimiento verde y ponlos en una olla r\\u00E1pida con un chorrito de aceite.\",\"A\\u00F1ade la cabeza de ajos, las hojas de laurel y la guindilla (sin pepitas). Incorpora los chorizos cortados en rodajas y las patatas peladas y cascadas. Cubre con agua y sazona. Cierra la olla y cocina al 1 durante 5 minutos a partir de que empiece a salir el vapor.\",\"Si no utilizas una olla r\\u00E1pida, cocina hasta que las patatas est\\u00E9n guisadas (30-40 minutos aproximadamente).\",\"Retira las semillas a los pimientos choriceros y ponlos a remojo en un cazo con agua templada. Cuando se ablanden, deja templar, retira la carne con un cuchillo y p\\u00EDcala.\",\"Destapa la olla, saca la cabeza de ajos y la guindilla y desgrasa con un cuchar\\u00F3n. A\\u00F1ade los pimientos choriceros, remueve y cocina durante dos minutos m\\u00E1s (para que se mezclen los sabores).\",\"Pon a punto de sal.\"]", "[\"Sirve las patatas a la riojana en un plato hondo y decora con una hojita de perejil.\"]" },
                    { 8, null, null, "7.jpg", null, "Ensalada de pasta", null, null },
                    { 9, null, null, "11.jpg", null, "Sandwich de Jamon York y Queso", null, null },
                    { 10, null, null, "10.jpg", "[\"1 patata\",\"1 pimiento rojo\",\"1 pimiento verde\",\"1 tomate\",\"1 zanahoria\",\"1 cebolla\",\"2 ajos\",\"1 cucharada de piment\\u00F3n dulce\",\"1 cucharadita de pimienta negra\"]", "Alubias Blancas de Bote", "[\"Pochas la cebolla en una cazuela\",\"Una vez pochada a\\u00F1ades los pimientos y los ajos bien picaditos\",\"Cuando veamos que los pimientos y la cebolla est\\u00E1n bien integrados a\\u00F1adimos el tomate tambi\\u00E9n picadito y sofreimos un poco mas\",\"A continuaci\\u00F3n a\\u00F1adimos la zanahoria a rodajas, la patata a gajos peque\\u00F1os, cubrimos con agua, ponemos la sal, pimienta y el pimenton dulce\",\"Cuando ya est\\u00E9n la patata y la zanahoria blandas y el agua haya reducido un poco a\\u00F1adimos las alubias bien lavadas, movemos con vuidado que no se rompan y listo\"]", null },
                    { 11, null, null, "6.jpg", "[\"carne picada\",\"pimiento rojo\",\"pimiento verde\",\"cebolla\",\"tomate frito\",\"maiz\",\"tortillas de trigo\",\"sal\",\"Tabasco\",\"Salsa Barbacoa\",\"Ketchp\",\"queso rallado\"]", "Burritos de carne picada", "[\"Pochamos la cebolla y los pimientos\",\"Cuando est\\u00E9n pochados a\\u00F1adimos la carne picada y la sal\",\"Cuando la carne est\\u00E9 hecha a\\u00F1adimos el maiz y el tomate frito\"]", "[\"Puedes acompa\\u00F1ar con unos nachos y guacamole\"]" },
                    { 12, null, null, "8.jpg", "[\"vainas\",\"carne de ternera\",\"cebolla\",\"pimiento verde\",\"sal\"]", "Sandwich de Jamon York y Queso", null, null },
                    { 13, null, null, null, "[\"Medio vaso de lentejas por cada raci\\u00F3n\",\"un pu\\u00F1ado de arroz\",\"media cebolla\",\"2 o 3 zanahorias\",\"2 o 3 puerros\",\"1 pimiento verde\",\"2 o 3 patatas\",\"2 tomates\",\"chorizo de cocido\",\"costilla de cerdo\",\"sal\",\"aceite de oliva\"]", "Lentejas con arroz", "[\"Pones a hervir los tomates para pelarlos y trocearlos antes de echarlos a la olla\",\"Echas las lentejas y el arroz en la olla con un vaso de agua por cada raci\\u00F3n\",\"Troceas finita la cebolla y la echas tb en la olla\",\"Troceas las zanahorias peladas y a la olla\",\"Troceas las patatas y los puerros y a la olla\",\"Echas el pimiento verde troceado solo en 2 para darle sabor, luego lo quitas\",\"Echas los tomates troceados\",\"Echas el chorizo y la costilla\",\"Si echas costilla mas de 15 minutos de olla\",\"Echas un chorro de aceite y sal\",\"Pones la olla 15 minutos\"]", null },
                    { 14, null, null, "4.jpg", "[\"anchoas\",\"harina\",\"huevo\",\"aceite de oliva\",\"cogollos de lechuga\"]", "Anchoas albardadas", "[\"Se limpian las anchoas quit\\u00E1ndoles la cabeza y las tripas\",\"Se pasan por harina y huevo\",\"Se fr\\u00EDen en aceite de oliva\"]", "[\"Se sirven con cogollos de lechuga\"]" },
                    { 15, null, "https://www.youtube.com/watch?v=myTmIYDStWs", null, "[\"1 rodaballo\",\"3 patatas\",\"1 pimiento verde italiano\",\"2 chalotas\",\"2 tomates rama\",\"2 dientes de ajo\",\"Perejil\",\"100 ml de vino blanco para el majado\",\"150 ml de vino blanco para las patatas\",\"Sal\",\"Aceite de oliva virgen extra\"]", "Robadallo al horno", null, null },
                    { 16, null, null, null, null, "Alubias", null, null },
                    { 17, null, null, null, null, "Lubina al horno", null, null },
                    { 18, null, null, null, null, "Tarta Lotus", null, null },
                    { 19, null, null, null, null, "Cordero al horno", null, null },
                    { 20, null, null, null, null, "Hamburgesas veganas", null, null },
                    { 21, null, null, null, null, "Fajitas de pollo", null, null },
                    { 22, null, null, null, null, "Berenjena rellena al horno", null, null },
                    { 23, null, null, null, null, "Coliflor gratinada", null, null },
                    { 24, null, null, null, null, "Pasta fresca con salsa de naranja", null, null },
                    { 25, null, null, null, null, "Pulpo a feira", null, null },
                    { 26, null, null, null, null, "Pasta con verduras", null, null },
                    { 27, null, null, null, "[\"pasta a poder ser La Molisana Mezzi Rigatini N\\u00BA 32 integral\",\"carne picada\",\"cebolla\",\"zanahoria\",\"pimiento verde\",\"tomate frito\",\"sal\"]", "Pasta con carne picada", "[\"Picas finoa la cebolla, la zanahoria y el pimiento\",\"Pochamos todo a\\u00F1adiendo sal\",\"Cuando est\\u00E9 todo pochado a\\u00F1adimos la carne picada a la que previamente hemos echado tambien sal\",\"Cuando la carne est\\u00E9 hecha desengrasas y a\\u00F1ades tomate frito\",\"Al final a\\u00F1ades la pasta cocida y mezclas todo bien\"]", "[\"Puedes a\\u00F1adir queso rallado por encima\"]" },
                    { 28, null, null, null, null, "Guisantes con jamón", null, null },
                    { 29, null, null, null, null, "Alcachofas con jamón", null, null },
                    { 30, null, null, "14.jpg", "[\"carne picada\",\"3 huevos\",\"pan rallado\",\"2 zanahorias\",\"sal\",\"pimienta\",\"2 cebollas\",\"harina\",\"tomate frito\",\"2 rebanadas de pan bimbo\",\"leche\",\"1 pmiento verdea\"]", "Albóndigas en salsa", "[\"Pones la carne picada en un bol\",\"Untamos en un poco de leche las 2 rebanadas de pan bimbo\",\"picas fina 1 cebolla y la pochas\",\"Echas esta cebolla pochada encima de la carne picada\",\"Echas las rebanadas de pan bimbo empapadas en leche en el bol\",\"Echas 3 huevos en el bol y mezclas todo con sal\",\"Para la salsa picas la otra cebolla, las zanahorias y el pimiento verde no hace falta que sea muy fino porque luego se bate todo\",\"Lo pochas todo y cuando est\\u00E9 pochado lo bates echando todo en un recipiente de batir y echando dentro tambi\\u00E9n tomate frito\",\"Haces las bolas enharinandolas y las fr\\u00EDes\",\"Cuando est\\u00E9n fritas las echas en una cazuela y echas la salsa por encima mas un poco de agua para que cubra y las tienes a fuego lento hasta que reduzca\"]", null },
                    { 31, null, null, null, null, "Sopa de fideos", null, null },
                    { 32, null, null, null, null, "Puré de calabaza", null, null },
                    { 33, null, null, "12.jpg", "[\"bacalao\",\"patatas\",\"cebolla\",\"pimiento verde\",\"pimiento rojo\",\"aceite de oliva\",\"sal\"]", "Bacalao al Horno", "[\"Precalientas el horno a 220 grados\",\"Echas un poco de aceite en la bandeja para que no se pege nada\",\"Cortas las patatas finas, les echas sal y las metes en el horno 15 minutos\",\"Cortas la cebolla en juliana y los pimientos, echas sal y los pones despu\\u00E9s otros 15 minutos en el horno\",\"Pones el bacalao en un hueco entre todo lo dem\\u00E1s, echas sal y lo metes 15 minutos mas a 200 grados\"]", null },
                    { 34, null, "https://www.hogarmania.com/cocina/recetas/postres/tarta-fria-limon.html#google_vignette", "17.jpg", "[\"200 g de galletas\",\"100 g de mantequilla fundida\",\"2 huevos peque\\u00F1os\",\"50 g de mantequilla\",\"ralladura de 1/2 lim\\u00F3n\",\"4 g de hojas de gelatina\",\"100 g de az\\u00FAcar\",\"60 ml de zumo de lim\\u00F3n\",\"250 ml de nata (35% materia grasa)\"]", "Tarta de limón", null, null },
                    { 35, null, null, "13.jpg", "[\"1 carcasa de pollo\",\"1 trozo cebolla\",\"1 puerro\",\"sal\",\"fideos\",\"1 huevo cocido\",\"1 zanahoria\"]", "Sopa de Pollo", "[\"Pones la carcasa de pollo en una olla con agua junto con la cebolla, el puerro y las zanahorias\",\"Dejas hervir y echas sal\",\"Quitas todo\",\"A\\u00F1ades los fideos y dejas cocer el tiempo que te diga la bolsa delo que eches\"]", "[\"Puedes a\\u00F1adir un huevo cocido picado por encima\",\"Puedes batir la zanahoria y el puerro que has sacado y echarlo encima\"]" },
                    { 36, null, null, null, null, "Entrecot a la plancha", null, null },
                    { 37, null, null, null, "[\"lechuga\",\"maiz\",\"at\\u00FAn\",\"aceitunas\",\"huevo cocido\",\"aceite de oliva\",\"sal\",\"vinagre\",\"manzana\",\"mozzarella o burrata\",\"Pimiento picado\"]", "Ensalada Mixta", null, null },
                    { 38, 4, "https://www.hogarmania.com/cocina/recetas/ensaladas-verduras/hamburguesas-calabaza.html", "15.jpg", "[\"1/2 kg de calabaza\",\"155 gr de copos de avena\",\"150 ml salsa de tomate\",\"aceite\",\"vinagre\",\"cebolla frita deshidratada\",\"1 zanahoria\",\"100 gr de queso mozzarella\",\"sal\",\"1/2 cucharadita de comino en polvo\",\"1 cucharada de ajo en polvo\"]", "Hamburguesas de Calabaza", "[\"Calienta una cazuela con abundante agua. Pela la calabaza, troc\\u00E9ala y a\\u00F1\\u00E1dela a la cazuela. Sazona, tapa y cu\\u00E9cela durante 12-15 minutos\",\"Retira, esc\\u00FArrela, p\\u00E1sala a un bol y apl\\u00E1stala con un tenedor hasta dejarla reducida a un pur\\u00E9.\",\"Pela la zanahoria, r\\u00E1llala y res\\u00E9rvala\",\"Pon el pur\\u00E9 de calabaza, los copos de avena y la zanahoria rallada en un bol grande. Agrega una cucharada de perejil picado, la cebolla, el comino y el ajo. Sazona y mezcla bien\",\"Corta el queso en daditos\",\"Para montar las hamburguesas, pon un trozo de papel de horno (10 x 10 cm) sobre la tabla, coloca encima un aro de emplatar de 7 cm y rell\\u00E9nalo (a la mitad) con una parte de la mezcla, agrega unos daditos de queso y c\\u00FAbrelos con otra parte de la mezcla de calabaza. Presiona un poco la masa, pasa la hamburguesa a una fuente y retira el aro. Repite el proceso y monta otras 7 hamburguesas.\",\"Calienta un par de cucharadas de aceite en una plancha, a\\u00F1ade las hamburguesas (sin retirarles el papel) y coc\\u00EDnalas durante 3 minutos por cada lado.\"]", "[\"Sirve en cada plato un par de hamburguesas y un poco de salsa de tomate\",\"Adereza la r\\u00FAcula con aceite, vinagre y sal y acompa\\u00F1a las hamburguesas con una porci\\u00F3n de ensalada\",\"Adorna los platos con unas hojas de perejil\"]" },
                    { 39, null, "https://www.cocinatis.com/receta/galletas-de-avena-y-platano-sin-azucar-una-receta-saludable-y-facil-con-solo-3-ingredientes.html", "18.jpg", null, "Galletas de Plátano con chocolate", null, null },
                    { 40, null, null, "19.jpg", "[\"Un Pollo Trozeado\",\"Zanahoria\",\"1 pimiento verde\",\"1 pimiento rojo\",\"Vino Blanco\",\"Ketchup\",\"Cebolla\",\"Sal\",\"Aceite de oliva\"]", "Pollo a la virulé", "[\"Marcas los trozos de pollo\",\"Picas fina la verdura y la pochas\",\"Cuando est\\u00E9 pochada a\\u00F1ades el pollo\",\"Cuando el pollo est\\u00E9 hecho a\\u00F1ades el vino blanco y el ketchup\"]", null }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaReceta_RecetasRecetaId",
                table: "CategoriaReceta",
                column: "RecetasRecetaId");

            migrationBuilder.CreateIndex(
                name: "IX_CDs_GrupoId",
                table: "CDs",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Discos_GrupoId",
                table: "Discos",
                column: "GrupoId");

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
                name: "CategoriaReceta");

            migrationBuilder.DropTable(
                name: "CDs");

            migrationBuilder.DropTable(
                name: "Discos");

            migrationBuilder.DropTable(
                name: "MenuSemanalReceta");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "MenuSemanal");

            migrationBuilder.DropTable(
                name: "Recetas");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
