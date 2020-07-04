using Servicios.Excepciones;
using Servicios.External;
using Servicios.Seguridad.DAL.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad.DAL
{
    public class SectorDAL
    {

        public static DataTable Select(int IdSector)
        {
            string spNombre = "Sector_Select";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdSector", DataTypes.ToDBNull(IdSector)));

            try
            {
                return db.EjecutarDataset(CommandType.StoredProcedure, spNombre, db.TipoBase.ResidicaSeguridad, parametros.ToArray()).Tables[0];
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }

        public static DataTable SelectAll()
        {
            string spNombre = "Sector_SelectAll";
            try
            {
                return db.EjecutarDataset(CommandType.StoredProcedure, spNombre, db.TipoBase.ResidicaSeguridad, null).Tables[0];
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }
    }
}
