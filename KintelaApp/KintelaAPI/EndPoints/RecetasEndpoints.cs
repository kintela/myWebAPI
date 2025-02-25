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
				.Include(r => r.Categorias)
				.OrderBy(c => c.Nombre)
				.Select(model => new RecetaDTO(
						model.RecetaId,
						model.Nombre,
						model.Ingredientes,
						model.Preparacion,
						model.Presentacion,
						model.EnlaceVideo,
						model.Imagen,
						model.Comensales,
						model.Categorias.Select(c => c.CategoriaId).ToList()
				))
				.ToListAsync();

				return recetas.Any()
								? TypedResults.Ok(recetas)
								: TypedResults.NotFound();
			})
			 .WithName("GetAllRecetas")
			 .WithOpenApi();

			/*group.MapGet("/Categorias", async Task<Results<Ok<List<CategoriaDTO>>, NotFound>> (KintelaContext db) =>
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
				.WithOpenApi();*/

			group.MapGet("/PorCategoria/{nombreCategoria}", async Task<Results<Ok<List<RecetaDTO>>, NotFound>> (string nombreCategoria, KintelaContext db) =>
			{
				var recetas = await db.Recetas
					.Include(r => r.Categorias)
					.Where(r => r.Categorias.Any(c => c.Nombre == nombreCategoria))
					.OrderBy(r => r.Nombre)
					.Select(model => new RecetaDTO(
							model.RecetaId,
							model.Nombre,
							model.Ingredientes,
							model.Preparacion,
							model.Presentacion,
							model.EnlaceVideo,
							model.Imagen,
							model.Comensales,
							model.Categorias.Select(c => c.CategoriaId).ToList()
					))
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
					.Include(r => r.Categorias)
					.Where(r => r.RecetaId == id)
					.Select(model => new RecetaDTO(
							model.RecetaId,
							model.Nombre,
							model.Ingredientes,
							model.Preparacion,
							model.Presentacion,
							model.EnlaceVideo,
							model.Imagen,
							model.Comensales,
							model.Categorias.Select(c => c.CategoriaId).ToList()
					))
					.FirstOrDefaultAsync();

				return receta != null
						? TypedResults.Ok(receta)
						: TypedResults.NotFound();
			})
				.WithName("GetRecetaById")
				.WithOpenApi();

			group.MapPost("/", async Task<Results<Created<RecetaDTO>, BadRequest<ErrorResponse>>> (KintelaContext db, RecetaDTO recetaDto) =>
			{
				// Verifica si las categorías existen
				var categorias = await db.Categorias.Where(c => recetaDto.CategoriaIds.Contains(c.CategoriaId)).ToListAsync();
				if (categorias.Count != recetaDto.CategoriaIds.Count)
				{
					return TypedResults.BadRequest(new ErrorResponse { Error = "Una o más categorías no fueron encontradas." });
				}

				// Crea la nueva receta
				var receta = new Receta
				{
					Nombre = recetaDto.Nombre,
					Ingredientes = recetaDto.Ingredientes,
					Preparacion = recetaDto.Preparacion,
					Presentacion = recetaDto.Presentacion,
					EnlaceVideo = recetaDto.EnlaceVideo,
					Imagen = recetaDto.Imagen,
					Comensales = recetaDto.Comensales
				};

				db.Recetas.Add(receta);
				await db.SaveChangesAsync();

				// Crea la relación entre la receta y las categorías
				receta.Categorias.AddRange(categorias);
				await db.SaveChangesAsync();

				// Crea el DTO de la receta creada
				var createdRecetaDto = new RecetaDTO(
						receta.RecetaId,
						receta.Nombre,
						receta.Ingredientes,
						receta.Preparacion,
						receta.Presentacion,
						receta.EnlaceVideo,
						receta.Imagen,
						receta.Comensales,
						categorias.Select(c => c.CategoriaId).ToList()
				);

				return TypedResults.Created($"/api/Recetas/{receta.RecetaId}", createdRecetaDto);
			})
				.WithName("CreateReceta")
				.WithOpenApi();

			group.MapPut("/{id}", async Task<Results<Ok<RecetaDTO>, NotFound, BadRequest<ErrorResponse>>> (int id, RecetaDTO recetaDto, KintelaContext db) =>
			{
				// Verifica si la receta existe
				var receta = await db.Recetas
						.Include(r => r.Categorias)
						.FirstOrDefaultAsync(r => r.RecetaId == id);

				if (receta == null)
				{
					return TypedResults.NotFound();
				}

				// Verifica si las categorías existen
				var categorias = await db.Categorias.Where(c => recetaDto.CategoriaIds.Contains(c.CategoriaId)).ToListAsync();
				if (categorias.Count != recetaDto.CategoriaIds.Count)
				{
					return TypedResults.BadRequest(new ErrorResponse { Error = "Una o más categorías no fueron encontradas." });
				}

				// Actualiza los campos de la receta
				receta.Nombre = recetaDto.Nombre;
				receta.Ingredientes = recetaDto.Ingredientes;
				receta.Preparacion = recetaDto.Preparacion;
				receta.Presentacion = recetaDto.Presentacion;
				receta.EnlaceVideo = recetaDto.EnlaceVideo;
				receta.Imagen = recetaDto.Imagen;
				receta.Comensales = recetaDto.Comensales;

				// Actualiza la relación con la categoría
				receta.Categorias.Clear();
				receta.Categorias.AddRange(categorias);

				db.Entry(receta).State = EntityState.Modified;

				await db.SaveChangesAsync();

				// Crea el DTO de la receta actualizada
				var updatedRecetaDto = new RecetaDTO(
						receta.RecetaId,
						receta.Nombre,
						receta.Ingredientes,
						receta.Preparacion,
						receta.Presentacion,
						receta.EnlaceVideo,
						receta.Imagen,
						receta.Comensales,
						categorias.Select(c => c.CategoriaId).ToList()
				);

				return TypedResults.Ok(updatedRecetaDto);
			})
				.WithName("UpdateReceta")
				.WithOpenApi();



	}
}
