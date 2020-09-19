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

namespace Residica.Auditoria
{
    public partial class frmAuditoria : Form
    {
        public frmAuditoria(Residente residente, int profesional)
        {
            InitializeComponent();
            txtResidente.Text = residente.Apellido.Trim() + ", " + residente.Nombre.Trim();
            txtDocumento.Text = Convert.ToString(residente.DocumentoNumero);
            txtResidenteId.Text = Convert.ToString(residente.ResidenteId);
            txtProfesionalId.Text = Convert.ToString(profesional);
            txtResidente.ReadOnly = true;
            txtDocumento.ReadOnly = true;
            txtResidenteId.Visible = false;
            txtProfesionalId.Visible = false;
            rtbObservacion.Focus();

            if (profesional == 5)
            {
                btnConfirmar.Text = "Aceptar Residente";
                btnCancelar.Text = "Aceptar Residente";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int residenteid = Convert.ToInt32(txtResidenteId.Text);
            int profesionalid = Convert.ToInt32(txtProfesionalId.Text);
            string Observacion = rtbObservacion.Text;
            DateTime dt = DateTime.Now;
            if (profesionalid == 5)
            {
                GestorAuditoriaBLL.GetInstance().AceptarResidente(residenteid, profesionalid, dt, Observacion);
            }
            else
            {     
            GestorAuditoriaBLL.GetInstance().AgregarAduditoria(residenteid, profesionalid, dt, Observacion);
            }
            MessageBox.Show("Residente Auditado Correctamente.");
            this.Hide();
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            int residenteid = Convert.ToInt32(txtResidenteId.Text);
            int profesionalid = Convert.ToInt32(txtProfesionalId.Text);
            string Observacion = rtbObservacion.Text;
            DateTime dt = DateTime.Now;
            if (profesionalid != 5)
            {
                this.Hide();
            }
            else
            {
                GestorAuditoriaBLL.GetInstance().RechazarResidente(residenteid, profesionalid, dt, Observacion);
            }
            
        }
    }
}
