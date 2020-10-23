using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residica.Turnos.Traslados
{
    public partial class frmGestionTraslados : DevExpress.XtraEditors.XtraForm
    {
        public frmGestionTraslados()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmReservarTraslados frmReservarTraslados = new frmReservarTraslados();
            frmReservarTraslados.ShowDialog();
        }

        private void frmGestionTraslados_Load(object sender, EventArgs e)
        {
            cbTraslados.DataSource = GestionTurnosBLL.GetInstance().TraerTraslados();
            cbTraslados.DisplayMember = "Patente";
            cbTraslados.ValueMember = "TrasladoId";

            cbResidente.DataSource = GestorResidenteBLL.GetInstance().TraerResidentes();
            cbResidente.DisplayMember = "ApellidoNombre";
            cbResidente.ValueMember = "ResidenteId";

            dtDia.DateTime = DateTime.Now;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = GestionTurnosBLL.GetInstance().TraerTurnos(0, DateTime.Now, 0);
        }
    }
}
