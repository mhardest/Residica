using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void tB_Usuario_Enter(object sender, EventArgs e)
        {
            if (tB_Usuario.Text == "Username")
            {
                tB_Usuario.Text = "";
            }


        }

        private void tB_Usuario_Leave(object sender, EventArgs e)
        {
            if (tB_Usuario.Text == "")
            {
                tB_Usuario.Text = "Username";
            }
        }

        private void tB_Contraseña_Enter(object sender, EventArgs e)
        {
            if (tB_Contraseña.Text == "Password")
            {
                tB_Contraseña.Text = "";
                tB_Contraseña.UseSystemPasswordChar = true;
            }
        }

        private void tB_Contraseña_Leave(object sender, EventArgs e)
        {
            if (tB_Contraseña.Text == "")
            {
                tB_Contraseña.Text = "Password";
                tB_Contraseña.UseSystemPasswordChar = false;
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Acceder_Click(object sender, EventArgs e)
        {
            if (tB_Usuario.Text != "Username")
            {
                if (tB_Contraseña.Text != "Password")
                {
                    if (tB_Usuario.Text == "admin" && tB_Contraseña.Text =="admin")
                    {
                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        mensajeerror(" Incorrect username or password entered. \n Please try again.");
                        tB_Contraseña.Clear();
                        tB_Contraseña.Focus();
                    }
                }
                else
                {
                    mensajeerror("Please enter Password");
                }
            }
            else
            {
                mensajeerror("Please enter Username");
            }

        }

        private void mensajeerror(string msg)
        {
            lb_ErrorMessage.Text = msg;
            lb_ErrorMessage.Visible = true;
        }
    }
}
