using Servicios.Seguridad.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad.DAL.Adapter
{
    public class SectorCollectionAdapter
    {
        public SectorCollectionAdapter(DataTable datosDT)
        {
            this.datosDT = datosDT;
        }

        public void Fill(List<Sector> collection)
        {

            foreach (DataRow row in this.datosDT.Rows)
            {
                Sector _object = new Sector();
                SectorAdapter adapter = new SectorAdapter(row);
                adapter.Fill(_object);
                collection.Add(_object);
            }
        }

        // Fields
        private DataTable datosDT;

    }
}
