using Microsoft.AspNetCore.Mvc;

namespace KintelaAPI.DTOs
{
	public class RecetaUpdateModel
	{	
		public string Receta { get; set; }
		
		public IFormFile Image { get; set; }
	}
}
