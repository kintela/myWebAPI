namespace KintelaAPI.DTOs
{
	public class MenuSemanalDTO
	{

    public MenuSemanalDTO(int? menuSemanalId,int usuarioId,string fechaCreacion,int?recetaPrimerPlatoLunes, int? recetaSegundoPlatoLunes, int? recetaCenaLunes, int? recetaPrimerPlatoMartes,
			int? recetaSegundoPlatoMartes, int? recetaCenaMartes, int? recetaPrimerPlatoMiercoles, int? recetaSegundoPlatoMiercoles, int? recetaCenaMiercoles,
			int? recetaPrimerPlatoJueves, int? recetaSegundoPlatoJueves, int? recetaCenaJueves, int? recetaPrimerPlatoViernes, int? recetaSegundoPlatoViernes, int? recetaCenaViernes,
			int? recetaPrimerPlatoSabado, int? recetaSegundoPlatoSabado, int? recetaCenaSabado, int? recetaPrimerPlatoDomingo, int? recetaSegundoPlatoDomingo, int? recetaCenaDomingo)
    {
			MenuSemanalId = menuSemanalId;
			UsuarioId = usuarioId;
			FechaCreacion = fechaCreacion;
			RecetaPrimerPlatoLunes = recetaPrimerPlatoLunes;
			RecetaSegundoPlatoLunes = recetaSegundoPlatoLunes;
			RecetaCenaLunes = recetaCenaLunes;
			RecetaPrimerPlatoMartes = recetaPrimerPlatoMartes;
			RecetaSegundoPlatoMartes = recetaSegundoPlatoMartes;
			RecetaCenaMartes = recetaCenaMartes;
			RecetaPrimerPlatoMiercoles = recetaPrimerPlatoMiercoles;
			RecetaSegundoPlatoMiercoles = recetaSegundoPlatoMiercoles;
			RecetaCenaMiercoles = recetaCenaMiercoles;
			RecetaPrimerPlatoJueves = recetaPrimerPlatoJueves;
			RecetaSegundoPlatoJueves = recetaSegundoPlatoJueves;
			RecetaCenaJueves = recetaCenaJueves;
			RecetaPrimerPlatoViernes = recetaPrimerPlatoViernes;
			RecetaSegundoPlatoViernes = recetaSegundoPlatoViernes;
			RecetaCenaViernes = recetaCenaViernes;
			RecetaPrimerPlatoSabado = recetaPrimerPlatoSabado;
			RecetaSegundoPlatoSabado = recetaSegundoPlatoSabado;
			RecetaCenaSabado = recetaCenaSabado;
			RecetaPrimerPlatoDomingo = recetaPrimerPlatoDomingo;
			RecetaSegundoPlatoDomingo = recetaSegundoPlatoDomingo;
			RecetaCenaDomingo = recetaCenaDomingo;

    }

		public int? MenuSemanalId { get; init; }
		public int UsuarioId { get; init; }
		public string FechaCreacion { get; init; }

		public int? RecetaPrimerPlatoLunes { get; init; }
		public int? RecetaSegundoPlatoLunes { get; init; }
		public int? RecetaCenaLunes { get; init; }

		public int? RecetaPrimerPlatoMartes { get; init; }
		public int? RecetaSegundoPlatoMartes { get; init; }
		public int? RecetaCenaMartes { get; init; }

		public int? RecetaPrimerPlatoMiercoles { get; init; }
		public int? RecetaSegundoPlatoMiercoles { get; init; }
		public int? RecetaCenaMiercoles { get; init; }

		public int? RecetaPrimerPlatoJueves { get; init; }
		public int? RecetaSegundoPlatoJueves { get; init; }
		public int? RecetaCenaJueves { get; init; }

		public int? RecetaPrimerPlatoViernes { get; init; }
		public int? RecetaSegundoPlatoViernes { get; init; }
		public int? RecetaCenaViernes { get; init; }

		public int? RecetaPrimerPlatoSabado { get; init; }
		public int? RecetaSegundoPlatoSabado { get; init; }
		public int? RecetaCenaSabado { get; init; }

		public int? RecetaPrimerPlatoDomingo { get; init; }
		public int? RecetaSegundoPlatoDomingo { get; init; }
		public int? RecetaCenaDomingo { get; init; }
	}
}
