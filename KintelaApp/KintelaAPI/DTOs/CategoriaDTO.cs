namespace KintelaAPI.DTOs
{
    public class CategoriaDTO
    {
      public CategoriaDTO(int categoriaId, string nombre)
      {
        CategoriaId = categoriaId;
        Nombre = nombre;  
      }

      public int CategoriaId { get; init; }
		  public string Nombre { get; init; }
	}
}
