using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using BLL;
using Residica.Equipos;

namespace Residica.Turno
{
    public partial class frmGestionEquipos : DevExpress.XtraEditors.XtraForm
    {
        public frmGestionEquipos()
        {
            InitializeComponent();
        }

        private void frmGestionEquipos_Load(object sender, EventArgs e)
        {
            cbEquipos.DataSource = GestionTurnosBLL.GetInstance().TraerEquipos();
            cbEquipos.DisplayMember = "EquipoNombre";
            cbEquipos.ValueMember = "EquipoId";

            cbResidente.DataSource = GestorResidenteBLL.GetInstance().TraerResidentes();
            cbResidente.DisplayMember = "ApellidoNombre";
            cbResidente.ValueMember = "ResidenteId";

            dtDia.DateTime = DateTime.Now;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmReservarEquipo frmReservarEquipo = new frmReservarEquipo();
            frmReservarEquipo.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = GestionTurnosBLL.GetInstance().TraerTurnos(0, DateTime.Now, 0);
        }
    }
}