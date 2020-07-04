using Servicios.Seguridad.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad
{
    public abstract class User
    {
        private static Usuario userSession;
        public static Usuario _userSession
        {
            get
            {
                if (userSession == null)
                    userSession = new Usuario();
                return userSession;
            }
            set { userSession = value; }
        }
    }
}
