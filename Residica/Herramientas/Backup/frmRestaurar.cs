using Servicios.Backup;
using Servicios.Bitacora.BLL;
using Servicios.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residica.Herramientas.Backup
{
    public partial class frmRestaurar : Form
    {
        public frmRestaurar()
        {
            InitializeComponent();
            tbRutaGestion.Enabled = false;
            tbRutaSeguridad.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Está seguro que desea cancelar?", "Residica", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
            {
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                BackupBLL.RealizarRestoreGestion(tbRutaGestion.Text);

                if (DialogResult.OK == MessageBox.Show("Restauración realizada exitosamente.", "Residica", MessageBoxButtons.OK))
                {
                    BitacoraBLL.GetInstance().RegistrarEnBitacora("Se realizó la restauración de la BD de Gestion.", User._userSession.NombreUsuario, string.Empty, System.Diagnostics.TraceEventType.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error realizando la restauración de la BD de Gestion" + ex, "Residica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                BackupBLL.RealizarRestore(tbRutaSeguridad.Text);

                if (DialogResult.OK == MessageBox.Show("Restauración realizada exitosamente.", "Residica", MessageBoxButtons.OK))
                {
                    BitacoraBLL.GetInstance().RegistrarEnBitacora("Se realizó la restauración de la BD de Seguridad.", User._userSession.NombreUsuario, string.Empty, System.Diagnostics.TraceEventType.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error realizando la restauración de la BD de Seguridad" + ex, "Residica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRestaurar_Load(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString();
            this.tbRutaGestion.Text = ConfigurationManager.AppSettings["ruta_backup"].ToString() + "ResidicaGestion_" + fecha + ".bak";
            this.tbRutaSeguridad.Text = ConfigurationManager.AppSettings["ruta_backup"].ToString() + "ResidicaSeguridad_" + fecha + ".bak";
        }
    }
}
