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

namespace Residica.Turnos.Traslados
{
    public partial class frmReservarTraslados : DevExpress.XtraEditors.XtraForm
    {
        public frmReservarTraslados()
        {
            InitializeComponent();
        }

        private void frmReservarTraslados_Load(object sender, EventArgs e)
        {
            cbTraslados.DataSource = GestionTurnosBLL.GetInstance().TraerTraslados();
            cbTraslados.DisplayMember = "Patente";
            cbTraslados.ValueMember = "TrasladoId";

            cbResidente.DataSource = GestorResidenteBLL.GetInstance().TraerResidentes();
            cbResidente.DisplayMember = "ApellidoNombre";
            cbResidente.ValueMember = "ResidenteId";

            dtDia.DateTime = DateTime.Now;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Turn turno = new Turn();
            turno.Tipo = 3;
            turno.ResidenteId = Convert.ToInt32(cbResidente.SelectedValue.ToString());
            turno.Fecha = Convert.ToDateTime(dtDia.Text);
            turno.TrasladoId = Convert.ToInt32(cbTraslados.SelectedValue.ToString());
            turno.Hora = Convert.ToInt32(tbHora.Text);
            turno.Duracion = 1;

            GestionTurnosBLL.GetInstance().AgregarTurno(turno);

            this.Close();
        }
    }
}
