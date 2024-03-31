using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KintelaDomain
{
	public class Usuario
	{
		public int UsuarioId { get; set; }
		public string Nombre { get; set; }
		public string Apellidos { get; set; }
		public string Email { get; set; }	
		public string PasswordHash { get; set; }
    public DateTime FechaAlta { get; set; }
		public DateTime? FechaBaja { get; set; }

		public List<MenuSemanal> Menus { get; set; }=new List<MenuSemanal>();
  }
}
