using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad.Dominio
{
    public class Familia : Permiso
    {
        // Fields
        private List<Permiso> _accesos = new List<Permiso>();

        // Properties
        public List<Permiso> Permisos
        {
            get { return this._accesos; }
            set { this._accesos = value; }
        }

        public override int ChildrenCount
        {
            get { return this.Permisos.Count; }
        }

        // Methods
        public override void Add(Permiso permiso)
        {
            this._accesos.Add(permiso);
        }

        public override void Remove(Permiso permiso)
        {
            this._accesos.Remove(permiso);
        }
    }
}
