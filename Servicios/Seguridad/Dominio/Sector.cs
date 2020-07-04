using Servicios.External;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad.Dominio
{
    public class Sector
    {
        public int IdSector { get; set; }

        public string Descripcion { get; set; }



        public Sector()
        {
            IdSector = DataTypes.IntNull;
            Descripcion = DataTypes.StringNull;

        }

        public Sector(string descripcion)
        {
            Descripcion = descripcion;

        }
    }
}

