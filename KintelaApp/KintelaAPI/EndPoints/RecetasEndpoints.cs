using Microsoft.EntityFrameworkCore;
using KintelaData;
using KintelaDomain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using KintelaAPI.DTOs;
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using System.Text.Json;
using Newtonsoft.Json;
namespace KintelaAPI.EndPoints;

public static class RecetasEndpoints
{
    public static void MapRecetasEndpoints(this IEndpointRouteBuilder routes)
    {
      var group = routes.MapGroup("/api/Recetas").WithTags(nameof(Receta));

			//group.WithMetadata(new IgnoreAntiforgeryTokenAttribute());

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

		group.MapGet("/PorIngrediente/{nombreIngrediente}", async Task<Results<Ok<List<RecetaDTO>>, NotFound>> (string nombreIngrediente, KintelaContext db) =>
		{
			var recetas = await db.Recetas
					.Include(r => r.Categorias)
					.Where(r => r.Ingredientes.Contains(nombreIngrediente))
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
						.WithName("GetRecetasPorIngrediente")
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

		group.MapPut("/{id}", async Task<Results<Ok<RecetaDTO>, NotFound, BadRequest<ErrorResponse>>> (int id, [FromForm] RecetaUpdateModel model, KintelaContext db, [FromServices] IConfiguration configuration) =>
		{
			var recetaRecibida = JsonConvert.DeserializeObject<RecetaDTO>(model.Receta);
			var image = model.Image;

			// Verifica si la receta existe
			var receta = await db.Recetas
					.Include(r => r.Categorias)
					.FirstOrDefaultAsync(r => r.RecetaId == id);

			if (receta == null)
			{
				return TypedResults.NotFound();
			}

			// Verifica si las categorías existen
			var categorias = await db.Categorias.Where(c => recetaRecibida.CategoriaIds.Contains(c.CategoriaId)).ToListAsync();
			if (categorias.Count != recetaRecibida.CategoriaIds.Count)
			{
				return TypedResults.BadRequest(new ErrorResponse { Error = "Una o más categorías no fueron encontradas." });
			}

			// Actualiza los campos de la receta
			receta.Nombre = receta.Nombre;
			receta.Ingredientes = receta.Ingredientes;
			receta.Preparacion = receta.Preparacion;
			receta.Presentacion = receta.Presentacion;
			receta.EnlaceVideo = receta.EnlaceVideo;
			receta.Comensales = receta.Comensales;

			/*if image.Files.Count > 0)			{
				var image = request.Form.Files[0];
				if (image.Length > 0)
				{
					var connectionString = configuration.GetValue<string>("AzureBlobStorage:ConnectionString");
					var containerName = configuration.GetValue<string>("AzureBlobStorage:ContainerName");

					var blobServiceClient = new BlobServiceClient(connectionString);
					var blobContainerClient = blobServiceClient.GetBlobContainerClient(containerName);

					var blobClient = blobContainerClient.GetBlobClient(image.FileName);

					using (var stream = image.OpenReadStream())
					{
						await blobClient.UploadAsync(stream, true);
					}

					receta.Imagen = blobClient.Uri.ToString();
				}
			}*/

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

		/*group.MapPut("/{id}", async Task<Results<Ok<RecetaDTO>, NotFound, BadRequest<ErrorResponse>>> (int id, [FromForm] RecetaDTO recetaDto, [FromForm] IFormFile? image, KintelaContext db, [FromServices]  IConfiguration configuration) =>
			{
				var receta = await db.Recetas
						.Include(r => r.Categorias)
						.FirstOrDefaultAsync(r => r.RecetaId == id);

				if (receta == null)
				{
					return TypedResults.NotFound();
				}

				var categorias = await db.Categorias.Where(c => recetaDto.CategoriaIds.Contains(c.CategoriaId)).ToListAsync();
				if (categorias.Count != recetaDto.CategoriaIds.Count)
				{
					return TypedResults.BadRequest(new ErrorResponse { Error = "Una o más categorías no fueron encontradas." });
				}

				receta.Nombre = recetaDto.Nombre;
				receta.Ingredientes = recetaDto.Ingredientes;
				receta.Preparacion = recetaDto.Preparacion;
				receta.Presentacion = recetaDto.Presentacion;
				receta.EnlaceVideo = recetaDto.EnlaceVideo;
				receta.Imagen = recetaDto.Imagen;
				receta.Comensales = recetaDto.Comensales;

				if (image != null && image.Length > 0)
				{
					var connectionString = configuration.GetValue<string>("AzureBlobStorage:ConnectionString");
					var containerName = configuration.GetValue<string>("AzureBlobStorage:ContainerName");

					var blobServiceClient = new BlobServiceClient(connectionString);
					var blobContainerClient = blobServiceClient.GetBlobContainerClient(containerName);

					var blobClient = blobContainerClient.GetBlobClient(image.FileName);

					using (var stream = image.OpenReadStream())
					{
						await blobClient.UploadAsync(stream, true);
					}

					receta.Imagen = blobClient.Uri.ToString();
				}

				receta.Categorias.Clear();
				receta.Categorias.AddRange(categorias);

				db.Entry(receta).State = EntityState.Modified;

				await db.SaveChangesAsync();

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
				.WithOpenApi();*/


	}
}
