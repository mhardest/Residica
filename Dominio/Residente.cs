using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Residente
    {
        public int ResidenteId { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int DocumentoNumero { get; set; }
        public int CUIL { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string ObraSocial { get; set; }
        public Boolean AuditoriaPsicologica { get; set; }
        public Boolean AuditoriaMedica { get; set; }
        public Boolean AuditoriaTraumatologica { get; set; }
        public Boolean AuditoriaGeneral { get; set; }
        public int Estado { get; set; }
        public string Observacion { get; set; }
        public string TelefonoContacto { get; set; }
        public string PersonaContacto { get; set; }
        public string DireccionContacto { get; set; }
        public string NumeroEmergencia { get; set; }
        public int HabitacionId { get; set; }
        public int PlanId { get; set; }
    }
}
