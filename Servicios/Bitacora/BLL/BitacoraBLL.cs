using Servicios.Bitacora.DAL;
using Servicios.Bitacora.Dominio;
using Servicios.Excepciones;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Bitacora.BLL
{
    public class BitacoraBLL
    {
        private static BitacoraBLL Instance;
        private BitacoraBLL()
        { }

        public static BitacoraBLL GetInstance()
        {
            if (Instance == null)
            {
                lock (new object())
                {
                    if (Instance == null)
                    {
                        Instance = new BitacoraBLL();
                    }
                }
            }
            return Instance;
        }


        public void RegistrarEnBitacora(string descripcion, string usuarionNombre, string messageExcep, TraceEventType traza)
        {
            try
            {
                BitacoraDM bitacora = new BitacoraDM();
                bitacora.Descripcion = descripcion;
                bitacora.IdUsuario = usuarionNombre;
                bitacora.MessageExcep = messageExcep;
                bitacora.TimeStamp = DateTime.Now;


                if (traza == TraceEventType.Critical)
                {
                    BitacoraDAL.RegistrarBitacoraTxt(bitacora);
                }
                else
                {
                    BitacoraDAL.RegistrarEnBitacora(bitacora);
                }
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }

        public List<BitacoraDM> ObtenerEventosBitacora()
        {
            try
            {
                List<BitacoraDM> lista = new List<BitacoraDM>();
                lista = BitacoraDAL.ObtenerEventosBitacora();
                return lista;
            }
            catch (ExceptionBLL bllex)
            {
                throw new ExceptionBLL(bllex, bllex.Message);
            }
        }
    }
}
