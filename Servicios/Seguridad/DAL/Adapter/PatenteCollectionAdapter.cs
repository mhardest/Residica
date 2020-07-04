using Servicios.Seguridad.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad.DAL.Adapter
{
    public class PatenteCollectionAdapter
    {
        // Methods
        public PatenteCollectionAdapter(DataTable datosDT)
        {
            this.datosDT = datosDT;
        }

        public void Fill(List<Patente> collection)
        {

            foreach (DataRow row in this.datosDT.Rows)
            {
                Patente _object = new Patente();
                PatenteAdapter adapter = new PatenteAdapter(row);
                adapter.Fill(_object);
                collection.Add(_object);
            }
        }


        // Fields
        private DataTable datosDT;
    }
}
