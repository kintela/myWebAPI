namespace KintelaDomain
{
	public class Plato
	{
    public Plato()
    {
        Categorias = new List<Categoria>();
    }
    public int Id { get; set; }
    public string Nombre { get; set; }
		public string Imagen { get; set; }
    public Receta Receta { get; set; }
    public List<Categoria> Categorias { get; set; }

  }
}
