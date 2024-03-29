using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KintelaDomain
{
	public class Categoria
	{
    public int CategoriaId { get; set; }
    public string Nombre { get; set; }
    public List<Receta> Recetas { get; set; }=new List<Receta>();

  }
}
