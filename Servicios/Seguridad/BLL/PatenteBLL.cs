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
    public class PatenteBLL
    {
        // Methods
        public static void Delete(Patente _object)
        {
            try
            {
                PatenteFacade.Delete(_object);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static Patente GetAdapted(string IdFamiliaElement)
        {
            Patente var;
            try
            {
                var = PatenteFacade.GetAdapted(IdFamiliaElement);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
            return var;
        }

        public static List<Patente> GetAllAdapted()
        {
            List<Patente> var;
            try
            {
                var = PatenteFacade.GetAllAdapted();
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
            return var;
        }

        public static void Insert(Patente _object)
        {
            try
            {
                PatenteFacade.Insert(_object);
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
                var = PatenteFacade.Select(IdFamiliaElement);
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
                var = PatenteFacade.SelectAll();
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
            return var;
        }

        public static void Update(Patente _object)
        {
            try
            {
                PatenteFacade.Update(_object);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }
    }
}
