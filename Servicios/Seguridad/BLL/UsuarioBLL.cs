using Servicios.Excepciones;
using Servicios.Seguridad.DAL;
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
    public class UsuarioBLL
    {
        //public static int Login(String NombreUsuario, String Contrasenia)
        //{
        //    try
        //    {
        //        return UsuarioFacade.Login(NombreUsuario, Contrasenia);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        public static int Bloquear(string NombreUsuario)
        {
            try
            {
                return UsuarioFacade.Bloquear(NombreUsuario);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static bool Existe(string NombreUsuario)
        {
            try
            {
                return UsuarioFacade.Existe(NombreUsuario);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }


        public static bool ExisteByDocumento(string numerodocumento)
        {
            try
            {
                return UsuarioFacade.ExisteByDocumento(numerodocumento);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }
        public static bool Bloqueado(string NombreUsuario)
        {
            try
            {
                return UsuarioFacade.Bloqueado(NombreUsuario);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static int Validar(string NombreUsuario, string Password)
        {
            try
            {
                return UsuarioFacade.Validar(NombreUsuario, Password);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static int Delete(Usuario _object)
        {
            try
            {
                return UsuarioFacade.Delete(_object);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static Usuario GetAdapted(int IdUsuario)
        {
            try
            {
                return UsuarioFacade.GetAdapted(IdUsuario);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static string GetAdapted(string loginID, int A)
        {
            try
            {
                return UsuarioFacade.GetAdapted(loginID, A);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static Usuario GetAdapted(string nombreUsuario)
        {
            try
            {
                return UsuarioFacade.GetAdapted(nombreUsuario);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static List<Usuario> GetAllAdapted()
        {
            try
            {
                return UsuarioFacade.GetAllAdapted();
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static List<Usuario> GetAllAdapted(string nombre, string documento)
        {
            try
            {
                return UsuarioFacade.GetAllAdapted(nombre, documento);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static int Insert(Usuario _object)
        {
            try
            {
                return UsuarioFacade.Insert(_object);
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
                return UsuarioFacade.Select(IdUsuario);
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
                return UsuarioFacade.SelectAll();
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static int Update(Usuario _object)
        {
            try
            {
                return UsuarioFacade.Update(_object);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static int Update_Desbloqueo(Usuario _object)
        {
            try
            {
                return UsuarioDAL.Update_Desbloqueo(_object);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static void ActualizarPermisos(Usuario _object)
        {
            try
            {
                UsuarioDAL.ActualizarPermisos(_object);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }
    }
}
