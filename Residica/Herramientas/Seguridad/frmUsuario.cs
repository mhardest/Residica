using Residica.Herramientas.Backup;
using Servicios.Bitacora.BLL;
using Servicios.Seguridad;
using Servicios.Seguridad.BLL;
using Servicios.Seguridad.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residica.Herramientas.Seguridad
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            TraerTodosLosUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Desea eliminar el usuario seleccionado?", "Residica", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                EliminarUsuario();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmUsuarioModificar frmUsuarioModificar = new frmUsuarioModificar();
            frmUsuarioModificar.FormClosed += new FormClosedEventHandler(frmUsuarioModificar_FormClosed);
            frmUsuarioModificar.IdUsuarioValue = Convert.ToInt32(this.dgvUsuario.CurrentRow.Cells[0].Value);
            frmUsuarioModificar.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmUsuarioAlta frmUsuarioAlta = new frmUsuarioAlta();
            frmUsuarioAlta.FormClosed += new FormClosedEventHandler(frmUsuarioAlta_FormClosed);
            frmUsuarioAlta.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validaciones())
                {
                    string nombrecompleto = tbNombre.Text.Trim() != null ? tbNombre.Text.Trim() : null;
                    string documento = tbDocumento.Text.Trim() != null ? tbDocumento.Text.Trim() : null;

                    List<Usuario> lista = UsuarioBLL.GetAllAdapted(nombrecompleto, documento);

                    if (lista.Count > 0)
                    {
                        var view = from item in lista
                                   select new
                                   {
                                       Nro_Usuario = item.IdUsuario,
                                       Usuario = item.NombreUsuario,
                                       Documento = item.NumeroDocumento,
                                       Nombre_Completo = item.NombreCompleto,
                                       Estado = item.Estado
                                   };

                        this.dgvUsuario.DataSource = view.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Residica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Metodos

        private void TraerTodosLosUsuarios()
        {
            try
            {
                List<Usuario> lista = UsuarioBLL.GetAllAdapted();
                var view = from item in lista
                           select new
                           {
                               Nro_Usuario = item.IdUsuario,
                               Usuario = item.NombreUsuario,
                               Documento = item.NumeroDocumento,
                               Nombre_Completo = item.NombreCompleto,
                               Estado = item.Estado
                           };

                this.dgvUsuario.DataSource = view.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Residica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarUsuario()
        {
            try
            {

                int returnValue = 0;
                Usuario usuario = new Usuario();
                usuario.IdUsuario = Convert.ToInt32(dgvUsuario.CurrentRow.Cells[0].Value);
                returnValue = UsuarioBLL.Delete(usuario);

                if (returnValue != 0)
                {
                    this.TraerTodosLosUsuarios();

                    BitacoraBLL.GetInstance().RegistrarEnBitacora("Usuario eliminado Id: " + usuario.IdUsuario.ToString(), User._userSession.NombreUsuario, string.Empty, System.Diagnostics.TraceEventType.Information);
                    MessageBox.Show("Usuario eliminado exitosamente.", "Residica", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Residica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validaciones()
        {

            if (tbNombre.Text == string.Empty && tbDocumento.Text == string.Empty)
            {
                MessageBox.Show("Complete al menos un campo de búsqueda", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        void frmUsuarioAlta_FormClosed(object sender, EventArgs e)
        {
            TraerTodosLosUsuarios();
        }

        void frmUsuarioModificar_FormClosed(object sender, EventArgs e)
        {
            TraerTodosLosUsuarios();
        }


        #endregion

      
    }
}
