using KintelaData;
using KintelaDomain;
using Microsoft.EntityFrameworkCore;

/*using (KintelaContext context=new KintelaContext())
{
	context.Database.EnsureCreated();
}*/
KintelaContext _context = new KintelaContext();

//InsertNewGrupoWithDisco();
//InsertTheWhoDiscos();
//InsertLedZeppelinDiscos();
//GetGruposYDiscos();
//GetGruposYDiscosAPartirDelYear(1982);
ConectarCategoriasYRecetas();

void InsertLedZeppelinDiscos()
{
	var grupo = new Grupo { Nombre = "Led Zeppelin" };
	grupo.Discos.AddRange(new List<Disco>{
		new Disco
		{ 
			Nombre = "Led Zeppelin I",
			YearPublicacion = 1969,
			Caratula = "LedZeppelinI.jpg",
			Discografica = "Atlantic Records",
			Productor = "Jimmy Page"
		},
		new Disco
		{ 
			Nombre = "Led Zeppelin II",
			YearPublicacion = 1969,
			Caratula = "LedZeppelinII.jpg",
			Discografica = "Atlantic Records",
			Productor = "Jimmy Page"
		},
		new Disco
		{
			Nombre = "Led Zeppelin III",
			YearPublicacion = 1970,
			Caratula = "LedZeppelinIII.jpg",
			Discografica = "Atlantic Records",
			Productor = "Jimmy Page"
		},
		new Disco
		{
			Nombre = "Led Zeppelin IV",
			YearPublicacion = 1971,
			Caratula = "LedZeppelinIV.jpg",
			Discografica = "Atlantic Records",
			Productor = "Jimmy Page"
		},
		new Disco
		{
			Nombre = "Houses of the Holy",
			YearPublicacion = 1973,
			Caratula = "HousesOfTheHoly.jpg",
			Discografica = "Atlantic Records",
			Productor = "Jimmy Page"
		},
		new Disco
		{
			Nombre = "Physical Graffiti",
			YearPublicacion = 1975,
			Caratula = "PhysicalGraffiti.jpg",
			Discografica = "Swan Song Records",
			Productor = "Jimmy Page"
		},
		new Disco
		{
			Nombre = "Presence",
			YearPublicacion = 1976,
			Caratula = "Presence.jpg",
			Discografica = "Swan Song Records",
			Productor = "Jimmy Page"
		},
		new Disco
		{
			Nombre = "In Through the out door",
			YearPublicacion = 1979,
			Caratula = "TheSongRemainsTheSame.jpg",
			Discografica = "Swan Song Records",
			Productor = "Jimmy Page"
		},
	});
	_context.Grupos.Add(grupo);
	_context.SaveChanges();
}

