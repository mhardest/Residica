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
    public class HabitacionDAL
    {
		/// <summary>
		/// Inserta registros dentro de la tabla Habitacion.
		/// </summary>
		/// <param name="numero"></param>
		/// <param name="nombre"></param>
		/// <param name="cantidadCamas"></param>
		/// <param name="cantidadCamasDisponibles"></param>
		/// <returns></returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	12/07/2020 20:43:26
		/// </history>
		public static int Insert(int numero, string nombre, int cantidadCamas, int cantidadCamasDisponibles)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("HabitacionInsert");

			myDatabase.AddInParameter(myCommand, "@Numero", DbType.Int32, numero);
			myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, nombre);
			myDatabase.AddInParameter(myCommand, "@CantidadCamas", DbType.Int32, cantidadCamas);
			myDatabase.AddInParameter(myCommand, "@CantidadCamasDisponibles", DbType.Int32, cantidadCamasDisponibles);

			//Ejecuta la consulta y retorna el nuevo identity.
			int returnValue = Convert.ToInt32(myDatabase.ExecuteScalar(myCommand));
			return returnValue;
		}

		/// <summary>
		/// Actualiza registros de la tabla Habitacion.
		/// </summary>
		/// <param name="habitacionId"></param>
		/// <param name="numero"></param>
		/// <param name="nombre"></param>
		/// <param name="cantidadCamas"></param>
		/// <param name="cantidadCamasDisponibles"></param>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	12/07/2020 20:43:26
		/// </history>
		public static void Update(Habitacion _object)//(int habitacionId, int numero, string nombre, int cantidadCamas, int cantidadCamasDisponibles)
		{
			try
			{
				string spNombre = "HabitacionUpdate";
				List<SqlParameter> parametros = new List<SqlParameter>();
				SqlParameter retVal = new SqlParameter("RetVal", SqlDbType.Int);
				retVal.Direction = ParameterDirection.ReturnValue;
				parametros.Add(new SqlParameter("@HabitacionId", DataTypes.ToDBNull(_object.HabitacionId)));
				parametros.Add(new SqlParameter("@Numero", DataTypes.ToDBNull(_object.Numero)));
				parametros.Add(new SqlParameter("@Nombre", DataTypes.ToDBNull(_object.Nombre)));
				parametros.Add(new SqlParameter("@CantidadCamas", DataTypes.ToDBNull(_object.CantidadCamas)));
				parametros.Add(new SqlParameter("@CantidadCamasDisponibles", DataTypes.ToDBNull(_object.CantidadCamasDisponibles)));
				parametros.Add(retVal);

				dbNeg.EjecutarConsulta(dbNeg.TipoBase.Residica, CommandType.StoredProcedure, spNombre, parametros.ToArray());
			}
			catch (SqlException sqlex)
			{
				throw new ExceptionDAL(sqlex, sqlex.Message);
			}
			/*
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("HabitacionUpdate");

			myDatabase.AddInParameter(myCommand, "@HabitacionId", DbType.Int32, habitacionId);
			myDatabase.AddInParameter(myCommand, "@Numero", DbType.Int32, numero);
			myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, nombre);
			myDatabase.AddInParameter(myCommand, "@CantidadCamas", DbType.Int32, cantidadCamas);
			myDatabase.AddInParameter(myCommand, "@CantidadCamasDisponibles", DbType.Int32, cantidadCamasDisponibles);

			myDatabase.ExecuteNonQuery(myCommand);
			*/
		}

		/// <summary>
		/// Suprime un registro de la tabla Habitacion por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	12/07/2020 20:43:26
		/// </history>
		public static void Delete(int habitacionId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("HabitacionDelete");

			myDatabase.AddInParameter(myCommand, "@HabitacionId", DbType.Int32, habitacionId);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Selecciona un registro desde la tabla Habitacion.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	12/07/2020 20:43:26
		/// </history>
		public static DataTable Select(int habitacionId)//DataSet Select(int habitacionId)
		{
			string spNombre = "HabitacionSelect";
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(new SqlParameter("@habitacionId", DataTypes.ToDBNull(habitacionId)));

			try
			{
				return dbNeg.EjecutarDataset(CommandType.StoredProcedure, spNombre, dbNeg.TipoBase.Residica, parametros.ToArray()).Tables[0];
			}
			catch (SqlException sqlex)
			{
				throw new ExceptionDAL(sqlex, sqlex.Message);
			}

			/*
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("HabitacionSelect");

			myDatabase.AddInParameter(myCommand, "@HabitacionId", DbType.Int32, habitacionId);

			return myDatabase.ExecuteDataSet(myCommand);
			*/
		}

		public static Habitacion SelectNew(int habitacionId)//DataSet Select(int habitacionId)
		{
			string spNombre = "HabitacionSelect";
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(new SqlParameter("@HabitacionId", DataTypes.ToDBNull(habitacionId)));
			DataTable dt = new DataTable();
			try
			{
				dt = dbNeg.EjecutarDataset(CommandType.StoredProcedure, spNombre, dbNeg.TipoBase.Residica, parametros.ToArray()).Tables[0];
				//return dbNeg.EjecutarDataset(CommandType.StoredProcedure, spNombre, dbNeg.TipoBase.Residica, null).Tables[0];

				foreach (DataRow row in dt.Rows)
				{
					Habitacion habitacion = new Habitacion();
					habitacion.HabitacionId = Convert.ToInt32(row["HabitacionId"].ToString());
					habitacion.Nombre = row["Nombre"].ToString();
					habitacion.Numero = Convert.ToInt32(row["Numero"].ToString());
					habitacion.CantidadCamas = Convert.ToInt32(row["CantidadCamas"].ToString());
					habitacion.CantidadCamasDisponibles = Convert.ToInt32(row["CantidadCamasDisponibles"].ToString());

					return habitacion;

				}
				return null;
			}
			catch (SqlException sqlex)
			{
				throw new ExceptionDAL(sqlex, sqlex.Message);
			}

			/*
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("HabitacionSelect");

			myDatabase.AddInParameter(myCommand, "@HabitacionId", DbType.Int32, habitacionId);

			return myDatabase.ExecuteDataSet(myCommand);
			*/
		}

		/// <summary>
		/// Selecciona todos los registros de la tabla Habitacion.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	12/07/2020 20:43:26
		/// </history>
		public static List<Habitacion> SelectAll()//DataSet SelectAll()
		{
			/*
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("HabitacionSelectAll");

			return myDatabase.ExecuteDataSet(myCommand);
			*/
			string spNombre = "HabitacionSelectAll";
			DataTable dt = new DataTable();
			List<Habitacion> lista = new List<Habitacion>();
			dt = dbNeg.EjecutarDataset(CommandType.StoredProcedure, spNombre, dbNeg.TipoBase.Residica, null).Tables[0];
			//return dbNeg.EjecutarDataset(CommandType.StoredProcedure, spNombre, dbNeg.TipoBase.Residica, null).Tables[0];

			foreach (DataRow row in dt.Rows)
			{
				Habitacion habitacion = new Habitacion();
				habitacion.HabitacionId = Convert.ToInt32(row["HabitacionId"].ToString());
				habitacion.Nombre = row["Nombre"].ToString();
				habitacion.Numero = Convert.ToInt32(row["Numero"].ToString());
				habitacion.CantidadCamas = Convert.ToInt32(row["CantidadCamas"].ToString());
				habitacion.CantidadCamasDisponibles  = Convert.ToInt32(row["CantidadCamasDisponibles"].ToString());

				lista.Add(habitacion);

			}
			return lista;
		}

		public static List<Habitacion> SelectDisponibles()//DataSet SelectAll()
		{
			/*
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("HabitacionSelectAll");

			return myDatabase.ExecuteDataSet(myCommand);
			*/
			string spNombre = "HabitacionesDisponibles";
			DataTable dt = new DataTable();
			List<Habitacion> lista = new List<Habitacion>();
			dt = dbNeg.EjecutarDataset(CommandType.StoredProcedure, spNombre, dbNeg.TipoBase.Residica, null).Tables[0];
			//return dbNeg.EjecutarDataset(CommandType.StoredProcedure, spNombre, dbNeg.TipoBase.Residica, null).Tables[0];

			foreach (DataRow row in dt.Rows)
			{
				Habitacion habitacion = new Habitacion();
				habitacion.HabitacionId = Convert.ToInt32(row["HabitacionId"].ToString());
				habitacion.Nombre = row["Nombre"].ToString();
				habitacion.Numero = Convert.ToInt32(row["Numero"].ToString());
				habitacion.CantidadCamas = Convert.ToInt32(row["CantidadCamas"].ToString());
				habitacion.CantidadCamasDisponibles = Convert.ToInt32(row["CantidadCamasDisponibles"].ToString());

				lista.Add(habitacion);

			}
			return lista;
		}

		public static int SelectCantidadDisponibles()//DataSet SelectAll()
		{
			/*
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("HabitacionSelectAll");

			return myDatabase.ExecuteDataSet(myCommand);
			*/
			string spNombre = "HabitacionesCantidadDisponibles";
			DataTable dt = new DataTable();
			int cantidadDispobile = 0;
			dt = dbNeg.EjecutarDataset(CommandType.StoredProcedure, spNombre, dbNeg.TipoBase.Residica, null).Tables[0];
			//return dbNeg.EjecutarDataset(CommandType.StoredProcedure, spNombre, dbNeg.TipoBase.Residica, null).Tables[0];

			foreach (DataRow row in dt.Rows)
			{
				cantidadDispobile = Convert.ToInt32(row["CantidadDisponibles"].ToString());
			}
			return cantidadDispobile;
		}
	}
}
