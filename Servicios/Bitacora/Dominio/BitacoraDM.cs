using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Bitacora.Dominio
{
    public class BitacoraDM
    {
        private string _IdEvento = Guid.NewGuid().ToString();

        public string IdEvento
        {
            get { return _IdEvento; }
            set { _IdEvento = value; }
        }

        public string IdUsuario { get; set; }

        public string Descripcion { get; set; }

        public string MessageExcep { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}

