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
    public class UsuarioFacade
    {
        //public static int Login(String NombreUsuario, String Contrasenia)
        //{
        //    try
        //    {
        //        return UsuarioDal.Login(NombreUsuario, Contrasenia);
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
                return UsuarioDAL.Bloquear(NombreUsuario);
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }

        public static bool Existe(string NombreUsuario)
        {
            try
            {
                return UsuarioDAL.Existe(NombreUsuario);
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }

        public static bool ExisteByDocumento(string numerodocumento)
        {
            try
            {
                return UsuarioDAL.ExisteByDocumento(numerodocumento);
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }
        public static bool Bloqueado(string NombreUsuario)
        {
            try
            {
                return UsuarioDAL.Bloqueado(NombreUsuario);
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }

        public static int Validar(string NombreUsuario, string Password)
        {
            try
            {
                return UsuarioDAL.Validar(NombreUsuario, Password);
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }



        public static int Delete(Usuario _object)
        {
            try
            {
                return UsuarioDAL.Delete(_object);
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }

        public static void DeleteFamilias(Usuario _object)
        {
            try
            {
                UsuarioDAL.DeleteFamilias(_object);
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }

        public static void DeletePatentes(Usuario _object)
        {
            try
            {
                UsuarioDAL.DeletePatentes(_object);
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }

        public static Usuario GetAdapted(int IdUsuario)
        {

            try
            {
                Usuario usuario;
                UsuarioAdapter adapter = new UsuarioAdapter(UsuarioFacade.Select(IdUsuario));
                Usuario _object = new Usuario();
                adapter.Fill(_object);
                usuario = _object;
                return usuario;
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }

        }

        public static string GetAdapted(string loginID, int A)
        {
            string varData;
            try
            {
                UsuarioAdapter adapter = new UsuarioAdapter(UsuarioFacade.Select(loginID, A));
                Usuario _object = new Usuario();
                if (A == 1)
                {
                    adapter.FillPwd(_object);
                    varData = _object.Password;
                }
                else
                {
                    adapter.FillID(_object);
                    varData = _object.IdUsuario.ToString();
                }
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
            return varData;
        }


        public static Usuario GetAdapted(string nombreUsuario)
        {
            try
            {
                Usuario usuario;
                UsuarioAdapter adapter = new UsuarioAdapter(UsuarioFacade.Select(nombreUsuario));
                Usuario _object = new Usuario();
                adapter.Fill(_object);
                usuario = _object;
                return _object;
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }


        public static List<Usuario> GetAllAdapted()
        {
            List<Usuario> varDataTable;
            try
            {
                UsuarioCollectionAdapter adapter = new UsuarioCollectionAdapter(UsuarioFacade.SelectAll());
                List<Usuario> collection = new List<Usuario>();
                adapter.Fill(collection);
                varDataTable = collection;
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
            return varDataTable;
        }

        public static int Insert(Usuario _object)
        {
            try
            {
                return UsuarioDAL.Insert(_object);
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }

        public static DataRow Select(int IdUsuario)
        {
            DataRow dr;
            try
            {
                return dr = UsuarioDAL.Select(IdUsuario).Rows[0];
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }

        }

        public static DataRow Select(string nombreUsuario)
        {
            try
            {
                DataRow dr;
                return dr = UsuarioDAL.Select(nombreUsuario).Rows[0];
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }

        public static DataRow Select(string loginID, int A)
        {
            DataRow dr;
            try
            {
                return dr = UsuarioDAL.Select(loginID, A).Rows[0];
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }

        public static DataTable SelectAll()
        {
            DataTable dt;
            try
            {
                return dt = UsuarioDAL.SelectAll();
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }

        }

        public static int Update(Usuario _object)
        {
            try
            {
                return UsuarioDAL.Update(_object);
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
        }



        public static List<Usuario> GetAllAdapted(string nombre, string documento)
        {
            List<Usuario> varDataTable;
            try
            {
                UsuarioCollectionAdapter adapter = new UsuarioCollectionAdapter(UsuarioFacade.SelectAll(nombre, documento));
                List<Usuario> collection = new List<Usuario>();
                adapter.Fill(collection);
                varDataTable = collection;
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }
            return varDataTable;
        }

        public static DataTable SelectAll(string nombre, string documento)
        {
            DataTable dt;
            try
            {
                return dt = UsuarioDAL.SelectAll(nombre, documento);
            }
            catch (ExceptionDAL dalex)
            {
                throw new ExceptionBLL(dalex, dalex.Message);
            }

        }
    }
}
