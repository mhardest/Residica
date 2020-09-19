using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Sql.Utiles
{
    public class SalaDAL
    {
		public static int Insert(int numero, string nombre, int estado)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("SalaInsert");

			myDatabase.AddInParameter(myCommand, "@Numero", DbType.Int32, numero);
			myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, nombre);
			myDatabase.AddInParameter(myCommand, "@Estado", DbType.Int32, estado);

			//Ejecuta la consulta y retorna el nuevo identity.
			int returnValue = Convert.ToInt32(myDatabase.ExecuteScalar(myCommand));
			return returnValue;
		}

		/// <summary>
		/// Actualiza registros de la tabla Sala.
		/// </summary>
		/// <param name="salaId"></param>
		/// <param name="numero"></param>
		/// <param name="nombre"></param>
		/// <param name="estado"></param>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 17:48:42
		/// </history>
		public static void Update(int salaId, int numero, string nombre, int estado)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("SalaUpdate");

			myDatabase.AddInParameter(myCommand, "@SalaId", DbType.Int32, salaId);
			myDatabase.AddInParameter(myCommand, "@Numero", DbType.Int32, numero);
			myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, nombre);
			myDatabase.AddInParameter(myCommand, "@Estado", DbType.Int32, estado);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Suprime un registro de la tabla Sala por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 17:48:42
		/// </history>
		public static void Delete(int salaId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("SalaDelete");

			myDatabase.AddInParameter(myCommand, "@SalaId", DbType.Int32, salaId);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Selecciona un registro desde la tabla Sala.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 17:48:42
		/// </history>
		public static DataSet Select(int salaId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("SalaSelect");

			myDatabase.AddInParameter(myCommand, "@SalaId", DbType.Int32, salaId);

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Selecciona todos los registros de la tabla Sala.
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
			DbCommand myCommand = myDatabase.GetStoredProcCommand("SalaSelectAll");

			return myDatabase.ExecuteDataSet(myCommand);
		}
	}
}
