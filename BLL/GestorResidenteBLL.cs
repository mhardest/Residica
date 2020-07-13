using DAL.Repositories.Sql;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorResidenteBLL
    {
        private static GestorResidenteBLL Instance;
        private GestorResidenteBLL()
        { }

        public static GestorResidenteBLL GetInstance()
        {
            if (Instance == null)
            {
                lock (new object())
                {
                    if (Instance == null)
                    {
                        Instance = new GestorResidenteBLL();
                    }
                }
            }
            return Instance;
        }
        public void AgregarResidente(Residente _residente)
        {
            ResidenteDAL.Insert(_residente);

            //Traigo la habitacion y le quito una cama disponible.
            Habitacion habitacion;
            habitacion = HabitacionDAL.SelectNew(_residente.HabitacionId);
            habitacion.CantidadCamasDisponibles -= 1;
            HabitacionDAL.Update(habitacion);
        }

        public void GenerarReserva(Residente _residente)
        {
            ResidenteDAL.InsertReserva(_residente);
        }

        public Boolean HabitacionesDispobibles()
        {
            return false;
        }

        public List<Plan> TraerPlanesHabilitados()
        {
            List<Plan> listaplanes = new List<Plan>();
            
            return listaplanes = PlanDAL.SelectAll();
        }

        public List<Habitacion> TraerHabitacionesDisponibles()
        {
            List<Habitacion> listahabitaciones = new List<Habitacion>();
            return listahabitaciones = HabitacionDAL.SelectDisponibles();
        }
    }
}
