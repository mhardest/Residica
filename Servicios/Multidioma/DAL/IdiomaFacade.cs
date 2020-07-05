using Servicios.Excepciones;
using Servicios.Multioma.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Multioma.DAL
{
    public class IdiomaFacade
    {
        public static IdiomaDM GetAdapted(int IdUsuario)
        {
            IdiomaDM varDataTable;
            try
            {
                IdiomaAdapter adapter = new IdiomaAdapter(IdiomaFacade.Select(IdUsuario));
                IdiomaDM _object = new IdiomaDM();
                adapter.Fill(_object);
                varDataTable = _object;
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
            return varDataTable;
        }

        public static DataRow Select(Int32 IdIdioma)
        {
            DataRow dr;
            try
            {
                return dr = IdiomaDAL.Select(IdIdioma).Rows[0];
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static List<IdiomaDM> GetAllAdapted()
        {
            try
            {
                List<IdiomaDM> lista;
                IdiomaCollectionAdapter adapter = new IdiomaCollectionAdapter(IdiomaFacade.SelectAll());
                List<IdiomaDM> collection = new List<IdiomaDM>();
                adapter.Fill(collection);
                lista = collection;
                return lista;
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
                DataTable dt;
                return dt = IdiomaDAL.SelectAll();
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }
    }
}

