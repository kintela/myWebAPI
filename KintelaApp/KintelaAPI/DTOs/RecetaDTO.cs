namespace KintelaAPI.DTOs
{
	public class RecetaDTO
	{
		public RecetaDTO(int recetaId, string nombre, string[] ingredientes, string[] preparacion, string[] presentacion, string enlaceVideo, string imagen, int? comensales)
		{
			RecetaId = recetaId;
			Nombre = nombre;
			Ingredientes = ingredientes;
			Preparacion = preparacion;
			Presentacion = presentacion;
			EnlaceVideo = enlaceVideo;
			Imagen = imagen;
			Comensales = comensales;
		}

    public int RecetaId { get; set; }
		public string Nombre { get; set; }
		public string[] Ingredientes { get; set; }
		public string[] Preparacion { get; set; }
		public string[] Presentacion { get; set; }
		public int? Comensales { get; set; }
		public string EnlaceVideo { get; set; }
		public string Imagen { get; set; }

	}
}
