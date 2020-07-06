using Servicios.Bitacora.BLL;
using Servicios.Criptografia;
using Servicios.Seguridad;
using Servicios.Seguridad.BLL;
using Servicios.Seguridad.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residica.Herramientas.Seguridad
{
    public partial class frmCambioContrasenia : Form
    {
        public frmCambioContrasenia()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Desea salir?", "Residica", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Validaciones())
                {
                    if ((UsuarioBLL.Validar(User._userSession.NombreUsuario, User._userSession.Password) != 0))
                    {
                        if (tbNuevaContraseña.Text.Length >= 3 && tbRepetirContraseña.Text.Length >= 3)
                        {
                            if (tbNuevaContraseña.Text == tbRepetirContraseña.Text)
                            {
                                Usuario usuario = UsuarioBLL.GetAdapted(User._userSession.IdUsuario);
                                usuario.Password = HelperEncrypt.EncodePassword(tbNuevaContraseña.Text, usuario.DigitoVerificador);
                                usuario.Estado = "A";
                                UsuarioBLL.Update_Desbloqueo(usuario);
                                BitacoraBLL.GetInstance().RegistrarEnBitacora("Cambio de contraseña", User._userSession.NombreUsuario, string.Empty, TraceEventType.Information);
                                MessageBox.Show("Cambio de contraseña exitoso", "Residica", MessageBoxButtons.OK, MessageBoxIcon.None);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Las contraseñas no coinciden.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Las contraseñas deben tener como mínimo 3 caracteres.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Residica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Metodos


        private bool Validaciones()
        {
            if (tbContraseñaActual.Text == string.Empty)
            {
                MessageBox.Show("Completa la contraseña actual.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbContraseñaActual.Focus();
                return false;
            }
            return true;
        }


        #endregion
    }
}
