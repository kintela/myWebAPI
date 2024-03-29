using KintelaData;
using KintelaDomain;
using Microsoft.EntityFrameworkCore;

/*using (KintelaContext context=new KintelaContext())
{
	context.Database.EnsureCreated();
}*/
KintelaContext _context = new KintelaContext();

InsertNewGrupoWithDisco();

void InsertNewGrupoWithDisco()
{
	var grupo = new Grupo { Nombre = "Led Zeppelin" };
	grupo.Discos.Add(new Disco 
	{ Nombre = "Led Zeppelin I", 
		YearPublicacion = 1969, 
		Caratula = "LedZeppelinI.jpg", 
		Discografica = "Atlantic Records", 
		Productor = "Jimmy Page" 
	});
	_context.Grupos.Add(grupo);
	_context.SaveChanges();
}





