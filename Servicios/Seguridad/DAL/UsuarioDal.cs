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
    internal class UsuarioDAL
    {
        public static int Bloquear(string NombreUsuario)
        {
            string spNombre = "Usuario_Bloquear";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@NombreUsuario", DataTypes.ToDBNull(NombreUsuario)));

            try
            {
                return db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spNombre, parametros.ToArray());
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }
        public static bool Existe(string NombreUsuario)
        {
            DataSet ds = null;
            string spNombre = "Usuario_Existe";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@NombreUsuario", DataTypes.ToDBNull(NombreUsuario)));

            try
            {
                ds = db.EjecutarDataset(CommandType.StoredProcedure, spNombre, db.TipoBase.ResidicaSeguridad, parametros.ToArray());

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                    return true;
                else
                    return false;

            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }

        public static bool ExisteByDocumento(string numerodocumento)
        {
            DataSet ds = null;
            string spNombre = "Usuario_ExisteByDocumento";
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@NumeroDocumento", DataTypes.ToDBNull(numerodocumento)));

            try
            {
                ds = db.EjecutarDataset(CommandType.StoredProcedure, spNombre, db.TipoBase.ResidicaSeguridad, parametros.ToArray());

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                    return true;
                else
                    return false;

            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }


        public static bool Bloqueado(string NombreUsuario)
        {
            DataSet ds = null;
            string spNombre = "Usuario_Bloqueado";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@NombreUsuario", DataTypes.ToDBNull(NombreUsuario)));

            try
            {
                ds = db.EjecutarDataset(CommandType.StoredProcedure, spNombre, db.TipoBase.ResidicaSeguridad, parametros.ToArray());

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                    return true;
                else
                    return false;

            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }
        public static int Validar(string NombreUsuario, string Password)
        {
            string spNombre = "Usuario_Validar";
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter retVal = new SqlParameter("RetVal", SqlDbType.Int);
            retVal.Direction = ParameterDirection.ReturnValue;
            parametros.Add(new SqlParameter("@NombreUsuario", DataTypes.ToDBNull(NombreUsuario)));
            parametros.Add(new SqlParameter("@Password", DataTypes.ToDBNull(Password)));
            parametros.Add(retVal);

            try
            {
                db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spNombre, parametros.ToArray());
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
            return Convert.ToInt32(retVal.Value);
        }
        public static int Insert(Usuario _object)
        {
            string spNombre = "Usuario_Insert";
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter retVal = new SqlParameter("RetVal", SqlDbType.Int);
            retVal.Direction = ParameterDirection.ReturnValue;

            parametros.Add(new SqlParameter("@NombreUsuario", DataTypes.ToDBNull(_object.NombreUsuario)));
            parametros.Add(new SqlParameter("@NumeroDocumento", DataTypes.ToDBNull(_object.NumeroDocumento)));
            parametros.Add(new SqlParameter("@NombreCompleto", DataTypes.ToDBNull(_object.NombreCompleto)));
            parametros.Add(new SqlParameter("@IdSector", DataTypes.ToDBNull(_object.Sector.IdSector)));
            parametros.Add(new SqlParameter("@Password", DataTypes.ToDBNull(_object.Password)));
            parametros.Add(new SqlParameter("@IdIdioma", DataTypes.ToDBNull(_object.IdIdioma)));
            parametros.Add(new SqlParameter("@DigitoVerificador", DataTypes.ToDBNull(_object.DigitoVerificador)));
            parametros.Add(new SqlParameter("@Estado", DataTypes.ToDBNull(_object.Estado)));

            parametros.Add(retVal);

            try
            {
                db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spNombre, parametros.ToArray());
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
            return Convert.ToInt32(retVal.Value);
        }
        public static int Update(Usuario _object)
        {
            try
            {
                string spNombre = "Usuario_Update";
                List<SqlParameter> parametros = new List<SqlParameter>();

                parametros.Add(new SqlParameter("@IdUsuario", DataTypes.ToDBNull(_object.IdUsuario)));
                parametros.Add(new SqlParameter("@NombreUsuario", DataTypes.ToDBNull(_object.NombreUsuario)));
                parametros.Add(new SqlParameter("@NumeroDocumento", DataTypes.ToDBNull(_object.NumeroDocumento)));
                parametros.Add(new SqlParameter("@NombreCompleto", DataTypes.ToDBNull(_object.NombreCompleto)));
                parametros.Add(new SqlParameter("@IdSector", DataTypes.ToDBNull(_object.Sector.IdSector)));
                parametros.Add(new SqlParameter("@IdIdioma", DataTypes.ToDBNull(_object.IdIdioma)));


                return db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spNombre, parametros.ToArray());
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }

            //if (_object.Permisos != null)
            //{
            //    UsuarioDal.DeleteFamilias(_object);
            //    UsuarioDal.DeletePatentes(_object);

            //    foreach (FamiliaElement _tipo in _object.Permisos)
            //    {
            //        if ((_tipo.GetType().Name == "Grupo"))
            //        {
            //            String sp_Familia_Insert = "Usuario_Familia_Insert";
            //            List<SqlParameter> params_Familia_Insert = new List<SqlParameter>();
            //            params_Familia_Insert.Add(new SqlParameter("@IdUsuario", DataTypes.ToDBNull(_object.IdUsuario)));
            //            params_Familia_Insert.Add(new SqlParameter("@IdFamilia", DataTypes.ToDBNull(_tipo.IdFamiliaElement)));
            //            db.EjecutarConsulta(db.TipoBase.PoligonoSeguridad, CommandType.StoredProcedure, sp_Familia_Insert, params_Familia_Insert.ToArray());
            //        }
            //        else
            //        {
            //            String sp_Patente_Insert = "Usuario_Patente_Insert";
            //            List<SqlParameter> params_Patente_Insert = new List<SqlParameter>();
            //            params_Patente_Insert.Add(new SqlParameter("@IdUsuario", DataTypes.ToDBNull(_object.IdUsuario)));
            //            params_Patente_Insert.Add(new SqlParameter("@IdPatente", DataTypes.ToDBNull(_tipo.IdFamiliaElement)));
            //            db.EjecutarConsulta(db.TipoBase.PoligonoSeguridad, CommandType.StoredProcedure, sp_Patente_Insert, params_Patente_Insert.ToArray());
            //        }
            //    }
            //}
        }

        public static int Update_Desbloqueo(Usuario _object)
        {
            try
            {
                string spNombre = "Usuario_UpdatePasswordByIdUsuario";
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@IdUsuario", DataTypes.ToDBNull(_object.IdUsuario)));
                parametros.Add(new SqlParameter("@Password", DataTypes.ToDBNull(_object.Password)));
                parametros.Add(new SqlParameter("@Estado", DataTypes.ToDBNull(_object.Estado)));
                return db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spNombre, parametros.ToArray());
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }

        public static int Delete(Usuario _object)
        {
            if (_object.Permisos != null)
            {
                UsuarioDAL.DeleteFamilias(_object);
                UsuarioDAL.DeletePatentes(_object);
            }

            string spNombre = "Usuario_Delete";

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdUsuario", DataTypes.ToDBNull(_object.IdUsuario)));
            // parametros.Add(retVal);

            try
            {
                return db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spNombre, parametros.ToArray());
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
            //return Convert.ToInt32(retVal.Value);
        }

        //public static int Login(String NombreUsuario, String Password)
        //{

        //    string spNombre = "Usuario_Login";
        //    List<SqlParameter> parametros = new List<SqlParameter>();
        //    SqlParameter retVal = new SqlParameter("RetVal", SqlDbType.Int);
        //    retVal.Direction = ParameterDirection.ReturnValue;
        //    parametros.Add(new SqlParameter("@NombreUsuario", DataTypes.ToDBNull(NombreUsuario)));
        //    parametros.Add(new SqlParameter("@Password", DataTypes.ToDBNull(Password)));
        //    parametros.Add(retVal);

        //    try
        //    {
        //        db.EjecutarConsulta(db.TipoBase.PoligonoSeguridad, CommandType.StoredProcedure, spNombre, parametros.ToArray());
        //    }
        //    catch (Exception ex)
        //    {
        //        //throw new Exception("Login Usuario - Db.TipoBase.Poligono ",ex);
        //        throw ex;
        //    }
        //    return Convert.ToInt32(retVal.Value);
        //}

        public static DataTable Select(int IdUsuario)
        {

            string spNombre = "Usuario_Select";
            //String spNombre = "Poligono_ObtenerUsuarioPorId";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdUsuario", DataTypes.ToDBNull(IdUsuario)));

            try
            {
                return db.EjecutarDataset(CommandType.StoredProcedure, spNombre, db.TipoBase.ResidicaSeguridad, parametros.ToArray()).Tables[0];
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }

        public static DataTable Select(string nombreUsuario)
        {
            string spNombre = "Usuario_SelectByNombreUsuario";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@NombreUsuario", DataTypes.ToDBNull(nombreUsuario)));

            try
            {
                return db.EjecutarDataset(CommandType.StoredProcedure, spNombre, db.TipoBase.ResidicaSeguridad, parametros.ToArray()).Tables[0];
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }

        public static DataTable Select(string loginID, int A)
        {
            string spNombre = "Usuario_Select_LoginID";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Id", DataTypes.ToDBNull(loginID)));

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
            String spNombre = "Usuario_SelectAll";
            List<SqlParameter> parametros = new List<SqlParameter>();

            try
            {
                return db.EjecutarDataset(CommandType.StoredProcedure, spNombre, db.TipoBase.ResidicaSeguridad, null).Tables[0];
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }

        public static DataTable SelectAll(string nombre, string documento)
        {
            string spNombre = "Usuario_SelectAllByNombreDocumento";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Nombre", DataTypes.ToDBNull(nombre)));
            parametros.Add(new SqlParameter("@Documento", DataTypes.ToDBNull(documento)));

            try
            {
                return db.EjecutarDataset(CommandType.StoredProcedure, spNombre, db.TipoBase.ResidicaSeguridad, parametros.ToArray()).Tables[0];
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }



        //public static int Insert(Usuario _object)
        //{
        //    string spNombre = "Usuario_Insert";
        //    List<SqlParameter> parametros = new List<SqlParameter>();
        //    SqlParameter retVal = new SqlParameter("RetVal", SqlDbType.Int);
        //    retVal.Direction = ParameterDirection.ReturnValue;

        //    parametros.Add(new SqlParameter("@NombreUsuario", DataTypes.ToDBNull(_object.NombreUsuario)));
        //    parametros.Add(new SqlParameter("@NumeroDocumento", DataTypes.ToDBNull(_object.NumeroDocumento)));
        //    parametros.Add(new SqlParameter("@NombreCompleto", DataTypes.ToDBNull(_object.NombreCompleto)));
        //    parametros.Add(new SqlParameter("@Descripcion", DataTypes.ToDBNull(_object.Descripcion)));
        //    parametros.Add(new SqlParameter("@Password", DataTypes.ToDBNull(_object.Password)));
        //    parametros.Add(new SqlParameter("@IdiomaId", DataTypes.ToDBNull(_object.IdIdioma)));
        //    parametros.Add(new SqlParameter("@DigitoVerificador", DataTypes.ToDBNull(_object.DigitoVerificador)));
        //    parametros.Add(new SqlParameter("@Estado", DataTypes.ToDBNull(_object.Estado)));
        //    parametros.Add(retVal);

        //    db.EjecutarConsulta(db.TipoBase.PoligonoSeguridad, CommandType.StoredProcedure, spNombre, parametros.ToArray());

        //    _object.IdUsuario = (int)retVal.Value;

        //    if (_object.Patente != null)
        //    {
        //        UsuarioDal.DeleteFamilias(_object);
        //        UsuarioDal.DeletePatentes(_object);
        //        foreach (FamiliaElement _tipo in _object.Patente)
        //        {
        //            if ((_tipo.GetType().Name == "Grupo"))
        //            {
        //                String sp_Familia_Insert = "Usuario_Familia_Insert";
        //                List<SqlParameter> params_Familia_Insert = new List<SqlParameter>();
        //                params_Familia_Insert.Add(new SqlParameter("@IdUsuario", DataTypes.ToDBNull(_object.IdUsuario)));
        //                params_Familia_Insert.Add(new SqlParameter("@IdFamilia", DataTypes.ToDBNull(_tipo.IdFamiliaElement)));
        //                db.EjecutarConsulta(db.TipoBase.PoligonoSeguridad, CommandType.StoredProcedure, sp_Familia_Insert, params_Familia_Insert.ToArray());
        //            }
        //            else
        //            {
        //                String sp_Patente_Insert = "Usuario_Patente_Insert";
        //                List<SqlParameter> params_Patente_Insert = new List<SqlParameter>();
        //                params_Patente_Insert.Add(new SqlParameter("@IdUsuario", DataTypes.ToDBNull(_object.IdUsuario)));
        //                params_Patente_Insert.Add(new SqlParameter("@IdPatente", DataTypes.ToDBNull(_tipo.IdFamiliaElement)));
        //                db.EjecutarConsulta(db.TipoBase.PoligonoSeguridad, CommandType.StoredProcedure, sp_Patente_Insert, params_Patente_Insert.ToArray());
        //            }
        //        }
        //    }
        //    return Convert.ToInt32(retVal.Value);
        //}

        public static void ActualizarPermisos(Usuario _object)
        {
            try
            {
                if (_object.Permisos != null)
                {
                    UsuarioDAL.DeleteFamilias(_object);
                    UsuarioDAL.DeletePatentes(_object);

                    foreach (Permiso _tipo in _object.Permisos)
                    {
                        if ((_tipo.GetType().Name == "Familia"))
                        {
                            string sp_Familia_Insert = "Usuario_Familia_Insert";
                            List<SqlParameter> params_Familia_Insert = new List<SqlParameter>();
                            params_Familia_Insert.Add(new SqlParameter("@IdUsuario", DataTypes.ToDBNull(_object.IdUsuario)));
                            params_Familia_Insert.Add(new SqlParameter("@IdFamilia", DataTypes.ToDBNull(_tipo.IdFamiliaElement)));
                            db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, sp_Familia_Insert, params_Familia_Insert.ToArray());
                        }
                        else
                        {
                            string sp_Patente_Insert = "Usuario_Patente_Insert";
                            List<SqlParameter> params_Patente_Insert = new List<SqlParameter>();
                            params_Patente_Insert.Add(new SqlParameter("@IdUsuario", DataTypes.ToDBNull(_object.IdUsuario)));
                            params_Patente_Insert.Add(new SqlParameter("@IdPatente", DataTypes.ToDBNull(_tipo.IdFamiliaElement)));
                            db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, sp_Patente_Insert, params_Patente_Insert.ToArray());
                        }
                    }
                }
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }

        public static DataTable GetFamilias(int IdUsuario)
        {
            string spNombre = "Usuario_Familia_SelectParticular";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdUsuario", DataTypes.ToDBNull(IdUsuario)));

            try
            {
                return db.EjecutarDataset(CommandType.StoredProcedure, spNombre, db.TipoBase.ResidicaSeguridad, parametros.ToArray()).Tables[0];
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }

        public static DataTable GetPatentes(Int32 IdUsuario)
        {
            string spNombre = "Usuario_Patente_SelectParticular";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdUsuario", DataTypes.ToDBNull(IdUsuario)));

            try
            {
                return db.EjecutarDataset(CommandType.StoredProcedure, spNombre, db.TipoBase.ResidicaSeguridad, parametros.ToArray()).Tables[0];
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }


        // Grupo - Patente
        public static void DeleteFamilias(Usuario _object)
        {
            string spNombre = "Usuario_Familia_DeleteParticular";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdUsuario", DataTypes.ToDBNull(_object.IdUsuario)));

            try
            {
                db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spNombre, parametros.ToArray());
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }

        public static void DeletePatentes(Usuario _object)
        {
            string spNombre = "Usuario_Patente_DeleteParticular";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdUsuario", DataTypes.ToDBNull(_object.IdUsuario)));

            try
            {
                db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spNombre, parametros.ToArray());
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }







        //public DataTable BuscarFamiliasAsociadas(string IdUsuario)
        //{
        //    string spNombre = "Usuario_Familias_Asociadas";
        //    List<SqlParameter> parametros = new List<SqlParameter>();
        //    parametros.Add(new SqlParameter("@IdUsuario", DataTypes.ToDBNull(IdUsuario)));

        //    try
        //    {
        //        return db.EjecutarDataset(CommandType.StoredProcedure, spNombre, db.TipoBase.PoligonoSeguridad, parametros.ToArray()).Tables[0];
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public DataTable BuscarPatentesAsociadas(string IdUsuario)
        //{
        //    string spNombre = "Usuario_Patente_Asociadas";
        //    List<SqlParameter> parametros = new List<SqlParameter>();
        //    parametros.Add(new SqlParameter("@IdUsuario", DataTypes.ToDBNull(IdUsuario)));

        //    try
        //    {
        //        return db.EjecutarDataset(CommandType.StoredProcedure, spNombre, db.TipoBase.PoligonoSeguridad, parametros.ToArray()).Tables[0];
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}


    }
}
