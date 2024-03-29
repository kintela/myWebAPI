using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KintelaDomain
{
	public class Receta
	{
    public int RecetaId { get; set; }
    public string Nombre { get; set; }
    public string[] Ingredientes { get; set; }
		public string[] Preparacion { get; set; }
		public string[] Presentacion { get; set; }
		public int? Comensales { get; set; }
		public string enlaceVideo { get; set; }

    public List<Categoria> Categorias { get; set; } = new List<Categoria>();
    public List<Menu> Menus { get; set; }=new List<Menu>();
   }
}
