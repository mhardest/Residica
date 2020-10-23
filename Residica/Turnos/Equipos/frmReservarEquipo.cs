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
using BLL;
using Dominio;

namespace Residica.Equipos
{
    public partial class frmReservarEquipo : DevExpress.XtraEditors.XtraForm
    {
        public frmReservarEquipo()
        {
            InitializeComponent();
        }

        private void frmReservarEquipo_Load(object sender, EventArgs e)
        {
            cbEquipos.DataSource = GestionTurnosBLL.GetInstance().TraerEquipos();
            cbEquipos.DisplayMember = "EquipoNombre";
            cbEquipos.ValueMember = "EquipoId";

            cbResidente.DataSource = GestorResidenteBLL.GetInstance().TraerResidentes();
            cbResidente.DisplayMember = "ApellidoNombre";
            cbResidente.ValueMember = "ResidenteId";

            dtDia.DateTime = DateTime.Now;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Turn turno = new Turn();
            turno.Tipo = 1;
            turno.ResidenteId = Convert.ToInt32(cbResidente.SelectedValue.ToString());
            turno.Fecha = Convert.ToDateTime(dtDia.Text);
            turno.EquipoId = Convert.ToInt32(cbEquipos.SelectedValue.ToString());
            turno.Hora = Convert.ToInt32(tbHora.Text);
            turno.Duracion = 1;

            GestionTurnosBLL.GetInstance().AgregarTurno(turno);
               
        }
    }
}