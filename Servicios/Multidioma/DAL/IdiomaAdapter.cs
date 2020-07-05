using Servicios.Multioma.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Multioma.DAL
{
    public class IdiomaAdapter
    {
        // Fields
        private DataRow row;

        public IdiomaAdapter(DataRow row)
        {
            this.row = row;
        }

        public void Fill(IdiomaDM _object)
        {
            _object.IdIdioma = (Convert.ToInt32(this.row["IdIdioma"]));
            _object.Descripcion = (Convert.ToString(this.row["Descripcion"]));
        }
    }
}
