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

namespace Residica.Herramientas.Seguridad
{
    public partial class frmUsuarioModificar : Form
    {
        private int IdUsuario;

        public int IdUsuarioValue
        {
            get { return IdUsuario; }
            set { IdUsuario = value; }
        }
        public frmUsuarioModificar()
        {
            InitializeComponent();
        }
        private void frmUsuarioModificar_Load(object sender, EventArgs e)
        {
            ObtenerUsuarioExistente();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                ModificarUsuario();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Esta seguro que desea salir?", "Residica", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        #region Metodos

        private void ObtenerUsuarioExistente()
        {
            try
            {
                Usuario usuario = UsuarioBLL.GetAdapted(IdUsuario);

                tbUsuario.Text = usuario.NombreUsuario;
                tbDocumento.Text = usuario.NumeroDocumento;
                tbNombre.Text = usuario.NombreCompleto;
                ObtenerSectorTodos();
                cbSector.SelectedValue = usuario.Sector.IdSector;
                ObtenerIdiomaTodos();
                cbIdioma.SelectedValue = usuario.IdIdioma;
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
        private bool Validaciones()
        {
            //List<Usuario> list = UsuarioBL.GetAllAdapted();
            //var result = list.Find(x => x.NombreUsuario == txtUsuario.Text.Trim());

            if (tbUsuario.Text == String.Empty)
            {
                MessageBox.Show("Complete el nombre de usuario.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbUsuario.Focus();
                return false;
            }

            if (tbNombre.Text == String.Empty)
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

            if (cbIdioma.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un idioma.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbIdioma.Focus();
                return false;
            }
            return true;
        }

        private void ModificarUsuario()
        {
            try
            {
                int returnValue = 0;
                Usuario usuario = new Usuario(IdUsuario,
                                              tbUsuario.Text.Trim(),
                                              tbDocumento.Text.Trim(),
                                              tbNombre.Text.Trim(),
                                              Convert.ToInt32(cbSector.SelectedValue),
                                              Convert.ToInt32(cbIdioma.SelectedValue));

                returnValue = UsuarioBLL.Update(usuario);

                if (returnValue != 0)
                {
                    if (DialogResult.OK == MessageBox.Show("Usuario actualizado exitosamente.", "Residica", MessageBoxButtons.OK))
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al actualizar.", "Residica", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Residica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


        #endregion

        
    }
}
