using Servicios.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Backup
{
    public class BackupBLL
    {
        public static void RealizarBackUp(string ruta)
        {
            try
            {
                BackupDAL.RealizarBackup(ruta);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static void RealizarBackUpGestion(string ruta)
        {
            try
            {
                BackupDAL.RealizarBackupGestion(ruta);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }


        public static void RealizarRestore(string ruta)
        {
            try
            {
                BackupDAL.RealizarRestore(ruta);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static void RealizarRestoreGestion(string ruta)
        {
            try
            {
                BackupDAL.RealizarRestoreGestion(ruta);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }
    }
}
