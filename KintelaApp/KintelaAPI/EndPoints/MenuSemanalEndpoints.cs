using Microsoft.EntityFrameworkCore;
using KintelaData;
using KintelaDomain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using KintelaAPI.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
namespace KintelaAPI.EndPoints;

public class ErrorResponse
{
	public string Error { get; set; }
}


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

		group.MapGet("/exists", async Task<Results<Ok<bool>, BadRequest>> (KintelaContext db, [FromQuery] int usuarioId, [FromQuery(Name = "fecha")] string fechaCreacionStr) =>
		{
			if (!DateOnly.TryParse(fechaCreacionStr, out DateOnly fechaCreacion))
			{
				return TypedResults.BadRequest();
			}

			// Calcula el inicio y el final de la semana para la fecha proporcionada
			var startOfWeek = fechaCreacion.AddDays(-(int)fechaCreacion.DayOfWeek);
			var endOfWeek = startOfWeek.AddDays(6);

			// Verifica si hay algún registro en la base de datos dentro de ese rango de fechas
			var exists = await db.MenuSemanal.AnyAsync(m => m.FechaCreacion >= startOfWeek && m.FechaCreacion <= endOfWeek && m.UsuarioId == usuarioId);

			return TypedResults.Ok(exists);
		})
			.WithName("CheckMenuExists")
			.WithOpenApi();


		group.MapGet("/currentWeek/{usuarioId}", async Task<Results<Ok<MenuSemanalDTO>, NotFound>> (
			KintelaContext db, 
			[FromRoute] int usuarioId) =>
		{
			var today = DateOnly.FromDateTime(DateTime.Today);
			var startOfWeek = today.AddDays(-(int)today.DayOfWeek);
			var endOfWeek = startOfWeek.AddDays(6);

			var menu = await db.MenuSemanal
					.Where(m => m.FechaCreacion >= startOfWeek && m.FechaCreacion <= endOfWeek && m.UsuarioId == usuarioId)
					.OrderBy(m => m.FechaCreacion)
					.Select(model => new MenuSemanalDTO(
							model.UsuarioId,
							model.FechaCreacion.ToShortDateString(),
							model.RecetaPrimerPlatoLunes,
							model.RecetaSegundoPlatoLunes,
							model.RecetaCenaLunes,
							model.RecetaPrimerPlatoMartes,
							model.RecetaSegundoPlatoMartes,
							model.RecetaCenaMartes,
							model.RecetaPrimerPlatoMiercoles,
							model.RecetaSegundoPlatoMiercoles,
							model.RecetaCenaMiercoles,
							model.RecetaPrimerPlatoJueves,
							model.RecetaSegundoPlatoJueves,
							model.RecetaCenaJueves,
							model.RecetaPrimerPlatoViernes,
							model.RecetaSegundoPlatoViernes,
							model.RecetaCenaViernes,
							model.RecetaPrimerPlatoSabado,
							model.RecetaSegundoPlatoSabado,
							model.RecetaCenaSabado,
							model.RecetaPrimerPlatoDomingo,
							model.RecetaSegundoPlatoDomingo,
							model.RecetaCenaDomingo))
					.FirstOrDefaultAsync();

			return menu != null
					? TypedResults.Ok(menu)
					: TypedResults.NotFound();
		})
			.WithName("GetCurrentWeekMenuSemanal")
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

		group.MapPut("/{usuarioId}/{fechaCreacionStr}", async Task<Results<Ok<MenuSemanalDTO>, NotFound, BadRequest<ErrorResponse>>> (
			KintelaContext db,
			[FromRoute] int usuarioId,
			[FromRoute] string fechaCreacionStr,
			[FromBody] MenuSemanalDTO menuDto) =>
			{				

				if (!DateOnly.TryParseExact(fechaCreacionStr, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateOnly fechaCreacion))
				{
					return TypedResults.BadRequest(new ErrorResponse { Error = "Formato de fecha inválido." });
				}

				// Calcula el inicio y el final de la semana para la fecha proporcionada
				var startOfWeek = fechaCreacion.AddDays(-(int)fechaCreacion.DayOfWeek);
				var endOfWeek = startOfWeek.AddDays(6);

				// Busca el registro en la base de datos dentro de ese rango de fechas
				var existingMenu = await db.MenuSemanal
						.AsTracking()
						.FirstOrDefaultAsync(m => m.FechaCreacion >= startOfWeek && m.FechaCreacion <= endOfWeek && m.UsuarioId == usuarioId);

				if (existingMenu == null)
				{
					return TypedResults.NotFound();
				}


				// Update properties
				existingMenu.RecetaPrimerPlatoLunes = menuDto.RecetaPrimerPlatoLunes;
				existingMenu.RecetaSegundoPlatoLunes = menuDto.RecetaSegundoPlatoLunes;
				existingMenu.RecetaCenaLunes = menuDto.RecetaCenaLunes;
				existingMenu.RecetaPrimerPlatoMartes = menuDto.RecetaPrimerPlatoMartes;
				existingMenu.RecetaSegundoPlatoMartes = menuDto.RecetaSegundoPlatoMartes;
				existingMenu.RecetaCenaMartes = menuDto.RecetaCenaMartes;
				existingMenu.RecetaPrimerPlatoMiercoles = menuDto.RecetaPrimerPlatoMiercoles;
				existingMenu.RecetaSegundoPlatoMiercoles = menuDto.RecetaSegundoPlatoMiercoles;
				existingMenu.RecetaCenaMiercoles = menuDto.RecetaCenaMiercoles;
				existingMenu.RecetaPrimerPlatoJueves = menuDto.RecetaPrimerPlatoJueves;
				existingMenu.RecetaSegundoPlatoJueves = menuDto.RecetaSegundoPlatoJueves;
				existingMenu.RecetaCenaJueves = menuDto.RecetaCenaJueves;
				existingMenu.RecetaPrimerPlatoViernes = menuDto.RecetaPrimerPlatoViernes;
				existingMenu.RecetaSegundoPlatoViernes = menuDto.RecetaSegundoPlatoViernes;
				existingMenu.RecetaCenaViernes = menuDto.RecetaCenaViernes;
				existingMenu.RecetaPrimerPlatoSabado = menuDto.RecetaPrimerPlatoSabado;
				existingMenu.RecetaSegundoPlatoSabado = menuDto.RecetaSegundoPlatoSabado;
				existingMenu.RecetaCenaSabado = menuDto.RecetaCenaSabado;
				existingMenu.RecetaPrimerPlatoDomingo = menuDto.RecetaPrimerPlatoDomingo;
				existingMenu.RecetaSegundoPlatoDomingo = menuDto.RecetaSegundoPlatoDomingo;
				existingMenu.RecetaCenaDomingo = menuDto.RecetaCenaDomingo;


				await db.SaveChangesAsync();

				var updatedMenuDto = new MenuSemanalDTO(
						existingMenu.UsuarioId,
						existingMenu.FechaCreacion.ToShortDateString(),
						existingMenu.RecetaPrimerPlatoLunes,
						existingMenu.RecetaSegundoPlatoLunes,
						existingMenu.RecetaCenaLunes,
						existingMenu.RecetaPrimerPlatoMartes,
						existingMenu.RecetaSegundoPlatoMartes,
						existingMenu.RecetaCenaMartes,
						existingMenu.RecetaPrimerPlatoMiercoles,
						existingMenu.RecetaSegundoPlatoMiercoles,
						existingMenu.RecetaCenaMiercoles,
						existingMenu.RecetaPrimerPlatoJueves,
						existingMenu.RecetaSegundoPlatoJueves,
						existingMenu.RecetaCenaJueves,
						existingMenu.RecetaPrimerPlatoViernes,
						existingMenu.RecetaSegundoPlatoViernes,
						existingMenu.RecetaCenaViernes,
						existingMenu.RecetaPrimerPlatoSabado,
						existingMenu.RecetaSegundoPlatoSabado,
						existingMenu.RecetaCenaSabado,
						existingMenu.RecetaPrimerPlatoDomingo,
						existingMenu.RecetaSegundoPlatoDomingo,
						existingMenu.RecetaCenaDomingo
				);

				return TypedResults.Ok(updatedMenuDto);
			})
			.WithName("UpdateMenuSemanal")
			.WithOpenApi();

			



	}
}
