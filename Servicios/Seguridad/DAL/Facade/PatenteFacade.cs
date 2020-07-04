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
    public class PatenteFacade
    {
        public static void Delete(Patente _object)
        {
            try
            {
                PatenteDAL.Delete(_object);
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }

        public static Patente GetAdapted(string IdFamiliaElement)
        {
            Patente varDataTable;
            try
            {
                PatenteAdapter adapter = new PatenteAdapter(PatenteFacade.Select(IdFamiliaElement));
                Patente _object = new Patente();
                adapter.Fill(_object);
                varDataTable = _object;
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
            return varDataTable;
        }

        public static List<Patente> GetAllAdapted()
        {
            List<Patente> varDataTable;
            try
            {
                PatenteCollectionAdapter adapter = new PatenteCollectionAdapter(PatenteFacade.SelectAll());
                List<Patente> collection = new List<Patente>();
                adapter.Fill(collection);
                varDataTable = collection;
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
            return varDataTable;
        }

        public static void Insert(Patente _object)
        {
            try
            {
                PatenteDAL.Insert(_object);
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }

        public static DataRow Select(string IdFamiliaElement)
        {
            DataRow varDataTable;
            try
            {
                varDataTable = PatenteDAL.Select(IdFamiliaElement).Rows[0];
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
            return varDataTable;
        }

        public static DataTable SelectAll()
        {
            DataTable varDataTable;
            try
            {
                varDataTable = PatenteDAL.SelectAll();
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
            return varDataTable;
        }

        public static void Update(Patente _object)
        {
            try
            {
                PatenteDAL.Update(_object);
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }
    }
}
