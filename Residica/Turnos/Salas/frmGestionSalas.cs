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

namespace Residica.Turnos.Salas
{
    public partial class frmGestionSalas :  DevExpress.XtraEditors.XtraForm
    {
        public frmGestionSalas()
        {
            InitializeComponent();
        }

        private void frmGestionSalas_Load(object sender, EventArgs e)
        {
            cbSala.DataSource = GestionTurnosBLL.GetInstance().TraerSalas();
            cbSala.DisplayMember = "Nombre";
            cbSala.ValueMember = "SalaId";

            cbResidente.DataSource = GestorResidenteBLL.GetInstance().TraerResidentes();
            cbResidente.DisplayMember = "ApellidoNombre";
            cbResidente.ValueMember = "ResidenteId";

            dtDia.DateTime = DateTime.Now;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmReservarSalas frmReservarSalas = new frmReservarSalas();
            frmReservarSalas.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = GestionTurnosBLL.GetInstance().TraerTurnos(0, DateTime.Now, 0);
        }
    }
}
