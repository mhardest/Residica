using DAL.Repositories.Sql.Utiles;
using Dominio;
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
	public class EquipoDAL
	{
		/// <summary>
		/// Inserta registros dentro de la tabla Equipo.
		/// </summary>
		/// <param name="equipoNombre"></param>
		/// <param name="equipoCaracteristicas"></param>
		/// <param name="equipoEstado"></param>
		/// <returns></returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 17:48:42
		/// </history>
		public static int Insert(string equipoNombre, string equipoCaracteristicas, int equipoEstado)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("EquipoInsert");

			myDatabase.AddInParameter(myCommand, "@EquipoNombre", DbType.String, equipoNombre);
			myDatabase.AddInParameter(myCommand, "@EquipoCaracteristicas", DbType.String, equipoCaracteristicas);
			myDatabase.AddInParameter(myCommand, "@EquipoEstado", DbType.Int32, equipoEstado);

			//Ejecuta la consulta y retorna el nuevo identity.
			int returnValue = Convert.ToInt32(myDatabase.ExecuteScalar(myCommand));
			return returnValue;
		}

		/// <summary>
		/// Actualiza registros de la tabla Equipo.
		/// </summary>
		/// <param name="equipoId"></param>
		/// <param name="equipoNombre"></param>
		/// <param name="equipoCaracteristicas"></param>
		/// <param name="equipoEstado"></param>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 17:48:42
		/// </history>
		public static void Update(int equipoId, string equipoNombre, string equipoCaracteristicas, int equipoEstado)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("EquipoUpdate");

			myDatabase.AddInParameter(myCommand, "@EquipoId", DbType.Int32, equipoId);
			myDatabase.AddInParameter(myCommand, "@EquipoNombre", DbType.String, equipoNombre);
			myDatabase.AddInParameter(myCommand, "@EquipoCaracteristicas", DbType.String, equipoCaracteristicas);
			myDatabase.AddInParameter(myCommand, "@EquipoEstado", DbType.Int32, equipoEstado);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Suprime un registro de la tabla Equipo por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 17:48:42
		/// </history>
		public static void Delete(int equipoId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("EquipoDelete");

			myDatabase.AddInParameter(myCommand, "@EquipoId", DbType.Int32, equipoId);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Selecciona un registro desde la tabla Equipo.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 17:48:42
		/// </history>
		public static DataSet Select(int equipoId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("EquipoSelect");

			myDatabase.AddInParameter(myCommand, "@EquipoId", DbType.Int32, equipoId);

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Selecciona todos los registros de la tabla Equipo.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 17:48:42
		/// </history>
		public static List<Equipo> SelectAll()
		{
			string spNombre = "EquipoSelectAll";
			DataTable dt = new DataTable();
			List<Equipo> lista = new List<Equipo>();
			dt = dbNeg.EjecutarDataset(CommandType.StoredProcedure, spNombre, dbNeg.TipoBase.Residica, null).Tables[0];


			foreach (DataRow row in dt.Rows)
			{
				Equipo equipo = new Equipo();
				equipo.EquipoId = Convert.ToInt32((row["EquipoId"].ToString()));
				equipo.EquipoNombre = row["EquipoNombre"].ToString();
				equipo.EquipoCaracteristicas = row["EquipoCaracteristicas"].ToString();
				equipo.EquipoEstado = Convert.ToInt32(row["EquipoEstado"].ToString());
				lista.Add(equipo);
			}
			return lista;
		}
	}
}
