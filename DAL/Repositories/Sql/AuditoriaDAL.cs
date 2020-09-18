using DAL.Repositories.Sql.Utiles;
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
    public class AuditoriaDAL
    {
		/// <summary>
		/// Inserta registros dentro de la tabla Auditoria.
		/// </summary>
		/// <param name="residenteId"></param>
		/// <param name="profesionalId"></param>
		/// <param name="fechaHora"></param>
		/// <param name="observacion"></param>
		/// <returns></returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	16/09/2020 21:54:02
		/// </history>
		public static void Insert(int residenteId, int profesionalId, DateTime fechaHora, string observacion)
		{
			try
			{
				string spNombre = "AuditoriaInsert";
				List<SqlParameter> parametros = new List<SqlParameter>();
				SqlParameter retVal = new SqlParameter("RetVal", SqlDbType.Int);
				retVal.Direction = ParameterDirection.ReturnValue;
				parametros.Add(new SqlParameter("@ResidenteId", DataTypes.ToDBNull(residenteId)));
				parametros.Add(new SqlParameter("@ProfesionalId", DataTypes.ToDBNull(profesionalId)));
				parametros.Add(new SqlParameter("@FechaHora", DataTypes.ToDBNull(fechaHora)));
				parametros.Add(new SqlParameter("@Observacion", DataTypes.ToDBNull(observacion)));
				parametros.Add(retVal);

				dbNeg.EjecutarConsulta(dbNeg.TipoBase.Residica, CommandType.StoredProcedure, spNombre, parametros.ToArray());
			}
			catch (SqlException sqlex)
			{
				throw new ExceptionDAL(sqlex, sqlex.Message);
			}

			/*
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("AuditoriaInsert");

			myDatabase.AddInParameter(myCommand, "@ResidenteId", DbType.Int32, residenteId);
			myDatabase.AddInParameter(myCommand, "@ProfesionalId", DbType.Int32, profesionalId);
			myDatabase.AddInParameter(myCommand, "@FechaHora", DbType.DateTime, fechaHora);
			myDatabase.AddInParameter(myCommand, "@Observacion", DbType.String, observacion);

			//Ejecuta la consulta y retorna el nuevo identity.
			int returnValue = Convert.ToInt32(myDatabase.ExecuteScalar(myCommand));
			return returnValue;
			*/
		}

		/// <summary>
		/// Actualiza registros de la tabla Auditoria.
		/// </summary>
		/// <param name="auditoriaId"></param>
		/// <param name="residenteId"></param>
		/// <param name="profesionalId"></param>
		/// <param name="fechaHora"></param>
		/// <param name="observacion"></param>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	16/09/2020 21:54:03
		/// </history>
		public static void Update(int auditoriaId, int residenteId, int profesionalId, DateTime fechaHora, string observacion)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("AuditoriaUpdate");

			myDatabase.AddInParameter(myCommand, "@AuditoriaId", DbType.Int32, auditoriaId);
			myDatabase.AddInParameter(myCommand, "@ResidenteId", DbType.Int32, residenteId);
			myDatabase.AddInParameter(myCommand, "@ProfesionalId", DbType.Int32, profesionalId);
			myDatabase.AddInParameter(myCommand, "@FechaHora", DbType.DateTime, fechaHora);
			myDatabase.AddInParameter(myCommand, "@Observacion", DbType.String, observacion);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Suprime un registro de la tabla Auditoria por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	16/09/2020 21:54:03
		/// </history>
		public static void Delete(int auditoriaId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("AuditoriaDelete");

			myDatabase.AddInParameter(myCommand, "@AuditoriaId", DbType.Int32, auditoriaId);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Elimina un registro de la tabla Auditoria a través de una foreign key.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	16/09/2020 21:54:03
		/// </history>
		public static void DeleteByResidenteId(int residenteId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("AuditoriaDeleteByResidenteId");

			myDatabase.AddInParameter(myCommand, "@ResidenteId", DbType.Int32, residenteId);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Elimina un registro de la tabla Auditoria a través de una foreign key.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	16/09/2020 21:54:03
		/// </history>
		public static void DeleteByProfesionalId(int profesionalId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("AuditoriaDeleteByProfesionalId");

			myDatabase.AddInParameter(myCommand, "@ProfesionalId", DbType.Int32, profesionalId);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Selecciona un registro desde la tabla Auditoria.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	16/09/2020 21:54:03
		/// </history>
		public static DataSet Select(int auditoriaId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("AuditoriaSelect");

			myDatabase.AddInParameter(myCommand, "@AuditoriaId", DbType.Int32, auditoriaId);

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Selecciona todos los registros de la tabla Auditoria.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	16/09/2020 21:54:03
		/// </history>
		public static DataSet SelectAll()
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("AuditoriaSelectAll");

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Selecciona todos los registros de la tabla Auditoria a través de una foreign key.
		/// </summary>
		/// <param name="residenteId"></param>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	16/09/2020 21:54:03
		/// </history>
		public static DataSet SelectByResidenteId(int residenteId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("AuditoriaSelectByResidenteId");

			myDatabase.AddInParameter(myCommand, "@ResidenteId", DbType.Int32, residenteId);

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Selecciona todos los registros de la tabla Auditoria a través de una foreign key.
		/// </summary>
		/// <param name="profesionalId"></param>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	16/09/2020 21:54:03
		/// </history>
		public static DataSet SelectByProfesionalId(int profesionalId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("AuditoriaSelectByProfesionalId");

			myDatabase.AddInParameter(myCommand, "@ProfesionalId", DbType.Int32, profesionalId);

			return myDatabase.ExecuteDataSet(myCommand);
		}
		}
}

