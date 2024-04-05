using Microsoft.EntityFrameworkCore;
using KintelaData;
using KintelaDomain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
namespace KintelaAPI;

public static class GrupoEndpoints
{
    public static void MapGrupoEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Grupo").WithTags(nameof(Grupo));

        group.MapGet("/WithDiscos", async (KintelaContext db) =>
        {
            return await db.Grupos.Include(g=>g.Discos).AsNoTracking().ToListAsync();
        })
        .WithName("GetAllGruposWithDiscos")
        .WithOpenApi();

        group.MapGet("/{grupoid}", async Task<Results<Ok<GrupoDTO>, NotFound>> (int grupoid, KintelaContext db) =>
        {
            return await db.Grupos.AsNoTracking()
                .Where(model => model.GrupoId == grupoid)
								.Select(model => new GrupoDTO(model.GrupoId, model.Nombre))
								.FirstOrDefaultAsync()
								is GrupoDTO model
										? TypedResults.Ok(model)
										: TypedResults.NotFound();
        })
        .WithName("GetGrupoById")
        .WithOpenApi();

        group.MapPut("/{grupoid}", async Task<Results<Ok, NotFound>> (int grupoid, GrupoDTO grupo, KintelaContext db) =>
        {
            var affected = await db.Grupos
                .Where(model => model.GrupoId == grupoid)
                .ExecuteUpdateAsync(setters => setters
                    //.SetProperty(m => m.GrupoId, grupo.GrupoId)
                    .SetProperty(m => m.Nombre, grupo.Nombre)
                    );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateGrupo")
        .WithOpenApi();

        group.MapPost("/", async (GrupoDTO grupoDTO, KintelaContext db) =>
        {
          var grupo= new Grupo{Nombre = grupoDTO.Nombre};
          db.Grupos.Add(grupo);
          await db.SaveChangesAsync();
          return TypedResults.Created($"/api/Grupo/{grupo.GrupoId}",new GrupoDTO(grupo.GrupoId, grupo.Nombre));
        })
        .WithName("CreateGrupo")
        .WithOpenApi();

        group.MapDelete("/{grupoid}", async Task<Results<Ok, NotFound>> (int grupoid, KintelaContext db) =>
        {
            var affected = await db.Grupos
                .Where(model => model.GrupoId == grupoid)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteGrupo")
        .WithOpenApi();
    }
}
