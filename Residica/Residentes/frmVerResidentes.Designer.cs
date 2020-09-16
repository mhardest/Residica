namespace Residica.Residentes
{
    partial class frmVerResidentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerResidentes));
            this.dgvResidentes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResidentes
            // 
            this.dgvResidentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResidentes.Location = new System.Drawing.Point(12, 28);
            this.dgvResidentes.Name = "dgvResidentes";
            this.dgvResidentes.Size = new System.Drawing.Size(754, 350);
            this.dgvResidentes.TabIndex = 0;
            this.dgvResidentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResidentes_CellContentClick);
            // 
            // frmVerResidentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.dgvResidentes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerResidentes";
            this.Text = "Ver Residentes";
            this.Load += new System.EventHandler(this.frmVerResidentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResidentes;
    }
}