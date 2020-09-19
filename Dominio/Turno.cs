using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {
        int TurnoId { get; set; }
        int Tipo { get; set; }
        DateTime Fecha { get; set;}
        int Hora { get; set; }
        int Duracion { get; set; }
        int ResidenteId { get; set; }
        int SalaId { get; set; }
        int EquipoId { get; set; }
        int TrasladoId { get; set; }
    }
}
