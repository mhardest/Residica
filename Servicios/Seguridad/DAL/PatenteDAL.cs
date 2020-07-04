using Servicios.Excepciones;
using Servicios.External;
using Servicios.Seguridad.DAL.Sql;
using Servicios.Seguridad.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad.DAL
{
    internal class PatenteDAL
    {
        public static void Insert(Patente _object)
        {
            String spNombre = "Patente_Insert";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdPatente", DataTypes.ToDBNull(_object.IdFamiliaElement)));
            parametros.Add(new SqlParameter("@Nombre", DataTypes.ToDBNull(_object.Nombre)));

            try
            {
                db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spNombre, parametros.ToArray());
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }
        public static void Update(Patente _object)
        {
            String spNombre = "Patente_Update";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdPatente", DataTypes.ToDBNull(_object.IdFamiliaElement)));
            parametros.Add(new SqlParameter("@Nombre", DataTypes.ToDBNull(_object.Nombre)));

            try
            {
                db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spNombre, parametros.ToArray());
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }
        public static void Delete(Patente _object)
        {
            String spNombre = "Patente_Delete";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdPatente", DataTypes.ToDBNull(_object.IdFamiliaElement)));

            try
            {
                db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spNombre, parametros.ToArray());
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }


        public static DataTable Select(string IdFamiliaElement)
        {
            String spNombre = "Patente_Select";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdPatente", DataTypes.ToDBNull(IdFamiliaElement)));

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
            String spNombre = "Patente_SelectAll";

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
