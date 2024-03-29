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
InsertLedZeppelinDiscos();

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





