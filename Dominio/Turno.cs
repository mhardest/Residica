using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turn
    {
        public int TurnoId { get; set; }
        public int Tipo { get; set; }
        public DateTime Fecha { get; set;}
        public int Hora { get; set; }
        public int Duracion { get; set; }
        public int ResidenteId { get; set; }
        public int SalaId { get; set; }
        public int EquipoId { get; set; }
        public int TrasladoId { get; set; }
    }
}
