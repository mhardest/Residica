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
    public partial class frmVerResidentesAuditoriaTrau : Form
    {
        public frmVerResidentesAuditoriaTrau()
        {
            InitializeComponent();
        }

        private void frmVerResidentesAuditoriaTrau_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = GestorAuditoriaBLL.GetInstance().TraerAuditados(2);
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
        }
    }
}
