using Microsoft.EntityFrameworkCore;
using KintelaData;
using KintelaDomain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using KintelaAPI.DTOs;
namespace KintelaAPI;

public static class RecetasEndpoints
{
    public static void MapRecetasEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Recetas").WithTags(nameof(Categoria));

			group.MapGet("/Categorias", async Task<Results<Ok<List<CategoriaDTO>>, NotFound>> (KintelaContext db) =>
			{
				var categorias = await db.Categorias
						.OrderBy(c => c.Nombre)
						.Select(model => new CategoriaDTO(model.CategoriaId, model.Nombre))
						.ToListAsync();

				return categorias.Any()
						? TypedResults.Ok(categorias)
						: TypedResults.NotFound();
			})
			.WithName("GetAllCategorias")
			.WithOpenApi();

		group.MapGet("/CategoriasOLD", async (KintelaContext db) =>
        {
						return await db.Categorias.OrderBy(c=>c.Nombre).ToListAsync();
				})
        .WithName("GetAllCategoriasOLD")
        .WithOpenApi();

        
    }
}
