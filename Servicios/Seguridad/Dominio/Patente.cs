using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad.Dominio
{
    public class Patente : Permiso
    {
        // Methods
        public override void Add(Permiso permiso)
        {
            throw new Exception("No se puede agregar una patente");
        }

        public override void Remove(Permiso permiso)
        {
            throw new Exception("No se puede eliminar una patente");
        }

        // Properties
        public override int ChildrenCount
        {
            get { return 0; }
        }
    }
}
