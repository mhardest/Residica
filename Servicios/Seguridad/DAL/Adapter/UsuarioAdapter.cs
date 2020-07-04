using Servicios.Seguridad.DAL.Facade;
using Servicios.Seguridad.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad.DAL.Adapter
{
    public class UsuarioAdapter
    {

        // Fields
        private DataRow row;

        public UsuarioAdapter(DataRow row)
        {
            this.row = row;
        }

        public void FillPwd(Usuario _object)
        {
            _object.Password = (Convert.ToString(this.row[0]));
        }



        public void FillID(Usuario _object)
        {
            _object.IdUsuario = (Convert.ToInt32(this.row[0]));
        }

        public void Fill(Usuario _object)
        {
            Permiso Permisos;


            _object.IdUsuario = (Convert.ToInt32(this.row["IdUsuario"]));
            _object.NombreUsuario = (Convert.ToString(this.row["NombreUsuario"]));
            _object.NumeroDocumento = (Convert.ToString(this.row["NumeroDocumento"]));
            _object.NombreCompleto = (Convert.ToString(this.row["NombreCompleto"]));

            _object.Password = (Convert.ToString(this.row["Password"]));
            _object.IdIdioma = (int)this.row["IdIdioma"];
            _object.DigitoVerificador = Convert.ToString(this.row["DigitoVerificador"]);
            _object.Estado = Convert.ToString(this.row["Estado"]);


            _object.Sector = SectorFacade.GetAdapted(Convert.ToInt32(this.row["IdSector"]));

            DataTable relacionesFamilia = UsuarioDAL.GetFamilias(_object.IdUsuario);

            foreach (DataRow rowPermisos in relacionesFamilia.Rows)
            {
                Permisos = FamiliaFacade.GetAdapted(Convert.ToString(rowPermisos["IdFamilia"]));
                _object.Permisos.Add(Permisos);
            }

            DataTable relacionesPatente = UsuarioDAL.GetPatentes(_object.IdUsuario);

            foreach (DataRow rowPermisos in relacionesPatente.Rows)
            {
                Permisos = PatenteFacade.GetAdapted(Convert.ToString(rowPermisos["IdPatente"]));
                _object.Permisos.Add(Permisos);
            }

            _object.GestionarPermisos();

        }

    }
}
