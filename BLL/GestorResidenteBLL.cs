using DAL.Repositories.Sql;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        enum EstadoResidente { Pendiente = 1, Reserva = 2, ReservaBaja = 3, Aceptado = 4, Rechazado = 5, Anulado = 6};
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
            _residente.Estado = Convert.ToInt32(EstadoResidente.Pendiente);
            ResidenteDAL.Insert(_residente);

            //Traigo la habitacion y le quito una cama disponible.
            Habitacion habitacion;
            habitacion = HabitacionDAL.SelectNew(_residente.HabitacionId);
            habitacion.CantidadCamasDisponibles -= 1;
            HabitacionDAL.Update(habitacion);
        }

        public void GenerarReserva(Residente _residente)
        {
            _residente.Estado = Convert.ToInt32(EstadoResidente.Reserva);
            ResidenteDAL.InsertReserva(_residente);
        }

        public Boolean HabitacionesDispobibles()
        {
            int CantidadDisponibles = 0;
            CantidadDisponibles = HabitacionDAL.SelectCantidadDisponibles();
            if (CantidadDisponibles >0)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public List<Residente> TraerResidentes()
        {
            List<Residente> listaplanes = new List<Residente>();
            List<Residente> listaplanesfinal = new List<Residente>();
            listaplanes = ResidenteDAL.SelectAll();
            foreach (var item  in listaplanes)
            {
                //Si el estado no es aceptado no lo muestro)
                if (item.Estado == Convert.ToInt32(EstadoResidente.Aceptado))
                {
                    item.ApellidoNombre = item.Apellido.Trim() + ", " + item.Nombre.Trim();
                    listaplanesfinal.Add(item);
                }

            }

            return listaplanesfinal;
        }

        public List<Residente> TraerListaEspera()
        {
            List<Residente> listaplanes = new List<Residente>();
            List<Residente> listaplanesfinal = new List<Residente>();
            listaplanes = ResidenteDAL.SelectAll();
            foreach (var item in listaplanes)
            {
                //Si el estado no es aceptado no lo muestro)
                if (item.Estado == Convert.ToInt32(EstadoResidente.Reserva))
                {
                    listaplanesfinal.Add(item);
                }

            }

            return listaplanesfinal;
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
        
       public Residente BuscarResidentePorDNI(int DNI)
       {
           Residente residente;
           return residente = ResidenteDAL.SelectByDNI(DNI);
       }

        
       public Residente BuscarResidentePorCUIL(int CUIL)
       {
            Residente residente;
            return residente = ResidenteDAL.SelectByCUIL(CUIL);
        }

        public void ActualizarResidente(Residente residente)
        {
            ResidenteDAL.Modificar(residente);
        }
    }
}

