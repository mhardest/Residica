using Servicios.Excepciones;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Sql.Utiles
{
    public class dbNeg
    {
        public enum TipoBase
        {
            Residica = 0,
            ResidicaSeguridad = 1
        }

        public static SqlConnection GetConnection(TipoBase tipoBase)
        {
            SqlConnection conn = null;

            switch (tipoBase)
            {
                case TipoBase.Residica:
                    conn = conexionNeg.Instance.GetDBConnectionResidica();
                    break;
                case TipoBase.ResidicaSeguridad:
                    conn = conexionNeg.Instance.GetDBConnectionResidicaSeguridad();
                    break;
            }
            return conn;
        }

        public static DataSet EjecutarDataset(CommandType commandType, string commandText, TipoBase tipoBase, params SqlParameter[] commandParameters)
        {
            try
            {
                SqlConnection connection = GetConnection(tipoBase);
                return EjecutarDataset(connection, commandType, commandText, 180, commandParameters);
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }


        private static DataSet EjecutarDataset(SqlConnection connection, CommandType commandType, string commandText, int commandTimeOut, params SqlParameter[] commandParameters)
        {
            if (connection == null) throw new ExceptionDAL("Error de connection");

            // Create a command and prepare it for execution
            SqlCommand cmd = new SqlCommand();
            if (commandTimeOut > 0)
                cmd.CommandTimeout = commandTimeOut;
            PrepararComando(cmd, connection, (SqlTransaction)null, commandType, commandText, commandParameters);

            try
            {
                // Create the DataAdapter & DataSet
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();

                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);

                    // Detach the SqlParameters from the command object, so they can be used again
                    cmd.Parameters.Clear();

                    connection.Close();

                    cmd.Dispose();

                    // Return the dataset
                    return ds;
                }
            }
            catch (SqlException sqlex)
            {
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }
        }

        private static void AdjuntarParametros(SqlCommand command, SqlParameter[] commandParameters)
        {
            if (command == null) throw new ExceptionDAL("Error de commando");
            if (commandParameters != null)
            {
                foreach (SqlParameter p in commandParameters)
                {
                    if (p != null)
                    {
                        // Compruebo que el valor de salida tengo un valor sin asignar
                        if ((p.Direction == ParameterDirection.InputOutput ||
                            p.Direction == ParameterDirection.Input) &&
                            (p.Value == null))
                        {
                            p.Value = DBNull.Value;
                        }
                        command.Parameters.Add(p);
                    }
                }
            }
        }

        public static int EjecutarConsulta(TipoBase tipoBase, CommandType commandType, String commandText, params SqlParameter[] commandParameters)
        {
            SqlConnection connection = GetConnection(tipoBase);
            int retval = 0;
            if (connection == null) throw new ExceptionDAL("Error de connection");

            // Create a command and prepare it for execution
            SqlCommand cmd = new SqlCommand();
            PrepararComando(cmd, connection, (SqlTransaction)null, commandType, commandText, commandParameters);

            // Finally, execute the command
            try
            {
                retval = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //throw new Exception("EjecutarQuery - Db.EjecutarQuery.Poligono ", ex);
                throw ex;
            }

            // Detach the SqlParameters from the command object, so they can be used again
            cmd.Parameters.Clear();
            connection.Close();
            cmd.Dispose();

            return retval;
        }

        private static void PrepararComando(SqlCommand command, SqlConnection connection, SqlTransaction transaction, CommandType commandType, String commandText, SqlParameter[] commandParameters)
        {
            if (command == null) throw new ExceptionDAL("Error de commando");
            if (commandText == null || commandText.Length == 0) throw new ExceptionDAL("Error de commandText");

            // If the provided connection is not open, we will open it
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            // Associate the connection with the command
            command.Connection = connection;

            // Set the command text (stored procedure name or SQL statement)
            command.CommandText = commandText;

            // If we were provided a transaction, assign it
            if (transaction != null)
            {
                if (transaction.Connection == null) throw new ExceptionDAL("La transaction no puede realizar rollback o commit, por favor proporcione una transaction abierta.");
                command.Transaction = transaction;
            }

            // Set the command type
            command.CommandType = commandType;

            // Attach the command parameters if they are provided
            if (commandParameters != null)
            {
                AdjuntarParametros(command, commandParameters);
            }
            return;
        }

        public static int EjecutarConsultaTransaction(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            // Creamos el objeto Transaction
            if (transaction == null) throw new ExceptionDAL("Error transaction");
            if (transaction != null && transaction.Connection == null) throw new ExceptionDAL("La transaction no puede realizar rollback o commit, por favor proporcione una transaction abierta.");

            // Create a command and prepare it for execution
            SqlCommand cmd = new SqlCommand();

            PrepararComando(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters);

            // Finally, execute the command
            int retval = cmd.ExecuteNonQuery();

            // Detach the SqlParameters from the command object, so they can be used again
            cmd.Parameters.Clear();
            cmd.Dispose();
            return retval;
        }

        public static SqlDataReader EjecutarReader(CommandType commandType, string commandText, TipoBase tipoBase, params SqlParameter[] commandParameters)
        {
            SqlConnection connection = GetConnection(tipoBase);
            return EjecutarReader(connection, (SqlTransaction)null, commandType, commandText, 0, commandParameters);
        }

        public static SqlDataReader EjecutarReader(SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, int commandTimeOut, params SqlParameter[] commandParameters)
        {
            if (connection == null) throw new ExceptionDAL("connection");
            // Create a command and prepare it for execution
            SqlCommand cmd = new SqlCommand();
            if (commandTimeOut > 0)
                cmd.CommandTimeout = commandTimeOut;
            try
            {
                PrepararComando(cmd, connection, transaction, commandType, commandText, commandParameters);

                // Create the DataAdapter & DataSet
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    // Fill the Reader using default values for DataTable names, etc
                    //SqlDataReader reader = cmd.ExecuteReader();
                    SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    // Detach the SqlParameters from the command object, so they can be used again
                    cmd.Parameters.Clear();
                    cmd.Dispose();

                    // Return the dataset
                    return reader;
                }
            }
            catch (SqlException sqlex)
            {
                //ExceptionHandler.Handle(ex);
                connection.Close();
                cmd.Dispose();
                throw new ExceptionDAL(sqlex, sqlex.Message);
            }

        }
    }
}
