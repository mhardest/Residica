using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Dominio.Security.Composite
{
	public abstract class FamiliaComponent
	{
		public String Nombre { get; set; }

		public FamiliaComponent()
		{

		}

		public abstract void Add(FamiliaComponent component);

		public abstract void Remove(FamiliaComponent component);

		public abstract int GetChilds();
	}

}
