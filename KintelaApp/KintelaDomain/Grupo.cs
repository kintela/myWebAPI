using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KintelaDomain
{
	public class Grupo
	{
        public int GrupoId { get; set; }
        public string Nombre { get; set; }

        public List<Disco> Discos { get; set;}=new List<Disco>();
  }
}
