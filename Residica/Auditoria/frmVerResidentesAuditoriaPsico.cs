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

namespace Residica.Auditoria
{
    public partial class frmVerResidentesAuditoriaPsico : Form
    {
        public frmVerResidentesAuditoriaPsico()
        {
            InitializeComponent();
        }

        private void frmVerResidentesAuditoriaPsico_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = GestorAuditoriaBLL.GetInstance().TraerAuditados(1);
        }
    }
}
