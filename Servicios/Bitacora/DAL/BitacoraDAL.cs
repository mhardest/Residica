using Servicios.Bitacora.Dominio;
using Servicios.Excepciones;
using Servicios.External;
using Servicios.Seguridad.DAL.Sql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Servicios.Bitacora.DAL
{
    public class BitacoraDAL
    {
        public static void RegistrarEnBitacora(BitacoraDM _object)
        {
            try
            {
                string spNombre = "Bitacora_Insert";
                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter retVal = new SqlParameter("RetVal", SqlDbType.Int);
                retVal.Direction = ParameterDirection.ReturnValue;
                parametros.Add(new SqlParameter("@IdEvento", DataTypes.ToDBNull(_object.IdEvento)));
                parametros.Add(new SqlParameter("@IdUsuario", DataTypes.ToDBNull(_object.IdUsuario)));
                parametros.Add(new SqlParameter("@Descripcion", DataTypes.ToDBNull(_object.Descripcion)));
                parametros.Add(new SqlParameter("@MessageExcep", DataTypes.ToDBNull(_object.MessageExcep)));
                parametros.Add(new SqlParameter("@TimeStamp", DataTypes.ToDBNull(_object.TimeStamp)));
                parametros.Add(retVal);

                db.EjecutarConsulta(db.TipoBase.ResidicaSeguridad, CommandType.StoredProcedure, spNombre, parametros.ToArray());
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }


        public static List<BitacoraDM> ObtenerEventosBitacora()
        {
            try
            {
                string spNombre = "Bitacora_SelectAllOrderByFecha";
                DataTable dt = new DataTable();
                List<BitacoraDM> lista = new List<BitacoraDM>();

                dt = db.EjecutarDataset(CommandType.StoredProcedure, spNombre, db.TipoBase.ResidicaSeguridad, null).Tables[0];

                foreach (DataRow row in dt.Rows)
                {
                    BitacoraDM bitacora = new BitacoraDM();
                    bitacora.IdEvento = row["IdEvento"].ToString();
                    bitacora.IdUsuario = row["IdUsuario"].ToString();
                    bitacora.Descripcion = row["Descripcion"].ToString();
                    bitacora.MessageExcep = row["MessageExcep"].ToString();
                    bitacora.TimeStamp = Convert.ToDateTime(row["TimeStamp"].ToString());
                    lista.Add(bitacora);
                }
                return lista;
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }


        public static void RegistrarBitacoraTxt(BitacoraDM _object)
        {
            try
            {
                string separador = "|";
                string ruta = ConfigurationManager.AppSettings["ruta_excel"].ToString();
                string titulo = "IdEvento" + separador + "IdUsuario" + separador + "Descripcion" + separador + "MessageExcep";

                StreamWriter archivo = new StreamWriter(ruta, true);
                archivo.WriteLine(titulo);
                string linea = null;
                string idEvento = _object.IdEvento.ToString();
                string idUsuario = _object.IdUsuario.ToString();
                string descripcion = _object.Descripcion;
                string MsgExep = _object.MessageExcep.ToString();

                linea = idEvento + separador + idUsuario + separador + descripcion + separador + MsgExep;
                archivo.WriteLine(linea);
                archivo.Close();
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }
    }
}

