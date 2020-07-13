using DAL.Repositories.Sql.Utiles;
using Dominio;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Servicios.Excepciones;
using Servicios.External;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Sql
{
    public class ResidenteDAL
    {

			/// <summary>
			/// Inserta registros dentro de la tabla Residente.
			/// </summary>
			/// <param name="apellido"></param>
			/// <param name="nombre"></param>
			/// <param name="documentoNumero"></param>
			/// <param name="cUIL"></param>
			/// <param name="fechaNacimiento"></param>
			/// <param name="obraSocial"></param>
			/// <param name="auditoriaPsicologica"></param>
			/// <param name="auditoriaMedica"></param>
			/// <param name="auditoriaTraumatologica"></param>
			/// <param name="estado"></param>
			/// <param name="observacion"></param>
			/// <param name="telefonoContacto"></param>
			/// <param name="personaContacto"></param>
			/// <param name="direccionContacto"></param>
			/// <param name="numeroEmergencia"></param>
			/// <param name="habitacionId"></param>
			/// <param name="planId"></param>
			/// <returns></returns>
			/// <remarks>
			/// </remarks>
			/// <history>
			/// 	[Matt]	12/07/2020 20:30:48
			/// </history>
			//public static int Insert(string apellido, string nombre, int documentoNumero, int cUIL, string fechaNacimiento, string obraSocial, bool auditoriaPsicologica, bool auditoriaMedica, bool auditoriaTraumatologica, int estado, string observacion, string telefonoContacto, string personaContacto, string direccionContacto, string numeroEmergencia, int habitacionId, int planId)
			public static void Insert(Residente _object)
			{
				try
				{
					string spNombre = "ResidenteInsert";
					List<SqlParameter> parametros = new List<SqlParameter>();
					SqlParameter retVal = new SqlParameter("RetVal", SqlDbType.Int);
					retVal.Direction = ParameterDirection.ReturnValue;
					parametros.Add(new SqlParameter("@Apellido", DataTypes.ToDBNull(_object.Apellido)));
					parametros.Add(new SqlParameter("@Nombre", DataTypes.ToDBNull(_object.Nombre)));
					parametros.Add(new SqlParameter("@DocumentoNumero", DataTypes.ToDBNull(_object.DocumentoNumero)));
					parametros.Add(new SqlParameter("@CUIL", DataTypes.ToDBNull(_object.CUIL)));
					parametros.Add(new SqlParameter("@FechaNacimiento", DataTypes.ToDBNull(_object.FechaNacimiento)));
					parametros.Add(new SqlParameter("@ObraSocial", DataTypes.ToDBNull(_object.ObraSocial)));
					parametros.Add(new SqlParameter("@AuditoriaPsicologica", DataTypes.ToDBNull(_object.AuditoriaPsicologica)));
					parametros.Add(new SqlParameter("@AuditoriaMedica", DataTypes.ToDBNull(_object.AuditoriaMedica)));
					parametros.Add(new SqlParameter("@AuditoriaTraumatologica", DataTypes.ToDBNull(_object.AuditoriaTraumatologica)));
					parametros.Add(new SqlParameter("@AuditoriaGeneral", DataTypes.ToDBNull(_object.AuditoriaGeneral)));
					parametros.Add(new SqlParameter("@Estado", DataTypes.ToDBNull(_object.Estado)));
					parametros.Add(new SqlParameter("@Observacion", DataTypes.ToDBNull(_object.Observacion)));
					parametros.Add(new SqlParameter("@TelefonoContacto", DataTypes.ToDBNull(_object.TelefonoContacto)));
					parametros.Add(new SqlParameter("@PersonaContacto", DataTypes.ToDBNull(_object.PersonaContacto)));
					parametros.Add(new SqlParameter("@DireccionContacto", DataTypes.ToDBNull(_object.DireccionContacto)));
					parametros.Add(new SqlParameter("@NumeroEmergencia", DataTypes.ToDBNull(_object.NumeroEmergencia)));
					parametros.Add(new SqlParameter("@HabitacionId", DataTypes.ToDBNull(_object.HabitacionId)));
					parametros.Add(new SqlParameter("@PlanId", "NULL"));//DataTypes.ToDBNull(_object.PlanId)));

					parametros.Add(retVal);

					dbNeg.EjecutarConsulta(dbNeg.TipoBase.Residica, CommandType.StoredProcedure, spNombre, parametros.ToArray());
				}
				catch (SqlException sqlex)
				{
					throw new ExceptionDAL(sqlex, sqlex.Message);
				}

				/*
				Database myDatabase = DatabaseFactory.CreateDatabase();
				DbCommand myCommand = myDatabase.GetStoredProcCommand("ResidenteInsert");

				myDatabase.AddInParameter(myCommand, "@Apellido", DbType.String, apellido);
				myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, nombre);
				myDatabase.AddInParameter(myCommand, "@DocumentoNumero", DbType.Int32, documentoNumero);
				myDatabase.AddInParameter(myCommand, "@CUIL", DbType.Int32, cUIL);
				myDatabase.AddInParameter(myCommand, "@FechaNacimiento", DbType.String, fechaNacimiento);
				myDatabase.AddInParameter(myCommand, "@ObraSocial", DbType.String, obraSocial);
				myDatabase.AddInParameter(myCommand, "@AuditoriaPsicologica", DbType.Boolean, auditoriaPsicologica);
				myDatabase.AddInParameter(myCommand, "@AuditoriaMedica", DbType.Boolean, auditoriaMedica);
				myDatabase.AddInParameter(myCommand, "@AuditoriaTraumatologica", DbType.Boolean, auditoriaTraumatologica);
				myDatabase.AddInParameter(myCommand, "@Estado", DbType.Int32, estado);
				myDatabase.AddInParameter(myCommand, "@Observacion", DbType.String, observacion);
				myDatabase.AddInParameter(myCommand, "@TelefonoContacto", DbType.String, telefonoContacto);
				myDatabase.AddInParameter(myCommand, "@PersonaContacto", DbType.String, personaContacto);
				myDatabase.AddInParameter(myCommand, "@DireccionContacto", DbType.String, direccionContacto);
				myDatabase.AddInParameter(myCommand, "@NumeroEmergencia", DbType.String, numeroEmergencia);
				myDatabase.AddInParameter(myCommand, "@HabitacionId", DbType.Int32, habitacionId);
				myDatabase.AddInParameter(myCommand, "@PlanId", DbType.Int32, planId);

				//Ejecuta la consulta y retorna el nuevo identity.
				int returnValue = Convert.ToInt32(myDatabase.ExecuteScalar(myCommand));
				return returnValue;
				*/
			}

		public static void InsertReserva(Residente _object)
		{
			try
			{
				string spNombre = "ResidenteReserva";
				List<SqlParameter> parametros = new List<SqlParameter>();
				SqlParameter retVal = new SqlParameter("RetVal", SqlDbType.Int);
				retVal.Direction = ParameterDirection.ReturnValue;
				parametros.Add(new SqlParameter("@Apellido", DataTypes.ToDBNull(_object.Apellido)));
				parametros.Add(new SqlParameter("@Nombre", DataTypes.ToDBNull(_object.Nombre)));
				parametros.Add(new SqlParameter("@DocumentoNumero", DataTypes.ToDBNull(_object.DocumentoNumero)));
				parametros.Add(new SqlParameter("@CUIL", DataTypes.ToDBNull(_object.CUIL)));
				parametros.Add(new SqlParameter("@FechaNacimiento", DataTypes.ToDBNull(_object.FechaNacimiento)));
				parametros.Add(new SqlParameter("@ObraSocial", DataTypes.ToDBNull(_object.ObraSocial)));
				parametros.Add(new SqlParameter("@AuditoriaPsicologica", DataTypes.ToDBNull(_object.AuditoriaPsicologica)));
				parametros.Add(new SqlParameter("@AuditoriaMedica", DataTypes.ToDBNull(_object.AuditoriaMedica)));
				parametros.Add(new SqlParameter("@AuditoriaTraumatologica", DataTypes.ToDBNull(_object.AuditoriaTraumatologica)));
				parametros.Add(new SqlParameter("@AuditoriaGeneral", DataTypes.ToDBNull(_object.AuditoriaGeneral)));
				parametros.Add(new SqlParameter("@Estado", DataTypes.ToDBNull(_object.Estado)));
				parametros.Add(new SqlParameter("@Observacion", DataTypes.ToDBNull(_object.Observacion)));
				parametros.Add(new SqlParameter("@TelefonoContacto", DataTypes.ToDBNull(_object.TelefonoContacto)));
				parametros.Add(new SqlParameter("@PersonaContacto", DataTypes.ToDBNull(_object.PersonaContacto)));
				parametros.Add(new SqlParameter("@DireccionContacto", DataTypes.ToDBNull(_object.DireccionContacto)));
				parametros.Add(new SqlParameter("@NumeroEmergencia", DataTypes.ToDBNull(_object.NumeroEmergencia)));

				parametros.Add(retVal);

				dbNeg.EjecutarConsulta(dbNeg.TipoBase.Residica, CommandType.StoredProcedure, spNombre, parametros.ToArray());
			}
			catch (SqlException sqlex)
			{
				throw new ExceptionDAL(sqlex, sqlex.Message);
			}
		}

			/// <summary>
			/// Actualiza registros de la tabla Residente.
			/// </summary>
			/// <param name="residenteId"></param>
			/// <param name="apellido"></param>
			/// <param name="nombre"></param>
			/// <param name="documentoNumero"></param>
			/// <param name="cUIL"></param>
			/// <param name="fechaNacimiento"></param>
			/// <param name="obraSocial"></param>
			/// <param name="auditoriaPsicologica"></param>
			/// <param name="auditoriaMedica"></param>
			/// <param name="auditoriaTraumatologica"></param>
			/// <param name="estado"></param>
			/// <param name="observacion"></param>
			/// <param name="telefonoContacto"></param>
			/// <param name="personaContacto"></param>
			/// <param name="direccionContacto"></param>
			/// <param name="numeroEmergencia"></param>
			/// <param name="habitacionId"></param>
			/// <param name="planId"></param>
			/// <remarks>
			/// </remarks>
			/// <history>
			/// 	[Matt]	12/07/2020 20:30:48
			/// </history>
			public static void Update(int residenteId, string apellido, string nombre, int documentoNumero, int cUIL, string fechaNacimiento, string obraSocial, bool auditoriaPsicologica, bool auditoriaMedica, bool auditoriaTraumatologica, int estado, string observacion, string telefonoContacto, string personaContacto, string direccionContacto, string numeroEmergencia, int habitacionId, int planId)
			{
				Database myDatabase = DatabaseFactory.CreateDatabase();
				DbCommand myCommand = myDatabase.GetStoredProcCommand("ResidenteUpdate");

				myDatabase.AddInParameter(myCommand, "@ResidenteId", DbType.Int32, residenteId);
				myDatabase.AddInParameter(myCommand, "@Apellido", DbType.String, apellido);
				myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, nombre);
				myDatabase.AddInParameter(myCommand, "@DocumentoNumero", DbType.Int32, documentoNumero);
				myDatabase.AddInParameter(myCommand, "@CUIL", DbType.Int32, cUIL);
				myDatabase.AddInParameter(myCommand, "@FechaNacimiento", DbType.String, fechaNacimiento);
				myDatabase.AddInParameter(myCommand, "@ObraSocial", DbType.String, obraSocial);
				myDatabase.AddInParameter(myCommand, "@AuditoriaPsicologica", DbType.Boolean, auditoriaPsicologica);
				myDatabase.AddInParameter(myCommand, "@AuditoriaMedica", DbType.Boolean, auditoriaMedica);
				myDatabase.AddInParameter(myCommand, "@AuditoriaTraumatologica", DbType.Boolean, auditoriaTraumatologica);
				myDatabase.AddInParameter(myCommand, "@Estado", DbType.Int32, estado);
				myDatabase.AddInParameter(myCommand, "@Observacion", DbType.String, observacion);
				myDatabase.AddInParameter(myCommand, "@TelefonoContacto", DbType.String, telefonoContacto);
				myDatabase.AddInParameter(myCommand, "@PersonaContacto", DbType.String, personaContacto);
				myDatabase.AddInParameter(myCommand, "@DireccionContacto", DbType.String, direccionContacto);
				myDatabase.AddInParameter(myCommand, "@NumeroEmergencia", DbType.String, numeroEmergencia);
				myDatabase.AddInParameter(myCommand, "@HabitacionId", DbType.Int32, habitacionId);
				myDatabase.AddInParameter(myCommand, "@PlanId", DbType.Int32, planId);

				myDatabase.ExecuteNonQuery(myCommand);
			}

			/// <summary>
			/// Suprime un registro de la tabla Residente por una clave primaria(primary key).
			/// </summary>
			/// <remarks>
			/// </remarks>
			/// <history>
			/// 	[Matt]	12/07/2020 20:30:48
			/// </history>
			public static void Delete(int residenteId)
			{
				Database myDatabase = DatabaseFactory.CreateDatabase();
				DbCommand myCommand = myDatabase.GetStoredProcCommand("ResidenteDelete");

				myDatabase.AddInParameter(myCommand, "@ResidenteId", DbType.Int32, residenteId);

				myDatabase.ExecuteNonQuery(myCommand);
			}

			/// <summary>
			/// Elimina un registro de la tabla Residente a través de una foreign key.
			/// </summary>
			/// <remarks>
			/// </remarks>
			/// <history>
			/// 	[Matt]	12/07/2020 20:30:48
			/// </history>
			public static void DeleteByHabitacionId(int habitacionId)
			{
				Database myDatabase = DatabaseFactory.CreateDatabase();
				DbCommand myCommand = myDatabase.GetStoredProcCommand("ResidenteDeleteByHabitacionId");

				myDatabase.AddInParameter(myCommand, "@HabitacionId", DbType.Int32, habitacionId);

				myDatabase.ExecuteNonQuery(myCommand);
			}

			/// <summary>
			/// Elimina un registro de la tabla Residente a través de una foreign key.
			/// </summary>
			/// <remarks>
			/// </remarks>
			/// <history>
			/// 	[Matt]	12/07/2020 20:30:48
			/// </history>
			public static void DeleteByPlanId(int planId)
			{
				Database myDatabase = DatabaseFactory.CreateDatabase();
				DbCommand myCommand = myDatabase.GetStoredProcCommand("ResidenteDeleteByPlanId");

				myDatabase.AddInParameter(myCommand, "@PlanId", DbType.Int32, planId);

				myDatabase.ExecuteNonQuery(myCommand);
			}

			/// <summary>
			/// Selecciona un registro desde la tabla Residente.
			/// </summary>
			/// <returns>DataSet</returns>
			/// <remarks>
			/// </remarks>
			/// <history>
			/// 	[Matt]	12/07/2020 20:30:48
			/// </history>
			public static DataSet Select(int residenteId)
			{
				Database myDatabase = DatabaseFactory.CreateDatabase();
				DbCommand myCommand = myDatabase.GetStoredProcCommand("ResidenteSelect");

				myDatabase.AddInParameter(myCommand, "@ResidenteId", DbType.Int32, residenteId);

				return myDatabase.ExecuteDataSet(myCommand);
			}

			/// <summary>
			/// Selecciona todos los registros de la tabla Residente.
			/// </summary>
			/// <returns>DataSet</returns>
			/// <remarks>
			/// </remarks>
			/// <history>
			/// 	[Matt]	12/07/2020 20:30:48
			/// </history>
			public static DataSet SelectAll()
			{
				Database myDatabase = DatabaseFactory.CreateDatabase();
				DbCommand myCommand = myDatabase.GetStoredProcCommand("ResidenteSelectAll");

				return myDatabase.ExecuteDataSet(myCommand);
			}

			/// <summary>
			/// Selecciona todos los registros de la tabla Residente a través de una foreign key.
			/// </summary>
			/// <param name="habitacionId"></param>
			/// <returns>DataSet</returns>
			/// <remarks>
			/// </remarks>
			/// <history>
			/// 	[Matt]	12/07/2020 20:30:48
			/// </history>
			public static DataSet SelectByHabitacionId(int habitacionId)
			{
				Database myDatabase = DatabaseFactory.CreateDatabase();
				DbCommand myCommand = myDatabase.GetStoredProcCommand("ResidenteSelectByHabitacionId");

				myDatabase.AddInParameter(myCommand, "@HabitacionId", DbType.Int32, habitacionId);

				return myDatabase.ExecuteDataSet(myCommand);
			}

			/// <summary>
			/// Selecciona todos los registros de la tabla Residente a través de una foreign key.
			/// </summary>
			/// <param name="planId"></param>
			/// <returns>DataSet</returns>
			/// <remarks>
			/// </remarks>
			/// <history>
			/// 	[Matt]	12/07/2020 20:30:48
			/// </history>
			public static DataSet SelectByPlanId(int planId)
			{
				Database myDatabase = DatabaseFactory.CreateDatabase();
				DbCommand myCommand = myDatabase.GetStoredProcCommand("ResidenteSelectByPlanId");

				myDatabase.AddInParameter(myCommand, "@PlanId", DbType.Int32, planId);

				return myDatabase.ExecuteDataSet(myCommand);
			}
		}
	}

