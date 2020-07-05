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
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString();
            this.tbRutaGestion.Text = ConfigurationManager.AppSettings["ruta_backup"].ToString() + "ResidicaGestion_" + fecha + ".bak";
            this.tbRutaSeguridad.Text = ConfigurationManager.AppSettings["ruta_backup"].ToString() + "ResidicaSeguridad_" + fecha + ".bak";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                BackupBLL.RealizarBackUpGestion(tbRutaGestion.Text);

                if (DialogResult.OK == MessageBox.Show("Copia de seguridad realizada exitosamente.", "Residica", MessageBoxButtons.OK))
                {
                    BitacoraBLL.GetInstance().RegistrarEnBitacora("Se realizó copia se seguridad de la BD de Gestion.", User._userSession.NombreUsuario, string.Empty, System.Diagnostics.TraceEventType.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error realizando backup de la BD de Gestion" + ex, "Residica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                BackupBLL.RealizarBackUp(tbRutaSeguridad.Text);

                if (DialogResult.OK == MessageBox.Show("Copia de seguridad realizada exitosamente.", "Residica", MessageBoxButtons.OK))
                {
                    BitacoraBLL.GetInstance().RegistrarEnBitacora("Se realizó copia se seguridad de la BD de Seguridad.", User._userSession.NombreUsuario, string.Empty, System.Diagnostics.TraceEventType.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error realizando backup de la BD de Seguridad" + ex, "Residica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
