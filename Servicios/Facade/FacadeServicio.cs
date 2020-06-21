using Servicios.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Tracing;
using Servicios.Dominio;
using System.Diagnostics;
using Servicios.Dominio.Security;
using Servicios.Dominio.Security.Composite;

namespace Servicios.Facade
{
    public static class FacadeServicio
    {
        public static void ManejarExepciones(Exception ex)
        {
            ExceptionManager.Current.Handle(ex);
        }


        public static void Write(string message, EventLevel e, Usuario user = null)
        {
            TraceManager.Current.Write(message, e, user);
        }
    }
}
