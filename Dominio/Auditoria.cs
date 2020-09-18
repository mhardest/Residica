using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Auditoria
    {
        public int AuditoriaId { get; set; }
        public int ResidenteId { get; set; }
        public int ProfesionalId { get; set; }
        public DateTime FechaHora { get; set; }
        public string Observacion { get; set; }
    }
}
