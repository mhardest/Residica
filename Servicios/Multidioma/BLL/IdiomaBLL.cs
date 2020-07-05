using Servicios.Excepciones;
using Servicios.Multioma.DAL;
using Servicios.Multioma.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Multioma.BLL
{
    public class IdiomaBLL
    {
        public static DataRow Select(int IdIdioma)
        {
            try
            {
                return IdiomaFacade.Select(IdIdioma);
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
                return IdiomaFacade.GetAllAdapted();
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static IdiomaDM GetAdapted(int IdIdioma)
        {
            try
            {
                return IdiomaFacade.GetAdapted(IdIdioma);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public static DataTable SelectAll()
        {
            DataTable dtIdioma = IdiomaDAL.SelectAll();
            return dtIdioma;
        }

        public static DataTable SelectAllLoad()
        {
            try
            {
                DataTable dtIdioma = IdiomaDAL.SelectAll();
                DataRow row = dtIdioma.NewRow();
                row["IdIdioma"] = 0;
                row["Descripcion"] = "Seleccione..";
                dtIdioma.Rows.InsertAt(row, 0);
                return dtIdioma;
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }


        public static DataTable Select_Text(int IdIdioma)
        {
            try
            {
                return IdiomaDAL.IdiomaTextoSelect(IdIdioma);
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }
    }
}
