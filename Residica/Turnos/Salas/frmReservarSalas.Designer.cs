namespace Residica.Turnos.Salas
{
    partial class frmReservarSalas
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
            this.tbHora = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbResidente = new System.Windows.Forms.ComboBox();
            this.cbSalas = new System.Windows.Forms.ComboBox();
            this.lbResidente = new DevExpress.XtraEditors.LabelControl();
            this.dtDia = new DevExpress.XtraEditors.DateEdit();
            this.lbDia = new DevExpress.XtraEditors.LabelControl();
            this.lbSala = new DevExpress.XtraEditors.LabelControl();
            this.btnConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDia.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbHora);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.cbResidente);
            this.groupBox1.Controls.Add(this.cbSalas);
            this.groupBox1.Controls.Add(this.lbResidente);
            this.groupBox1.Controls.Add(this.dtDia);
            this.groupBox1.Controls.Add(this.lbDia);
            this.groupBox1.Controls.Add(this.lbSala);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 210);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // tbHora
            // 
            this.tbHora.Location = new System.Drawing.Point(70, 160);
            this.tbHora.Name = "tbHora";
            this.tbHora.Size = new System.Drawing.Size(154, 21);
            this.tbHora.TabIndex = 14;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 160);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Hora";
            // 
            // cbResidente
            // 
            this.cbResidente.FormattingEnabled = true;
            this.cbResidente.Location = new System.Drawing.Point(70, 26);
            this.cbResidente.Name = "cbResidente";
            this.cbResidente.Size = new System.Drawing.Size(154, 21);
            this.cbResidente.TabIndex = 12;
            // 
            // cbSalas
            // 
            this.cbSalas.FormattingEnabled = true;
            this.cbSalas.Location = new System.Drawing.Point(70, 69);
            this.cbSalas.Name = "cbSalas";
            this.cbSalas.Size = new System.Drawing.Size(154, 21);
            this.cbSalas.TabIndex = 11;
            // 
            // lbResidente
            // 
            this.lbResidente.Location = new System.Drawing.Point(6, 29);
            this.lbResidente.Name = "lbResidente";
            this.lbResidente.Size = new System.Drawing.Size(48, 13);
            this.lbResidente.TabIndex = 8;
            this.lbResidente.Text = "Residente";
            // 
            // dtDia
            // 
            this.dtDia.EditValue = null;
            this.dtDia.Location = new System.Drawing.Point(70, 115);
            this.dtDia.Name = "dtDia";
            this.dtDia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDia.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDia.Size = new System.Drawing.Size(154, 20);
            this.dtDia.TabIndex = 4;
            // 
            // lbDia
            // 
            this.lbDia.Location = new System.Drawing.Point(6, 118);
            this.lbDia.Name = "lbDia";
            this.lbDia.Size = new System.Drawing.Size(15, 13);
            this.lbDia.TabIndex = 2;
            this.lbDia.Text = "Dia";
            // 
            // lbSala
            // 
            this.lbSala.Location = new System.Drawing.Point(6, 72);
            this.lbSala.Name = "lbSala";
            this.lbSala.Size = new System.Drawing.Size(20, 13);
            this.lbSala.TabIndex = 1;
            this.lbSala.Text = "Sala";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(89, 252);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(130, 74);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmReservarSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConfirmar);
            this.IconOptions.Image = global::Residica.Properties.Resources.IconoResidica;
            this.Name = "frmReservarSalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservar Salas";
            this.Load += new System.EventHandler(this.frmReservarSalas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDia.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDia.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbHora;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbResidente;
        private System.Windows.Forms.ComboBox cbSalas;
        private DevExpress.XtraEditors.LabelControl lbResidente;
        private DevExpress.XtraEditors.DateEdit dtDia;
        private DevExpress.XtraEditors.LabelControl lbDia;
        private DevExpress.XtraEditors.LabelControl lbSala;
        private DevExpress.XtraEditors.SimpleButton btnConfirmar;
    }
}