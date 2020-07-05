using Servicios.External;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Multioma.Domain
{
    public class IdiomaDM
    {
        public int IdIdioma { get; set; }
        public string Descripcion { get; set; }

        public IdiomaDM()
        {
            this.IdIdioma = DataTypes.IntNull;
            this.Descripcion = DataTypes.StringNull;
        }

        public IdiomaDM(int idIdioma, string descripcion)
        {
            IdIdioma = IdIdioma;
            Descripcion = descripcion;
        }
    }
}