void InsertTheWhoDiscos()
{
	var grupo = new Grupo { Nombre = "The Who" };
	grupo.Discos.AddRange(new List<Disco> { 
		new Disco
		{
			Nombre = "My Generation", 
			YearPublicacion = 1965, 
			Caratula = "MyGeneration.jpg", 
			Discografica = "Brunswick Records", 
			Productor = "Shel Talmy" 
		},
		new Disco
		{
			Nombre = "A Quick One",
			YearPublicacion = 1966,
			Caratula = "x.jpg",
			Discografica = "Decca Records",
			Productor = "Kit Lambert"
		},
		new Disco
		{
			Nombre = "The Who Sell Out",
			YearPublicacion = 1967,
			Caratula = "x.jpg",
			Discografica = "Decca Records",
			Productor = "Kit Lambert"
		},
		new Disco
		{
			Nombre = "Tommy", 
			YearPublicacion = 1969, 
			Caratula = "Tommy.jpg", 
			Discografica = "Track Records", 
			Productor = "Kit Lambert" 
		},
		new Disco
		{
			Nombre = "Who's Next", 
			YearPublicacion = 1971, 
			Caratula = "WhosNext.jpg", 
			Discografica = "Track Records", 
			Productor = "The Who, Glyn Johns" 
		},
		new Disco
		{
			Nombre = "Quadrophenia", 
			YearPublicacion = 1973, 
			Caratula = "Quadrophenia.jpg", 
			Discografica = "Track Records", 
			Productor = "The Who" 
		},
		new Disco
		{
			Nombre = "The Who by Numbers", 
			YearPublicacion = 1975, 
			Caratula = "TheWhoByNumbers.jpg", 
			Discografica = "Polydor Records", 
			Productor = "Glyn Johns" 
		},
		new Disco
		{
			Nombre = "Who Are You", 
			YearPublicacion = 1978, 
			Caratula = "WhoAreYou.jpg", 
			Discografica = "Polydor Records", 
			Productor = "Jon Astley, Glyn Johns" 
		},
		new Disco
		{
			Nombre = "Face Dances", 
			YearPublicacion = 1981, 
			Caratula = "FaceDances.jpg", 
			Discografica = "Polydor Records", 
			Productor = "Bill Szymczyk" 
		},
		new Disco
		{
			Nombre = "It's Hard", 
			YearPublicacion = 1982, 
			Caratula = "ItsHard.jpg", 
			Discografica = "Polydor Records", 
			Productor = "Glyn Johns" 
		},
		new Disco
		{
			Nombre = "Endless Wire", 
			YearPublicacion = 2006, 
			Caratula = "EndlessWire.jpg", 
			Discografica = "Polydor Records", 
			Productor = "Pete Townshend, Bob Pridden, Billy Nicholls" 
		},
		new Disco
		{
			Nombre = "Who", 
			YearPublicacion = 2019, 
			Caratula = "Who.jpg", 
			Discografica = "Polydor Records", 
			Productor = "Pete Townshend, Dave Sardy, Bob Pridden, Dave Eringa" 
		}
	});
	_context.Grupos.Add(grupo);
	_context.SaveChanges();
}

