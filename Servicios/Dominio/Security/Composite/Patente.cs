using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Dominio.Security.Composite
{
	public class Patente : FamiliaComponent
	{
		public override void Add(FamiliaComponent component)
		{
			throw new Exception("No se pueden agregar elementos...");
		}

		public override int GetChilds()
		{
			return 0;
		}

		public override void Remove(FamiliaComponent component)
		{
			throw new Exception("No se pueden quitar elementos...");
		}
	}
}
