using KintelaData;

using (KintelaContext context=new KintelaContext())
{
	context.Database.EnsureCreated();
}

void GetPlatos()
{
	using var context=new KintelaContext();

	var pLATOS=context.Platos.ToList();

	foreach (var plato in pLATOS)
	{
		Console.WriteLine(plato.Nombre);
	}
}	
