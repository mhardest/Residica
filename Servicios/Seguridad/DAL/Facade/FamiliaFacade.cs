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
    public class FamiliaFacade
    {
        // Methods
        public static void Delete(Familia _object)
        {
            try
            {
                FamiliaDAL.Delete(_object);
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }

        public static void DeleteAccesos(Familia _object)
        {
            try
            {
                FamiliaDAL.DeleteAccesos(_object);
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }

        public static Familia GetAdapted(string IdFamiliaElement)
        {
            Familia varDataTable;
            try
            {
                FamiliaAdapter adapter = new FamiliaAdapter(FamiliaFacade.Select(IdFamiliaElement));
                Familia _object = new Familia();
                adapter.Fill(_object);
                varDataTable = _object;
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
            return varDataTable;
        }

        public static List<Familia> GetAllAdapted()
        {
            List<Familia> varDataTable;
            try
            {
                FamiliaCollectionAdapter adapter = new FamiliaCollectionAdapter(FamiliaFacade.SelectAll());
                List<Familia> collection = new List<Familia>();
                adapter.Fill(collection);
                varDataTable = collection;
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
            return varDataTable;
        }

        public static void Insert(Familia _object)
        {
            try
            {
                FamiliaDAL.Insert(_object);
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
                varDataTable = FamiliaDAL.Select(IdFamiliaElement).Rows[0];
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
                varDataTable = FamiliaDAL.SelectAll();
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
            return varDataTable;
        }

        public static void Update(Familia _object)
        {
            try
            {
                FamiliaDAL.Update(_object);
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }
    }
}
