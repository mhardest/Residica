using Servicios.Seguridad.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad.DAL.Adapter
{
    public class FamiliaCollectionAdapter
    {
        // Methods
        public FamiliaCollectionAdapter(DataTable datosDT)
        {
            this.datosDT = datosDT;
        }

        public void Fill(List<Familia> collection)
        {

            foreach (DataRow row in this.datosDT.Rows)
            {
                Familia _object = new Familia();
                FamiliaAdapter adapter = new FamiliaAdapter(row);
                adapter.Fill(_object);
                collection.Add(_object);
            }
        }


        // Fields
        private DataTable datosDT;
    }
}
