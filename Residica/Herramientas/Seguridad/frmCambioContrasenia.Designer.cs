namespace Residica.Herramientas.Seguridad
{
    partial class frmCambioContrasenia
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
            this.lbContraseñaActual = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNuevaContraseña = new System.Windows.Forms.Label();
            this.lbRepetirContraseña = new System.Windows.Forms.Label();
            this.tbContraseñaActual = new System.Windows.Forms.TextBox();
            this.tbNuevaContraseña = new System.Windows.Forms.TextBox();
            this.tbRepetirContraseña = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbContraseñaActual
            // 
            this.lbContraseñaActual.AutoSize = true;
            this.lbContraseñaActual.Location = new System.Drawing.Point(6, 48);
            this.lbContraseñaActual.Name = "lbContraseñaActual";
            this.lbContraseñaActual.Size = new System.Drawing.Size(94, 13);
            this.lbContraseñaActual.TabIndex = 0;
            this.lbContraseñaActual.Text = "Contraseña Actual";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRepetirContraseña);
            this.groupBox1.Controls.Add(this.tbNuevaContraseña);
            this.groupBox1.Controls.Add(this.tbContraseñaActual);
            this.groupBox1.Controls.Add(this.lbRepetirContraseña);
            this.groupBox1.Controls.Add(this.lbNuevaContraseña);
            this.groupBox1.Controls.Add(this.lbContraseñaActual);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campos";
            // 
            // lbNuevaContraseña
            // 
            this.lbNuevaContraseña.AutoSize = true;
            this.lbNuevaContraseña.Location = new System.Drawing.Point(6, 76);
            this.lbNuevaContraseña.Name = "lbNuevaContraseña";
            this.lbNuevaContraseña.Size = new System.Drawing.Size(96, 13);
            this.lbNuevaContraseña.TabIndex = 1;
            this.lbNuevaContraseña.Text = "Nueva Contraseña";
            // 
            // lbRepetirContraseña
            // 
            this.lbRepetirContraseña.AutoSize = true;
            this.lbRepetirContraseña.Location = new System.Drawing.Point(6, 104);
            this.lbRepetirContraseña.Name = "lbRepetirContraseña";
            this.lbRepetirContraseña.Size = new System.Drawing.Size(98, 13);
            this.lbRepetirContraseña.TabIndex = 2;
            this.lbRepetirContraseña.Text = "Repetir Contraseña";
            // 
            // tbContraseñaActual
            // 
            this.tbContraseñaActual.Location = new System.Drawing.Point(144, 48);
            this.tbContraseñaActual.Name = "tbContraseñaActual";
            this.tbContraseñaActual.Size = new System.Drawing.Size(147, 20);
            this.tbContraseñaActual.TabIndex = 3;
            // 
            // tbNuevaContraseña
            // 
            this.tbNuevaContraseña.Location = new System.Drawing.Point(144, 76);
            this.tbNuevaContraseña.Name = "tbNuevaContraseña";
            this.tbNuevaContraseña.Size = new System.Drawing.Size(147, 20);
            this.tbNuevaContraseña.TabIndex = 4;
            // 
            // tbRepetirContraseña
            // 
            this.tbRepetirContraseña.Location = new System.Drawing.Point(144, 104);
            this.tbRepetirContraseña.Name = "tbRepetirContraseña";
            this.tbRepetirContraseña.Size = new System.Drawing.Size(147, 20);
            this.tbRepetirContraseña.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(41, 177);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Cambiar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(196, 177);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCambioContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 227);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCambioContrasenia";
            this.Text = "Cambio Contraseña";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbContraseñaActual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbRepetirContraseña;
        private System.Windows.Forms.TextBox tbNuevaContraseña;
        private System.Windows.Forms.TextBox tbContraseñaActual;
        private System.Windows.Forms.Label lbRepetirContraseña;
        private System.Windows.Forms.Label lbNuevaContraseña;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}