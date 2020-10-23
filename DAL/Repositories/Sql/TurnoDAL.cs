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
    public class TurnoDAL
    {
		/// <summary>
		/// Inserta registros dentro de la tabla Turno.
		/// </summary>
		/// <param name="tipo"></param>
		/// <param name="hora"></param>
		/// <param name="duracion"></param>
		/// <param name="residenteId"></param>
		/// <param name="salaId"></param>
		/// <param name="equipoId"></param>
		/// <param name="trasladoId"></param>
		/// <returns></returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 18:09:30
		/// </history>
		public static void Insert(Turn _object)
		{
			try
			{
				string spNombre = "TurnoInsert";
				List<SqlParameter> parametros = new List<SqlParameter>();
				SqlParameter retVal = new SqlParameter("RetVal", SqlDbType.Int);
				retVal.Direction = ParameterDirection.ReturnValue;
				parametros.Add(new SqlParameter("@Tipo", DataTypes.ToDBNull(_object.Tipo)));
				parametros.Add(new SqlParameter("@Hora", DataTypes.ToDBNull(_object.Hora)));
				parametros.Add(new SqlParameter("@Duracion", DataTypes.ToDBNull(_object.Duracion)));
				parametros.Add(new SqlParameter("@ResidenteId", DataTypes.ToDBNull(_object.ResidenteId)));
				parametros.Add(new SqlParameter("@SalaId", DataTypes.ToDBNull(_object.SalaId)));
				parametros.Add(new SqlParameter("@EquipoId", DataTypes.ToDBNull(_object.EquipoId)));
				parametros.Add(new SqlParameter("@TrasladoId", DataTypes.ToDBNull(_object.TrasladoId)));
				parametros.Add(new SqlParameter("@Fecha", DataTypes.ToDBNull(_object.Fecha)));
				parametros.Add(retVal);

				dbNeg.EjecutarConsulta(dbNeg.TipoBase.Residica, CommandType.StoredProcedure, spNombre, parametros.ToArray());
			}
			catch (SqlException sqlex)
			{
				throw new ExceptionDAL(sqlex, sqlex.Message);
			}
		}

		/// <summary>
		/// Actualiza registros de la tabla Turno.
		/// </summary>
		/// <param name="turnoId"></param>
		/// <param name="tipo"></param>
		/// <param name="hora"></param>
		/// <param name="duracion"></param>
		/// <param name="residenteId"></param>
		/// <param name="salaId"></param>
		/// <param name="equipoId"></param>
		/// <param name="trasladoId"></param>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 18:09:30
		/// </history>
		public static void Update(int turnoId, int tipo, int hora, int duracion, int residenteId, int salaId, int equipoId, int trasladoId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TurnoUpdate");

			myDatabase.AddInParameter(myCommand, "@TurnoId", DbType.Int32, turnoId);
			myDatabase.AddInParameter(myCommand, "@Tipo", DbType.Int32, tipo);
			myDatabase.AddInParameter(myCommand, "@Hora", DbType.Int32, hora);
			myDatabase.AddInParameter(myCommand, "@Duracion", DbType.Int32, duracion);
			myDatabase.AddInParameter(myCommand, "@ResidenteId", DbType.Int32, residenteId);
			myDatabase.AddInParameter(myCommand, "@SalaId", DbType.Int32, salaId);
			myDatabase.AddInParameter(myCommand, "@EquipoId", DbType.Int32, equipoId);
			myDatabase.AddInParameter(myCommand, "@TrasladoId", DbType.Int32, trasladoId);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Suprime un registro de la tabla Turno por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 18:09:30
		/// </history>
		public static void Delete(int turnoId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TurnoDelete");

			myDatabase.AddInParameter(myCommand, "@TurnoId", DbType.Int32, turnoId);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Elimina un registro de la tabla Turno a través de una foreign key.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 18:09:30
		/// </history>
		public static void DeleteByResidenteId(int residenteId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TurnoDeleteByResidenteId");

			myDatabase.AddInParameter(myCommand, "@ResidenteId", DbType.Int32, residenteId);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Elimina un registro de la tabla Turno a través de una foreign key.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 18:09:30
		/// </history>
		public static void DeleteByEquipoId(int equipoId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TurnoDeleteByEquipoId");

			myDatabase.AddInParameter(myCommand, "@EquipoId", DbType.Int32, equipoId);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Elimina un registro de la tabla Turno a través de una foreign key.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 18:09:30
		/// </history>
		public static void DeleteByTrasladoId(int trasladoId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TurnoDeleteByTrasladoId");

			myDatabase.AddInParameter(myCommand, "@TrasladoId", DbType.Int32, trasladoId);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Elimina un registro de la tabla Turno a través de una foreign key.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 18:09:30
		/// </history>
		public static void DeleteBySalaId(int salaId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TurnoDeleteBySalaId");

			myDatabase.AddInParameter(myCommand, "@SalaId", DbType.Int32, salaId);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Selecciona un registro desde la tabla Turno.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 18:09:30
		/// </history>
		public static DataSet Select(int turnoId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TurnoSelect");

			myDatabase.AddInParameter(myCommand, "@TurnoId", DbType.Int32, turnoId);

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Selecciona todos los registros de la tabla Turno.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 18:09:30
		/// </history>
		public static List<Turn> SelectAll()
		{
			string spNombre = "TurnoSelectAll";
			DataTable dt = new DataTable();
			List<Turn> lista = new List<Turn>();
			dt = dbNeg.EjecutarDataset(CommandType.StoredProcedure, spNombre, dbNeg.TipoBase.Residica, null).Tables[0];


			foreach (DataRow row in dt.Rows)
			{
				Turn turno = new Turn();
				turno.TurnoId = Convert.ToInt32(row["TurnoId"].ToString());
				turno.Tipo = Convert.ToInt32(row["Tipo"].ToString());
				turno.Fecha = Convert.ToDateTime(row["Fecha"].ToString());
				turno.Hora = Convert.ToInt32(row["Hora"].ToString());
				turno.Duracion = Convert.ToInt32(row["Duracion"].ToString());

				if (row["EquipoId"].ToString() != "")
				{
					turno.EquipoId = Convert.ToInt32(row["EquipoId"].ToString());
				}
				if (row["SalaId"].ToString() != "")
				{
					turno.SalaId = Convert.ToInt32(row["SalaId"].ToString());
				}
				if (row["TrasladoId"].ToString() != "")
				{
					turno.TrasladoId = Convert.ToInt32(row["TrasladoId"].ToString());
				}
				lista.Add(turno);

			}
			return lista;
		}

		/// <summary>
		/// Selecciona todos los registros de la tabla Turno a través de una foreign key.
		/// </summary>
		/// <param name="residenteId"></param>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 18:09:30
		/// </history>
		public static DataSet SelectByResidenteId(int residenteId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TurnoSelectByResidenteId");

			myDatabase.AddInParameter(myCommand, "@ResidenteId", DbType.Int32, residenteId);

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Selecciona todos los registros de la tabla Turno a través de una foreign key.
		/// </summary>
		/// <param name="equipoId"></param>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 18:09:30
		/// </history>
		public static DataSet SelectByEquipoId(int equipoId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TurnoSelectByEquipoId");

			myDatabase.AddInParameter(myCommand, "@EquipoId", DbType.Int32, equipoId);

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Selecciona todos los registros de la tabla Turno a través de una foreign key.
		/// </summary>
		/// <param name="trasladoId"></param>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 18:09:30
		/// </history>
		public static DataSet SelectByTrasladoId(int trasladoId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TurnoSelectByTrasladoId");

			myDatabase.AddInParameter(myCommand, "@TrasladoId", DbType.Int32, trasladoId);

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Selecciona todos los registros de la tabla Turno a través de una foreign key.
		/// </summary>
		/// <param name="salaId"></param>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	19/09/2020 18:09:30
		/// </history>
		public static DataSet SelectBySalaId(int salaId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TurnoSelectBySalaId");

			myDatabase.AddInParameter(myCommand, "@SalaId", DbType.Int32, salaId);

			return myDatabase.ExecuteDataSet(myCommand);
		}
	}
}
