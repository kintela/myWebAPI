using Microsoft.EntityFrameworkCore;
using KintelaData;
using KintelaDomain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using KintelaAPI.DTOs;
namespace KintelaAPI.EndPoints;

public static class RecetasEndpoints
{
    public static void MapRecetasEndpoints(this IEndpointRouteBuilder routes)
    {
      var group = routes.MapGroup("/api/Recetas").WithTags(nameof(Receta));

			group.MapGet("/", async Task<Results<Ok<List<RecetaDTO>>, NotFound>> (KintelaContext db) =>
			{
				var recetas = await db.Recetas
								.OrderBy(c => c.Nombre)
								.Select(model => new RecetaDTO(model.RecetaId, model.Nombre, model.Ingredientes, model.Preparacion, model.Presentacion,  model.EnlaceVideo, model.Imagen, model.Comensales))
								.ToListAsync();

				return recetas.Any()
								? TypedResults.Ok(recetas)
								: TypedResults.NotFound();
			})
		 .WithName("GetAllRecetas")
		 .WithOpenApi();

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

		group.MapGet("/PorCategoria/{nombreCategoria}", async Task<Results<Ok<List<RecetaDTO>>, NotFound>> (string nombreCategoria, KintelaContext db) =>
		{
			var recetas = await db.Recetas
					.Where(r => r.Categorias.Any(c => c.Nombre == nombreCategoria))
					.OrderBy(r => r.Nombre)
					.Select(model => new RecetaDTO(model.RecetaId, model.Nombre, model.Ingredientes, model.Preparacion, model.Presentacion, model.EnlaceVideo, model.Imagen, model.Comensales))
					.ToListAsync();

			return recetas.Any()
					? TypedResults.Ok(recetas)
					: TypedResults.NotFound();
		})
		.WithName("GetRecetasPorCategoria")
		.WithOpenApi();

		group.MapGet("/{id}", async Task<Results<Ok<RecetaDTO>, NotFound>> (int id, KintelaContext db) =>
		{
			var receta = await db.Recetas
					.Where(r => r.RecetaId == id)
					.Select(model => new RecetaDTO(model.RecetaId, model.Nombre, model.Ingredientes, model.Preparacion, model.Presentacion, model.EnlaceVideo, model.Imagen, model.Comensales))
					.FirstOrDefaultAsync();

			return receta != null
					? TypedResults.Ok(receta)
					: TypedResults.NotFound();
		})
		.WithName("GetRecetaById")
		.WithOpenApi();





	}
}
