using Servicios.Multioma.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Multioma.DAL
{
    public class IdiomaCollectionAdapter
    {
        // Fields
        private DataTable datosDT;
        public IdiomaCollectionAdapter(DataTable datosDT)
        {
            this.datosDT = datosDT;
        }

        public void Fill(List<IdiomaDM> collection)
        {
            foreach (DataRow row in this.datosDT.Rows)
            {
                IdiomaDM _object = new IdiomaDM();
                IdiomaAdapter adapter = new IdiomaAdapter(row);
                adapter.Fill(_object);
                collection.Add(_object);
            }
        }
    }
}
