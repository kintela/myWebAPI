using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KintelaDomain
{
	public class MenuSemanal
	{
      public int MenuSemanalId { get; set; }
      public DateOnly FechaCreacion { get; set; }

      public int? RecetaPrimerPlatoLunes { get; set; }
		  public int? RecetaSegundoPlatoLunes { get; set; }
      public int? RecetaPostreLunes { get; set; }
		  public int? RecetaCenaLunes { get; set; }

		  public int? RecetaPrimerPlatoMartes { get; set; }
      public int? RecetaSegundoPlatoMartes { get; set; }
      public int? RecetaPostreMartes { get; set; }
      public int? RecetaCenaMartes { get; set; }

      public int? RecetaPrimerPlatoMiercoles { get; set; }
      public int? RecetaSegundoPlatoMiercoles { get; set; }
      public int? RecetaPostreMiercoles { get; set; }
		  public int? RecetaCenaMiercoles { get; set; }

		  public int? RecetaPrimerPlatoJueves { get; set; }
      public int? RecetaSegundoPlatoJueves { get; set; }
      public int? RecetaPostreJueves { get; set; }
		  public int? RecetaCenaJueves { get; set; }

		  public int? RecetaPrimerPlatoViernes { get; set; }
      public int? RecetaSegundoPlatoViernes { get; set; }
      public int? RecetaPostreViernes { get; set; }
		  public int? RecetaCenaViernes { get; set; }

		  public int? RecetaPrimerPlatoSabado { get; set; }
      public int? RecetaSegundoPlatoSabado { get; set; }
      public int? RecetaPostreSabado { get; set; }
      public int? RecetaCenaSabado { get; set; }

      public int? RecetaPrimerPlatoDomingo { get; set; }
      public int? RecetaSegundoPlatoDomingo { get; set; }
      public int? RecetaPostreDomingo { get; set; }
      public int? RecetaCenaDomingo { get; set; }

		  public Usuario Usuario { get; set; }
      public int UsuarioId { get; set; }

      public List<Receta> Recetas { get; set; } = new List<Receta>();
  }
}
