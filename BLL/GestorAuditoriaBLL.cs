using DAL.Repositories.Sql;
using Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorAuditoriaBLL
    {
        private static GestorAuditoriaBLL Instance;
        private GestorAuditoriaBLL()
        { }
        public static GestorAuditoriaBLL GetInstance()
        {
            if (Instance == null)
            {
                lock (new object())
                {
                    if (Instance == null)
                    {
                        Instance = new GestorAuditoriaBLL();
                    }
                }
            }
            return Instance;
        }

        public List<Residente> TraerAuditados(int tipo)
        {
            List<Residente> listaplanes = new List<Residente>();
            List<Residente> listaplanesfinal = new List<Residente>();
            listaplanes = ResidenteDAL.SelectAll();
            foreach (var item in listaplanes)
            {
                switch (tipo)
                {
                    case 1: //Psicologia
                        if (item.AuditoriaPsicologica == true)
                        {
                            listaplanesfinal.Add(item);
                        }
                        break;
                    case 2:// Traumatilogica
                        if (item.AuditoriaTraumatologica == true)
                        {
                            listaplanesfinal.Add(item);
                        }
                        break;
                    case 3://Medica
                        if (item.AuditoriaMedica == true)
                        {
                            listaplanesfinal.Add(item);
                        }
                        break;
                    case 4://General
                        if (item.AuditoriaGeneral == true)
                        {
                            listaplanesfinal.Add(item);
                        }
                        break;
                }
            }

            return listaplanesfinal;
        }

        public List<Residente> TraerPendienteAuditoria(int tipo)
        {
            List<Residente> listaplanes = new List<Residente>();
            List<Residente> listaplanesfinal = new List<Residente>();
            listaplanes = ResidenteDAL.SelectAll();
            foreach (var item in listaplanes)
            {
                switch (tipo)
                {
                    case 1: //Psicologia
                        if (item.AuditoriaPsicologica == false)
                        {
                            listaplanesfinal.Add(item);
                        }
                        break;
                    case 2:// Traumatilogica
                        if (item.AuditoriaTraumatologica == false)
                        {
                            listaplanesfinal.Add(item);
                        }
                        break;
                    case 3://Medica
                        if (item.AuditoriaMedica == false)
                        {
                            listaplanesfinal.Add(item);
                        }
                        break;
                    case 4://General
                        if (item.AuditoriaGeneral == false)
                        {
                            listaplanesfinal.Add(item);
                        }
                        break;
                }

            }

            return listaplanesfinal;
        }

    }
}
