using BLL;
using Dominio;
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
    public partial class frmReservarSalas : DevExpress.XtraEditors.XtraForm
    {
        public frmReservarSalas()
        {
            InitializeComponent();
        }

        private void frmReservarSalas_Load(object sender, EventArgs e)
        {
            cbSalas.DataSource = GestionTurnosBLL.GetInstance().TraerSalas();
            cbSalas.DisplayMember = "Nombre";
            cbSalas.ValueMember = "SalaId";

            cbResidente.DataSource = GestorResidenteBLL.GetInstance().TraerResidentes();
            cbResidente.DisplayMember = "ApellidoNombre";
            cbResidente.ValueMember = "ResidenteId";

            dtDia.DateTime = DateTime.Now;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Turn turno = new Turn();
            turno.Tipo = 2;
            turno.ResidenteId = Convert.ToInt32(cbResidente.SelectedValue.ToString());
            turno.Fecha = Convert.ToDateTime(dtDia.Text);
            turno.SalaId = Convert.ToInt32(cbSalas.SelectedValue.ToString());
            turno.Hora = Convert.ToInt32(tbHora.Text);
            turno.Duracion = 1;

            GestionTurnosBLL.GetInstance().AgregarTurno(turno);
        }
    }
}
