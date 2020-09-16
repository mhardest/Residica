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

namespace Residica.Residentes
{
    public partial class frmGestionResidente : Form
    {
        public frmGestionResidente()
        {
            InitializeComponent();
            gbResidente.Visible = false;
            btnGuardarCambios.Visible = false;
            tbResidenteId.Visible = false;
        }

        private void btnNuevoResidente_Click(object sender, EventArgs e)
        {
            frmNuevoResidente frmNuevoResidente = new frmNuevoResidente();
            frmNuevoResidente.ShowDialog();
        }

        private void btnVerResidentes_Click(object sender, EventArgs e)
        {
            frmVerResidentes frmVerResidentes = new frmVerResidentes();
            frmVerResidentes.ShowDialog();
        }

        private void btnBuscarResidente_Click(object sender, EventArgs e)
        {
            gbResidente.Visible = false;
            btnGuardarCambios.Visible = false;

            if (Validaciones())
            {
                Residente residente;

                if (txtNroCuil.Text == string.Empty)
                {
                    int DocumentoNumero = Convert.ToInt32(txtNroDocumento.Text);
                    residente = GestorResidenteBLL.GetInstance().BuscarResidentePorDNI(DocumentoNumero);

                    if (residente.DocumentoNumero != 0)
                    {
                        tbResidenteId.Text = Convert.ToString(residente.ResidenteId);
                        tbApellido.Text = residente.Apellido;
                        tbNombre.Text = residente.Nombre;
                        tbDocumento.Text = Convert.ToString(residente.DocumentoNumero);
                        tbCuil.Text = Convert.ToString(residente.CUIL);
                        dtpFechaNacimiento.Text = Convert.ToString(residente.FechaNacimiento);
                        tbObraSocial.Text = residente.ObraSocial;
                        tbPersonaContacto.Text = residente.PersonaContacto;
                        tbTelefonoContacto.Text = residente.TelefonoContacto;
                        tbDireccionContacto.Text = residente.DireccionContacto;
                        tbTelefonoEmergencia.Text = residente.NumeroEmergencia;
                        rbObservacion.Text = residente.Observacion;

                        gbResidente.Visible = true;
                        btnGuardarCambios.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("El Número ingresado no coincide con ningún residente .", "Residica.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNroDocumento.Focus();
                    }
                }
                else
                {
                    int CUIL = Convert.ToInt32(txtNroCuil.Text);
                    residente = GestorResidenteBLL.GetInstance().BuscarResidentePorCUIL(CUIL);

                    if (residente.DocumentoNumero != 0)
                    {
                        tbResidenteId.Text = Convert.ToString(residente.ResidenteId);
                        tbApellido.Text = residente.Apellido;
                        tbNombre.Text = residente.Nombre;
                        tbDocumento.Text = Convert.ToString(residente.DocumentoNumero);
                        tbCuil.Text = Convert.ToString(residente.CUIL);
                        dtpFechaNacimiento.Text = Convert.ToString(residente.FechaNacimiento);
                        tbObraSocial.Text = residente.ObraSocial;
                        tbPersonaContacto.Text = residente.PersonaContacto;
                        tbTelefonoContacto.Text = residente.TelefonoContacto;
                        tbDireccionContacto.Text = residente.DireccionContacto;
                        tbTelefonoEmergencia.Text = residente.NumeroEmergencia;
                        rbObservacion.Text = residente.Observacion;

                        gbResidente.Visible = true;
                        btnGuardarCambios.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("El Número ingresado no coincide con ningún residente .", "Residica.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNroDocumento.Focus();
                    }
                }
            }
        }
        private bool Validaciones()
        {
            if (txtNroDocumento.Text == string.Empty && txtNroCuil.Text == string.Empty)
            {
                MessageBox.Show("Debe completar el DNI o el CUIL.", "Residica.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNroDocumento.Focus();
                return false;
            }
            return true;
        }
        private bool ValidacionesUpdate()
        {
            if (tbApellido.Text == string.Empty)
            {
                MessageBox.Show("Complete el Apellido.", "Residica.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbApellido.Focus();
                return false;
            }

            if (tbNombre.Text == string.Empty)
            {
                MessageBox.Show("Complete el Nombre.", "Residica.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbNombre.Focus();
                return false;
            }

            if (tbDocumento.Text == string.Empty)
            {
                MessageBox.Show("Complete el Número Documento.", "Residica.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbDocumento.Focus();
                return false;
            }

            if (tbCuil.Text == string.Empty)
            {
                MessageBox.Show("Complete el Número de CUIL.", "Residica.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbCuil.Focus();
                return false;
            }

            if (dtpFechaNacimiento.Text == string.Empty)
            {
                MessageBox.Show("Complete la fecha de nacimiento.", "Residica.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpFechaNacimiento.Focus();
                return false;
            }

            if (tbObraSocial.Text == string.Empty)
            {
                MessageBox.Show("Complete la Obra Social.", "Residica.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbObraSocial.Focus();
                return false;
            }

            if (tbPersonaContacto.Text == string.Empty)
            {
                MessageBox.Show("Complete la persona de contacto.", "Residica.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbPersonaContacto.Focus();
                return false;
            }

            if (tbTelefonoContacto.Text == string.Empty)
            {
                MessageBox.Show("Complete el telefono de contacto.", "Residica.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbTelefonoContacto.Focus();
                return false;
            }

            if (tbDireccionContacto.Text == string.Empty)
            {
                MessageBox.Show("Complete la dirección de contacto.", "Residica.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbDireccionContacto.Focus();
                return false;
            }
            return true;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (ValidacionesUpdate())
            {
                Residente residente = new Residente();
                residente.ResidenteId = Convert.ToInt32(tbResidenteId.Text);
                residente.Apellido = tbApellido.Text;
                residente.Nombre = tbNombre.Text;
                residente.DocumentoNumero = Convert.ToInt32(tbDocumento.Text);
                residente.CUIL = Convert.ToInt32(tbCuil.Text);
                residente.FechaNacimiento = Convert.ToDateTime(dtpFechaNacimiento.Text);
                residente.ObraSocial = tbObraSocial.Text;
                residente.PersonaContacto = tbPersonaContacto.Text;
                residente.TelefonoContacto = tbTelefonoContacto.Text;
                residente.DireccionContacto = tbDireccionContacto.Text;
                residente.NumeroEmergencia = tbTelefonoEmergencia.Text;
                residente.Observacion = rbObservacion.Text;
                residente.Estado = 4; 

                GestorResidenteBLL.GetInstance().ActualizarResidente(residente);

                MessageBox.Show("Cambios realizados con exito..", "Residica.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gbResidente.Visible = false;
                btnGuardarCambios.Visible = false;
                txtNroCuil.Text = "";
                txtNroDocumento.Text = "";
            }
        }
    }
}
