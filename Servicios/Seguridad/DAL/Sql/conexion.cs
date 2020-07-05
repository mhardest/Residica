using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad.DAL.Sql
{
    public sealed class conexion
    {
        private static conexion instance;
        static conexion() { }

        public static conexion Instance
        {
            get
            {
                if (instance == null)
                    instance = new conexion();
                return instance;
            }
        }

        public SqlConnection GetDBConnectionResidica()
        {
            SqlConnection connResidicaGestion = new SqlConnection(ConfigurationManager.ConnectionStrings["Residica"].ConnectionString);
            return connResidicaGestion;
        }

        public SqlConnection GetDBConnectionResidicaSeguridad()
        {
            SqlConnection connQuickSeguridad = new SqlConnection(ConfigurationManager.ConnectionStrings["ResidicaSeguridad"].ConnectionString);
            return connQuickSeguridad;
        }
    }
}
