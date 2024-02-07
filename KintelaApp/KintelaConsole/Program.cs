using KintelaData;

using (KintelaContext context=new KintelaContext())
{
	context.Database.EnsureCreated();
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
