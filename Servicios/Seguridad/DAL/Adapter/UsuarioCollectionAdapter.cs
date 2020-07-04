using Servicios.Seguridad.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad.DAL.Adapter
{
    public class UsuarioCollectionAdapter
    {
        public UsuarioCollectionAdapter(DataTable datosDT)
        {
            this.datosDT = datosDT;
        }

        public void Fill(List<Usuario> collection)
        {
            foreach (DataRow row in this.datosDT.Rows)
            {
                Usuario _object = new Usuario();
                UsuarioAdapter adapter = new UsuarioAdapter(row);
                adapter.Fill(_object);
                collection.Add(_object);
            }
        }

        // Fields
        private DataTable datosDT;
    }
}
