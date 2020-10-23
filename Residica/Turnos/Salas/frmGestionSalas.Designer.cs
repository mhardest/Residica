namespace Residica.Turnos.Salas
{
    partial class frmGestionSalas
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbResidente = new System.Windows.Forms.ComboBox();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.lbResidente = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.dtDia = new DevExpress.XtraEditors.DateEdit();
            this.lbDia = new DevExpress.XtraEditors.LabelControl();
            this.lbSala = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDia.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 162);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(751, 290);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbResidente);
            this.groupBox1.Controls.Add(this.cbSala);
            this.groupBox1.Controls.Add(this.lbResidente);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.dtDia);
            this.groupBox1.Controls.Add(this.lbDia);
            this.groupBox1.Controls.Add(this.lbSala);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cbResidente
            // 
            this.cbResidente.FormattingEnabled = true;
            this.cbResidente.Location = new System.Drawing.Point(70, 96);
            this.cbResidente.Name = "cbResidente";
            this.cbResidente.Size = new System.Drawing.Size(167, 21);
            this.cbResidente.TabIndex = 12;
            // 
            // cbSala
            // 
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(70, 21);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(167, 21);
            this.cbSala.TabIndex = 11;
            // 
            // lbResidente
            // 
            this.lbResidente.Location = new System.Drawing.Point(6, 99);
            this.lbResidente.Name = "lbResidente";
            this.lbResidente.Size = new System.Drawing.Size(48, 13);
            this.lbResidente.TabIndex = 8;
            this.lbResidente.Text = "Residente";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(556, 38);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(128, 74);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Reservar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(334, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(130, 74);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtDia
            // 
            this.dtDia.EditValue = null;
            this.dtDia.Location = new System.Drawing.Point(70, 59);
            this.dtDia.Name = "dtDia";
            this.dtDia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDia.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDia.Size = new System.Drawing.Size(167, 20);
            this.dtDia.TabIndex = 4;
            // 
            // lbDia
            // 
            this.lbDia.Location = new System.Drawing.Point(6, 62);
            this.lbDia.Name = "lbDia";
            this.lbDia.Size = new System.Drawing.Size(15, 13);
            this.lbDia.TabIndex = 2;
            this.lbDia.Text = "Dia";
            // 
            // lbSala
            // 
            this.lbSala.Location = new System.Drawing.Point(6, 24);
            this.lbSala.Name = "lbSala";
            this.lbSala.Size = new System.Drawing.Size(20, 13);
            this.lbSala.TabIndex = 1;
            this.lbSala.Text = "Sala";
            // 
            // frmGestionSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox1);
            this.IconOptions.Image = global::Residica.Properties.Resources.IconoResidica;
            this.Name = "frmGestionSalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Salas";
            this.Load += new System.EventHandler(this.frmGestionSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDia.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDia.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbResidente;
        private System.Windows.Forms.ComboBox cbSala;
        private DevExpress.XtraEditors.LabelControl lbResidente;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.DateEdit dtDia;
        private DevExpress.XtraEditors.LabelControl lbDia;
        private DevExpress.XtraEditors.LabelControl lbSala;
    }
}