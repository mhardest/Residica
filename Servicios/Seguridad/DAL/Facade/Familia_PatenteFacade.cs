using Servicios.Excepciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad.DAL.Facade
{
    public class Familia_PatenteFacade
    {
        // Methods
        public static DataRow Select(string IdFamiliaElement)
        {
            DataRow varDataTable;
            try
            {
                return varDataTable = Familia_PatenteDAL.Select(IdFamiliaElement).Rows[0];
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }
    }
}
