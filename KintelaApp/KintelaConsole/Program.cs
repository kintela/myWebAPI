using KintelaData;
using KintelaDomain;
using Microsoft.EntityFrameworkCore;

using (KintelaContext context=new KintelaContext())
{
	context.Database.EnsureCreated();
}

AddCategorias();
//AddPlato();
//GetPlatos();
//AddPlatoConReceta();
//GetPlatosConRecetas();

void AddCategorias()
{
	List<Categoria> categorias=new List<Categoria>
	{
		new Categoria
		{
			Nombre="Carne",
		},
		new Categoria
		{
			Nombre="Ensalada",
		},
		new Categoria
		{
			Nombre="Huevos",
		},
		new Categoria
		{
			Nombre="Legumbres",
		},
		new Categoria
		{
			Nombre="Pasta",
		},
		new Categoria
		{
			Nombre="Patatas",
		},
		new Categoria
		{
			Nombre="Pescado",
		},
		new Categoria
		{
			Nombre="Postre",
		},
		new Categoria
		{
			Nombre="Sandwich",
		},
		new Categoria
		{
			Nombre="Sopa",
		},
		new Categoria
		{
			Nombre="Tortilla",
		},
		new Categoria
		{
			Nombre="Verdura",
		}
	};

	
	using var context = new KintelaContext();

	context.Categorias.AddRange(categorias);
	context.SaveChanges();
}	






