using Servicios.External;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad.Dominio
{
    public class Usuario : Permiso
    {
        // Propiedades
        private List<Permiso> _permisos { get; set; }
        private List<Familia> _familiasFinales { get; set; }
        private List<Patente> _patentesFinales { get; set; }
        private Sector _sector { get; set; }


        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string NumeroDocumento { get; set; }
        public string Password { get; set; }
        public string DigitoVerificador { get; set; }
        public string Estado { get; set; }
        public int IdIdioma { get; set; }


        public List<Permiso> Permisos
        {
            get
            {
                if (_permisos == null)
                    _permisos = new List<Permiso>();
                return _permisos;
            }
            set { _permisos = value; }
        }
        public List<Familia> FamiliasFinales
        {
            get
            {
                if (_familiasFinales == null)
                    _familiasFinales = new List<Familia>();
                return _familiasFinales;
            }
            set { _familiasFinales = value; }
        }
        public List<Patente> PatentesFinales
        {
            get
            {
                if (_patentesFinales == null)
                    _patentesFinales = new List<Patente>();
                return _patentesFinales;
            }
            set { _patentesFinales = value; }
        }

        public Sector Sector
        {
            get
            {
                if (_sector == null)
                    _sector = new Sector();
                return _sector;
            }
            set { _sector = value; }
        }


        // Contructores
        public Usuario()
        {
            IdUsuario = DataTypes.IntNull;
            NombreUsuario = DataTypes.StringNull;
            NombreCompleto = DataTypes.StringNull;
            NumeroDocumento = DataTypes.StringNull;
            Password = DataTypes.StringNull;
            DigitoVerificador = DataTypes.StringNull;
            Estado = DataTypes.StringNull;
            IdIdioma = DataTypes.IntNull;
        }

        public Usuario(string nombreUsuario, string numeroDocumento, string nombreCompleto, int idSector, string password, int idIdioma, string digitoVerificador, string estado)
        {
            NombreUsuario = nombreUsuario;
            NumeroDocumento = numeroDocumento;
            NombreCompleto = nombreCompleto;
            Sector.IdSector = idSector;
            Password = password;
            IdIdioma = idIdioma;
            DigitoVerificador = digitoVerificador;
            Estado = estado;
        }

        public Usuario(int idusuario, string nombreUsuario, string numeroDocumento, string nombreCompleto, int idSector, int idIdioma)
        {
            IdUsuario = idusuario;
            NombreUsuario = nombreUsuario;
            NumeroDocumento = numeroDocumento;
            NombreCompleto = nombreCompleto;
            Sector.IdSector = idSector;
            IdIdioma = idIdioma;
        }

        public override void Add(Permiso permiso)
        {
            Permisos.Add(permiso);
        }

        public override void Remove(Permiso permiso)
        {
            Permisos.Remove(permiso);
        }

        public override int ChildrenCount
        {
            get
            {
                return Permisos.Count();
            }
        }

        public void GestionarPermisos()
        {
            if ((this.Permisos != null))
            {
                foreach (Permiso _tipo in this.Permisos)
                {
                    if (_tipo.GetType().Name == "Patente")
                    {
                        this.PatentesFinales.Add((Patente)_tipo);
                    }
                    else
                    {
                        dynamic existeFamilia = false;
                        this.ObtenerPermisosDeFamilia((Familia)_tipo);
                        foreach (Familia flia in this.FamiliasFinales)
                        {
                            if ((flia.Nombre == _tipo.Nombre))
                            {
                                existeFamilia = true;
                            }
                        }
                        if (!(existeFamilia))
                        {
                            this.FamiliasFinales.Add((Familia)_tipo);
                        }
                    }
                }
            }
        }

        public void ObtenerPermisosDeFamilia(Familia flia)
        {
            foreach (Permiso _tipo in flia.Permisos)
            {
                if (_tipo.GetType().Name == "Patente")
                {
                    this.PatentesFinales.Add((Patente)_tipo);
                }
                else
                {
                    dynamic existeFamilia = false;
                    this.ObtenerPermisosDeFamilia((Familia)_tipo);
                    foreach (Familia fli in this.FamiliasFinales)
                    {
                        if ((fli.Nombre == _tipo.Nombre))
                        {
                            existeFamilia = true;
                        }
                    }
                    if (!(existeFamilia))
                    {
                        this.FamiliasFinales.Add((Familia)_tipo);
                    }
                }
            }
        }
    }
}
