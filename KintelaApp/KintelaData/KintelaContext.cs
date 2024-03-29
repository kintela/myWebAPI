using KintelaDomain;
using Microsoft.EntityFrameworkCore;

namespace KintelaData
{
	public class KintelaContext:DbContext
	{
		public DbSet<Receta> Recetas { get; set; }
		public DbSet<Categoria> Categorias { get; set; }
		public DbSet<Menu> Menus { get; set; }
		public DbSet<Grupo> Grupos { get; set; }
		public DbSet<Disco> Discos { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=KintelaDatabase");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			List<Categoria> categorias = new List<Categoria>
			{
				new Categoria
				{
					Id=1,
					Nombre="Carne",
				},
				new Categoria
				{
					Id=2,
					Nombre="Ensalada",
				},
				new Categoria
				{
					Id=3,
					Nombre="Huevos",
				},
				new Categoria
				{
					Id=4,
					Nombre="Legumbres",
				},
				new Categoria
				{
					Id=5,
					Nombre="Pasta",
				},
				new Categoria
				{
					Id=6,
					Nombre="Patatas",
				},
				new Categoria
				{
					Id=7,
					Nombre="Pescado",
				},
				new Categoria
				{
					Id=8,
					Nombre="Postre",
				},
				new Categoria
				{
					Id=9,
					Nombre="Sandwich",
				},
				new Categoria
				{
					Id=10,
					Nombre="Sopa",
				},
				new Categoria
				{
					Id=11,
					Nombre="Tortilla",
				},
				new Categoria
				{
					Id=12,
					Nombre="Verdura",
				}
			};
			modelBuilder.Entity<Categoria>().HasData(categorias);

			List<Grupo> grupos = new List<Grupo>
			{
				new Grupo
				{
					Id=1,
					Nombre="The Beatles",
				},
				new Grupo
				{
					Id=2,
					Nombre="The Rolling Stones",
				},
				new Grupo
				{
					Id=3,
					Nombre="Tom Petty & The Heart Breakers",
				},
				new Grupo
				{
					Id=4,
					Nombre="Tom Petty",
				},
				new Grupo
				{
					Id=5,
					Nombre="Traveling Wilburys",
				}
			};
			modelBuilder.Entity<Grupo>().HasData(grupos);

			List<Disco> discos = new List<Disco>
			{
				new Disco
				{
					Id=1,
					Nombre="Tom Petty & The Heartbreakers",
					YearPublicacion=1976,
					Caratula="1.jpg",
					Discografica="Shelter Records",
					Productor="Denny Cordell",
					GrupoId=3
				},
				new Disco
				{
					Id=2,
					Nombre="You're Gonna Get It!",
					YearPublicacion=1978,
					Caratula="2.jpg",
					Discografica="Shelter Records",
					Productor="Denny Cordell, Noah Shark, Tom Petty",
					GrupoId=3
				},
				new Disco
				{
					Id=3,
					Nombre="Damn the Torpedoes",
					YearPublicacion=1979,
					Caratula="3.jpg",
					Discografica="Backstreet Records",
					Productor="Jimmy Iovine, Tom Petty",
					GrupoId=3
				},
				new Disco
				{
					Id=4,
					Nombre="Hard Promises",
					YearPublicacion=1981,
					Caratula="4.jpg",
					Discografica="Backstreet Records",
					Productor="Jimmy Iovine, Tom Petty",
					GrupoId=3
				},
				new Disco
				{
					Id=5,
					Nombre="Long After Dark",
					YearPublicacion=1982,
					Caratula="5.jpg",
					Discografica="Backstreet Records",
					Productor="Jimmy Iovine, Tom Petty",
					GrupoId=3
				},
				new Disco
				{
					Id=6,
					Nombre="Southern Accents",
					YearPublicacion=1985,
					Caratula="6.jpg",
					Discografica="MCA Records",
					Productor="Tom Petty, Dave Stewart, Jimmy Iovine, Robbie Robertson, Mike Campbell",
					GrupoId=3
				},
				new Disco
				{
					Id=7,
					Nombre="Let Me Up (I've Had Enough)",
					YearPublicacion=1987,
					Caratula="7.jpg",
					Discografica="MCA Records",
					Productor="Tom Petty, Mike Campbell",
					GrupoId=3
				},
				new Disco
				{
					Id=8,
					Nombre="Into the Great Wide Open",
					YearPublicacion=1991,
					Caratula="8.jpg",
					Discografica="MCA Records",
					Productor="Jeff Lynne, Tom Petty, Mike Campbell",
					GrupoId=3
				},
				new Disco
				{
					Id=9,
					Nombre="Songs and Music from 'She's the One'",
					YearPublicacion=1996,
					Caratula="9.jpg",
					Discografica="Warner Bros. Records",
					Productor="Rick Rubin, Tom Petty, Mike Campbell",
					GrupoId=3
				},
				new Disco
				{
					Id=10,
					Nombre="Echo",
					YearPublicacion=1999,
					Caratula="10.jpg",
					Discografica="Warner Bros. Records",
					Productor="Rick Rubin, Tom Petty, Mike Campbell",
					GrupoId=3
				},
				new Disco
				{
					Id=11,
					Nombre="The Last DJ",
					YearPublicacion=2002,
					Caratula="11.jpg",
					Discografica="Warner Bros. Records",
					Productor="Tom Petty, Mike Campbell, George Drakoulias",
					GrupoId=3
				},
				new Disco
				{
					Id=12,
					Nombre="Mojo",
					YearPublicacion=2010,
					Caratula="12.jpg",
					Discografica="Reprise Records",
					Productor="Tom Petty, Mike Campbell, Ryan Ulyate",
					GrupoId=3
				},
				new Disco
				{
					Id=13,
					Nombre="Hypnotic Eye",
					YearPublicacion=2014,
					Caratula="13.jpg",
					Discografica="Reprise Records",
					Productor="Tom Petty, Mike Campbell, Ryan Ulyate",
					GrupoId=3
				},
				new Disco
				{
					Id=14,
					Nombre="Wildflowers",
					YearPublicacion=1994,
					Caratula="14.jpg",
					Discografica="Warner Bros. Records",
					Productor="Rick Rubin, Tom Petty, Mike Campbell",
					GrupoId=4
				},
				new Disco
				{
					Id=15,
					Nombre="Highway Companion",
					YearPublicacion=2006,
					Caratula="15.jpg",
					Discografica="American Recordings",
					Productor="Jeff Lynne, Tom Petty, Mike Campbell",
					GrupoId=4
				},
				new Disco
				{
					Id=16,
					Nombre="Traveling Wilburys Vol. 1",
					YearPublicacion=1998,
					Caratula="16.jpg",
					Discografica="Warner Bros. Records",
					Productor="Jeff Lynne, George Harrison",
					GrupoId=5
				},
				new Disco
				{
					Id=17,
					Nombre="Traveling Wilburys Vol. 3",
					YearPublicacion=1998,
					Caratula="17.jpg",
					Discografica="Warner Bros. Records",
					Productor="Jeff Lynne, George Harrison",
					GrupoId=5
				},
				new Disco
				{
					Id=18,
					Nombre="Please Please Me",
					YearPublicacion=1963,
					Caratula="1.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					Id=19,
					Nombre="With The Beatles",
					YearPublicacion=1963,
					Caratula="1.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					Id=20,
					Nombre="A Hard Day's Night",
					YearPublicacion=1964,
					Caratula="2.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					Id=21,
					Nombre="Beatles for Sale",
					YearPublicacion=1964,
					Caratula="3.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					Id=22,
					Nombre="Help!",
					YearPublicacion=1965,
					Caratula="4.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					Id=23,
					Nombre="Rubber Soul",
					YearPublicacion=1965,
					Caratula="5.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					Id=24,
					Nombre="Revolver",
					YearPublicacion=1966,
					Caratula="6.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					Id=25,
					Nombre="Sgt. Pepper's Lonely Hearts Club Band",
					YearPublicacion=1967,
					Caratula="7.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					Id=26,
					Nombre="Magical Mystery Tour",
					YearPublicacion=1967,
					Caratula="8.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					Id=27,
					Nombre="The Beatles (White Album)",
					YearPublicacion=1968,
					Caratula="9.png",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					Id=28,
					Nombre="Yellow Submarine",
					YearPublicacion=1969,
					Caratula="10.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					Id=29,
					Nombre="Abbey Road",
					YearPublicacion=1969,
					Caratula="11.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					Id=30,
					Nombre="Let It Be",
					YearPublicacion=1970,
					Caratula="12.jpeg",
					Discografica="Parlophone",
					Productor="George Martin",
					GrupoId=1
				},
				new Disco
				{
					Id=31,
					Nombre="The Rolling Stones",
					YearPublicacion=1964,
					Caratula="31.jpeg",
					Discografica="Decca Records",
					Productor="Andrew Loog Oldham",
					GrupoId=2
				},
				new Disco
				{
					Id=32,
					Nombre="The Rolling Stones No. 2",
					YearPublicacion=1965,
					Caratula="32.jpeg",
					Discografica="Decca Records",
					Productor="Andrew Loog Oldham",
					GrupoId=2
				},
				new Disco
				{
					Id=33,
					Nombre="Out of Our Heads",
					YearPublicacion=1965,
					Caratula="33.jpeg",
					Discografica="Decca Records",
					Productor="Andrew Loog Oldham",
					GrupoId=2
				},
				new Disco
				{
					Id=34,
					Nombre="Aftermath",
					YearPublicacion=1966,
					Caratula="34.jpeg",
					Discografica="Decca Records",
					Productor="Andrew Loog Oldham",
					GrupoId=2
				},
				new Disco
				{
					Id=35,
					Nombre="Between the Buttons",
					YearPublicacion=1967,
					Caratula="35.jpeg",
					Discografica="Decca Records",
					Productor="Andrew Loog Oldham",
					GrupoId=2
				},
				new Disco
				{
					Id=36,
					Nombre="Their Satanic Majesties Request",
					YearPublicacion=1967,
					Caratula="36.jpeg",
					Discografica="Decca Records",
					Productor="The Rolling Stones",
					GrupoId=2
				},
				new Disco
				{
					Id=37,
					Nombre="Beggar's Banquet",
					YearPublicacion=1968,
					Caratula="37.jpeg",
					Discografica="Decca Records",
					Productor="Jimmy Miller",
					GrupoId=2
				},
				new Disco
				{
					Id=38,
					Nombre="Let It Bleed",
					YearPublicacion=1969,
					Caratula="38.jpeg",
					Discografica="Decca Records",
					Productor="Jimmy Miller",
					GrupoId=2
				},
				new Disco
				{
					Id=39,
					Nombre="Sticky Fingers",
					YearPublicacion=1971,
					Caratula="39.jpeg",
					Discografica="Rolling Stones Records",
					Productor="Jimmy Miller",
					GrupoId=2
				},
				new Disco
				{
					Id=40,
					Nombre="Exile on Main St",
					YearPublicacion=1972,
					Caratula="40.jpeg",
					Discografica="Rolling Stones Records",
					Productor="Jimmy Miller",
					GrupoId=2
				},
				new Disco
				{
					Id=41,
					Nombre="Goats Head Soup",
					YearPublicacion=1973,
					Caratula="41.jpeg",
					Discografica="Rolling Stones Records",
					Productor="Jimmy Miller",
					GrupoId=2
				},
				new Disco
				{
					Id=42,
					Nombre="It's Only Rock 'n Roll",
					YearPublicacion=1974,
					Caratula="42.jpeg",
					Discografica="Rolling Stones Records",
					Productor="The Glimmer Twins",
					GrupoId=2
				},
				new Disco
				{
					Id=43,
					Nombre="Black and Blue",
					YearPublicacion=1976,
					Caratula="43.jpeg",
					Discografica="Rolling Stones Records",
					Productor="The Glimmer Twins",
					GrupoId=2
				},
				new Disco
				{
					Id=43,
					Nombre="Some Girls",
					YearPublicacion=1978,
					Caratula="43.jpeg",
					Discografica="Rolling Stones Records",
					Productor="The Glimmer Twins",
					GrupoId=2
				},
				new Disco
				{
					Id=44,
					Nombre="Emotional Rescue",
					YearPublicacion=1980,
					Caratula="44.jpeg",
					Discografica="Rolling Stones Records",
					Productor="The Glimmer Twins",
					GrupoId=2
				},
				new Disco
				{
					Id=45,
					Nombre="Tatoo You",
					YearPublicacion=1981,
					Caratula="45.jpeg",
					Discografica="Rolling Stones Records",
					Productor="The Glimmer Twins",
					GrupoId=2
				},
				new Disco
				{
					Id=46,
					Nombre="Undercover",
					YearPublicacion=1983,
					Caratula="46.jpeg",
					Discografica="Rolling Stones Records",
					Productor="The Glimmer Twins, Chris Kimsey",
					GrupoId=2
				},
				new Disco
				{
					Id=47,
					Nombre="Dirty Work",
					YearPublicacion=1986,
					Caratula="47.jpeg",
					Discografica="Rolling Stones Records",
					Productor="The Glimmer Twins, Steve Lilywhite",
					GrupoId=2
				},
				new Disco
				{
					Id=48,
					Nombre="Steel Wheels",
					YearPublicacion=1989,
					Caratula="48.jpeg",
					Discografica="Rolling Stones Records",
					Productor="The Glimmer Twins, Chris Kimsey",
					GrupoId=2
				},
				new Disco
				{
					Id=49,
					Nombre="Voodoo Lounge",
					YearPublicacion=1994,
					Caratula="49.jpeg",
					Discografica="Virgin Records",
					Productor="The Glimmer Twins, Don Was",
					GrupoId=2
				},
				new Disco
				{
					Id=50,
					Nombre="Bridge to Babylon",
					YearPublicacion=1997,
					Caratula="50.jpeg",
					Discografica="Virgin Records",
					Productor="The Glimmer Twins. Don Was, Rob Fraboni, Danny Saber, Pierre de Beauport. The Dust Brothers",
					GrupoId=2
				},
				new Disco
				{
					Id=51,
					Nombre="A Bigger Bang",
					YearPublicacion=2005,
					Caratula="51.jpeg",
					Discografica="Virgin Records",
					Productor="The Glimmer Twins, Don Was, Matt Clifford",
					GrupoId=2
				},
				new Disco
				{
					Id=52,
					Nombre="Blue & Lonesome",
					YearPublicacion=2016,
					Caratula="52.jpeg",
					Discografica="Polydor Records",
					Productor="The Glimmer Twins, Don Was",
					GrupoId=2
				},
				new Disco
				{
					Id=53,
					Nombre="Hackney Diamonds",
					YearPublicacion=2023,
					Caratula="53.jpeg",
					Discografica="Geffen Records",
					Productor="Andrew Watt",
					GrupoId=2
				},


			};

			modelBuilder.Entity<Receta>(entity =>
			{
				entity.Property(e => e.Ingredientes).IsRequired();
				entity.Property(e => e.Preparacion).IsRequired();
				entity.Property(e => e.Presentacion).IsRequired(false);
				entity.Property(e => e.enlaceVideo).IsRequired(false);
				entity.Property(e => e.Comensales).IsRequired(false);
			});

		}
	}
}
