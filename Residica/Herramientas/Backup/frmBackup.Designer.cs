namespace Residica.Herramientas.Backup
{
    partial class frmBackup
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbRutaSeguridad = new System.Windows.Forms.Label();
            this.tbRutaSeguridad = new System.Windows.Forms.TextBox();
            this.lbRutaGestion = new System.Windows.Forms.Label();
            this.tbRutaGestion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRutaSeguridad);
            this.groupBox1.Controls.Add(this.tbRutaSeguridad);
            this.groupBox1.Controls.Add(this.lbRutaGestion);
            this.groupBox1.Controls.Add(this.tbRutaGestion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbRutaSeguridad
            // 
            this.lbRutaSeguridad.AutoSize = true;
            this.lbRutaSeguridad.Location = new System.Drawing.Point(6, 54);
            this.lbRutaSeguridad.Name = "lbRutaSeguridad";
            this.lbRutaSeguridad.Size = new System.Drawing.Size(81, 13);
            this.lbRutaSeguridad.TabIndex = 3;
            this.lbRutaSeguridad.Text = "Ruta Seguridad";
            // 
            // tbRutaSeguridad
            // 
            this.tbRutaSeguridad.Enabled = false;
            this.tbRutaSeguridad.Location = new System.Drawing.Point(107, 54);
            this.tbRutaSeguridad.Name = "tbRutaSeguridad";
            this.tbRutaSeguridad.Size = new System.Drawing.Size(399, 20);
            this.tbRutaSeguridad.TabIndex = 2;
            // 
            // lbRutaGestion
            // 
            this.lbRutaGestion.AutoSize = true;
            this.lbRutaGestion.Location = new System.Drawing.Point(6, 28);
            this.lbRutaGestion.Name = "lbRutaGestion";
            this.lbRutaGestion.Size = new System.Drawing.Size(69, 13);
            this.lbRutaGestion.TabIndex = 1;
            this.lbRutaGestion.Text = "Ruta Gestión";
            // 
            // tbRutaGestion
            // 
            this.tbRutaGestion.Enabled = false;
            this.tbRutaGestion.Location = new System.Drawing.Point(107, 28);
            this.tbRutaGestion.Name = "tbRutaGestion";
            this.tbRutaGestion.Size = new System.Drawing.Size(399, 20);
            this.tbRutaGestion.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(129, 118);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(328, 118);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 165);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBackup";
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.frmBackup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbRutaGestion;
        private System.Windows.Forms.TextBox tbRutaGestion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbRutaSeguridad;
        private System.Windows.Forms.TextBox tbRutaSeguridad;
    }
}