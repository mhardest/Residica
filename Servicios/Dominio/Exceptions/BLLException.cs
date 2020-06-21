using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Dominio.Exceptions
{
    public class BLLException : Exception
    {
        public bool IsBussinessException { get; private set; }
        public BLLException(Exception ex, bool IsBussinessException = false) : base("BLL Exception", ex)
        {
            this.IsBussinessException = IsBussinessException;
        }

        public BLLException(string message, bool IsBussinessException = false) : base(message)
        {
            this.IsBussinessException = IsBussinessException;
        }
    }
}

