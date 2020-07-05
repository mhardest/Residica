using Servicios.Bitacora.BLL;
using Servicios.Criptografia;
using Servicios.Seguridad;
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

namespace Residica
{
    public partial class Login : Form
    {

        private string usuarioIngresado = string.Empty;
        private int intentos = 0;
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
            try
            {
                int IdUsuario = 0;
                if (tB_Usuario.Text != "Username")
                {
                    if (tB_Contraseña.Text != "Password")
                    {
                        if (UsuarioBLL.Existe(this.tB_Usuario.Text)) 
                        {
                            string auxIntentos = tB_Usuario.Text;
                            if (usuarioIngresado.Length == 0)
                                usuarioIngresado = auxIntentos;
                                
                            Usuario usuario = UsuarioBLL.GetAdapted(tB_Usuario.Text.Trim());
                            IdUsuario = UsuarioBLL.Validar(this.tB_Usuario.Text, HelperEncrypt.EncodePassword(this.tB_Contraseña.Text, usuario.DigitoVerificador)); //this.tB_Contraseña.Text);// 

                            if (!UsuarioBLL.Bloqueado(this.tB_Usuario.Text))
                            {
                                if (IdUsuario == 0)
                                {
                                    if (usuarioIngresado == auxIntentos)
                                    {
                                        intentos = intentos + 1;
                                        MessageBox.Show("Logueo incorrecto.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    else
                                    {
                                        usuarioIngresado = string.Empty;
                                    }

                                    if (intentos == 3)
                                    {
                                        UsuarioBLL.Bloquear(usuarioIngresado);
                                        BitacoraBLL.GetInstance().RegistrarEnBitacora("Usuario bloqueado por mas de 3 intentos.", /*User._userSession.NombreUsuario*/usuario.NombreUsuario, string.Empty, System.Diagnostics.TraceEventType.Information);
                                        MessageBox.Show("El usuario ha sido bloqueado", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                                else
                                {

                                    this.tB_Usuario.Clear();
                                    this.tB_Contraseña.Clear();
                                    Menu menu = new Menu();
                                    User._userSession = UsuarioBLL.GetAdapted(IdUsuario);
                                    BitacoraBLL.GetInstance().RegistrarEnBitacora("Nuevo logueo en el sistema.", User._userSession.NombreUsuario, string.Empty, System.Diagnostics.TraceEventType.Information);

                                    menu.Show();
                                    this.Hide();

                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuario bloqueado.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario no registrado.", "Residica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Residica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            void mensajeerror(string msg)
            {
                lb_ErrorMessage.Text = msg;
                lb_ErrorMessage.Visible = true;
            }
        }
    }
}


