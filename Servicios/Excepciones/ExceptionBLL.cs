using Servicios.Bitacora.BLL;
using Servicios.Seguridad;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Excepciones
{
    public class ExceptionBLL : Exception
    {
        public ExceptionBLL(string mensaje) : base(mensaje)
        {
            BitacoraBLL.GetInstance().RegistrarEnBitacora("Se genero Exception BLL", User._userSession.NombreUsuario, mensaje, TraceEventType.Critical);
        }

        public ExceptionBLL(Exception inner, string mensaje) : base(mensaje, inner)
        {
            //string msg = DateTime.Now + ": " + Message + Environment.NewLine;
            // msg += string.Format("{0}: Error running {1}. {2}{3}{4}", DateTime.Now, args.Method.Name, args.Exception.Message.ToString(), Environment.NewLine, args.Exception.StackTrace);

            string msg = mensaje + Environment.NewLine;
            msg += string.Format("Error :{0}{1}{2}", inner.Message.ToString(), Environment.NewLine, inner.StackTrace);

            BitacoraBLL.GetInstance().RegistrarEnBitacora("Se genero Exception BLL", User._userSession.NombreUsuario, msg, TraceEventType.Critical);
            BitacoraBLL.GetInstance().RegistrarEnBitacora("Se genero Exception BLL", User._userSession.NombreUsuario, msg, TraceEventType.Information);

            if (inner == null)
            {
                throw new Exception("Error accediendo al negocio.", inner);
            }
            else
            {
                throw new Exception("Error accediendo a datos.", inner);
            }
        }
    }
}
