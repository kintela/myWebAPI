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
//ConectarCategoriasYRecetas();
//AñadirNuevaRecetaACategoriaExistente();
//AñadirNuevaCategoriaYNuevaReceta();
//GetCategoriaConSusRecetas("Carne");
//GetRecetaYSuCategoria("Paella");
GetAllCategoriasYSusRecetas();

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

void AñadirNuevaRecetaACategoriaExistente()
{
	var categoria = _context.Categorias.FirstOrDefault(c => c.Nombre == "Carne");
	var receta=new Receta 
	{ 
		Nombre = "Muslos de Pollo al limón",
		Ingredientes = new string[] { "8 muslos de pollo", "1 cebolla", "100 ml. de vino blanco", "3 dientes de ajo", "Romero seco", "Tomillo fresco o seco", "100 ml. de aceite de oliva virgen extra", "4 patatas medianas especial para asar", "Sal y pimienta negra recién molida (al gusto)" },
		EnlaceVideo = "https://www.youtube.com/watch?v=1KjqHygii9M&embeds_referring_euri=https%3A%2F%2Fwww.abc.es%2F&feature=emb_imp_woyt", 
		Preparacion = new string[] { "Empezamos precalentando el horno a 200º C.", "Pelamos la cebolla y la cortamos en aros de 0,5 cm. Separamos los aros de cebolla y los colocamos en una fuente apta para horno. Lavamos y partimos un limón. Troceamos una mitad y exprimimos el zumo de la otra mitad. Bañamos la cebolla con el zumo del medio limón" , "Ponemos los muslos de pollo sobre la cama de cebolla, el limón troceado, el tomillo fresco y los dientes de ajo partidos por la mitad (no es necesario pelarlos)." , "En un mortero picamos el romero seco y lo mezclamos con la mitad del vino blanco, los 50 ml. de aceite de oliva virgen extra, la sal y la pimienta. Removemos bien para que se mezclen los ingredientes. Pincelamos la carne con la mezcla de romero y bañamos la bandeja con el resto.", "Horneamos con calor arriba y abajo, sin aire caliente para no resecar el pollo. El tiempo más o menos de 40 – 45 minutos a 200º C en la bandeja del medio. Tened cuidado porque cada horno es un mundo y el tuyo puede necesitar variar la temperatura. Durante el horneado vamos regando con la mitad que nos queda del vino blanco, para que siempre tenga un poco de líquido y no se quede seco.", "Lavamos bien las patatas y las cortamos en gajos sin pelar", "Las pasamos a otra fuente de horno y bañamos con los otros 50 ml de aceite. Espolvoreamos sal, pimienta y romero seco. Horneamos durante una hora a 200º C, los podemos meter 15 minutos antes de hornear el pollo, así luego serán 45 minutos con el horneado de los muslos." },
		Presentacion = new string[] { "Servimos el pollo acompañado de las patatas asadas y un poco de ensalada de tomate, por ejemplo." },
		Imagen = "20.jpg" 
	};

	receta.Categorias.Add(categoria);

	_context.Recetas.Add(receta);

	_context.SaveChanges();


}

