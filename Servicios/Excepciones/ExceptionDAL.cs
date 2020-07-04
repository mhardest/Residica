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
    public class ExceptionDAL : Exception
    {
        public ExceptionDAL(string mensaje) : base(mensaje)
        {
            BitacoraBLL.GetInstance().RegistrarEnBitacora("Se genero Exception DAL", User._userSession.NombreUsuario, mensaje, TraceEventType.Information);
        }

        public ExceptionDAL(Exception inner, string mensaje) : base(mensaje, inner)
        {
            string msg = mensaje + Environment.NewLine;
            msg += string.Format("Error :{0}{1}{2}", inner.Message.ToString(), Environment.NewLine, inner.StackTrace);

            if (inner != null)
            {
                BitacoraBLL.GetInstance().RegistrarEnBitacora("Se genero Exception DAL", User._userSession.NombreUsuario, mensaje, TraceEventType.Critical);

                throw new Exception("Error conectandose a la base de datos", inner);
            }
            else
            {
                BitacoraBLL.GetInstance().RegistrarEnBitacora("Se genero Exception DAL", User._userSession.NombreUsuario, mensaje, TraceEventType.Critical);
                BitacoraBLL.GetInstance().RegistrarEnBitacora("Se genero Exception DAL", User._userSession.NombreUsuario, mensaje, TraceEventType.Information);
            }
        }
    }
}
