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
    public class FamiliaBLL
    {
        // Methods
        public static void Delete(Familia _object)
        {
            try
            {
                FamiliaFacade.Delete(_object);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static void DeleteAccesos(Familia _object)
        {
            try
            {
                FamiliaFacade.DeleteAccesos(_object);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static Familia GetAdapted(string IdFamiliaElement)
        {
            Familia var;
            try
            {
                var = FamiliaFacade.GetAdapted(IdFamiliaElement);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
            return var;
        }

        public static List<Familia> GetAllAdapted()
        {
            List<Familia> var;
            try
            {
                var = FamiliaFacade.GetAllAdapted();
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
            return var;
        }

        public static void Insert(Familia _object)
        {
            try
            {
                FamiliaFacade.Insert(_object);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static DataRow Select(string IdFamiliaElement)
        {
            DataRow var;
            try
            {
                var = FamiliaFacade.Select(IdFamiliaElement);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
            return var;
        }

        public static DataTable SelectAll()
        {
            DataTable var;
            try
            {
                var = FamiliaFacade.SelectAll();
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
            return var;
        }

        public static void Update(Familia _object)
        {
            try
            {
                FamiliaFacade.Update(_object);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }
    }
}