void AñadirNuevaCategoriaYNuevaReceta()
{
	var categoria = new Categoria { Nombre = "Arroces" };
	var receta = new Receta
	{
		Nombre = "Paella",
		Ingredientes = new string[] { "Arroz bomba La Fallera 700 g", "1/2 pollo de corral", "400 g. de conejo (importante que incluya cabeza e higadillos)", "150 g. de “bachoqueta”, judía verde plana (en este caso roja)", "150 g. de garrofón", "200 g. de alcachofas (3 alcachofas medianas)", "Aceite de oliva virgen extra", "1 cucharada de pimentón dulce de la Vera", "Tomate triturado", "Hebras de azafrán", "Romero fresco", "Sal", "2,1 l. de agua (la mitad puede ser caldo de ave)", "Paellera de 50 cm." },
		Imagen = "21.jpg",
		Preparacion = new string[] { "Es fundamental tener la paella lista y a ser posible con varios usos (ayuda a que el arroz no se pegue). El tamaño es importante, que permita que el arroz se cocine de forma uniforme por toda su superficie.", "Esto es el primer gran problema que surge al tratar de hacer el plato en casa. Para que quede bien, la cantidad de arroz no debe superar en mucho el dedo de grosor, por lo que para hacer, por ejemplo, una paella para seis personas necesitaremos un recipiente de en torno a medio metro de diámetro", "A falta de leña y fuego con madera de naranjo, necesitaremos un buen quemador de gas o difusor de temperatura para que alcance la superficie total de la paella. En caso de necesitar aumentar la cantidad de ingredientes habrá que aumentar también el tamaño de la paella o cazuela", "Vamos a empezar por un buen sofrito, la base de nuestra paella. Lo primero es cortar en trozos todos los ingredientes. El pollo y el conejo como para un guiso (puedes pedirle al carnicero que lo prepare), las judías verdes sin hebras y en trozos de dos o tres centímetros. Las alcachofas bien limpias y en mitades o cuartos según su tamaño.", "Sofreímos en abundante aceite de oliva virgen extra el pollo, el conejo, las judías, el garrafó y las alcachofas. Cuando estén bien dorados los trozos de carne sazonamos bien y echamos el pimentón dulce de la Vera. Los trozos de conejo y pollo deben estar bien dorados, con cuidado de que no se quemen. Justo después añadimos el tomate triturado y dejamos que se rehoge bien el sofrito.", "Añadimos el agua. Es mejor quedarse corto que pasarse pues siempre podemos añadir algo más de agua si vemos que el arroz está demasiado seco y no se ha hecho todavía. Las proporciones dependen mucho del fuego, del calor que haga, del grado de humedad y del diámetro de la paella. Necesitamos tres veces el volumen de agua que de arroz. Aunque es la experiencia la que os hará ajustar y perfeccionar estas cantidades.", "Cocinamos el caldo durante 25 o 30 minutos. Es un buen momento de echar el azafrán, debemos ir probando el caldo para saber si está lo suficientemente sabroso y poder corregirlo. No queremos que se quede soso, así que es fundamental que el caldo lo prueben al menos 2 personas para que haya consenso en este tema.", "Añadimos el arroz en diagonal y en forma de cruz tal como veis en las fotos. Distribuimos el arroz de forma uniforme por la paella. Cocemos entre 18 a 20 minutos, aunque aquí el tiempo lo marca de nuevo el grano de arroz y la potencia del fuego, que debemos ir dejando consumirse. Tiene que quedar completamente seco y suelto.", "Podéis tener un cazo con agua hirviendo al lado, por si hay que añadir agua. A mitad cocción también podemos poner unas ramitas de romero, que retiraremos antes de servir.", "Una buena paella debe tener socarrat. Lo mejor para conseguirlo fácilmente sin quemar el arroz es cuando esta terminando de cocinarse la paella, es hacer pequeños agujeros con el extremos de una cuchara y añadir un poquito de aceite de oliva virgen extra en los mismos. Subir el fuego del quemador al máximo durante un minuto y tostar el arroz. Apagamos el fuego y dejamos reposar la paella.", "La dejamos reposar unos minutos tapada con un gran paño de algodón. Con unos 5-8 minutos fuera del fuego será suficiente para lograr un resultado de rechupete." }
	};

	categoria.Recetas.Add(receta);
	_context.Categorias.Add(categoria);

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

void GetCategoriaConSusRecetas(string categoriaABuscar)
{
	var categoria = _context.Categorias.Include(c => c.Recetas).FirstOrDefault(c => c.Nombre == categoriaABuscar);

	categoria.Recetas.ForEach(r =>
	{
		Console.WriteLine($"Receta: {r.Nombre}");
	});

	
}

void GetRecetaYSuCategoria(string recetaABuscar)
{
	var receta = _context.Recetas.Include(r => r.Categorias).FirstOrDefault(r => r.Nombre == recetaABuscar);
	receta.Categorias.ForEach(c =>
	{
		Console.WriteLine($"Categoria: {c.Nombre}");
	});
}	

void GetAllCategoriasYSusRecetas()
{
	var categorias = _context.Categorias.Include(c => c.Recetas).ToList();

	categorias.ForEach(c =>
	{
		Console.WriteLine($"Categoria: {c.Nombre}");
		c.Recetas.ForEach(r =>
		{
			Console.WriteLine($"\tReceta: {r.Nombre}");
		});
	});
}







