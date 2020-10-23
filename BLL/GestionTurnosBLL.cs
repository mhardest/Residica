using DAL.Repositories.Sql;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories.Sql.Utiles;

namespace BLL
{
    public class GestionTurnosBLL
    {
        private static GestionTurnosBLL Instance;
        private GestionTurnosBLL()
        { }
        public static GestionTurnosBLL GetInstance()
        {
            if (Instance == null)
            {
                lock (new object())
                {
                    if (Instance == null)
                    {
                        Instance = new GestionTurnosBLL();
                    }
                }
            }
            return Instance;
        }

        public List<Equipo> TraerEquipos()
        {
            List<Equipo> listaequipos = new List<Equipo>();
            listaequipos = EquipoDAL.SelectAll();
            return listaequipos;
        }

        public List<Sala> TraerSalas()
        {
            List<Sala> listasalas = new List<Sala>();
            listasalas = SalaDAL.SelectAll();
            return listasalas;
        }

        public List<Traslado> TraerTraslados()
        {
            List<Traslado> listatraslados = new List<Traslado>();
            listatraslados = TrasladoDAL.SelectAll();
            return listatraslados;
        }

        public void AgregarTurno(Turn turno)
        {
            TurnoDAL.Insert(turno);
        }

        public List<Turn> TraerTurnos(int ResidenteId, DateTime fecha, int Tipo)
        {
            List<Turn> listaturnos = new List<Turn>();    
            listaturnos = TurnoDAL.SelectAll();
            return listaturnos;
        }
    }
}
