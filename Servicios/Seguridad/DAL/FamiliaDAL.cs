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
    internal class FamiliaDAL
    {
        public static void Insert(Familia _object)
        {
            try
            {

                string spNombre = "Familia_Insert";
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@IdFamilia", DataTypes.ToDBNull(_object.IdFamiliaElement)));
                parametros.Add(new SqlParameter("@Nombre", DataTypes.ToDBNull(_object.Nombre)));
                db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spNombre, parametros.ToArray());

                if (((_object.Permisos != null)))
                {
                    FamiliaDAL.DeleteAccesos(_object);
                    Familia_PatenteDAL.DeleteAccesos(_object);

                    foreach (Permiso _tipo in _object.Permisos)
                    {

                        if ((_tipo.GetType().Name == "Familia"))
                        {
                            String spFamilia_Familia_insert = "Familia_Familia_Insert";
                            List<SqlParameter> paramsFamilia_Familia_insert = new List<SqlParameter>();
                            parametros.Add(new SqlParameter("@IdFamilia", DataTypes.ToDBNull(_object.IdFamiliaElement)));
                            parametros.Add(new SqlParameter("@IdFamiliaHijo", DataTypes.ToDBNull(_tipo.IdFamiliaElement)));
                            db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spFamilia_Familia_insert, paramsFamilia_Familia_insert.ToArray());

                        }
                        else
                        {
                            String spFamilia_Patente_insert = "Familia_Patente_Insert";
                            List<SqlParameter> paramsFamilia_Patente_insert = new List<SqlParameter>();
                            parametros.Add(new SqlParameter("@IdFamilia", DataTypes.ToDBNull(_object.IdFamiliaElement)));
                            parametros.Add(new SqlParameter("@IdPatente", DataTypes.ToDBNull(_tipo.IdFamiliaElement)));
                            db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spFamilia_Patente_insert, paramsFamilia_Patente_insert.ToArray());
                        }
                    }
                }
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }

        public static void Update(Familia _object)
        {
            try
            {
                string spNombre = "Familia_Update";
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@IdFamilia", DataTypes.ToDBNull(_object.IdFamiliaElement)));
                parametros.Add(new SqlParameter("@Nombre", DataTypes.ToDBNull(_object.Nombre)));
                db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spNombre, parametros.ToArray());

                if (((_object.Permisos != null)))
                {
                    FamiliaDAL.DeleteAccesos(_object);
                    Familia_PatenteDAL.DeleteAccesos(_object);

                    foreach (Permiso _tipo in _object.Permisos)
                    {
                        if ((_tipo.GetType().Name == "Familia"))
                        {
                            String spFamilia_Familia_insert = "Familia_Familia_Insert";
                            List<SqlParameter> paramsFamilia_Familia_Insert = new List<SqlParameter>();
                            parametros.Add(new SqlParameter("@IdFamilia", DataTypes.ToDBNull(_object.IdFamiliaElement)));
                            parametros.Add(new SqlParameter("@IdFamiliaHijo", DataTypes.ToDBNull(_tipo.Nombre)));
                            db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spFamilia_Familia_insert, paramsFamilia_Familia_Insert.ToArray());
                        }
                        else
                        {
                            String spFamilia_Patente_insert = "Familia_Patente_Insert";
                            List<SqlParameter> paramsFamilia_Patente_Insert = new List<SqlParameter>();
                            parametros.Add(new SqlParameter("@IdFamilia", DataTypes.ToDBNull(_object.IdFamiliaElement)));
                            parametros.Add(new SqlParameter("@IdPatente", DataTypes.ToDBNull(_tipo.IdFamiliaElement)));
                            db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spFamilia_Patente_insert, paramsFamilia_Patente_Insert.ToArray());
                        }
                    }
                }
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }

        public static void Delete(Familia _object)
        {
            if (((_object.Permisos != null)))
            {
                FamiliaDAL.DeleteAccesos(_object);
            }

            string spNombre = "Familia_Delete";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdFamilia", DataTypes.ToDBNull(_object.IdFamiliaElement)));

            try
            {
                db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spNombre, parametros.ToArray());
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }

        public static void DeleteAccesos(Familia _object)
        {
            string spNombre = "Familia_Familia_DeleteParticular";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdFamilia", DataTypes.ToDBNull(_object.IdFamiliaElement)));

            try
            {
                db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spNombre, parametros.ToArray());
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }

        public static DataTable GetAccesos(string IdFamiliaElement)
        {
            string spNombre = "Familia_Familia_SelectParticular";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdFamilia", DataTypes.ToDBNull(IdFamiliaElement)));

            try
            {
                return db.EjecutarDataset(CommandType.StoredProcedure, spNombre, db.TipoBase.ResidicaSeguridad, parametros.ToArray()).Tables[0];
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }

        public static DataTable Select(string IdFamiliaElement)
        {
            string spNombre = "Familia_Select";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdFamilia", DataTypes.ToDBNull(IdFamiliaElement)));

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
            try
            {
                string spNombre = "Familia_SelectAll";
                return db.EjecutarDataset(CommandType.StoredProcedure, spNombre, db.TipoBase.ResidicaSeguridad, null).Tables[0];
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }
    }
}
