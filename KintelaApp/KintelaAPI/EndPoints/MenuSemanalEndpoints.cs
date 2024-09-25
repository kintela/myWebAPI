using Microsoft.EntityFrameworkCore;
using KintelaData;
using KintelaDomain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using KintelaAPI.DTOs;
namespace KintelaAPI.EndPoints;

public static class MenuSemanalEndpoints
{
    public static void MapMenuSemanalEndpoints(this IEndpointRouteBuilder routes)
    {
      var group = routes.MapGroup("/api/MenuSemanal").WithTags(nameof(MenuSemanal));

			group.MapGet("/", async Task<Results<Ok<List<MenuSemanalDTO>>, NotFound>> (KintelaContext db) =>
			{
				var menus = await db.MenuSemanal
								.OrderBy(c => c.FechaCreacion)
								.Select(model => new MenuSemanalDTO(model.UsuarioId,model.FechaCreacion.ToShortDateString(), model.RecetaPrimerPlatoLunes, model.RecetaSegundoPlatoLunes,		model.RecetaCenaLunes, model.RecetaPrimerPlatoMartes, model.RecetaSegundoPlatoMartes,model.RecetaCenaMartes, model.RecetaPrimerPlatoMiercoles,  model.RecetaSegundoPlatoMiercoles, model.RecetaCenaMiercoles, model.RecetaPrimerPlatoJueves, model.RecetaSegundoPlatoJueves,model.RecetaCenaJueves,model.RecetaPrimerPlatoViernes, model.RecetaSegundoPlatoViernes,model.RecetaCenaViernes,model.RecetaPrimerPlatoSabado, model.RecetaSegundoPlatoSabado, model.RecetaCenaSabado, model.RecetaPrimerPlatoDomingo, model.RecetaSegundoPlatoDomingo, model.RecetaCenaDomingo))
								.ToListAsync();

				return menus.Any()
								? TypedResults.Ok(menus)
								: TypedResults.NotFound();
			})
		 .WithName("GetAllMenusSemanales")
		 .WithOpenApi();

		group.MapPost("/", async Task<Results<Created<MenuSemanalDTO>, BadRequest>> (KintelaContext db, MenuSemanalDTO menuDto) =>
		{
			DateOnly fechaCreacion;
			if (!DateOnly.TryParse(menuDto.FechaCreacion, out fechaCreacion))
			{
				return TypedResults.BadRequest();  // Devuelve un error si la fecha no es válida
			}
			var menuSemanal = new MenuSemanal
			{
				FechaCreacion = fechaCreacion,
				RecetaPrimerPlatoLunes = menuDto.RecetaPrimerPlatoLunes,
				RecetaSegundoPlatoLunes = menuDto.RecetaSegundoPlatoLunes,
				RecetaCenaLunes = menuDto.RecetaCenaLunes,
				RecetaPrimerPlatoMartes = menuDto.RecetaPrimerPlatoMartes,
				RecetaSegundoPlatoMartes = menuDto.RecetaSegundoPlatoMartes,
				RecetaCenaMartes = menuDto.RecetaCenaMartes,
				RecetaPrimerPlatoMiercoles = menuDto.RecetaPrimerPlatoMiercoles,
				RecetaSegundoPlatoMiercoles = menuDto.RecetaSegundoPlatoMiercoles,
				RecetaCenaMiercoles = menuDto.RecetaCenaMiercoles,
				RecetaPrimerPlatoJueves = menuDto.RecetaPrimerPlatoJueves,
				RecetaSegundoPlatoJueves = menuDto.RecetaSegundoPlatoJueves,
				RecetaCenaJueves = menuDto.RecetaCenaJueves,
				RecetaPrimerPlatoViernes = menuDto.RecetaPrimerPlatoViernes,
				RecetaSegundoPlatoViernes = menuDto.RecetaSegundoPlatoViernes,
				RecetaCenaViernes = menuDto.RecetaCenaViernes,
				RecetaPrimerPlatoSabado = menuDto.RecetaPrimerPlatoSabado,
				RecetaSegundoPlatoSabado = menuDto.RecetaSegundoPlatoSabado,
				RecetaCenaSabado = menuDto.RecetaCenaSabado,
				RecetaPrimerPlatoDomingo = menuDto.RecetaPrimerPlatoDomingo,
				RecetaSegundoPlatoDomingo = menuDto.RecetaSegundoPlatoDomingo,
				RecetaCenaDomingo = menuDto.RecetaCenaDomingo,
				UsuarioId = menuDto.UsuarioId
			};

			db.MenuSemanal.Add(menuSemanal);
			await db.SaveChangesAsync();

			var createdMenuDto = new MenuSemanalDTO(
					menuSemanal.UsuarioId,
					menuSemanal.FechaCreacion.ToShortDateString(),
					menuSemanal.RecetaPrimerPlatoLunes,
					menuSemanal.RecetaSegundoPlatoLunes,
					menuSemanal.RecetaCenaLunes,
					menuSemanal.RecetaPrimerPlatoMartes,
					menuSemanal.RecetaSegundoPlatoMartes,
					menuSemanal.RecetaCenaMartes,
					menuSemanal.RecetaPrimerPlatoMiercoles,
					menuSemanal.RecetaSegundoPlatoMiercoles,
					menuSemanal.RecetaCenaMiercoles,
					menuSemanal.RecetaPrimerPlatoJueves,
					menuSemanal.RecetaSegundoPlatoJueves,
					menuSemanal.RecetaCenaJueves,
					menuSemanal.RecetaPrimerPlatoViernes,
					menuSemanal.RecetaSegundoPlatoViernes,
					menuSemanal.RecetaCenaViernes,
					menuSemanal.RecetaPrimerPlatoSabado,
					menuSemanal.RecetaSegundoPlatoSabado,
					menuSemanal.RecetaCenaSabado,
					menuSemanal.RecetaPrimerPlatoDomingo,
					menuSemanal.RecetaSegundoPlatoDomingo,
					menuSemanal.RecetaCenaDomingo
			);

			return TypedResults.Created($"/api/MenuSemanal/{menuSemanal.MenuSemanalId}", createdMenuDto);
		})
	 .WithName("CreateMenuSemanal")
	 .WithOpenApi();





	}
}
