using KintelaData;
using KintelaDomain;
using Microsoft.EntityFrameworkCore;

using (KintelaContext context=new KintelaContext())
{
	context.Database.EnsureCreated();
}

//AddPlato();
//GetPlatos();
AddPlatoConReceta();
GetPlatosConRecetas();

void AddPlato()
{	

	var plato=new Plato
	{
		Nombre="Tortilla de Patatas",		
	};

	using var context = new KintelaContext();

	context.Platos.Add(plato);
	context.SaveChanges();
}

void GetPlatos()
{
	using var context=new KintelaContext();

	var platos=context.Platos.ToList();

	foreach (var plato in platos)
	{
		Console.WriteLine(plato.Nombre);
	}
}	

void AddPlatoConReceta()
{
	var plato=new Plato	{	Nombre= "Garbanzos con chorizo y Zanquarrón", Categorias= new string[] { "Legumbres"} };

	plato.Recetas.Add(
		new Receta
		{
			Ingredientes = new string[] { "Garbanzos", "Chorizo", "Zanquarrón" },
			Preparacion = new string[] { "bla bvla bla", "bla bla bla" }
		});

	using var context = new KintelaContext();

	context.Platos.Add(plato);
	context.SaveChanges();
}

void GetPlatosConRecetas()
{
	using var context = new KintelaContext();

	var platos = context.Platos.Include(a => a.Recetas).ToList();
	foreach (var plato in platos)
	{
		Console.WriteLine(plato.Nombre);
		foreach (var receta in plato.Recetas)
		{
			Console.WriteLine("  " + receta.Ingredientes);
		}
	}
}
