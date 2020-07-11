using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Habitacion
    {
        public int HabitacionId { get; set; }
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public int CantidadCamas { get; set; }
        public int CantidadCamasDisponibles { get; set; }

    }
}
