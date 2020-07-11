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
        public frmNuevoResidente()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Residente residente = new Residente();
            residente.Apellido = tbApellido.Text;
            residente.Nombre = tbNombre.Text;

            GestorResidenteBLL gestorResidenteBLL = new GestorResidenteBLL();
            gestorResidenteBLL.AgregarResidente(residente);
        }
    }
}
