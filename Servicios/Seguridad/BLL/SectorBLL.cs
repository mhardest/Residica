using Servicios.Excepciones;
using Servicios.Seguridad.DAL.Facade;
using Servicios.Seguridad.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad.BLL
{
    public class SectorBLL
    {
        public static Sector GetAdapted(int IdSector)
        {
            try
            {
                return SectorFacade.GetAdapted(IdSector);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }




        public static List<Sector> GetAllAdapted()
        {
            try
            {
                return SectorFacade.GetAllAdapted();
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static DataRow Select(int IdUsuario)
        {

            try
            {
                return SectorFacade.Select(IdUsuario);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static DataTable SelectAll()
        {
            try
            {
                return SectorFacade.SelectAll();
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

    }
}

