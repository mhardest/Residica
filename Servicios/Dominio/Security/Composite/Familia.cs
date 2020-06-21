using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Dominio.Security.Composite
{
	public class Familia : FamiliaComponent
	{
		public List<FamiliaComponent> Permisos { get; set; }

		public Familia()
		{
			Permisos = new List<FamiliaComponent>();
		}

		public override void Add(FamiliaComponent component)
		{
			Permisos.Add(component);
		}

		public override int GetChilds()
		{
			return Permisos.Count;
		}

		public override void Remove(FamiliaComponent component)
		{
			Permisos.RemoveAll(o => o.Nombre == component.Nombre); //SÍ FUNCIONA!!!
		}
	}
}
