namespace KintelaAPI.DTOs
{
    public class CategoriaDTO
    {
      public CategoriaDTO(int categoriaId, string nombre)
      {
        CategoriaId = categoriaId;
        Nombre = nombre;  
      }

      public int CategoriaId { get; set; }
		  public string Nombre { get; set; }
	}
}
