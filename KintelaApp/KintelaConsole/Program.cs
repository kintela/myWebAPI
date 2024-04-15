using KintelaData;
using KintelaDomain;
using Microsoft.EntityFrameworkCore;

using (KintelaContext context=new KintelaContext())
{
	context.Database.EnsureCreated();
}

KintelaContext _context = new KintelaContext();


//InsertTheWhoDiscos();
//InsertLedZeppelinDiscos();

//InsertCDs();
//GetGruposYDiscos();
//GetGruposYDiscosAPartirDelYear(1982);
//ConectarCategoriasYRecetas();
//AñadirNuevaRecetaACategoriaExistente();
//AñadirNuevaCategoriaYNuevaReceta();
//GetCategoriaConSusRecetas("Carne");
//GetRecetaYSuCategoria("Paella");
//GetAllCategoriasYSusRecetas();

void InsertCDs()
{
	var acdc = new Grupo { Nombre = "AC/DC" };
	var cdsacdc = new List<CD> {
		new CD{
			Titulo = "Back in black",
			YearPublicacion = 1980,
			IsInSpotify = true,
			Etiqueta = 39
		},
		new CD{
			Titulo = "Black Ice",
			YearPublicacion = 2008,
			IsInSpotify = true,
			Etiqueta = 31
		},
		new CD{
			Titulo = "High Voltage",
			YearPublicacion = 1976,
			IsInSpotify = true,
			Etiqueta = 83
		},
		new CD{
			Titulo = "Highway To Hell",
			YearPublicacion = 1979,
			IsInSpotify = true,
			Etiqueta = 22
		},
		new CD{
			Titulo = "Live",
			YearPublicacion = 1991,
			IsInSpotify = true,
			Etiqueta = 69
		},

	};
	acdc.CDs.AddRange(cdsacdc);
	_context.Grupos.Add(acdc);

	var adele = new Grupo { Nombre = "Adele" };
	adele.CDs.Add(new CD
	{
		Titulo = "21",
		YearPublicacion = 2011,
		IsInSpotify = true,
		Etiqueta = 77
	});
	_context.Grupos.Add(adele);

	var aerosmith = new Grupo { Nombre = "Aerosmith" };
	aerosmith.CDs.Add(new CD
	{
		Titulo = "Aerosmith's greatest hits 1973-1988",
		YearPublicacion = 2008,
		IsInSpotify = false,
		Etiqueta = 29
	});
	_context.Grupos.Add(aerosmith);

	var aliceinchains = new Grupo { Nombre = "Alice in chains" };
	aliceinchains.CDs.Add(new CD
	{
		Titulo = "Alice In Chains",
		YearPublicacion = 1995,
		IsInSpotify = true,
		Etiqueta = 538
	});
	_context.Grupos.Add(aliceinchains);

	var amy = new Grupo { Nombre = "Amy Winehouse" };
	amy.CDs.Add(new CD
	{
		Titulo = "Back to black",
		YearPublicacion = 2007,
		IsInSpotify = true,
		Etiqueta = 30
	});
	_context.Grupos.Add(amy);

	var anne = new Grupo { Nombre = "Anne MacCue" };
	var cdsAnne = new List<CD> {
		new CD{
			Titulo = "East of electric",
			YearPublicacion = 2008,
			IsInSpotify = true,
			Etiqueta = 41
		},
		new CD{
			Titulo = "Live: Ballad of an aoutlaw women",
			YearPublicacion = 2001,
			IsInSpotify = false,
			Etiqueta = 42
		},
	};

	anne.CDs.AddRange(cdsAnne);
	_context.Grupos.Add(anne);

	var ariel = new Grupo { Nombre = "Ariel Rot" };
	ariel.CDs.Add(new CD
	{
		Titulo = "Solo Rot",
		YearPublicacion = 2010,
		IsInSpotify = true,
		Etiqueta = 78,
		Firmado = true
	});
	_context.Grupos.Add(ariel);

	var jackie = new Grupo { Nombre = "Jackie Brown" };
	jackie.CDs.Add(new CD
	{
		Titulo = "Jackie Brown (B.S.O.)",
		YearPublicacion = 1997,
		IsInSpotify = true,
		Etiqueta = 164,
	});
	_context.Grupos.Add(jackie);

	var beastie = new Grupo { Nombre = "Beastie Boys" };
	beastie.CDs.Add(new CD
	{
		Titulo = "Licensed To ill",
		YearPublicacion = 1986,
		IsInSpotify = true,
		Etiqueta = 490,
	});
	_context.Grupos.Add(beastie);

	var benharper = new Grupo { Nombre = "Ben Harper" };
	var cdsbenharper = new List<CD> {
		new CD{
			Titulo = "Both sides of the gun",
			YearPublicacion = 2006,
			IsInSpotify = true,
			Etiqueta = 51
		},
		new CD{
			Titulo = "Diamonds on the inside",
			YearPublicacion = 2003,
			IsInSpotify = true,
			Etiqueta = 54
		},
		new CD{
			Titulo = "Fight Four Your Mind",
			YearPublicacion = 1995,
			IsInSpotify = true,
			Etiqueta = 563
		},
		new CD{
			Titulo = "give till it's gone",
			YearPublicacion = 2011,
			IsInSpotify = true,
			Etiqueta = 82
		},
		new CD{
			Titulo = "Lifeline",
			YearPublicacion = 2007,
			IsInSpotify = true,
			Etiqueta = 4
		},
		new CD{
			Titulo = "Live From Mars",
			YearPublicacion = 2001,
			IsInSpotify = true,
			Etiqueta = 553
		},
		new CD{
			Titulo = "Live from Montreal Internationa Jazz Festival",
			YearPublicacion = 2010,
			IsInSpotify = false,
			Etiqueta = 66
		},
		new CD{
			Titulo = "There will be a light",
			YearPublicacion = 2004,
			IsInSpotify = true,
			Etiqueta = 260
		},
		new CD{
			Titulo = "White lies for dark times",
			YearPublicacion = 2009,
			IsInSpotify = true,
			Etiqueta = 34
		},
	};
	benharper.CDs.AddRange(cdsbenharper);
	_context.Grupos.Add(benharper);

	var boddylan = new Grupo { Nombre = "Bob Dylan" };
	var cdsBobDylan = new List<CD>
	{
		new CD
		{
			Titulo = "Modern Times",
			YearPublicacion = 2006,
			IsInSpotify = true,
			Etiqueta = 18
		},
		new CD
		{
			Titulo = "Street-Legal",
			YearPublicacion = 1978,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "Pat Garret & Billy the Kid",
			YearPublicacion = 1973,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "Highway 61 Revisited",
			YearPublicacion = 1965,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "The bootleg series Vol. 4",
			YearPublicacion = 1966,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "Bob Dylan",
			YearPublicacion = 1962,
			IsInSpotify = false,
		},
		new CD
		{
			Titulo = "The bootleg series Vol. 5",
			YearPublicacion = 1975,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "New Morning",
			YearPublicacion = 1970,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "Hard Rain",
			YearPublicacion = 1976,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "Another side of Bob Dylan",
			YearPublicacion = 1964,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "The bootleg series Vol. 6",
			YearPublicacion = 1964,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "Blonde on Blonde",
			YearPublicacion = 1966,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "The bootleg series Vol. 1-3",
			YearPublicacion = 1961,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "Blood on the tracks",
			YearPublicacion = 1975,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "Planet waves",
			YearPublicacion = 1974,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "At Budokan (I)",
			YearPublicacion = 1978,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "At Budokan (II)",
			YearPublicacion = 1978,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "The Freewheelin'",
			YearPublicacion = 1963,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "Nashville Skyline",
			YearPublicacion = 1969,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "The times they are a-changin'",
			YearPublicacion = 1964,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "Bringing it all back home",
			YearPublicacion = 1965,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "John Wesley harding",
			YearPublicacion = 1967,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "Selfportrait",
			YearPublicacion = 1970,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "The bootleg series Vol. 7 (No direction home soundtrack)",
			YearPublicacion = 1961,
			IsInSpotify = true,
		},
		new CD
		{
			Titulo = "Desire",
			YearPublicacion = 1976,
			IsInSpotify = true,
		},
	};

	boddylan.CDs.AddRange(cdsBobDylan);
	_context.Grupos.Add(boddylan);

	var bruces = new Grupo { Nombre = "Bruce Springsteen" };
	var cdsbruce = new List<CD>
	{
		new CD
		{
			Titulo = "Born in the USA",
			YearPublicacion = 1984,
			IsInSpotify = true,
			Etiqueta = 45
		},
		new CD
		{
			Titulo = "Born to run",
			YearPublicacion = 1975,
			IsInSpotify = true,
			Etiqueta = 21
		},
		new CD
		{
			Titulo = "Devils & Dust",
			YearPublicacion = 2005,
			IsInSpotify = true,
			Etiqueta = 44
		},
		new CD
		{
			Titulo = "Magic",
			YearPublicacion = 2007,
			IsInSpotify = true,
			Etiqueta = 10
		},
		new CD
		{
			Titulo = "The Rising",
			YearPublicacion = 2002,
			IsInSpotify = true,
			Etiqueta = 9
		},


	};

	bruces.CDs.AddRange(cdsbruce);
	_context.Grupos.Add(bruces);

	var bulldozer = new Grupo { Nombre = "Bulldozer" };
	bulldozer.CDs.Add(new CD
	{
		Titulo = "Adrenalina & Distorsión",
		YearPublicacion = 2002,
		IsInSpotify = false,
		Etiqueta = 678,
	});
	_context.Grupos.Add(bulldozer);





	_context.SaveChanges();
	
}
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







