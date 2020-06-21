using Servicios.Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BizExceptions
{
    public class ClienteMenorEdadException : BLLException
    {
        public ClienteMenorEdadException() : base("El cliente no puede ser menor de edad.", true)
        {
            
        }
    }
}
