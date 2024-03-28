using KintelaDomain;
using Microsoft.EntityFrameworkCore;

namespace KintelaData
{
	public class KintelaContext:DbContext
	{
		public DbSet<Receta> Recetas { get; set; }
		public DbSet<Categoria> Categorias { get; set; }
		public DbSet<Menu> Menus { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=KintelaDatabase");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Categoria>(entity =>
			{
				entity.Property(e => e.Nombre).IsRequired();
			});

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
