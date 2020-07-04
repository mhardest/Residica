using Servicios.Excepciones;
using Servicios.Seguridad.DAL.Adapter;
using Servicios.Seguridad.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad.DAL.Facade
{
    public class SectorFacade
    {

        public static Sector GetAdapted(int IdSector)
        {
            Sector sector = null;
            try
            {
                SectorAdapter adapter = new SectorAdapter(SectorFacade.Select(IdSector));
                Sector _object = new Sector();
                adapter.Fill(_object);
                sector = _object;
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
            return sector;
        }

        public static List<Sector> GetAllAdapted()
        {
            List<Sector> lista = null;
            try
            {
                SectorCollectionAdapter adapter = new SectorCollectionAdapter(SectorFacade.SelectAll());
                List<Sector> collection = new List<Sector>();
                adapter.Fill(collection);
                lista = collection;
                return lista;
            }

            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }


        }

        public static DataRow Select(int IdSector)
        {
            DataRow dr;
            try
            {
                return dr = SectorDAL.Select(IdSector).Rows[0];
            }


            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }

        public static DataTable SelectAll()
        {
            try
            {
                DataTable dt;
                dt = SectorDAL.SelectAll();
                return dt;
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }
    }
}
