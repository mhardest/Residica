namespace Residica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cBCultura = new System.Windows.Forms.ComboBox();
            this.lb_Idioma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(127, 236);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(408, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cBCultura
            // 
            this.cBCultura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCultura.FormattingEnabled = true;
            this.cBCultura.Location = new System.Drawing.Point(293, 92);
            this.cBCultura.Name = "cBCultura";
            this.cBCultura.Size = new System.Drawing.Size(121, 21);
            this.cBCultura.TabIndex = 3;
            this.cBCultura.SelectedIndexChanged += new System.EventHandler(this.cBCultura_SelectedIndexChanged);
            // 
            // lb_Idioma
            // 
            this.lb_Idioma.AutoSize = true;
            this.lb_Idioma.Location = new System.Drawing.Point(227, 92);
            this.lb_Idioma.Name = "lb_Idioma";
            this.lb_Idioma.Size = new System.Drawing.Size(38, 13);
            this.lb_Idioma.TabIndex = 4;
            this.lb_Idioma.Text = "Idioma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.lb_Idioma);
            this.Controls.Add(this.cBCultura);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cBCultura;
        private System.Windows.Forms.Label lb_Idioma;
    }
}

