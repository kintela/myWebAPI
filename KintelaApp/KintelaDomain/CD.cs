using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KintelaDomain
{
	public class CD
	{
    public int CDId { get; set; }
		public string Titulo { get; set; }			
		public int? YearPublicacion { get; set; }
		public bool? IsInSpotify { get; set; }
		public int Etiqueta { get; set; }
		public string caratula { get; set; }
		public bool? Firmado { get; set; }


		public Grupo Grupo { get; set; }
    public int GrupoId { get; set; }
	}
}
