using Servicios.Facade.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCambiarIdioma_Click(object sender, EventArgs e)
        {
            string cultureInfo = Thread.CurrentThread.CurrentUICulture.Name;
            if (cultureInfo == "en-US")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            }
           

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBCultura.Items.Add("es-AR");
            cBCultura.Items.Add("en-US");
            cBCultura.Text = "es-AR";
        }

        private void cBCultura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cBCultura.SelectedItem == "en-US")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                traductor();
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");
                traductor();
            }
        }

        private void traductor()
        {
            btnAceptar.Text = "Aceptar".Translate();
            btnCancelar.Text = "Cancelar".Translate();
            lb_Idioma.Text = "Idioma".Translate();
        }
    }
}
