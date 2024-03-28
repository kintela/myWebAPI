using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KintelaDomain
{
	public class Disco
	{
        public int Id { get; set; }
				public string Nombre { get; set; }
				public int YearPublicacion { get; set; }
				public string Caratula { get; set; }	
				public string Discografica { get; set; }
				public string Productor { get; set; }

        public Grupo Grupo { get; set; }
        public int GrupoId { get; set; }

    }
}
