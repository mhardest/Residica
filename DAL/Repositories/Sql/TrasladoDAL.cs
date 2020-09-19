using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Sql
{
    public class TrasladoDAL
    {
		/// <summary>
		/// Inserta registros dentro de la tabla Traslado.
		/// </summary>
		/// <param name="numeroUnidad"></param>
		/// <param name="nombre"></param>
		/// <param name="patente"></param>
		/// <param name="estado"></param>
		/// <returns></returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 17:48:42
		/// </history>
		public static int Insert(int numeroUnidad, int nombre, string patente, int estado)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TrasladoInsert");

			myDatabase.AddInParameter(myCommand, "@NumeroUnidad", DbType.Int32, numeroUnidad);
			myDatabase.AddInParameter(myCommand, "@Nombre", DbType.Int32, nombre);
			myDatabase.AddInParameter(myCommand, "@Patente", DbType.String, patente);
			myDatabase.AddInParameter(myCommand, "@Estado", DbType.Int32, estado);

			//Ejecuta la consulta y retorna el nuevo identity.
			int returnValue = Convert.ToInt32(myDatabase.ExecuteScalar(myCommand));
			return returnValue;
		}

		/// <summary>
		/// Actualiza registros de la tabla Traslado.
		/// </summary>
		/// <param name="trasladoId"></param>
		/// <param name="numeroUnidad"></param>
		/// <param name="nombre"></param>
		/// <param name="patente"></param>
		/// <param name="estado"></param>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 17:48:42
		/// </history>
		public static void Update(int trasladoId, int numeroUnidad, int nombre, string patente, int estado)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TrasladoUpdate");

			myDatabase.AddInParameter(myCommand, "@TrasladoId", DbType.Int32, trasladoId);
			myDatabase.AddInParameter(myCommand, "@NumeroUnidad", DbType.Int32, numeroUnidad);
			myDatabase.AddInParameter(myCommand, "@Nombre", DbType.Int32, nombre);
			myDatabase.AddInParameter(myCommand, "@Patente", DbType.String, patente);
			myDatabase.AddInParameter(myCommand, "@Estado", DbType.Int32, estado);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Suprime un registro de la tabla Traslado por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 17:48:42
		/// </history>
		public static void Delete(int trasladoId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TrasladoDelete");

			myDatabase.AddInParameter(myCommand, "@TrasladoId", DbType.Int32, trasladoId);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Selecciona un registro desde la tabla Traslado.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 17:48:42
		/// </history>
		public static DataSet Select(int trasladoId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TrasladoSelect");

			myDatabase.AddInParameter(myCommand, "@TrasladoId", DbType.Int32, trasladoId);

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Selecciona todos los registros de la tabla Traslado.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 17:48:42
		/// </history>
		public static DataSet SelectAll()
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TrasladoSelectAll");

			return myDatabase.ExecuteDataSet(myCommand);
		}
	}
}
