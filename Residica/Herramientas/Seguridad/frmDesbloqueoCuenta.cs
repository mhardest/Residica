using Servicios.Bitacora.BLL;
using Servicios.Criptografia;
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
    public partial class frmDesbloqueoCuenta : Form
    {
        public frmDesbloqueoCuenta()
        {
            InitializeComponent();
        }

        private void frmDesbloqueoCuenta_Load(object sender, EventArgs e)
        {
            btnVerificar.Enabled = true;
            btnDesbloquear.Enabled = false;
            tbContraseñaActual.Enabled = false;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (UsuarioBLL.Bloqueado(tbUsuario.Text.Trim()))
            {
                tbContraseñaActual.Enabled = true;
                btnVerificar.Enabled = false;
                btnDesbloquear.Enabled = true;
            }
            else
            {
                MessageBox.Show("El Usuario seleccionado no esta bloqueado, o no existe.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Desea salir?", "Residica", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbContraseñaActual.Text.Length >= 3)
                {
                    Usuario usuario = UsuarioBLL.GetAdapted(tbUsuario.Text.Trim());
                    usuario.Password = HelperEncrypt.EncodePassword(tbContraseñaActual.Text, usuario.DigitoVerificador);
                    usuario.Estado = "A";
                    UsuarioBLL.Update_Desbloqueo(usuario);
                    BitacoraBLL.GetInstance().RegistrarEnBitacora("Desbloqueo de usuario", User._userSession.NombreUsuario, string.Empty, System.Diagnostics.TraceEventType.Information);
                    MessageBox.Show("Usuario desbloqueado correctamente", "Residica", MessageBoxButtons.OK, MessageBoxIcon.None);

                    tbUsuario.Clear();
                    tbContraseñaActual.Clear();
                    btnDesbloquear.Enabled = false;
                    tbContraseñaActual.Enabled = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La contraseña debe contener como mínimo 3 caracteres.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Residica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
