using Servicios.Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.BLL
{
    internal sealed class ExceptionManager
    {
        #region Singleton
        private readonly static ExceptionManager _instance = new ExceptionManager();

        public static ExceptionManager Current
        {
            get
            {
                return _instance;
            }
        }

        private ExceptionManager()
        {
            //Implement here the initialization code
        }
        #endregion
        public void Handle(Exception ex)
        {
            if (ex is BLLException)
            {
                Handle(ex as BLLException);
            }
            else if (ex is DALException)
            {
                Handle(ex as DALException);
            }
            else if (ex is UIException)
            {
                Handle(ex as UIException);
            }
            else
            {
                //Porque fallo
                throw new Exception("Exception desconocida", ex);
            }
            throw ex;
        }

        private void Handle(BLLException ex)
        {
            if (ex.InnerException is DALException)
            {
                //Es una BLL Exception que en realidad viene desde una DALException
                throw new Exception("Error accediendo a los datos comuniquese al 0800-ERROR (37767)", ex);
            }
            else
            {
                TraceManager.Current.Write(ex.Message, System.Diagnostics.Tracing.EventLevel.Error);
            }
        }

        private void Handle(DALException ex)
        {
            //Registro la exception en un archivo --> bitacora
            //
            TraceManager.Current.Write(ex.Message, System.Diagnostics.Tracing.EventLevel.Error);
            throw ex;
        }

        private void Handle(UIException ex)
        {
            //Registro la exception en un archivo --> bitacora

            throw ex;
        }
    }
}
