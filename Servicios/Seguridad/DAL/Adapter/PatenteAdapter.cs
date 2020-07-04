using Servicios.Seguridad.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad.DAL.Adapter
{
    public class PatenteAdapter
    {
        // Methods
        public PatenteAdapter(DataRow row)
        {
            this.row = row;
        }

        public void Fill(Patente _object)
        {
            _object.IdFamiliaElement = (Convert.ToString(this.row["IdPatente"]));
            _object.Nombre = (Convert.ToString(this.row["Nombre"]));
        }


        // Fields
        private DataRow row;
    }
}
