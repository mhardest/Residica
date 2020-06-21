using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Dominio.Security.Composite
{
	public class Usuario
	{
		public Usuario()
		{
			Permisos = new List<FamiliaComponent>();
		}
		public String Nombre { get; set; }

		public String Pass { get; set; }

		public String CultureInfo { get; set; }

		public List<FamiliaComponent> Permisos { get; set; }
	}
}
