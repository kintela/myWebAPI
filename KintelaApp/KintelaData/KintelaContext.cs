using KintelaDomain;
using Microsoft.EntityFrameworkCore;

namespace KintelaData
{
	public class KintelaContext:DbContext
	{
		public DbSet<Plato> Platos { get; set; }
		public DbSet<Receta> Recetas { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=KintelaDatabase");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Plato>(entity =>
			{
				entity.Property(e => e.Nombre).IsRequired();
				entity.Property(e => e.Categorias).IsRequired(false);
				entity.Property(e => e.Imagen).IsRequired(false);
			});
			modelBuilder.Entity<Receta>(entity =>
			{
				entity.Property(e => e.Presentacion).IsRequired(false);
				entity.Property(e => e.enlaceVideo).IsRequired(false);
			});

		}
	}
}
