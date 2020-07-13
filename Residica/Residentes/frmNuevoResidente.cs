using System;
using Dominio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Residica.Residentes
{
    public partial class frmNuevoResidente : Form
    {
        private Boolean segundavez = false;
        public frmNuevoResidente()
        {
            InitializeComponent();
        }

        private void frmNuevoResidente_Load(object sender, EventArgs e)
        {
            PlanHabitacion.Visible = false;
            btnAceptar.Text = "Verificar Disponibilidad";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                if (segundavez == false)
                {
                    Boolean Disponibles = false;
                    Disponibles = GestorResidenteBLL.GetInstance().HabitacionesDispobibles();

                    // Si existen habitaciones disponibles voy a la nueva pantalla que pido el Plan y la habitacion.
                    if (Disponibles)
                    {
                        PlanHabitacion.Visible = true;
                        btnAceptar.Text = "Aceptar";
                        segundavez = true;
                        //Busco los planes
                        cbPlan.DataSource = GestorResidenteBLL.GetInstance().TraerPlanesHabilitados();
                        cbPlan.DisplayMember = "Nombre";
                        cbPlan.ValueMember = "PlanId";

                        //Busco las habitaciones
                        cbHabitacion.DataSource = GestorResidenteBLL.GetInstance().TraerHabitacionesDisponibles();
                        cbHabitacion.DisplayMember = "Nombre";
                        cbHabitacion.ValueMember = "HabitacionId";
                    }
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("NO existen habitaciones DISPONIBLES, ¿desea generar una reserva?", "Residica", MessageBoxButtons.YesNo))
                        {
                            Residente residente;
                            residente = AgregarResidente();
                            residente.Estado = 2;
                            GestorResidenteBLL.GetInstance().GenerarReserva(residente);

                            if (DialogResult.OK == MessageBox.Show("Reserva de Residente generada correctamente.", "Residica", MessageBoxButtons.OK))
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            this.Close();
                        }
                    }//gestorResidenteBLL.AgregarResidente(residente);
                }
                else
                {
                    Residente residente;
                    residente = AgregarResidente();

                    residente.PlanId = Convert.ToInt32(cbPlan.SelectedValue.ToString());
                    residente.HabitacionId = Convert.ToInt32(cbHabitacion.SelectedValue.ToString());
                    residente.Estado = 1;
                    GestorResidenteBLL.GetInstance().AgregarResidente(residente);

                    if (DialogResult.OK == MessageBox.Show("Residente agregado correctamente.", "Residica", MessageBoxButtons.OK))
                    {
                        this.Close();
                    }
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Esta seguro que desea cancelar?", "Residica", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private bool Validaciones()
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

            if (cbPlan.SelectedIndex == -1 && segundavez)
            {
                MessageBox.Show("Seleccione un Plan.", "Residica.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbDireccionContacto.Focus();
                return false;
            }

            if (cbHabitacion.SelectedIndex == -1 && segundavez)
            {
                MessageBox.Show("Seleccione una Habitación.", "Residica.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbDireccionContacto.Focus();
                return false;
            }

            return true;
        }

        private Residente AgregarResidente()
        {
            Residente residente = new Residente
            {
                Apellido = tbApellido.Text,
                Nombre = tbNombre.Text,
                DocumentoNumero = Convert.ToInt32(tbDocumento.Text),
                CUIL = Convert.ToInt32(tbCuil.Text),
                FechaNacimiento = Convert.ToDateTime(dtpFechaNacimiento.Text),
                ObraSocial = tbObraSocial.Text,
                PersonaContacto = tbPersonaContacto.Text,
                TelefonoContacto = tbTelefonoContacto.Text,
                DireccionContacto = tbDireccionContacto.Text,
                NumeroEmergencia = tbTelefonoEmergencia.Text,
                Observacion = rbObservacion.Text,
                AuditoriaMedica = false,
                AuditoriaPsicologica = false,
                AuditoriaTraumatologica = false,
                AuditoriaGeneral = false
            };
            return residente;
        }
    }
}
