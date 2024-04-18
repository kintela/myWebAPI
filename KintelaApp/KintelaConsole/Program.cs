using KintelaData;
using KintelaDomain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

using (KintelaContext context=new KintelaContext())
{
	context.Database.EnsureCreated();
}

KintelaContext _context = new KintelaContext();


//InsertTheWhoDiscos();
//InsertLedZeppelinDiscos();
//InsertCDs1();
InsertCDs2();

//GetGruposYDiscos();
//GetGruposYDiscosAPartirDelYear(1982);
//ConectarCategoriasYRecetas();
//AñadirNuevaRecetaACategoriaExistente();
//AñadirNuevaCategoriaYNuevaReceta();
//GetCategoriaConSusRecetas("Carne");
//GetRecetaYSuCategoria("Paella");
//GetAllCategoriasYSusRecetas();

void InsertCDs1()
{
	InsertOrUpdateGrupo("AC/DC", new List<CD>
		{
				new CD { Titulo = "Back in black", YearPublicacion = 1980, IsInSpotify = true, Etiqueta = 39 },
				new CD { Titulo = "Black Ice", YearPublicacion = 2008, IsInSpotify = true, Etiqueta = 31 },
				new CD { Titulo = "High Voltage", YearPublicacion = 1976, IsInSpotify = true, Etiqueta = 83 },
				new CD { Titulo = "Highway To Hell", YearPublicacion = 1979, IsInSpotify = true, Etiqueta = 22 },
				new CD { Titulo = "Live", YearPublicacion = 1991, IsInSpotify = true, Etiqueta = 69 }
		});

	InsertOrUpdateGrupo("Adele", new List<CD>
		{
				new CD { Titulo = "21", YearPublicacion = 2011, IsInSpotify = true, Etiqueta = 77 }
		});

	InsertOrUpdateGrupo("Aerosmith", new List<CD>
		{
				new CD{Titulo = "Aerosmith's greatest hits 1973-1988",YearPublicacion = 2008,IsInSpotify = false,Etiqueta = 29}
		});

	InsertOrUpdateGrupo("Alice in chains", new List<CD>
		{
				new CD{ Titulo = "Alice In Chains", YearPublicacion = 1995, IsInSpotify = true, Etiqueta = 538 }
		});

	InsertOrUpdateGrupo("Amy Winehouse", new List<CD>
		{
				new CD{ Titulo = "Back to black", YearPublicacion = 2007, IsInSpotify = true, Etiqueta = 30 }
		});

	InsertOrUpdateGrupo("Anne MacCue", new List<CD>
		{
				new CD{ Titulo = "East of electric", YearPublicacion = 2008, IsInSpotify = true, Etiqueta = 41 },
				new CD{ Titulo = "Live: Ballad of an outlaw women", YearPublicacion = 2001, IsInSpotify = false, Etiqueta = 42 }
		});

	InsertOrUpdateGrupo("Ariel Rot", new List<CD>
		{
				new CD{ Titulo = "Solo Rot", YearPublicacion = 2010, IsInSpotify = true, Etiqueta = 78, Firmado = true }
		});

	InsertOrUpdateGrupo("Jackie Brown", new List<CD>
		{
				new CD{ Titulo = "Jackie Brown (B.S.O.)", YearPublicacion = 1997, IsInSpotify = true, Etiqueta = 164 }
		});

	InsertOrUpdateGrupo("Beastie Boys", new List<CD>
		{
				new CD{ Titulo = "Licensed To ill", YearPublicacion = 1986, IsInSpotify = true, Etiqueta = 490 }
		});

	InsertOrUpdateGrupo("Ben Harper", new List<CD>
		{
				new CD{ Titulo = "Both sides of the gun", YearPublicacion = 2006, IsInSpotify = true, Etiqueta = 51 },
				new CD{ Titulo = "Diamonds on the inside", YearPublicacion = 2003, IsInSpotify = true, Etiqueta = 54 },
				new CD{ Titulo = "Fight Four Your Mind", YearPublicacion = 1995, IsInSpotify = true, Etiqueta = 563 },
				new CD{ Titulo = "give till it's gone", YearPublicacion = 2011, IsInSpotify = true, Etiqueta = 82 },
				new CD{ Titulo = "Lifeline", YearPublicacion = 2007, IsInSpotify = true, Etiqueta = 4 },
				new CD{ Titulo = "Live From Mars", YearPublicacion = 2001, IsInSpotify = true, Etiqueta = 553 },
				new CD{ Titulo = "Live from Montreal International Jazz Festival", YearPublicacion = 2010, IsInSpotify = false, Etiqueta = 66 },
				new CD{ Titulo = "There will be a light", YearPublicacion = 2004, IsInSpotify = true, Etiqueta = 260 },
				new CD{ Titulo = "White lies for dark times", YearPublicacion = 2009, IsInSpotify = true, Etiqueta = 34 }
		});

	InsertOrUpdateGrupo("Bob Dylan", new List<CD>
		{
				new CD { Titulo = "Modern Times", YearPublicacion = 2006, IsInSpotify = true, Etiqueta = 18 },
				new CD { Titulo = "Street-Legal", YearPublicacion = 1978, IsInSpotify = true },
				new CD { Titulo = "Pat Garret & Billy the Kid", YearPublicacion = 1973, IsInSpotify = true },
				new CD { Titulo = "Highway 61 Revisited", YearPublicacion = 1965, IsInSpotify = true },
				new CD { Titulo = "The bootleg series Vol. 4", YearPublicacion = 1966, IsInSpotify = true },
				new CD { Titulo = "Bob Dylan", YearPublicacion = 1962, IsInSpotify = false },
				new CD { Titulo = "The bootleg series Vol. 5", YearPublicacion = 1975, IsInSpotify = true },
				new CD { Titulo = "New Morning", YearPublicacion = 1970, IsInSpotify = true },
				new CD { Titulo = "Hard Rain", YearPublicacion = 1976, IsInSpotify = true },
				new CD { Titulo = "Another side of Bob Dylan", YearPublicacion = 1964, IsInSpotify = true },
				new CD { Titulo = "The bootleg series Vol. 6", YearPublicacion = 1964, IsInSpotify = true },
				new CD { Titulo = "Blonde on Blonde", YearPublicacion = 1966, IsInSpotify = true },
				new CD { Titulo = "The bootleg series Vol. 1-3", YearPublicacion = 1961, IsInSpotify = true },
				new CD { Titulo = "Blood on the tracks", YearPublicacion = 1975, IsInSpotify = true },
				new CD { Titulo = "Planet waves", YearPublicacion = 1974, IsInSpotify = true },
				new CD { Titulo = "At Budokan (I)", YearPublicacion = 1978, IsInSpotify = true },
				new CD { Titulo = "At Budokan (II)", YearPublicacion = 1978, IsInSpotify = true },
				new CD { Titulo = "The Freewheelin'", YearPublicacion = 1963, IsInSpotify = true },
				new CD { Titulo = "Nashville Skyline", YearPublicacion = 1969, IsInSpotify = true },
				new CD { Titulo = "The times they are a-changin'", YearPublicacion = 1964, IsInSpotify = true },
				new CD { Titulo = "Bringing it all back home", YearPublicacion = 1965, IsInSpotify = true },
				new CD { Titulo = "John Wesley harding", YearPublicacion = 1967, IsInSpotify = true },
				new CD { Titulo = "Selfportrait", YearPublicacion = 1970, IsInSpotify = true },
				new CD { Titulo = "The bootleg series Vol. 7 (No direction home soundtrack)", YearPublicacion = 1961, IsInSpotify = true },
				new CD { Titulo = "Desire", YearPublicacion = 1976, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Bruce Springsteen", new List<CD>
		{
				new CD { Titulo = "Born in the USA", YearPublicacion = 1984, IsInSpotify = true, Etiqueta = 45 },
				new CD { Titulo = "Born to run", YearPublicacion = 1975, IsInSpotify = true, Etiqueta = 21 },
				new CD { Titulo = "Devils & Dust", YearPublicacion = 2005, IsInSpotify = true, Etiqueta = 44 },
				new CD { Titulo = "Magic", YearPublicacion = 2007, IsInSpotify = true, Etiqueta = 10 },
				new CD { Titulo = "The Rising", YearPublicacion = 2002, IsInSpotify = true, Etiqueta = 9 }
		});

	InsertOrUpdateGrupo("Bulldozer", new List<CD>
		{
				new CD { Titulo = "Adrenalina & Distorsión", YearPublicacion = 2002, IsInSpotify = false, Etiqueta = 678 }
		});

	InsertOrUpdateGrupo("Dexter Gordon", new List<CD>
		{
				new CD { Titulo = "Our man in Paris", YearPublicacion = 1963, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Miles Davis", new List<CD>
		{
				new CD { Titulo = "Birth of the cool", YearPublicacion = 2000, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Sonny Rollins", new List<CD>
		{
				new CD { Titulo = "Newk's time", YearPublicacion = 2004, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Kenny Burrell", new List<CD>
		{
				new CD { Titulo = "Midnight Blue", YearPublicacion = 1999, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Thelonious Monk", new List<CD>
		{
				new CD { Titulo = "Genius of modern music", YearPublicacion = 2001, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Joe Henderson", new List<CD>
		{
				new CD { Titulo = "Page one", YearPublicacion = 1999, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Cannonball Adderley", new List<CD>
		{
				new CD { Titulo = "Something' else", YearPublicacion = 1999, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Charlie Parker", new List<CD>
		{
				new CD { Titulo = "At storyville", YearPublicacion = 1988, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Chick Corea", new List<CD>
		{
				new CD { Titulo = "Now he sings, now he sobs", YearPublicacion = 2002, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Bill Evans", new List<CD>
		{
				new CD { Titulo = "Undercurrent", YearPublicacion = 2002, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Pablo Almaraz", new List<CD>
		{
				new CD { Titulo = "The roadside kind", YearPublicacion = 2018, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Weevers", new List<CD>
		{
				new CD { Titulo = "First Round", YearPublicacion = 2016, IsInSpotify = false }
		});

	InsertOrUpdateGrupo("High Felicity", new List<CD>
		{
				new CD { Titulo = "The takeoff", YearPublicacion = 2017, IsInSpotify = false }
		});

	InsertOrUpdateGrupo("Roy Orbison", new List<CD>
		{
				new CD { Titulo = "The all-time greatest hits of", YearPublicacion = 1974, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Surfin' Bichos", new List<CD>
		{
				new CD { Titulo = "La luz en tus entrañas", YearPublicacion = 1990, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Tom Jones", new List<CD>
		{
				new CD { Titulo = "Duets", YearPublicacion = 1999, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Art Blakey and the Jazz Messengers", new List<CD>
		{
				new CD { Titulo = "Moanin'", YearPublicacion = 1999, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Herbie Hancock", new List<CD>
		{
				new CD { Titulo = "Maiden Voyage", YearPublicacion = 1999, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Duke Ellington", new List<CD>
		{
				new CD { Titulo = "Money Jungle", YearPublicacion = 2002, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Wayne Shorter", new List<CD>
		{
				new CD { Titulo = "Speak no evil", YearPublicacion = 1999, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Horace Silver", new List<CD>
		{
				new CD { Titulo = "Song for my father", YearPublicacion = 1999, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Lee Morgan", new List<CD>
		{
				new CD { Titulo = "The sidewinder", YearPublicacion = 1999, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("John Coltrane", new List<CD>
		{
				new CD { Titulo = "Blue Train", YearPublicacion = 2003, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Caetano Veloso y Gilberto Gil", new List<CD>
		{
				new CD { Titulo = "Dos amigos, un siglo de música", YearPublicacion = 2016, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Jimmy Smith", new List<CD>
		{
				new CD { Titulo = "Back at the chicken shack", YearPublicacion = 1960, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Billie Holiday", new List<CD>
		{
				new CD { Titulo = "Billie's Blues", YearPublicacion = 1988, IsInSpotify = true }
		});

	InsertOrUpdateGrupo("Chez Luna", new List<CD>
		{
				new CD { Titulo = "Chez Luna", YearPublicacion = 2011, IsInSpotify = true, Etiqueta = 88 }
		});

	InsertOrUpdateGrupo("Coldplay", new List<CD>
		{
				new CD { Titulo = "Viva la vida or death and all his friends", YearPublicacion = 2008, IsInSpotify = true, Etiqueta = 25 },
				new CD { Titulo = "X&Y", YearPublicacion = 2005, IsInSpotify = true, Etiqueta = 291 }
		});

	InsertOrUpdateGrupo("Collective Soul", new List<CD>
		{
				new CD { Titulo = "Disciplined Breakdown", YearPublicacion = 1997, IsInSpotify = true, Etiqueta = 569 }
		});

	InsertOrUpdateGrupo("Corey Harris", new List<CD>
		{
				new CD { Titulo = "Greens From the garden", YearPublicacion = 1999, IsInSpotify = true, Etiqueta = 1 }
		});

	InsertOrUpdateGrupo("Cream", new List<CD>
		{
				new CD { Titulo = "Wheels of fire", YearPublicacion = 1968, IsInSpotify = true, Etiqueta = 95 }
		});

	InsertOrUpdateGrupo("Dave Matthews Band", new List<CD>
		{
				new CD { Titulo = "Big whiskey & the groogrux king", YearPublicacion = 2009, IsInSpotify = true, Etiqueta = 47 },
				new CD { Titulo = "Everyday", YearPublicacion = 2001, IsInSpotify = true, Etiqueta = 539 },
				new CD { Titulo = "Recently", YearPublicacion = 1994, IsInSpotify = true, Etiqueta = 568 },
				new CD { Titulo = "Stand Up", YearPublicacion = 2005, IsInSpotify = true, Etiqueta = 14 }
		});

	InsertOrUpdateGrupo("Deep Purple", new List<CD>
		{
				new CD { Titulo = "Deepest Purple", YearPublicacion = 1980, IsInSpotify = true, Etiqueta = 94 },
				new CD { Titulo = "Machine Head", YearPublicacion = 1997, IsInSpotify = true, Etiqueta = 99 }
		});

	InsertOrUpdateGrupo("Delamitri", new List<CD>
		{
				new CD { Titulo = "The best of Delamitri hatful of rain", YearPublicacion = 1998, IsInSpotify = true, Etiqueta = 277 }
		});

	InsertOrUpdateGrupo("Diana Krall", new List<CD>
		{
				new CD { Titulo = "The look of love", YearPublicacion = 2001, IsInSpotify = true, Etiqueta = 148 }
		});

	InsertOrUpdateGrupo("Dire Straits", new List<CD>
		{
				new CD { Titulo = "Brothers in arms", YearPublicacion = 1996, IsInSpotify = true, Etiqueta = 545 },
				new CD { Titulo = "Alchemy", YearPublicacion = 1984, IsInSpotify = true, Etiqueta = 165 }
		});

	InsertOrUpdateGrupo("Dream Theater", new List<CD>
		{
				new CD { Titulo = "Live scenes from New York", YearPublicacion = 2001, IsInSpotify = true, Etiqueta = 602 }
		});

	InsertOrUpdateGrupo("Eleanor McEvoy", new List<CD>
		{
				new CD { Titulo = "Out there", YearPublicacion = 2006, IsInSpotify = true, Etiqueta = 5 }
		});

	InsertOrUpdateGrupo("Elvis Presley", new List<CD>
		{
				new CD { Titulo = "NBC TV Special", YearPublicacion = 1968, IsInSpotify = true, Etiqueta = 46 },
				new CD { Titulo = "The Gospel Masters", YearPublicacion = 2009, IsInSpotify = false, Etiqueta = 86 }
		});

	InsertOrUpdateGrupo("Eric Clapton", new List<CD>
		{
				new CD { Titulo = "461 ocean boulevard", YearPublicacion = 1974, IsInSpotify = true, Etiqueta = 72 },
				new CD { Titulo = "Crossroads 2", YearPublicacion = 1996, IsInSpotify = true, Etiqueta = 570 },
				new CD { Titulo = "Derek and the Dominos - Layla and other assorted love songs", YearPublicacion = 1970, IsInSpotify = true, Etiqueta = 168 },
				new CD { Titulo = "one more car one more rider", YearPublicacion = 2001, IsInSpotify = true, Etiqueta = 206 },
				new CD { Titulo = "Sessions for Robert J", YearPublicacion = 2004, IsInSpotify = true, Etiqueta = 264 },
				new CD { Titulo = "slowhand", YearPublicacion = 1977, IsInSpotify = true, Etiqueta = 73 },
				new CD { Titulo = "Unplugged", YearPublicacion = 1992, IsInSpotify = true, Etiqueta = 85 },
				new CD { Titulo = "The road to escondido", YearPublicacion = 2006, IsInSpotify = true, Etiqueta = 3 }
		});

	InsertOrUpdateGrupo("Everlast", new List<CD>
		{
				new CD { Titulo = "Forever everlasting", YearPublicacion = 1989, IsInSpotify = true, Etiqueta = 267 }
		});

	InsertOrUpdateGrupo("Faith No More", new List<CD>
		{
				new CD { Titulo = "Angel Dust", YearPublicacion = 1992, IsInSpotify = true, Etiqueta = 26 },
				new CD { Titulo = "The Real Thing", YearPublicacion = 1989, IsInSpotify = true, Etiqueta = 26 }
		});

	InsertOrUpdateGrupo("Frank Sinatra", new List<CD>
		{
				new CD { Titulo = "Classic Sinatra - His Greatest Hits", YearPublicacion = 1950, IsInSpotify = false, Etiqueta = 32 },
				new CD { Titulo = "my way the best of sinatra", YearPublicacion = 1997, IsInSpotify = false, Etiqueta = 35 }
		});

	InsertOrUpdateGrupo("Frank Zappa", new List<CD>
		{
				new CD { Titulo = "Cheap Thrills", YearPublicacion = 1998, IsInSpotify = true, Etiqueta = 566 },
				new CD { Titulo = "Hot Rats", YearPublicacion = 1969, IsInSpotify = true, Etiqueta = 147 }
		});



	InsertOrUpdateGrupo("Fumanchu", new List<CD>
{
		new CD { Titulo = "The Action Is Go", YearPublicacion = 1997, IsInSpotify = true, Etiqueta = 60 }
});

	InsertOrUpdateGrupo("Funkadelic", new List<CD>
{
		new CD { Titulo = "America eats its young", YearPublicacion = 1972, IsInSpotify = true, Etiqueta = 138 },
		new CD { Titulo = "Standing on the verge of getting it on", YearPublicacion = 1974, IsInSpotify = true, Etiqueta = 119 }
});

	InsertOrUpdateGrupo("Gari", new List<CD>
{
		new CD { Titulo = "16 lore", YearPublicacion = 2009, IsInSpotify = true, Etiqueta = 56 }
});

	InsertOrUpdateGrupo("Gary Moore", new List<CD>
{
		new CD { Titulo = "Out in the fields-The very best of", YearPublicacion = 1998, IsInSpotify = true, Etiqueta = 383 }
});

	InsertOrUpdateGrupo("Gerry Rafferty", new List<CD>
{
		new CD { Titulo = "The best of Gerry Rafferty", YearPublicacion = 1997, IsInSpotify = true, Etiqueta = 111 }
});

	InsertOrUpdateGrupo("Gov't Mule", new List<CD>
{
		new CD { Titulo = "Live…With a Little Help From Our Friends", YearPublicacion = 1999, IsInSpotify = true, Etiqueta = 676 }
});

	InsertOrUpdateGrupo("Guns N' Roses", new List<CD>
{
		new CD { Titulo = "Appetite For Destruction", YearPublicacion = 1987, IsInSpotify = true, Etiqueta = 167 }
});

	InsertOrUpdateGrupo("Hiram Bullock", new List<CD>
{
		new CD { Titulo = "Color me", YearPublicacion = 2001, IsInSpotify = false, Etiqueta = 623 }
});

	InsertOrUpdateGrupo("Jeff Buckley", new List<CD>
{
		new CD { Titulo = "Grace", YearPublicacion = 1994, IsInSpotify = true, Etiqueta = 24 },
		new CD { Titulo = "Mystery White Boy", YearPublicacion = 1994, IsInSpotify = true, Etiqueta = 24 }
});

	InsertOrUpdateGrupo("Jethro Tull", new List<CD>
{
		new CD { Titulo = "Greatest Hits", YearPublicacion = 1997, IsInSpotify = true, Etiqueta = 332 },
		new CD { Titulo = "Living In The Past", YearPublicacion = 1972, IsInSpotify = true, Etiqueta = 171 }
});

	InsertOrUpdateGrupo("Jimi Hendrix", new List<CD>
{
		new CD { Titulo = "Are You Experienced", YearPublicacion = 1967, IsInSpotify = true, Etiqueta = 22 },
		new CD { Titulo = "Blues", YearPublicacion = 1984, IsInSpotify = true, Etiqueta = 320 },
		new CD { Titulo = "Electric Ladyland", YearPublicacion = 1968, IsInSpotify = true, Etiqueta = 312 }
});

	InsertOrUpdateGrupo("Jimmy Page & The Black Crowes", new List<CD>
{
		new CD { Titulo = "Live at The Greek", YearPublicacion = 1999, IsInSpotify = true, Etiqueta = 316 }
});

	InsertOrUpdateGrupo("Joe Satriani", new List<CD>
{
		new CD { Titulo = "Joe Satriani", YearPublicacion = 1995, IsInSpotify = true, Etiqueta = 239 },
		new CD { Titulo = "Strange beautiful music", YearPublicacion = 2002, IsInSpotify = true, Etiqueta = 689 }
});

	InsertOrUpdateGrupo("John Mayall & The Blues Breakers", new List<CD>
{
		new CD { Titulo = "John Mayall & Blues Breakers with Eric Clapton", YearPublicacion = 1966, IsInSpotify = false, Etiqueta = 675 }
});

	InsertOrUpdateGrupo("John Mayer", new List<CD>
{
		new CD { Titulo = "Room for squares", YearPublicacion = 2001, IsInSpotify = true, Etiqueta = 57 }
});

	InsertOrUpdateGrupo("John McLaughlin, Al di Meola, Paco de Lucia", new List<CD>
{
		new CD { Titulo = "Friday night in San Francisco", YearPublicacion = 1981, IsInSpotify = true, Etiqueta = 230 }
});

	InsertOrUpdateGrupo("Keane", new List<CD>
{
		new CD { Titulo = "Hopes and fears", YearPublicacion = 2004, IsInSpotify = true, Etiqueta = 309 }
});

	InsertOrUpdateGrupo("Keith Richards", new List<CD>
{
		new CD { Titulo = "Main Offender", YearPublicacion = 1992, IsInSpotify = true, Etiqueta = 658 }
});

	InsertOrUpdateGrupo("Kerri Chandler", new List<CD>
{
		new CD { Titulo = "Coast2Coast", YearPublicacion = 2006, IsInSpotify = false, Etiqueta = 7 }
});

	InsertOrUpdateGrupo("Kid Rock", new List<CD>
{
		new CD { Titulo = "The history of rock", YearPublicacion = 2000, IsInSpotify = false, Etiqueta = 266 }
});

	InsertOrUpdateGrupo("Kiss", new List<CD>
{
		new CD { Titulo = "Alive II", YearPublicacion = 1977, IsInSpotify = true, Etiqueta = 359 },
		new CD { Titulo = "Creatures of the Night", YearPublicacion = 1982, IsInSpotify = true, Etiqueta = 330 }
});

	InsertOrUpdateGrupo("KT Tunstall", new List<CD>
{
		new CD { Titulo = "Eye to the telescope", YearPublicacion = 2004, IsInSpotify = false, Etiqueta = 297 }
});

	InsertOrUpdateGrupo("Kukuma", new List<CD>
{
		new CD { Titulo = "Kukuma", YearPublicacion = 2004, IsInSpotify = true, Etiqueta = 212 }
});

	

	_context.SaveChanges();
	
}

void InsertCDs2()
{
	InsertOrUpdateGrupo("Led Zeppelin", new List<CD>
		{
				new CD { Titulo = "III", YearPublicacion = 1970, IsInSpotify = true, Etiqueta =68 },
				new CD { Titulo = "IV", YearPublicacion = 1971, IsInSpotify = true, Etiqueta = 243 },
				new CD { Titulo = "Led Zeppelin", YearPublicacion = 1968, IsInSpotify = true, Etiqueta = 175 },
				new CD { Titulo = "Led Zeppelin II", YearPublicacion = 1969, IsInSpotify = true, Etiqueta = 174 },
				new CD { Titulo = "Physical Graffiti", YearPublicacion = 1975, IsInSpotify = true, Etiqueta = 173 },
				new CD { Titulo = "Remasters", YearPublicacion = 1990, IsInSpotify = true, Etiqueta = 244 }
		});

	InsertOrUpdateGrupo("Lenny Kravitz", new List<CD>
		{
				new CD { Titulo = "Mama Said", YearPublicacion = 1991, IsInSpotify = true, Etiqueta =299 }
		});

	InsertOrUpdateGrupo("Lighthouse Family", new List<CD>
		{ 
				new CD { Titulo = "Postcards from heaven", YearPublicacion = 1997, IsInSpotify = true, Etiqueta =299 }
		});

	InsertOrUpdateGrupo("Live", new List<CD>
		{
				new CD { Titulo = "Birds of pray", YearPublicacion = 2003, IsInSpotify = true, Etiqueta =116 },
				new CD { Titulo = "V", YearPublicacion = 2001, IsInSpotify = true, Etiqueta =577 }
		});

	InsertOrUpdateGrupo("Lizz Wright", new List<CD>
		{
				new CD { Titulo = "The Orchard", YearPublicacion = 2008, IsInSpotify = true, Etiqueta =15 }
		});

	InsertOrUpdateGrupo("Lou Reed", new List<CD>
		{
				new CD { Titulo = "NYC Man", YearPublicacion = 2003, IsInSpotify = true, Etiqueta =84 }
		});

	InsertOrUpdateGrupo("Louis Amstrong", new List<CD>
		{
				new CD { Titulo = "Ella & Louis", YearPublicacion = 1957, IsInSpotify = true, Etiqueta =33 }
		});

	InsertOrUpdateGrupo("Luar Na Lubre", new List<CD>
		{
				new CD { Titulo = "O Son Do Ar", YearPublicacion = 1997, IsInSpotify = true, Etiqueta =271 }
		});

	InsertOrUpdateGrupo("Lynch Mob", new List<CD>
		{
				new CD { Titulo = "Lynch Mob", YearPublicacion = 1992, IsInSpotify = true, Etiqueta =249 }
		});

	InsertOrUpdateGrupo("Lynrd Skynyrd", new List<CD>
		{
				new CD { Titulo = "A Retrospective", YearPublicacion = 1993, IsInSpotify = true, Etiqueta =250 }
		});

	InsertOrUpdateGrupo("Maceo Parker", new List<CD>
		{
				new CD { Titulo = "Dial Maceo", YearPublicacion = 2000, IsInSpotify = true, Etiqueta =575 }
		});

	InsertOrUpdateGrupo("Macy Gray", new List<CD>
		{
				new CD { Titulo = "The very best of macy gray", YearPublicacion = 2004, IsInSpotify = true, Etiqueta =17 }
		});

	InsertOrUpdateGrupo("Marah", new List<CD>
		{
				new CD { Titulo = "Angels of destruction", YearPublicacion = 2008, IsInSpotify = true, Etiqueta =16 },
				new CD { Titulo = "Let's cut the crap and hook up later on tonight", YearPublicacion = 2004, IsInSpotify = true, Etiqueta =36 },
		});

	InsertOrUpdateGrupo("Marvin Gaye", new List<CD>
		{
				new CD { Titulo = "What's going on", YearPublicacion = 1971, IsInSpotify = true, Etiqueta =65 }
		});

	InsertOrUpdateGrupo("Mauri Sanchis", new List<CD>
		{
				new CD { Titulo = "What did you expect?", YearPublicacion = 2011, IsInSpotify = true, Etiqueta =80 }
		});

	InsertOrUpdateGrupo("Metallica", new List<CD>
		{
				new CD { Titulo = "Bilbao BBK Live Festival, 29 Junio 2007", YearPublicacion = 2007, IsInSpotify = false, Etiqueta =28 },
				new CD { Titulo = "Reload", YearPublicacion = 1997, IsInSpotify = true, Etiqueta =329 },
		});

	InsertOrUpdateGrupo("Mi Hermana Corina", new List<CD>
	{
			new CD { Titulo = "In a sea of prawns", YearPublicacion = 2002, IsInSpotify = true, Etiqueta =672 },
			new CD { Titulo = "MHC", YearPublicacion = 2007, IsInSpotify = true, Etiqueta =13 },
			new CD { Titulo = "sisterland", YearPublicacion = 2004, IsInSpotify = true, Etiqueta =48 },
			new CD { Titulo = "Wito", YearPublicacion = 2010, IsInSpotify = true, Etiqueta =70 },
			new CD { Titulo = "The day after", YearPublicacion = 2012, IsInSpotify = true, Etiqueta =89 },
			new CD { Titulo = "Stay Free", YearPublicacion = 2014, IsInSpotify = true, Etiqueta =102 },
			new CD { Titulo = "E=mHc2", YearPublicacion = 2017, IsInSpotify = true },
			new CD { Titulo = "While", YearPublicacion = 2021, IsInSpotify = true }
	});

	InsertOrUpdateGrupo("Michael Jackson", new List<CD>
	{
			new CD { Titulo = "Thriller 25 aniversario", YearPublicacion = 2008, IsInSpotify = true, Etiqueta =12 }
	});

	InsertOrUpdateGrupo("Miguel Salvador", new List<CD>
	{
			new CD { Titulo = "Viaje a Etreum", YearPublicacion = 2011, IsInSpotify = true, Etiqueta =81 }
	});

	InsertOrUpdateGrupo("Mike Oldfield", new List<CD>
	{
			new CD { Titulo = "The Orchestral Tubular Bells", YearPublicacion = 1975, IsInSpotify = true, Etiqueta =339 }
	});

	InsertOrUpdateGrupo("Miles Davis", new List<CD>
	{
			new CD { Titulo = "Kind of blue", YearPublicacion = 1959, IsInSpotify = true, Etiqueta =40 }
	});

	InsertOrUpdateGrupo("Mojo Project", new List<CD>
	{
			new CD { Titulo = "Taste the mojo", YearPublicacion = 2004, IsInSpotify = true, Etiqueta =254 }
	});

	InsertOrUpdateGrupo("Morcheeba", new List<CD>
	{
			new CD { Titulo = "Dive Deep", YearPublicacion = 2007, IsInSpotify = true, Etiqueta =20 },
			new CD { Titulo = "Fragments of freedom", YearPublicacion = 2007, IsInSpotify = true, Etiqueta =201 },
			new CD { Titulo = "Parts of the process", YearPublicacion = 2003, IsInSpotify = true, Etiqueta =117 },
	});

	InsertOrUpdateGrupo("Neil Young", new List<CD>
	{
			new CD { Titulo = "Weld", YearPublicacion = 1991, IsInSpotify = true, Etiqueta =43 }
	});

	InsertOrUpdateGrupo("Ocean Colour Scene", new List<CD>
	{
			new CD { Titulo = "Marchin´ Already", YearPublicacion = 1997, IsInSpotify = true, Etiqueta =337 }
	});

	InsertOrUpdateGrupo("O'funkillo", new List<CD>
	{
			new CD { Titulo = "…en el planeta aseituna", YearPublicacion = 2002, IsInSpotify = true, Etiqueta =61 }
	});

	InsertOrUpdateGrupo("Paco de Lucia", new List<CD>
	{
			new CD { Titulo = "Cositas buenas", YearPublicacion = 2004, IsInSpotify = true, Etiqueta =196 }
	});

	InsertOrUpdateGrupo("Pearl Jam", new List<CD>
	{
			new CD { Titulo = "back spacer", YearPublicacion = 2009, IsInSpotify = true, Etiqueta =52 },
			new CD { Titulo = "Pearl Jam", YearPublicacion = 2006, IsInSpotify = true, Etiqueta =52 },
			new CD { Titulo = "Ten", YearPublicacion = 1992, IsInSpotify = true, Etiqueta =2 }
	});

	InsertOrUpdateGrupo("Pink Floyd", new List<CD>
	{
			new CD { Titulo = "dark side of the moon", YearPublicacion = 1973, IsInSpotify = true, Etiqueta =50 }
	});

	InsertOrUpdateGrupo("Primus", new List<CD>
	{
			new CD { Titulo = "Rhinoplasty", YearPublicacion = 1998, IsInSpotify = true, Etiqueta =328 }
	});

	InsertOrUpdateGrupo("Prince", new List<CD>
	{
			new CD { Titulo = "Planet Earth", YearPublicacion = 2007, IsInSpotify = true, Etiqueta =6 }
	});

	InsertOrUpdateGrupo("Queens of the stone age", new List<CD>
	{
			new CD { Titulo = "Queens of the stone age", YearPublicacion = 1998, IsInSpotify = true, Etiqueta =132 }
	});

	InsertOrUpdateGrupo("Rage Against The Machine", new List<CD>
	{
			new CD { Titulo = "Rage Against The Machine", YearPublicacion = 1992, IsInSpotify = true, Etiqueta =19 }
	});

	InsertOrUpdateGrupo("Red Hot Chili Peppers", new List<CD>
	{
			new CD { Titulo = "Blood Sugar Sex Magik", YearPublicacion = 1991, IsInSpotify = true, Etiqueta =295 },
			new CD { Titulo = "One Hot Minute", YearPublicacion = 1995, IsInSpotify = true, Etiqueta =327 }
	});

	InsertOrUpdateGrupo("Robben Ford", new List<CD>
	{
			new CD { Titulo = "Blue Moon", YearPublicacion = 2002, IsInSpotify = true, Etiqueta =673 }
	});

	InsertOrUpdateGrupo("Robert Johnson", new List<CD>
	{
			new CD { Titulo = "Gold Collection", YearPublicacion = 1990, IsInSpotify = true, Etiqueta =296 }
	});

	InsertOrUpdateGrupo("Ronny Jordan", new List<CD>
	{
			new CD { Titulo = "At last", YearPublicacion = 2003, IsInSpotify = true, Etiqueta =161 },
			new CD { Titulo = "off the record", YearPublicacion = 2001, IsInSpotify = true, Etiqueta =708 }
	});

	InsertOrUpdateGrupo("Ry Cooder", new List<CD>
	{
			new CD { Titulo = "Greatest Hits", YearPublicacion = 1995, IsInSpotify = true, Etiqueta =489 }
	});

	InsertOrUpdateGrupo("Ryan Adams", new List<CD>
	{
			new CD { Titulo = "Rock And Roll", YearPublicacion = 2003, IsInSpotify = true, Etiqueta =76 }
	});

	InsertOrUpdateGrupo("Sex Pistols", new List<CD>
	{
			new CD { Titulo = "never mind the bollocks", YearPublicacion = 1977, IsInSpotify = true, Etiqueta =75 }
	});

	InsertOrUpdateGrupo("Staind", new List<CD>
	{
			new CD { Titulo = "Break the cycle", YearPublicacion = 2001, IsInSpotify = true, Etiqueta =574 }
	});

	InsertOrUpdateGrupo("Steve Vai", new List<CD>
	{
			new CD { Titulo = "Alive In An Ultra World", YearPublicacion = 2001, IsInSpotify = true, Etiqueta =607 }
	});

	InsertOrUpdateGrupo("Stevie Ray Vaughan", new List<CD>
	{
			new CD { Titulo = "The Sky Is Crying", YearPublicacion = 1991, IsInSpotify = true, Etiqueta =386 }
	});

	InsertOrUpdateGrupo("The Beatles", new List<CD>
	{
			new CD { Titulo = "Abbey Road", YearPublicacion = 1969, IsInSpotify = true, Etiqueta =59 },
			new CD { Titulo = "Revolver", YearPublicacion = 1966, IsInSpotify = true, Etiqueta =134 },
			new CD { Titulo = "Sgt. Pepper`s Lonely hearts club band", YearPublicacion = 1967, IsInSpotify = true, Etiqueta =130 }
	});

	InsertOrUpdateGrupo("The Black Crowes", new List<CD>
	{
			new CD { Titulo = "Amorica", YearPublicacion = 1994, IsInSpotify = true, Etiqueta =428 },
			new CD { Titulo = "Before the frost", YearPublicacion = 2009, IsInSpotify = true, Etiqueta =58 },
			new CD { Titulo = "croweology", YearPublicacion = 2010, IsInSpotify = true, Etiqueta =71 },
			new CD { Titulo = "Shake your money maker", YearPublicacion = 1990, IsInSpotify = true, Etiqueta =38 },
			new CD { Titulo = "The southern harmony and musical companion", YearPublicacion = 1992, IsInSpotify = true, Etiqueta =668 },
			new CD { Titulo = "Three snakes and one charm", YearPublicacion = 1996, IsInSpotify = true, Etiqueta =37 }
	});

	InsertOrUpdateGrupo("The Clash", new List<CD>
	{
			new CD { Titulo = "London Calling", YearPublicacion = 1979, IsInSpotify = true, Etiqueta =64 }
	});

	InsertOrUpdateGrupo("The Cult", new List<CD>
	{
			new CD { Titulo = "Beyond Good And Evil", YearPublicacion = 2001, IsInSpotify = true, Etiqueta =562 },
			new CD { Titulo = "Ceremony", YearPublicacion = 1991, IsInSpotify = true, Etiqueta =92 },
			new CD { Titulo = "Sonic Temple", YearPublicacion = 1989, IsInSpotify = true, Etiqueta =298 }
	});

	InsertOrUpdateGrupo("The Meters", new List<CD>
	{
			new CD { Titulo = "Sundazed", YearPublicacion = 1969, IsInSpotify = false, Etiqueta =115 }
	});

	InsertOrUpdateGrupo("The Police", new List<CD>
	{
			new CD { Titulo = "Reggatta de blanc", YearPublicacion = 1979, IsInSpotify = true, Etiqueta =23 }
	});

	InsertOrUpdateGrupo("The Pretenders", new List<CD>
	{
			new CD { Titulo = "Greatest Hits", YearPublicacion = 2000, IsInSpotify = true, Etiqueta =62 }
	});

	InsertOrUpdateGrupo("The Rolling Stones", new List<CD>
	{
			new CD { Titulo = "Exile on main street", YearPublicacion = 1972, IsInSpotify = true, Etiqueta =74 },
			new CD { Titulo = "Stripped", YearPublicacion = 1995, IsInSpotify = true, Etiqueta =503 },
			new CD { Titulo = "Tatoo You", YearPublicacion = 1981, IsInSpotify = true, Etiqueta =123 },
			new CD { Titulo = "Vodoo Lounge", YearPublicacion = 1994, IsInSpotify = true, Etiqueta =324 }
	});

	InsertOrUpdateGrupo("The Screamin´ Cheetah Wheelies", new List<CD>
	{
			new CD { Titulo = "Live Volumes", YearPublicacion = 2004, IsInSpotify = true, Etiqueta =259 }
	});

	InsertOrUpdateGrupo("The Verve", new List<CD>
	{
			new CD { Titulo = "Urban Hymns", YearPublicacion = 1997, IsInSpotify = true, Etiqueta =317 }
	});

	InsertOrUpdateGrupo("Tom Waits", new List<CD>
	{
			new CD { Titulo = "Beautiful maladies", YearPublicacion = 1998, IsInSpotify = true, Etiqueta =63 }
	});

	InsertOrUpdateGrupo("Train", new List<CD>
	{
			new CD { Titulo = "Drops of Jupiter", YearPublicacion = 2001, IsInSpotify = true, Etiqueta =603 }
	});

	InsertOrUpdateGrupo("U2", new List<CD>
	{
			new CD { Titulo = "How to dismantle an atomic bomb", YearPublicacion = 2004, IsInSpotify = true, Etiqueta =101 }
	});

	InsertOrUpdateGrupo("US3", new List<CD>
	{
			new CD { Titulo = "Broadway & 52nd", YearPublicacion = 1997, IsInSpotify = true, Etiqueta =53 }
	});

	InsertOrUpdateGrupo("Van Halen", new List<CD>
	{
			new CD { Titulo = "1984", YearPublicacion = 1983, IsInSpotify = true, Etiqueta =302 },
			new CD { Titulo = "5150", YearPublicacion = 1986, IsInSpotify = true, Etiqueta =303 },
			new CD { Titulo = "Balance", YearPublicacion = 1995, IsInSpotify = true, Etiqueta =304 },
			new CD { Titulo = "Diver Down", YearPublicacion = 1982, IsInSpotify = true, Etiqueta =305 },
			new CD { Titulo = "Fair Warning", YearPublicacion = 1981, IsInSpotify = true, Etiqueta =306 },
			new CD { Titulo = "Van Halen", YearPublicacion = 1978, IsInSpotify = true, Etiqueta =331 },
			new CD { Titulo = "Women And Children First", YearPublicacion = 1980, IsInSpotify = true, Etiqueta =311 }
	});

	InsertOrUpdateGrupo("Varios", new List<CD>
	{
			new CD { Titulo = "Alligator Records", YearPublicacion = 2006, IsInSpotify = false, Etiqueta =8 }
	});

	InsertOrUpdateGrupo("Whitesnake", new List<CD>
	{
			new CD { Titulo = "Greatest Hits", YearPublicacion = 1994, IsInSpotify = true, Etiqueta =67 }
	});

	InsertOrUpdateGrupo("Wolfmother", new List<CD>
	{
			new CD { Titulo = "Wolfmother", YearPublicacion = 2006, IsInSpotify = true, Etiqueta =49 }
	});

	InsertOrUpdateGrupo("WOP", new List<CD>
	{
			new CD { Titulo = "2t", YearPublicacion = 2011, IsInSpotify = false, Etiqueta =87 },
			new CD { Titulo = "WOP(Maxi)", YearPublicacion = 2011, IsInSpotify = false, Etiqueta =79 }
	});

	InsertOrUpdateGrupo("ZZ Top", new List<CD>
	{
			new CD { Titulo = "Eliminator", YearPublicacion = 1983, IsInSpotify = true, Etiqueta =332 },
			new CD { Titulo = "Tres Hombres", YearPublicacion = 1973, IsInSpotify = true, Etiqueta =27 },
			new CD { Titulo = "Fandango", YearPublicacion = 1975, IsInSpotify = true, Etiqueta =27 }
	});

	_context.SaveChanges();

}

void InsertOrUpdateGrupo(string nombreGrupo, List<CD> cds)
{
	var grupo = _context.Grupos.FirstOrDefault(g => g.Nombre == nombreGrupo);

	if (grupo == null)
	{
		grupo = new Grupo { Nombre = nombreGrupo };
		_context.Grupos.Add(grupo);
	}

	grupo.CDs.AddRange(cds);
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

void AñadirNuevaRecetaACategoriaExistente(	)
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







