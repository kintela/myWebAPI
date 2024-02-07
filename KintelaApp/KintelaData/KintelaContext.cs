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
	}
}
