using Servicios.Bitacora.BLL;
using Servicios.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residica.Herramientas.Log
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();

            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLog.AllowUserToResizeColumns = false;
            this.dgvLog.AllowUserToResizeRows = false;
            this.dgvLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLog.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLog.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvLog.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvLog.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Green;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            BitacoraBLL.GetInstance().RegistrarEnBitacora("Se consulta bítacora del sistema", User._userSession.NombreUsuario, string.Empty, TraceEventType.Information);
            dgvLog.DataSource = BitacoraBLL.GetInstance().ObtenerEventosBitacora();
        }
    }
}
