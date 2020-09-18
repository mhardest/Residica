namespace Residica.Auditoria
{
    partial class frmAuditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditoria));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDocumento = new DevExpress.XtraEditors.TextEdit();
            this.txtResidente = new DevExpress.XtraEditors.TextEdit();
            this.lbDocumento = new System.Windows.Forms.Label();
            this.lbResidente = new System.Windows.Forms.Label();
            this.rtbObservacion = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.txtResidenteId = new DevExpress.XtraEditors.TextEdit();
            this.txtProfesionalId = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResidente.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResidenteId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProfesionalId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDocumento);
            this.groupBox1.Controls.Add(this.txtResidente);
            this.groupBox1.Controls.Add(this.lbDocumento);
            this.groupBox1.Controls.Add(this.lbResidente);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(90, 58);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(255, 20);
            this.txtDocumento.TabIndex = 3;
            // 
            // txtResidente
            // 
            this.txtResidente.Location = new System.Drawing.Point(90, 19);
            this.txtResidente.Name = "txtResidente";
            this.txtResidente.Size = new System.Drawing.Size(255, 20);
            this.txtResidente.TabIndex = 2;
            // 
            // lbDocumento
            // 
            this.lbDocumento.AutoSize = true;
            this.lbDocumento.Location = new System.Drawing.Point(6, 61);
            this.lbDocumento.Name = "lbDocumento";
            this.lbDocumento.Size = new System.Drawing.Size(62, 13);
            this.lbDocumento.TabIndex = 1;
            this.lbDocumento.Text = "Documento";
            // 
            // lbResidente
            // 
            this.lbResidente.AutoSize = true;
            this.lbResidente.Location = new System.Drawing.Point(6, 22);
            this.lbResidente.Name = "lbResidente";
            this.lbResidente.Size = new System.Drawing.Size(55, 13);
            this.lbResidente.TabIndex = 0;
            this.lbResidente.Text = "Residente";
            // 
            // rtbObservacion
            // 
            this.rtbObservacion.Location = new System.Drawing.Point(7, 20);
            this.rtbObservacion.Name = "rtbObservacion";
            this.rtbObservacion.Size = new System.Drawing.Size(332, 170);
            this.rtbObservacion.TabIndex = 0;
            this.rtbObservacion.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbObservacion);
            this.groupBox2.Location = new System.Drawing.Point(13, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 196);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Observación";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(103, 358);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(168, 53);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtResidenteId
            // 
            this.txtResidenteId.Location = new System.Drawing.Point(13, 332);
            this.txtResidenteId.Name = "txtResidenteId";
            this.txtResidenteId.Size = new System.Drawing.Size(68, 20);
            this.txtResidenteId.TabIndex = 3;
            // 
            // txtProfesionalId
            // 
            this.txtProfesionalId.Location = new System.Drawing.Point(87, 333);
            this.txtProfesionalId.Name = "txtProfesionalId";
            this.txtProfesionalId.Size = new System.Drawing.Size(74, 20);
            this.txtProfesionalId.TabIndex = 4;
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 450);
            this.Controls.Add(this.txtProfesionalId);
            this.Controls.Add(this.txtResidenteId);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditoria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResidente.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtResidenteId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProfesionalId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtResidente;
        private System.Windows.Forms.Label lbDocumento;
        private System.Windows.Forms.Label lbResidente;
        private DevExpress.XtraEditors.TextEdit txtDocumento;
        private System.Windows.Forms.RichTextBox rtbObservacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnConfirmar;
        private DevExpress.XtraEditors.TextEdit txtResidenteId;
        private DevExpress.XtraEditors.TextEdit txtProfesionalId;
    }
}