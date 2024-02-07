namespace KintelaDomain
{
	public class Plato
	{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string[] Categorias { get; set; }
		public string Imagen { get; set; }
    public List<Receta> Recetas { get; set; } =new List<Receta>();

    }
}
