using BLL;
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
    public partial class frmVerResidenteListaEspera : Form
    {
        public frmVerResidenteListaEspera()
        {
            InitializeComponent();
        }

        private void frmVerResidenteListaEspera_Load(object sender, EventArgs e)
        {
            dgvResidentes.DataSource = GestorResidenteBLL.GetInstance().TraerListaEspera();
        }
    }
}
