namespace Residica.Residentes
{
    partial class frmVerResidenteListaEspera
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
            this.dgvResidentes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResidentes
            // 
            this.dgvResidentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResidentes.Location = new System.Drawing.Point(12, 12);
            this.dgvResidentes.Name = "dgvResidentes";
            this.dgvResidentes.Size = new System.Drawing.Size(754, 339);
            this.dgvResidentes.TabIndex = 1;
            // 
            // frmVerResidenteListaEspera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 380);
            this.Controls.Add(this.dgvResidentes);
            this.Name = "frmVerResidenteListaEspera";
            this.Text = "Lista Espera";
            this.Load += new System.EventHandler(this.frmVerResidenteListaEspera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResidentes;
    }
}