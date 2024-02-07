using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KintelaDomain
{
	public class Receta
	{
		public int Id { get; set; }
    public string[] Ingredientes { get; set; }
		public string[] Preparacion { get; set; }
		public string[] Presentacion { get; set; }
		public int Comensales { get; set; }
		public string enlaceVideo { get; set; }		
		Plato Plato { get; set; }
    public int PlatoId { get; set; }
   }
}
