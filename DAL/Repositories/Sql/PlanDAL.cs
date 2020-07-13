using DAL.Repositories.Sql.Utiles;
using Dominio;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Servicios.Excepciones;
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
    public class PlanDAL
    {
		public static int Insert(string planNombre, decimal planImporte)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("PlanInsert");

			myDatabase.AddInParameter(myCommand, "@PlanNombre", DbType.String, planNombre);
			myDatabase.AddInParameter(myCommand, "@PlanImporte", DbType.Decimal, planImporte);

			//Ejecuta la consulta y retorna el nuevo identity.
			int returnValue = Convert.ToInt32(myDatabase.ExecuteScalar(myCommand));
			return returnValue;
		}

		/// <summary>
		/// Actualiza registros de la tabla Plan.
		/// </summary>
		/// <param name="planId"></param>
		/// <param name="planNombre"></param>
		/// <param name="planImporte"></param>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	12/07/2020 20:36:22
		/// </history>
		public static void Update(int planId, string planNombre, decimal planImporte)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("PlanUpdate");

			myDatabase.AddInParameter(myCommand, "@PlanId", DbType.Int32, planId);
			myDatabase.AddInParameter(myCommand, "@PlanNombre", DbType.String, planNombre);
			myDatabase.AddInParameter(myCommand, "@PlanImporte", DbType.Decimal, planImporte);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Suprime un registro de la tabla Plan por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	12/07/2020 20:36:22
		/// </history>
		public static void Delete(int planId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("PlanDelete");

			myDatabase.AddInParameter(myCommand, "@PlanId", DbType.Int32, planId);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Selecciona un registro desde la tabla Plan.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	12/07/2020 20:36:22
		/// </history>
		public static DataSet Select(int planId)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("PlanSelect");

			myDatabase.AddInParameter(myCommand, "@PlanId", DbType.Int32, planId);

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Selecciona todos los registros de la tabla Plan.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Matt]	12/07/2020 20:36:22
		/// </history>
		public static List<Plan> SelectAll()//DataTable SelectAll()
		{
			//Database myDatabase = DatabaseFactory.CreateDatabase();
			//DbCommand myCommand = myDatabase.GetStoredProcCommand("PlanSelectAll");

			//return myDatabase.ExecuteDataSet(myCommand);

			try
			{
				string spNombre = "PlanSelectAll";
				DataTable dt = new DataTable();
				List<Plan> lista = new List<Plan>();
				dt = dbNeg.EjecutarDataset(CommandType.StoredProcedure, spNombre, dbNeg.TipoBase.Residica, null).Tables[0];
				//return dbNeg.EjecutarDataset(CommandType.StoredProcedure, spNombre, dbNeg.TipoBase.Residica, null).Tables[0];

				foreach (DataRow row in dt.Rows)
				{
					Plan plan = new Plan();
					plan.PlanId = Convert.ToInt32(row["PlanId"].ToString());
					plan.Nombre = row["PlanNombre"].ToString();
					plan.Importe = Convert.ToDecimal(row["PlanImporte"].ToString());
					lista.Add(plan);
					
				}
				return lista;
			}
			catch (SqlException sqlex)
			{
				throw new ExceptionDAL(sqlex, sqlex.Message);
			}
		}
		
	}

}

