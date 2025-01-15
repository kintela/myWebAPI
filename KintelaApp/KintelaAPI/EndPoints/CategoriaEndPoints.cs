using KintelaAPI.DTOs;
using KintelaData;
using KintelaDomain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace KintelaAPI.EndPoints
{
	public static class CategoriaEndPoints
	{
		public static void MapCategoriaEndpoints(this IEndpointRouteBuilder routes)
		{
			var group = routes.MapGroup("/api/Categoria").WithTags(nameof(Categoria));

			group.MapPost("/", async Task<Results<Created<CategoriaDTO>, BadRequest<ErrorResponse>>> (KintelaContext db, CategoriaDTO categoriaDTO) =>
			{
				// Verifica si la categoría ya existe
				var existingCategoria = await db.Categorias.FirstOrDefaultAsync(c => c.Nombre == categoriaDTO.Nombre);
				if (existingCategoria != null)
				{
					var errorResponse = new ErrorResponse { Error = "La categoría ya existe." };
					return TypedResults.BadRequest(errorResponse);
				}

				var categoria = new Categoria { Nombre = categoriaDTO.Nombre };
				db.Categorias.Add(categoria);
				await db.SaveChangesAsync();
				return TypedResults.Created($"/api/Categoria/{categoria.CategoriaId}", new CategoriaDTO(categoria.CategoriaId, categoria.Nombre));
			})
				.WithName("CreateCategoria")
				.WithOpenApi();
		}
	}
}