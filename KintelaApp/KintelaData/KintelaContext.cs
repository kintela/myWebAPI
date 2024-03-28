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
