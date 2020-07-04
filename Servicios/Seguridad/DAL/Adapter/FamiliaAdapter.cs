using Servicios.Seguridad.DAL.Facade;
using Servicios.Seguridad.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad.DAL.Adapter
{
    public class FamiliaAdapter
    {
        // Methods
        public FamiliaAdapter(DataRow row)
        {
            this.row = row;
        }

        public void Fill(Familia _object)
        {
            _object.IdFamiliaElement = (Convert.ToString(this.row["IdFamilia"]));
            _object.Nombre = (Convert.ToString(this.row["Nombre"]));
            DataTable relacionesFamilia = FamiliaDAL.GetAccesos(_object.IdFamiliaElement);


            foreach (DataRow rowAccesos in relacionesFamilia.Rows)
            {
                _object.Add(FamiliaFacade.GetAdapted(Convert.ToString(rowAccesos["IdFamiliaHijo"])));
            }

            DataTable relacionesPatentes = Familia_PatenteDAL.GetAccesos(_object.IdFamiliaElement);

            foreach (DataRow rowAccesos in relacionesPatentes.Rows)
            {
                _object.Add(PatenteFacade.GetAdapted(Convert.ToString(rowAccesos["IdPatente"])));
            }
        }
        // Fields
        private DataRow row;
    }
}
