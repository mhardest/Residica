namespace Residica.Herramientas.Seguridad
{
    partial class frmDesbloqueoCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContraseñaActual = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbContraseñaActual = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(206, 178);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.Location = new System.Drawing.Point(51, 178);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(75, 23);
            this.btnDesbloquear.TabIndex = 5;
            this.btnDesbloquear.Text = "Desbloquear";
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbUsuario);
            this.groupBox1.Controls.Add(this.tbContraseñaActual);
            this.groupBox1.Controls.Add(this.lbUsuario);
            this.groupBox1.Controls.Add(this.lbContraseñaActual);
            this.groupBox1.Location = new System.Drawing.Point(22, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 116);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campos";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(133, 29);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(147, 20);
            this.tbUsuario.TabIndex = 4;
            // 
            // tbContraseñaActual
            // 
            this.tbContraseñaActual.Location = new System.Drawing.Point(133, 69);
            this.tbContraseñaActual.Name = "tbContraseñaActual";
            this.tbContraseñaActual.Size = new System.Drawing.Size(147, 20);
            this.tbContraseñaActual.TabIndex = 3;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(6, 29);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbUsuario.TabIndex = 1;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbContraseñaActual
            // 
            this.lbContraseñaActual.AutoSize = true;
            this.lbContraseñaActual.Location = new System.Drawing.Point(6, 72);
            this.lbContraseñaActual.Name = "lbContraseñaActual";
            this.lbContraseñaActual.Size = new System.Drawing.Size(94, 13);
            this.lbContraseñaActual.TabIndex = 0;
            this.lbContraseñaActual.Text = "Contraseña Actual";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(99, 136);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(146, 23);
            this.btnVerificar.TabIndex = 7;
            this.btnVerificar.Text = "Verificar Bloqueo";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // frmDesbloqueoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 215);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDesbloquear);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDesbloqueoCuenta";
            this.Text = "Desbloqueo de Cuenta";
            this.Load += new System.EventHandler(this.frmDesbloqueoCuenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContraseñaActual;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbContraseñaActual;
        private System.Windows.Forms.Button btnVerificar;
    }
}