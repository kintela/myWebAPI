using KintelaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.IO;

namespace KintelaData
{
	public class KintelaContext:DbContext
	{
		public DbSet<Receta> Recetas { get; set; }
		public DbSet<Categoria> Categorias { get; set; }
		public DbSet<MenuSemanal> MenuSemanal { get; set; }
		public DbSet<Grupo> Grupos { get; set; }
		public DbSet<Disco> Discos { get; set; }
		public DbSet<CD> CDs { get; set; }

		public KintelaContext(DbContextOptions<KintelaContext> options):base(options)
    {
            
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			/*optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=KintelaDatabase")
				.LogTo(Console.WriteLine, 
					new[] { DbLoggerCategory.Database.Command.Name},
					LogLevel.Information)
				.EnableSensitiveDataLogging();*/

			
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Receta>(entity =>
			{
				entity.Property(e => e.Preparacion).IsRequired(false);
				entity.Property(e => e.Ingredientes).IsRequired(false);
				entity.Property(e => e.Presentacion).IsRequired(false);
				entity.Property(e => e.EnlaceVideo).IsRequired(false);
				entity.Property(e => e.Comensales).IsRequired(false);
				entity.Property(e => e.Imagen).IsRequired(false);
			});

			modelBuilder.Entity<MenuSemanal>(entity =>
			{
				entity.Property(e => e.FechaCreacion).IsRequired();
			});

			modelBuilder.Entity<Usuario>(entity =>
			{
				entity.Property(e => e.Nombre).IsRequired(false);
				entity.Property(e => e.Apellidos).IsRequired(false);
				entity.Property(e => e.FechaBaja).IsRequired(false);
				entity.Property(e => e.FechaAlta).IsRequired();
			});			

			modelBuilder.Entity<CD>(entity =>
			{
				entity.Property(e => e.caratula).IsRequired(false);
			});


			List<Categoria> categorias = new List<Categoria>
			{
				new Categoria
				{
					CategoriaId=1,
					Nombre="Carne",
				},
				new Categoria
				{
					CategoriaId=2,
					Nombre="Ensalada",
				},
				new Categoria
				{
					CategoriaId=3,
					Nombre="Huevos",
				},
				new Categoria
				{
					CategoriaId=4,
					Nombre="Legumbres",
				},
				new Categoria
				{
					CategoriaId=5,
					Nombre="Pasta",
				},
				new Categoria
				{
					CategoriaId=6,
					Nombre="Patatas",
				},
				new Categoria
				{
					CategoriaId=7,
					Nombre="Pescado",
				},
				new Categoria
				{
					CategoriaId=8,
					Nombre="Postre",
				},
				new Categoria
				{
					CategoriaId=9,
					Nombre="Sandwich",
				},
				new Categoria
				{
					CategoriaId=10,
					Nombre="Sopa",
				},
				new Categoria
				{
					CategoriaId=11,
					Nombre="Tortilla",
				},
				new Categoria
				{
					CategoriaId=12,
					Nombre="Verdura",
				}
			};
			modelBuilder.Entity<Categoria>().HasData(categorias);

			List<Grupo> grupos = new List<Grupo>
			{
				new Grupo
				{
					GrupoId=1,
					Nombre="The Beatles",
				},
				new Grupo
				{
					GrupoId=2,
					Nombre="The Rolling Stones",
				},
				new Grupo
				{
					GrupoId=3,
					Nombre="Tom Petty & The Heart Breakers",
				},
				new Grupo
				{
					GrupoId=4,
					Nombre="Tom Petty",
				},
				new Grupo
				{
					GrupoId=5,
					Nombre="Traveling Wilburys",
				},
				new Grupo
				{
					GrupoId=6,
					Nombre="Corey Harris",
				},
				new Grupo
				{
					GrupoId=7,
					Nombre="Pearl Jam",
				},
				new Grupo
				{
					GrupoId=8,
					Nombre="Eric Clapton",
				}
			};
			modelBuilder.Entity<Grupo>().HasData(grupos);

			List<Disco> discos = new List<Disco>
			{
				new Disco
				{
					DiscoId=1,
					Nombre="Tom Petty & The Heartbreakers",
					YearPublicacion=1976,
					Caratula="1.jpg",
					Discografica="Shelter Records",
					Productor="Denny Cordell",
					GrupoId=3
				},
				new Disco
				{
					DiscoId=2,
					Nombre="You're Gonna Get It!",
					YearPublicacion=1978,
					Caratula="2.jpg",
					Discografica="Shelter Records",
					Productor="Denny Cordell, Noah Shark, Tom Petty",
					GrupoId=3
				},
				new Disco
				{
					DiscoId=3,
					Nombre="Damn the Torpedoes",
					YearPublicacion=1979,
					Caratula="3.jpg",
					Discografica="Backstreet Records",
					Productor="Jimmy Iovine, Tom Petty",
					GrupoId=3
				},
				new Disco
				{
					DiscoId=4,
					Nombre="Hard Promises",
					YearPublicacion=1981,
					Caratula="4.jpg",
					Discografica="Backstreet Records",
					Productor="Jimmy Iovine, Tom Petty",
					GrupoId=3
				},
				new Disco
				{
					DiscoId=5,
					Nombre="Long After Dark",
					YearPublicacion=1982,
					Caratula="5.jpg",
					Discografica="Backstreet Records",
					Productor="Jimmy Iovine, Tom Petty",
					GrupoId=3
				},
				new Disco
				{
					DiscoId=6,
					Nombre="Southern Accents",
					YearPublicacion=1985,
					Caratula="6.jpg",
					Discografica="MCA Records",
					Productor="Tom Petty, Dave Stewart, Jimmy Iovine, Robbie Robertson, Mike Campbell",
					GrupoId=3
				},
				new Disco
				{
					DiscoId=7,
					Nombre="Let Me Up (I've Had Enough)",
					YearPublicacion=1987,
					Caratula="7.jpg",
					Discografica="MCA Records",
					Productor="Tom Petty, Mike Campbell",
					GrupoId=3
				},
				new Disco
				{
					DiscoId=8,
					Nombre="Into the Great Wide Open",
					YearPublicacion=1991,
					Caratula="8.jpg",
					Discografica="MCA Records",
					Productor="Jeff Lynne, Tom Petty, Mike Campbell",
					GrupoId=3
				},
				new Disco
				{
					DiscoId=9,
					Nombre="Songs and Music from 'She's the One'",
					YearPublicacion=1996,
					Caratula="9.jpg",
					Discografica="Warner Bros. Records",
					Productor="Rick Rubin, Tom Petty, Mike Campbell",
					GrupoId=3
				},
				new Disco
				{
					DiscoId=10,
					Nombre="Echo",
					YearPublicacion=1999,
					Caratula="10.jpg",
					Discografica="Warner Bros. Records",
					Productor="Rick Rubin, Tom Petty, Mike Campbell",
					GrupoId=3
				},
				new Disco
				{
					DiscoId=11,
					Nombre="The Last DJ",
					YearPublicacion=2002,
					Caratula="11.jpg",
					Discografica="Warner Bros. Records",
					Productor="Tom Petty, Mike Campbell, George Drakoulias",
					GrupoId=3
				},
				new Disco
				{
					DiscoId=12,
					Nombre="Mojo",
					YearPublicacion=2010,
					Caratula="12.jpg",
					Discografica="Reprise Records",
					Productor="Tom Petty, Mike Campbell, Ryan Ulyate",
					GrupoId=3
				},
				new Disco
				{
					DiscoId=13,
					Nombre="Hypnotic Eye",
					YearPublicacion=2014,
					Caratula="13.jpg",
					Discografica="Reprise Records",
					Productor="Tom Petty, Mike Campbell, Ryan Ulyate",
					GrupoId=3
				},

				new Disco
				{
					DiscoId=14,
					Nombre="Wildflowers",
					YearPublicacion=1994,
					Caratula="14.jpg",
					Discografica="Warner Bros. Records",
					Productor="Rick Rubin, Tom Petty, Mike Campbell",
					GrupoId=4
				},
				new Disco
				{
					DiscoId=15,
					Nombre="Highway Companion",
					YearPublicacion=2006,
					Caratula="15.jpg",
					Discografica="American Recordings",
					Productor="Jeff Lynne, Tom Petty, Mike Campbell",
					GrupoId=4
				},

				new Disco
				{
					DiscoId=16,
					Nombre="Traveling Wilburys Vol. 1",
					YearPublicacion=1998,
					Caratula="16.jpg",
					Discografica="Warner Bros. Records",
					Productor="Jeff Lynne, George Harrison",
					GrupoId=5
				},
				new Disco
				{
					DiscoId=17,
					Nombre="Traveling Wilburys Vol. 3",
					YearPublicacion=1998,
					Caratula="17.jpg",
					Discografica="Warner Bros. Records",
					Productor="Jeff Lynne, George Harrison",
					GrupoId=5
				},

				new Disco
				{
					DiscoId=18,
					Nombre="Please Please Me",
					YearPublicacion=1963,
					Caratula="1.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					DiscoId=19,
					Nombre="With The Beatles",
					YearPublicacion=1963,
					Caratula="1.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					DiscoId=20,
					Nombre="A Hard Day's Night",
					YearPublicacion=1964,
					Caratula="2.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					DiscoId=21,
					Nombre="Beatles for Sale",
					YearPublicacion=1964,
					Caratula="3.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					DiscoId=22,
					Nombre="Help!",
					YearPublicacion=1965,
					Caratula="4.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					DiscoId=23,
					Nombre="Rubber Soul",
					YearPublicacion=1965,
					Caratula="5.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					DiscoId=24,
					Nombre="Revolver",
					YearPublicacion=1966,
					Caratula="6.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					DiscoId=25,
					Nombre="Sgt. Pepper's Lonely Hearts Club Band",
					YearPublicacion=1967,
					Caratula="7.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					DiscoId=26,
					Nombre="Magical Mystery Tour",
					YearPublicacion=1967,
					Caratula="8.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					DiscoId=27,
					Nombre="The Beatles (White Album)",
					YearPublicacion=1968,
					Caratula="9.png",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					DiscoId=28,
					Nombre="Yellow Submarine",
					YearPublicacion=1969,
					Caratula="10.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					DiscoId=29,
					Nombre="Abbey Road",
					YearPublicacion=1969,
					Caratula="11.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					DiscoId=30,
					Nombre="Let It Be",
					YearPublicacion=1970,
					Caratula="12.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},

				new Disco
				{
					DiscoId=31,
					Nombre="The Rolling Stones",
					YearPublicacion=1964,
					Caratula="31.jpeg",
					Discografica="Decca Records",
					Productor="Andrew Loog Oldham",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=32,
					Nombre="The Rolling Stones No. 2",
					YearPublicacion=1965,
					Caratula="32.jpeg",
					Discografica="Decca Records",
					Productor="Andrew Loog Oldham",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=33,
					Nombre="Out of Our Heads",
					YearPublicacion=1965,
					Caratula="33.jpeg",
					Discografica="Decca Records",
					Productor="Andrew Loog Oldham",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=34,
					Nombre="Aftermath",
					YearPublicacion=1966,
					Caratula="34.jpeg",
					Discografica="Decca Records",
					Productor="Andrew Loog Oldham",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=35,
					Nombre="Between the Buttons",
					YearPublicacion=1967,
					Caratula="35.jpeg",
					Discografica="Decca Records",
					Productor="Andrew Loog Oldham",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=36,
					Nombre="Their Satanic Majesties Request",
					YearPublicacion=1967,
					Caratula="36.jpeg",
					Discografica="Decca Records",
					Productor="The Rolling Stones",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=37,
					Nombre="Beggar's Banquet",
					YearPublicacion=1968,
					Caratula="37.jpeg",
					Discografica="Decca Records",
					Productor="Jimmy Miller",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=38,
					Nombre="Let It Bleed",
					YearPublicacion=1969,
					Caratula="38.jpeg",
					Discografica="Decca Records",
					Productor="Jimmy Miller",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=39,
					Nombre="Sticky Fingers",
					YearPublicacion=1971,
					Caratula="39.jpeg",
					Discografica="Rolling Stones Records",
					Productor="Jimmy Miller",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=40,
					Nombre="Exile on Main St",
					YearPublicacion=1972,
					Caratula="40.jpeg",
					Discografica="Rolling Stones Records",
					Productor="Jimmy Miller",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=41,
					Nombre="Goats Head Soup",
					YearPublicacion=1973,
					Caratula="41.jpeg",
					Discografica="Rolling Stones Records",
					Productor="Jimmy Miller",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=42,
					Nombre="It's Only Rock 'n Roll",
					YearPublicacion=1974,
					Caratula="42.jpeg",
					Discografica="Rolling Stones Records",
					Productor="The Glimmer Twins",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=43,
					Nombre="Black and Blue",
					YearPublicacion=1976,
					Caratula="43.jpeg",
					Discografica="Rolling Stones Records",
					Productor="The Glimmer Twins",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=44,
					Nombre="Some Girls",
					YearPublicacion=1978,
					Caratula="43.jpeg",
					Discografica="Rolling Stones Records",
					Productor="The Glimmer Twins",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=45,
					Nombre="Emotional Rescue",
					YearPublicacion=1980,
					Caratula="44.jpeg",
					Discografica="Rolling Stones Records",
					Productor="The Glimmer Twins",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=46,
					Nombre="Tatoo You",
					YearPublicacion=1981,
					Caratula="45.jpeg",
					Discografica="Rolling Stones Records",
					Productor="The Glimmer Twins",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=47,
					Nombre="Undercover",
					YearPublicacion=1983,
					Caratula="46.jpeg",
					Discografica="Rolling Stones Records",
					Productor="The Glimmer Twins, Chris Kimsey",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=48,
					Nombre="Dirty Work",
					YearPublicacion=1986,
					Caratula="47.jpeg",
					Discografica="Rolling Stones Records",
					Productor="The Glimmer Twins, Steve Lilywhite",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=49,
					Nombre="Steel Wheels",
					YearPublicacion=1989,
					Caratula="48.jpeg",
					Discografica="Rolling Stones Records",
					Productor="The Glimmer Twins, Chris Kimsey",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=50,
					Nombre="Voodoo Lounge",
					YearPublicacion=1994,
					Caratula="49.jpeg",
					Discografica="Virgin Records",
					Productor="The Glimmer Twins, Don Was",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=51,
					Nombre="Bridge to Babylon",
					YearPublicacion=1997,
					Caratula="50.jpeg",
					Discografica="Virgin Records",
					Productor="The Glimmer Twins. Don Was, Rob Fraboni, Danny Saber, Pierre de Beauport. The Dust Brothers",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=52,
					Nombre="A Bigger Bang",
					YearPublicacion=2005,
					Caratula="51.jpeg",
					Discografica="Virgin Records",
					Productor="The Glimmer Twins, Don Was, Matt Clifford",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=53,
					Nombre="Blue & Lonesome",
					YearPublicacion=2016,
					Caratula="52.jpeg",
					Discografica="Polydor Records",
					Productor="The Glimmer Twins, Don Was",
					GrupoId=2
				},
				new Disco
				{
					DiscoId=54,
					Nombre="Hackney Diamonds",
					YearPublicacion=2023,
					Caratula="53.jpeg",
					Discografica="Geffen Records",
					Productor="Andrew Watt",
					GrupoId=2
				},


			};
			modelBuilder.Entity<Disco>().HasData(discos);

			List<Receta> recetas = new List<Receta>
			{
				new Receta
				{
					RecetaId=1,
					Imagen="1.jpg",	
					Nombre="Langostinos al horno",
					Ingredientes=["24 langostinos","1 limón","40 ml de whisky","sal", "2 dientes de ajo","1/2 guindilla","aceite de oliva virgen extra","perejil"],
					Preparacion=["Para hacer esta original versión de la salsa de ajo y perejil, pela y pica los dientes de ajo en daditos, y ponlos en un bol. Pica también la guindilla y un manojo de perejil (necesitamos una cucharada de perejil) y agrégalos. Vierte el whisky y 60 ml de aceite, y mezcla bien",
				"Pela los langostinos dejándoles la cabeza y la punta de la cola, sin pelar. Colócalos en una bandeja de horno, sazona y aderézalos con la mezcla de aceite, whisky, ajo, guindilla y perejil.",
				"Hornea los langostinos (con el horno precalentado) a 220ºC durante 4-5 minutos"],
					Presentacion=["Sirve 6 langostinos en cada plato y riégalos con el líquido de la bandeja del horno.","Lava el limón, córtalo en 4 y coloca un trozo en cada plato. Decóralos con unas hojas de perejil fresco"],
					EnlaceVideo="https://www.hogarmania.com/cocina/recetas/pescados-mariscos/langostinos-horno-perejil-karlos-arguinano.html?utm_source=TwitterKarlos&utm_medium=social&utm_campaign=langostinos-horno-perejil-karlos-arguinano"
				},
				new Receta
				{
					RecetaId=2,
					Imagen="16.jpg",
					Nombre="Tortilla de Patatas",
				},
				new Receta
				{
					RecetaId=3,
					Nombre="Garbanzos con chorizo y Zanquarrón",
				},
				new Receta
				{
					RecetaId=4,
					Nombre="Merluza al Horno",
					Ingredientes=["1 cola de merluza grandecita","500 gr de cebolla","2 patatas cocidas","75 gr de aceite de oliva virgen extra","5 gr de pimentón",
				"50 gr de aceite de oliva (refrito): aceite donde has dorado unos ajos","20 gr de vinagre de sidra","1 cayena","16 gr de ajo laminado","perejil picado",
				"una pizca de sal"],
					Preparacion=["Precalentar el horno a 180º","Se corta la cebolla en juliana y se frie en una sartén con los 75 gr de aceite de oliva durante unos 30 o 40 minutos hasta que esté muy pochada",
				"Se agrega el pimentón de la vera en la sartén, se mueve bien el conjunto y cuando esté ligado se extiende sobre una placa del horno","Se colocan encima las patatas cocidas cortadas en rodajas de medio centrímetro de grosor y se corona el conjunto con la cola de merluza, abierta en libro y perfectamente desespinada, con la piel hacia abajo en contacto con las patatas",
				"Se mete la placa en el horno y se cocina entorno a 8 minutos"],
					Presentacion=["Se ponen los 50 gr de aceite de oliva refrito en una sartén junto al ajo y la cayena","Cuando los ajos empiecen a bailar y tomen color se vierte el conjunto sobre la merluza y las patatas que previamente habremos sacado del horno",
				"Se echa el vinagre sobre la misma sartén, se deja que de un hervor y se vierte de nuevo sobre la merluza","Se escurre todo el jugo de la bandeja de hornear sobre la sartén y se lleva a ebullición.",
				"Se vierte de nuevo sobre la merluza y se repite este paso 3 veces en total","Se espolvorea con perejil y se sirve inmediatamente"],
				},
				new Receta
				{
					RecetaId=5,
					Nombre="Brócoli con gulas",
					Imagen="5.jpg",
				},
				new Receta
				{
					RecetaId=6,
					Nombre="Pechugas a la plancha",
				},
				new Receta
				{
					RecetaId=7,
					Nombre="Patatas a la riojana",
					Imagen="2.jpg",
					Comensales=4,
					Ingredientes=["3 chorizos","1 pimiento verde","1 cabeza de ajos","aceite de oliva","2 hojas de laurel","perejil (para decorar)","6 patatas","1 cebolla","2 pimientos choriceros","agua","sal","1 guindilla"],
					Preparacion=["Pica la cebolla y el pimiento verde y ponlos en una olla rápida con un chorrito de aceite.","Añade la cabeza de ajos, las hojas de laurel y la guindilla (sin pepitas). Incorpora los chorizos cortados en rodajas y las patatas peladas y cascadas. Cubre con agua y sazona. Cierra la olla y cocina al 1 durante 5 minutos a partir de que empiece a salir el vapor.",
				"Si no utilizas una olla rápida, cocina hasta que las patatas estén guisadas (30-40 minutos aproximadamente).","Retira las semillas a los pimientos choriceros y ponlos a remojo en un cazo con agua templada. Cuando se ablanden, deja templar, retira la carne con un cuchillo y pícala.",
				"Destapa la olla, saca la cabeza de ajos y la guindilla y desgrasa con un cucharón. Añade los pimientos choriceros, remueve y cocina durante dos minutos más (para que se mezclen los sabores).",
				"Pon a punto de sal."],
					Presentacion=["Sirve las patatas a la riojana en un plato hondo y decora con una hojita de perejil."],
					EnlaceVideo="https://www.hogarmania.com/cocina/recetas/ensaladas-verduras/patatas-riojana-3737.html"
				},
				new Receta
				{
					RecetaId=8,
					Nombre="Ensalada de pasta",
					Imagen="7.jpg",
				},
				new Receta
				{
					RecetaId=9,
					Nombre="Sandwich de Jamon York y Queso",
					Imagen="11.jpg",
				},
				new Receta
				{
					RecetaId=10,
					Nombre="Alubias Blancas de Bote",
					Imagen="10.jpg",
					Ingredientes=["1 patata","1 pimiento rojo","1 pimiento verde","1 tomate","1 zanahoria","1 cebolla","2 ajos","1 cucharada de pimentón dulce","1 cucharadita de pimienta negra"],
					Preparacion=["Pochas la cebolla en una cazuela","Una vez pochada añades los pimientos y los ajos bien picaditos","Cuando veamos que los pimientos y la cebolla están bien integrados añadimos el tomate también picadito y sofreimos un poco mas",
				"A continuación añadimos la zanahoria a rodajas, la patata a gajos pequeños, cubrimos con agua, ponemos la sal, pimienta y el pimenton dulce",
				"Cuando ya estén la patata y la zanahoria blandas y el agua haya reducido un poco añadimos las alubias bien lavadas, movemos con vuidado que no se rompan y listo"]
				},
				new Receta
				{
					RecetaId=11,
					Nombre="Burritos de carne picada",
					Imagen="6.jpg",
					Ingredientes=["carne picada","pimiento rojo","pimiento verde","cebolla","tomate frito","maiz","tortillas de trigo","sal","Tabasco","Salsa Barbacoa","Ketchp","queso rallado"],
					Preparacion=["Pochamos la cebolla y los pimientos","Cuando estén pochados añadimos la carne picada y la sal","Cuando la carne esté hecha añadimos el maiz y el tomate frito"],
					Presentacion= ["Puedes acompañar con unos nachos y guacamole"]
				},
				new Receta
				{
					RecetaId=12,
					Nombre="Sandwich de Jamon York y Queso",
					Imagen="8.jpg",
					Ingredientes=["vainas","carne de ternera","cebolla","pimiento verde","sal",]
				},
				new Receta
				{
					RecetaId=13,
					Nombre="Lentejas con arroz",
					Ingredientes=["Medio vaso de lentejas por cada ración","un puñado de arroz","media cebolla","2 o 3 zanahorias","2 o 3 puerros","1 pimiento verde",
				"2 o 3 patatas","2 tomates","chorizo de cocido","costilla de cerdo","sal","aceite de oliva"],
					Preparacion=["Pones a hervir los tomates para pelarlos y trocearlos antes de echarlos a la olla","Echas las lentejas y el arroz en la olla con un vaso de agua por cada ración",
				"Troceas finita la cebolla y la echas tb en la olla","Troceas las zanahorias peladas y a la olla","Troceas las patatas y los puerros y a la olla",
				"Echas el pimiento verde troceado solo en 2 para darle sabor, luego lo quitas","Echas los tomates troceados","Echas el chorizo y la costilla",
				"Si echas costilla mas de 15 minutos de olla","Echas un chorro de aceite y sal","Pones la olla 15 minutos"]
				},
				new Receta
				{
					RecetaId=14,
					Nombre="Anchoas albardadas",
					Imagen="4.jpg",
					Ingredientes=["anchoas","harina","huevo","aceite de oliva","cogollos de lechuga"],
					Preparacion=["Se limpian las anchoas quitándoles la cabeza y las tripas","Se pasan por harina y huevo","Se fríen en aceite de oliva"],
					Presentacion=["Se sirven con cogollos de lechuga"],
				},
				new Receta
				{
					RecetaId=15,
					Nombre="Robadallo al horno",
					Ingredientes=["1 rodaballo","3 patatas","1 pimiento verde italiano","2 chalotas","2 tomates rama","2 dientes de ajo","Perejil","100 ml de vino blanco para el majado",
				"150 ml de vino blanco para las patatas","Sal","Aceite de oliva virgen extra"],
					EnlaceVideo="https://www.youtube.com/watch?v=myTmIYDStWs"
				},
				new Receta
				{
					RecetaId=16,
					Nombre="Alubias",
				},
				new Receta
				{
					RecetaId=17,
					Nombre="Lubina al horno",
				},
				new Receta
				{
					RecetaId=18,
					Nombre="Tarta Lotus",
				},
				new Receta
				{
					RecetaId=19,
					Nombre="Cordero al horno",
				},
				new Receta
				{
					RecetaId=20,
					Nombre="Hamburgesas veganas",
				},
				new Receta
				{
					RecetaId=21,
					Nombre="Fajitas de pollo",
				},
				new Receta
				{
					RecetaId=22,
					Nombre="Berenjena rellena al horno",
				},
				new Receta
				{
					RecetaId=23,
					Nombre="Coliflor gratinada",
				},
				new Receta
				{
					RecetaId=24,
					Nombre="Pasta fresca con salsa de naranja",
				},
				new Receta
				{
					RecetaId=25,
					Nombre="Pulpo a feira",
				},
				new Receta
				{
					RecetaId=26,
					Nombre="Pasta con verduras",
				},
				new Receta
				{
					RecetaId=27,
					Nombre="Pasta con carne picada",
					Ingredientes=["pasta a poder ser La Molisana Mezzi Rigatini Nº 32 integral","carne picada","cebolla","zanahoria","pimiento verde","tomate frito","sal"],
					Preparacion=["Picas finoa la cebolla, la zanahoria y el pimiento","Pochamos todo añadiendo sal","Cuando esté todo pochado añadimos la carne picada a la que previamente hemos echado tambien sal","Cuando la carne esté hecha desengrasas y añades tomate frito",
                        "Al final añades la pasta cocida y mezclas todo bien"],
					Presentacion=["Puedes añadir queso rallado por encima"],
				},
				new Receta
				{
					RecetaId=28,
					Nombre="Guisantes con jamón",
				},
				new Receta
				{
					RecetaId=29,
					Nombre="Alcachofas con jamón",
				},
				new Receta
				{
					RecetaId=30,
					Nombre="Albóndigas en salsa",
					Imagen="14.jpg",
					Ingredientes=["carne picada","3 huevos","pan rallado","2 zanahorias","sal","pimienta","2 cebollas","harina","tomate frito","2 rebanadas de pan bimbo","leche","1 pmiento verdea"],
					Preparacion=["Pones la carne picada en un bol","Untamos en un poco de leche las 2 rebanadas de pan bimbo","picas fina 1 cebolla y la pochas","Echas esta cebolla pochada encima de la carne picada",
        "Echas las rebanadas de pan bimbo empapadas en leche en el bol","Echas 3 huevos en el bol y mezclas todo con sal","Para la salsa picas la otra cebolla, las zanahorias y el pimiento verde no hace falta que sea muy fino porque luego se bate todo",
        "Lo pochas todo y cuando esté pochado lo bates echando todo en un recipiente de batir y echando dentro también tomate frito","Haces las bolas enharinandolas y las fríes","Cuando estén fritas las echas en una cazuela y echas la salsa por encima mas un poco de agua para que cubra y las tienes a fuego lento hasta que reduzca"]
				},
				new Receta
				{
					RecetaId=31,
					Nombre="Sopa de fideos",
				},
				new Receta
				{
					RecetaId=32,
					Nombre="Puré de calabaza",
				},
				new Receta
				{
					RecetaId=33,
					Nombre="Bacalao al Horno",
					Imagen="12.jpg",
					Ingredientes=["bacalao","patatas","cebolla","pimiento verde","pimiento rojo","aceite de oliva","sal"],
					Preparacion= ["Precalientas el horno a 220 grados","Echas un poco de aceite en la bandeja para que no se pege nada","Cortas las patatas finas, les echas sal y las metes en el horno 15 minutos","Cortas la cebolla en juliana y los pimientos, echas sal y los pones después otros 15 minutos en el horno",
        "Pones el bacalao en un hueco entre todo lo demás, echas sal y lo metes 15 minutos mas a 200 grados"],
				},
				new Receta
				{
					RecetaId=34,
					Nombre="Tarta de limón",
					Imagen="17.jpg",
					Ingredientes=["200 g de galletas","100 g de mantequilla fundida","2 huevos pequeños","50 g de mantequilla","ralladura de 1/2 limón","4 g de hojas de gelatina","100 g de azúcar","60 ml de zumo de limón",
				"250 ml de nata (35% materia grasa)"],
					EnlaceVideo="https://www.hogarmania.com/cocina/recetas/postres/tarta-fria-limon.html#google_vignette"
				},
				new Receta
				{
					RecetaId=35,
					Nombre="Sopa de Pollo",
					Imagen="13.jpg",
					Ingredientes=["1 carcasa de pollo","1 trozo cebolla","1 puerro","sal","fideos","1 huevo cocido", "1 zanahoria"],
					Preparacion =["Pones la carcasa de pollo en una olla con agua junto con la cebolla, el puerro y las zanahorias","Dejas hervir y echas sal", "Quitas todo","Añades los fideos y dejas cocer el tiempo que te diga la bolsa delo que eches"],
					Presentacion= ["Puedes añadir un huevo cocido picado por encima","Puedes batir la zanahoria y el puerro que has sacado y echarlo encima"],
				},
				new Receta
				{
					RecetaId=36,
					Nombre="Entrecot a la plancha"
				},
				new Receta
				{
					RecetaId=37,
					Nombre="Ensalada Mixta",
					Ingredientes=["lechuga","maiz","atún","aceitunas","huevo cocido","aceite de oliva","sal", "vinagre", "manzana","mozzarella o burrata","Pimiento picado"]
				},
				new Receta
				{
					RecetaId=38,
					Nombre="Hamburguesas de Calabaza",
					Imagen="15.jpg",
					Comensales=4,
					EnlaceVideo="https://www.hogarmania.com/cocina/recetas/ensaladas-verduras/hamburguesas-calabaza.html",
					Ingredientes= ["1/2 kg de calabaza","155 gr de copos de avena","150 ml salsa de tomate","aceite","vinagre","cebolla frita deshidratada","1 zanahoria","100 gr de queso mozzarella","sal","1/2 cucharadita de comino en polvo","1 cucharada de ajo en polvo"],
					Preparacion= ["Calienta una cazuela con abundante agua. Pela la calabaza, trocéala y añádela a la cazuela. Sazona, tapa y cuécela durante 12-15 minutos","Retira, escúrrela, pásala a un bol y aplástala con un tenedor hasta dejarla reducida a un puré.",
            "Pela la zanahoria, rállala y resérvala","Pon el puré de calabaza, los copos de avena y la zanahoria rallada en un bol grande. Agrega una cucharada de perejil picado, la cebolla, el comino y el ajo. Sazona y mezcla bien",
            "Corta el queso en daditos","Para montar las hamburguesas, pon un trozo de papel de horno (10 x 10 cm) sobre la tabla, coloca encima un aro de emplatar de 7 cm y rellénalo (a la mitad) con una parte de la mezcla, agrega unos daditos de queso y cúbrelos con otra parte de la mezcla de calabaza. Presiona un poco la masa, pasa la hamburguesa a una fuente y retira el aro. Repite el proceso y monta otras 7 hamburguesas.",
            "Calienta un par de cucharadas de aceite en una plancha, añade las hamburguesas (sin retirarles el papel) y cocínalas durante 3 minutos por cada lado."],
					Presentacion= ["Sirve en cada plato un par de hamburguesas y un poco de salsa de tomate","Adereza la rúcula con aceite, vinagre y sal y acompaña las hamburguesas con una porción de ensalada",
        "Adorna los platos con unas hojas de perejil"],
				},
				new Receta
				{
					RecetaId=39,
					Nombre="Galletas de Plátano con chocolate",
					Imagen="18.jpg",
					EnlaceVideo="https://www.cocinatis.com/receta/galletas-de-avena-y-platano-sin-azucar-una-receta-saludable-y-facil-con-solo-3-ingredientes.html",
				},
				new Receta
				{
					RecetaId=40,
					Nombre="Pollo a la virulé",
					Imagen="19.jpg",
					Ingredientes=["Un Pollo Trozeado","Zanahoria","1 pimiento verde","1 pimiento rojo","Vino Blanco","Ketchup","Cebolla","Sal","Aceite de oliva"],
					Preparacion=["Marcas los trozos de pollo","Picas fina la verdura y la pochas","Cuando esté pochada añades el pollo","Cuando el pollo esté hecho añades el vino blanco y el ketchup"]
				},				
			};
			modelBuilder.Entity<Receta>().HasData(recetas);


		}
	}
}
