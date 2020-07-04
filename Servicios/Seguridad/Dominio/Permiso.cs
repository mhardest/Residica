using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad.Dominio
{
    public abstract class Permiso
    {
        // Propiedades
        private string idFamiliaElemento;
        private string nombreN;

        public abstract int ChildrenCount { get; }

        public string IdFamiliaElement
        {
            get { return idFamiliaElemento; }
            set { idFamiliaElemento = value; }
        }
        public string Nombre
        {
            get { return nombreN; }
            set { nombreN = value; }
        }

        // Metodos
        public Permiso()
        { }

        public abstract void Add(Permiso permiso);
        public abstract void Remove(Permiso permiso);
    }
}
