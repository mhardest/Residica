using Servicios.Criptografia;
using Servicios.Multioma.BLL;
using Servicios.Seguridad.BLL;
using Servicios.Seguridad.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residica.Herramientas.Backup
{
    public partial class frmUsuarioAlta : Form
    {
        public frmUsuarioAlta()
        {
            InitializeComponent();
        }

        private void frmUsuarioAlta_Load(object sender, EventArgs e)
        {
            ObtenerIdiomaTodos();
            ObtenerSectorTodos();
            tbUsuario.Focus();
        }

        #region Metodos
        private bool Validaciones()
        {
            if (tbUsuario.Text == string.Empty)
            {
                MessageBox.Show("Complete el nombre de usuario.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbUsuario.Focus();
                return false;
            }

            if (tbDocumento.Text == string.Empty)
            {
                MessageBox.Show("Complete el documento.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbDocumento.Focus();
                return false;
            }

            if (tbDocumento.Text.Length > 8)
            {
                MessageBox.Show("El documento debe tener como máximo 8 cáracteres.", "Admin Poligono", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbDocumento.Focus();
                return false;
            }



            if (tbNombre.Text == string.Empty)
            {
                MessageBox.Show("Complete el nombre completo.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbNombre.Focus();
                return false;
            }

            if (cbSector.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un sector.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbSector.Focus();
                return false;
            }

            if (tbContraseña.Text == string.Empty)
            {
                MessageBox.Show("Complete la contraseña.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbContraseña.Focus();
                return false;
            }

            if (tbRepetirContraseña.Text == string.Empty)
            {
                MessageBox.Show("Repitir la contraseña.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbRepetirContraseña.Focus();
                return false;
            }

            if (tbContraseña.Text != tbRepetirContraseña.Text)
            {
                MessageBox.Show("No coinciden las contraseñas.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbContraseña.Focus();
                return false;
            }

            if (cbIdioma.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un idioma.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbIdioma.Focus();
                return false;
            }

            if (tbContraseña.Text.Length < 3 && tbRepetirContraseña.Text.Length < 3)
            {
                MessageBox.Show("La contraseña tiene que tener como mínimo 3 caracteres.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbContraseña.Focus();
                return false;
            }

            if (tbUsuario.Text != string.Empty)
            {
                if (UsuarioBLL.Existe(tbUsuario.Text.Trim()))
                {
                    MessageBox.Show("Ya existe el nombre de usuario.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbUsuario.Focus();
                    return false;
                }
            }

            if (tbDocumento.Text != string.Empty)
            {
                if (UsuarioBLL.ExisteByDocumento(tbDocumento.Text.Trim()))
                {
                    MessageBox.Show("Ya existe el documento.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbDocumento.Focus();
                    return false;
                }
            }


            return true;
        }

        private void ObtenerIdiomaTodos()
        {
            try
            {
                this.cbIdioma.ValueMember = "IdIdioma";
                this.cbIdioma.DisplayMember = "Descripcion";
                DataTable dtIdioma = IdiomaBLL.SelectAllLoad();
                this.cbIdioma.DataSource = dtIdioma;
                this.cbIdioma.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Residica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObtenerSectorTodos()
        {
            try
            {
                this.cbSector.ValueMember = "IdSector";
                this.cbSector.DisplayMember = "Descripcion";
                DataTable dtSector = SectorBLL.SelectAll();

                DataRow row = dtSector.NewRow();
                row["IdSector"] = 0;
                row["Descripcion"] = "Seleccione..";
                dtSector.Rows.InsertAt(row, 0);

                this.cbSector.DataSource = dtSector;
                this.cbSector.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Residica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AltaUsuario()
        {
            try
            {
                int returnValue = 0;
                var digitoVerificador = HelperEncrypt.GeneratePassword(10);

                Usuario usuario = new Usuario(tbUsuario.Text.Trim(),
                                              tbDocumento.Text.Trim(),
                                              tbNombre.Text.Trim(),
                                              cbSector.SelectedIndex,
                                              HelperEncrypt.EncodePassword(tbContraseña.Text.Trim(), digitoVerificador),
                                              cbIdioma.SelectedIndex,
                                              digitoVerificador,
                                              "A");

                returnValue = UsuarioBLL.Insert(usuario);

                if (returnValue != 0)
                {
                    if (DialogResult.OK == MessageBox.Show("Usuario guardado exitosamente.", "Residica", MessageBoxButtons.OK))
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al guardar el Miembro.", "Residica", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Residica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                AltaUsuario();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Está seguro que desea salir?", "Residica", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }
    }
}
