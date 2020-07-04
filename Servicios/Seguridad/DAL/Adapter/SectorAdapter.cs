using Servicios.Seguridad.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad.DAL.Adapter
{
    public class SectorAdapter
    {
        // Fields
        private DataRow row;

        public SectorAdapter(DataRow row)
        {
            this.row = row;
        }

        public void FillID(Sector _object)
        {
            _object.IdSector = (Convert.ToInt32(this.row[0]));
        }

        public void Fill(Sector _object)
        {
            _object.IdSector = Convert.ToInt32(this.row["IdSector"]);
            _object.Descripcion = Convert.ToString(this.row["Descripcion"]);

        }
    }
}
