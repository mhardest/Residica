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
    public partial class frmAsignarUsuario : Form
    {
        private int IdUsuario;
        public int IdUsuarioValue
        {
            get { return IdUsuario; }
            set { IdUsuario = value; }
        }
        public frmAsignarUsuario()
        {
            InitializeComponent();

            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.RowHeadersVisible = false;
            this.dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsuario.AllowUserToResizeColumns = false;
            this.dgvUsuario.AllowUserToResizeRows = false;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuario.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsuario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvUsuario.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvUsuario.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Green;

            btnSeleccionar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                string nombre = tbUsuario.Text.Trim() != null ? tbUsuario.Text.Trim() : null; ;
                string documento = tbDocumento.Text.Trim() != null ? tbDocumento.Text.Trim() : null; ;

                List<Usuario> lista = UsuarioBLL.GetAllAdapted(nombre, documento);

                var view = from item in lista
                           select new
                           {
                               Nro_Usuario = item.IdUsuario,
                               Nombre_Usuario = item.NombreUsuario,
                               Documento = item.NumeroDocumento,
                               Nombre_Completo = item.NombreCompleto,
                               Sector = item.Sector.Descripcion
                           };

                this.dgvUsuario.DataSource = view.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Residica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                List<Usuario> lista = UsuarioBLL.GetAllAdapted();
                var view = from item in lista
                           select new
                           {
                               Nro_Usuario = item.IdUsuario,
                               Nombre_Usuario = item.NombreUsuario,
                               Documento = item.NumeroDocumento,
                               Nombre_Completo = item.NombreCompleto,
                               Sector = item.Sector.Descripcion
                           };

                this.dgvUsuario.DataSource = view.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Residica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            IdUsuario = Convert.ToInt32(dgvUsuario.CurrentRow.Cells[0].Value);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Desea cancelar la carga?", "Residica", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btnSeleccionar.Enabled = true;
        }
    }
}
