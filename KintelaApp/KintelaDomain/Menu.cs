using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KintelaDomain
{
	public class Menu
	{
        public Menu()
        {
            Recetas = new List<Receta>();
        }
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public List<Receta> Recetas { get; set; }
    }
}
