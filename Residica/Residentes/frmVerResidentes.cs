﻿using BLL;
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
    public partial class frmVerResidentes : Form
    {
        public frmVerResidentes()
        {
            InitializeComponent();
        }

        private void frmVerResidentes_Load(object sender, EventArgs e)
        {
            dgvResidentes.DataSource = GestorResidenteBLL.GetInstance().TraerResidentes();
        }

        private void dgvResidentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorCelda = dgvResidentes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }
    }
}