void ConectarCategoriasYRecetas()
{
	var categoriaPostre=_context.Categorias.FirstOrDefault(c=>c.Nombre=="Postre");
	var categoriaCarne = _context.Categorias.FirstOrDefault(c => c.Nombre == "Carne");
	var categoriaEnsalada = _context.Categorias.FirstOrDefault(c => c.Nombre == "Ensalada");
	var categoriaHuevos = _context.Categorias.FirstOrDefault(c => c.Nombre == "Huevos");
	var categoriaLegumbres = _context.Categorias.FirstOrDefault(c => c.Nombre == "Legumbres");
	var categoriaPasta = _context.Categorias.FirstOrDefault(c => c.Nombre == "Pasta");
	var categoriaPatatas = _context.Categorias.FirstOrDefault(c => c.Nombre == "Patatas");
	var categoriaPescado = _context.Categorias.FirstOrDefault(c => c.Nombre == "Pescado");
	var categoriaSandwich = _context.Categorias.FirstOrDefault(c => c.Nombre == "Sandwich");
	var categoriaSopa = _context.Categorias.FirstOrDefault(c => c.Nombre == "Sopa");
	var categoriaTortilla = _context.Categorias.FirstOrDefault(c => c.Nombre == "Tortilla");
	var categoriaVerdura = _context.Categorias.FirstOrDefault(c => c.Nombre == "Verdura");

	var recetasPostre=_context.Recetas.Where(r=>r.Nombre.Contains("Tarta") || r.Nombre.Contains("Galleta")).ToList();
	foreach (var receta in recetasPostre)
	{
		receta.Categorias.Add(categoriaPostre);
	}

	var recetasCarne = _context.Recetas.Where(r => r.Nombre.Contains("Carne") || r.Nombre.Contains("Albóndigas") || r.Nombre.Contains("Cordero") || r.Nombre.Contains("Entrecot")
	|| r.Nombre.Contains("Pollo") || r.Nombre.Contains("Pechuga")).ToList();
	foreach (var receta in recetasCarne)
	{
		receta.Categorias.Add(categoriaCarne);
	}

	var recetasEnsalada = _context.Recetas.Where(r => r.Nombre.Contains("Ensalada")).ToList();
	foreach (var receta in recetasEnsalada)
	{
		receta.Categorias.Add(categoriaEnsalada);
	}

	var recetasHuevos = _context.Recetas.Where(r => r.Nombre.Contains("Tortilla")).ToList();
	foreach (var receta in recetasHuevos)
	{
		receta.Categorias.Add(categoriaHuevos);
	}

	var recetasLegumbres = _context.Recetas.Where(r => r.Nombre.Contains("Alubias") || r.Nombre.Contains("Garbanzos") || r.Nombre.Contains("Lentejas")).ToList();
	foreach (var receta in recetasLegumbres)
	{
		receta.Categorias.Add(categoriaLegumbres);
	}

	var recetasPasta = _context.Recetas.Where(r => r.Nombre.Contains("Pasta")).ToList();
	foreach (var receta in recetasPasta)
	{
		receta.Categorias.Add(categoriaPasta);
	}

	var recetasPatatas = _context.Recetas.Where(r => r.Nombre.Contains("Patatas")).ToList();
	foreach (var receta in recetasPatatas)
	{
		receta.Categorias.Add(categoriaPatatas);
	}

	var recetasPescado = _context.Recetas.Where(r => r.Nombre.Contains("Anchoas") || r.Nombre.Contains("Bacalao") || r.Nombre.Contains("Langostinos") || r.Nombre.Contains("Lubina") || r.Nombre.Contains("Merluza") || r.Nombre.Contains("Pulpo") || r.Nombre.Contains("Rodaballo")).ToList();
	foreach (var receta in recetasPescado)
	{
		receta.Categorias.Add(categoriaPescado);
	}

	var recetasSandwich = _context.Recetas.Where(r => r.Nombre.Contains("Sandwich")).ToList();
	foreach (var receta in recetasSandwich)
	{
		receta.Categorias.Add(categoriaSandwich);
	}

	var recetasSopa = _context.Recetas.Where(r => r.Nombre.Contains("Sopa")).ToList();
	foreach (var receta in recetasSopa)
	{
		receta.Categorias.Add(categoriaSopa);
	}

	var recetasTortilla = _context.Recetas.Where(r => r.Nombre.Contains("Tortilla")).ToList();
	foreach (var receta in recetasTortilla)
	{
		receta.Categorias.Add(categoriaTortilla);
	}

	var recetasVerdura = _context.Recetas.Where(r => r.Nombre.Contains("Alcachofas") || r.Nombre.Contains("Berenjena") || r.Nombre.Contains("Brócoli") || r.Nombre.Contains("Coliflor") || r.Nombre.Contains("Guisantes") || r.Nombre.Contains("veganas") || r.Nombre.Contains("Calabaza") || r.Nombre.Contains("verduras") || r.Nombre.Contains("riojana") || r.Nombre.Contains("Puré") || r.Nombre.Contains("Vainas")).ToList();

	foreach (var receta in recetasVerdura)
	{
		receta.Categorias.Add(categoriaVerdura);
	}


	_context.SaveChanges();

}

void GetGruposYDiscos()
{
	var grupos=_context.Grupos.Include(g => g.Discos).ToList();

	grupos.ForEach(g =>
	{
		Console.WriteLine($"Grupo: {g.Nombre}");
		g.Discos.ForEach(d =>
		{
			Console.WriteLine($"\tDisco: {d.Nombre}");
		});
	});
}

void GetGruposYDiscosAPartirDelYear(int year)
{	
	var grupos = _context.Grupos
		.Include(g => g.Discos
										.Where(d=>d.YearPublicacion>=year)
										.OrderBy(d=>d.YearPublicacion))
		.ToList();

	grupos.ForEach(g =>
	{
		Console.WriteLine($"Grupo: {g.Nombre}");
		g.Discos.ForEach(d =>
		{
			Console.WriteLine($"\tYear:{d.YearPublicacion} - Disco: {d.Nombre}");
		});
	});
}







