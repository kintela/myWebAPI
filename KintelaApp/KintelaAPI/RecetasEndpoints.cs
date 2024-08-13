using Microsoft.EntityFrameworkCore;
using KintelaData;
using KintelaDomain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
namespace KintelaAPI;

public static class RecetasEndpoints
{
    public static void MapRecetasEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Recetas").WithTags(nameof(Categoria));

        group.MapGet("/Categorias", async (KintelaContext db) =>
        {
						return await db.Categorias.OrderBy(c=>c.Nombre).ToListAsync();
				})
        .WithName("GetAllCategorias")
        .WithOpenApi();

        
    }
}
