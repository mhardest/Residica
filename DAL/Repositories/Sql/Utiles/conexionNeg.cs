using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Sql.Utiles
{
    public sealed class conexionNeg
    {
        private static conexionNeg instance;
        static conexionNeg() { }

        public static conexionNeg Instance
        {
            get
            {
                if (instance == null)
                    instance = new conexionNeg();
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
