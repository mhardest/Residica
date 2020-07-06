namespace Residica.Herramientas.Seguridad
{
    partial class frmPermisos
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
            this.cbPermisosUsuario = new System.Windows.Forms.ComboBox();
            this.pnlFamilia = new System.Windows.Forms.GroupBox();
            this.lbPermisos = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbSector = new System.Windows.Forms.TextBox();
            this.btnPatenteRemover = new System.Windows.Forms.Button();
            this.btnPatenteAgregar = new System.Windows.Forms.Button();
            this.lbSector = new System.Windows.Forms.Label();
            this.listPatenteNoContiene = new System.Windows.Forms.ListBox();
            this.listPatenteContiene = new System.Windows.Forms.ListBox();
            this.listPatenteContieneACT = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFamiliaRemover = new System.Windows.Forms.Button();
            this.btnFamiliaAgregar = new System.Windows.Forms.Button();
            this.listFamiliaNoContiene = new System.Windows.Forms.ListBox();
            this.listFamiliaContiene = new System.Windows.Forms.ListBox();
            this.btnPermisoBuscar = new System.Windows.Forms.Button();
            this.btnPermisosAsignarUsuario = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlFamilia.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPermisosUsuario
            // 
            this.cbPermisosUsuario.FormattingEnabled = true;
            this.cbPermisosUsuario.Location = new System.Drawing.Point(96, 33);
            this.cbPermisosUsuario.Name = "cbPermisosUsuario";
            this.cbPermisosUsuario.Size = new System.Drawing.Size(185, 21);
            this.cbPermisosUsuario.TabIndex = 0;
            // 
            // pnlFamilia
            // 
            this.pnlFamilia.Controls.Add(this.lbPermisos);
            this.pnlFamilia.Controls.Add(this.groupBox3);
            this.pnlFamilia.Controls.Add(this.groupBox2);
            this.pnlFamilia.Controls.Add(this.btnPermisoBuscar);
            this.pnlFamilia.Controls.Add(this.btnPermisosAsignarUsuario);
            this.pnlFamilia.Controls.Add(this.cbPermisosUsuario);
            this.pnlFamilia.Location = new System.Drawing.Point(12, 12);
            this.pnlFamilia.Name = "pnlFamilia";
            this.pnlFamilia.Size = new System.Drawing.Size(645, 565);
            this.pnlFamilia.TabIndex = 1;
            this.pnlFamilia.TabStop = false;
            // 
            // lbPermisos
            // 
            this.lbPermisos.AutoSize = true;
            this.lbPermisos.Location = new System.Drawing.Point(31, 34);
            this.lbPermisos.Name = "lbPermisos";
            this.lbPermisos.Size = new System.Drawing.Size(49, 13);
            this.lbPermisos.TabIndex = 5;
            this.lbPermisos.Text = "Permisos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbSector);
            this.groupBox3.Controls.Add(this.btnPatenteRemover);
            this.groupBox3.Controls.Add(this.btnPatenteAgregar);
            this.groupBox3.Controls.Add(this.lbSector);
            this.groupBox3.Controls.Add(this.listPatenteNoContiene);
            this.groupBox3.Controls.Add(this.listPatenteContiene);
            this.groupBox3.Controls.Add(this.listPatenteContieneACT);
            this.groupBox3.Location = new System.Drawing.Point(25, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(587, 241);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // tbSector
            // 
            this.tbSector.Location = new System.Drawing.Point(388, 59);
            this.tbSector.Name = "tbSector";
            this.tbSector.Size = new System.Drawing.Size(193, 20);
            this.tbSector.TabIndex = 6;
            // 
            // btnPatenteRemover
            // 
            this.btnPatenteRemover.Location = new System.Drawing.Point(262, 183);
            this.btnPatenteRemover.Name = "btnPatenteRemover";
            this.btnPatenteRemover.Size = new System.Drawing.Size(69, 33);
            this.btnPatenteRemover.TabIndex = 4;
            this.btnPatenteRemover.Text = ">>";
            this.btnPatenteRemover.UseVisualStyleBackColor = true;
            this.btnPatenteRemover.Click += new System.EventHandler(this.btnPatenteRemover_Click_1);
            // 
            // btnPatenteAgregar
            // 
            this.btnPatenteAgregar.Location = new System.Drawing.Point(262, 134);
            this.btnPatenteAgregar.Name = "btnPatenteAgregar";
            this.btnPatenteAgregar.Size = new System.Drawing.Size(69, 33);
            this.btnPatenteAgregar.TabIndex = 4;
            this.btnPatenteAgregar.Text = "<<";
            this.btnPatenteAgregar.UseVisualStyleBackColor = true;
            this.btnPatenteAgregar.Click += new System.EventHandler(this.btnPatenteAgregar_Click_1);
            // 
            // lbSector
            // 
            this.lbSector.AutoSize = true;
            this.lbSector.Location = new System.Drawing.Point(328, 59);
            this.lbSector.Name = "lbSector";
            this.lbSector.Size = new System.Drawing.Size(38, 13);
            this.lbSector.TabIndex = 5;
            this.lbSector.Text = "Sector";
            // 
            // listPatenteNoContiene
            // 
            this.listPatenteNoContiene.FormattingEnabled = true;
            this.listPatenteNoContiene.Location = new System.Drawing.Point(338, 120);
            this.listPatenteNoContiene.Name = "listPatenteNoContiene";
            this.listPatenteNoContiene.Size = new System.Drawing.Size(243, 108);
            this.listPatenteNoContiene.TabIndex = 3;
            this.listPatenteNoContiene.SelectedIndexChanged += new System.EventHandler(this.listPatenteNoContiene_SelectedIndexChanged);
            // 
            // listPatenteContiene
            // 
            this.listPatenteContiene.FormattingEnabled = true;
            this.listPatenteContiene.Location = new System.Drawing.Point(6, 120);
            this.listPatenteContiene.Name = "listPatenteContiene";
            this.listPatenteContiene.Size = new System.Drawing.Size(250, 108);
            this.listPatenteContiene.TabIndex = 2;
            this.listPatenteContiene.SelectedIndexChanged += new System.EventHandler(this.listPatenteContiene_SelectedIndexChanged);
            // 
            // listPatenteContieneACT
            // 
            this.listPatenteContieneACT.FormattingEnabled = true;
            this.listPatenteContieneACT.Location = new System.Drawing.Point(6, 32);
            this.listPatenteContieneACT.Name = "listPatenteContieneACT";
            this.listPatenteContieneACT.Size = new System.Drawing.Size(250, 82);
            this.listPatenteContieneACT.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFamiliaRemover);
            this.groupBox2.Controls.Add(this.btnFamiliaAgregar);
            this.groupBox2.Controls.Add(this.listFamiliaNoContiene);
            this.groupBox2.Controls.Add(this.listFamiliaContiene);
            this.groupBox2.Location = new System.Drawing.Point(25, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 216);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnFamiliaRemover
            // 
            this.btnFamiliaRemover.Location = new System.Drawing.Point(262, 122);
            this.btnFamiliaRemover.Name = "btnFamiliaRemover";
            this.btnFamiliaRemover.Size = new System.Drawing.Size(69, 33);
            this.btnFamiliaRemover.TabIndex = 3;
            this.btnFamiliaRemover.Text = ">>";
            this.btnFamiliaRemover.UseVisualStyleBackColor = true;
            this.btnFamiliaRemover.Click += new System.EventHandler(this.btnFamiliaRemover_Click_1);
            // 
            // btnFamiliaAgregar
            // 
            this.btnFamiliaAgregar.Location = new System.Drawing.Point(262, 61);
            this.btnFamiliaAgregar.Name = "btnFamiliaAgregar";
            this.btnFamiliaAgregar.Size = new System.Drawing.Size(69, 33);
            this.btnFamiliaAgregar.TabIndex = 2;
            this.btnFamiliaAgregar.Text = "<<";
            this.btnFamiliaAgregar.UseVisualStyleBackColor = true;
            this.btnFamiliaAgregar.Click += new System.EventHandler(this.btnFamiliaAgregar_Click_1);
            // 
            // listFamiliaNoContiene
            // 
            this.listFamiliaNoContiene.FormattingEnabled = true;
            this.listFamiliaNoContiene.Location = new System.Drawing.Point(337, 28);
            this.listFamiliaNoContiene.Name = "listFamiliaNoContiene";
            this.listFamiliaNoContiene.Size = new System.Drawing.Size(250, 160);
            this.listFamiliaNoContiene.TabIndex = 1;
            this.listFamiliaNoContiene.SelectedIndexChanged += new System.EventHandler(this.listFamiliaNoContiene_SelectedIndexChanged);
            // 
            // listFamiliaContiene
            // 
            this.listFamiliaContiene.FormattingEnabled = true;
            this.listFamiliaContiene.Location = new System.Drawing.Point(6, 28);
            this.listFamiliaContiene.Name = "listFamiliaContiene";
            this.listFamiliaContiene.Size = new System.Drawing.Size(250, 160);
            this.listFamiliaContiene.TabIndex = 0;
            this.listFamiliaContiene.SelectedIndexChanged += new System.EventHandler(this.listFamiliaContiene_SelectedIndexChanged);
            // 
            // btnPermisoBuscar
            // 
            this.btnPermisoBuscar.Location = new System.Drawing.Point(488, 31);
            this.btnPermisoBuscar.Name = "btnPermisoBuscar";
            this.btnPermisoBuscar.Size = new System.Drawing.Size(130, 23);
            this.btnPermisoBuscar.TabIndex = 2;
            this.btnPermisoBuscar.Text = "Buscar Permisos";
            this.btnPermisoBuscar.UseVisualStyleBackColor = true;
            this.btnPermisoBuscar.Click += new System.EventHandler(this.btnPermisoBuscar_Click_1);
            // 
            // btnPermisosAsignarUsuario
            // 
            this.btnPermisosAsignarUsuario.Location = new System.Drawing.Point(363, 31);
            this.btnPermisosAsignarUsuario.Name = "btnPermisosAsignarUsuario";
            this.btnPermisosAsignarUsuario.Size = new System.Drawing.Size(119, 23);
            this.btnPermisosAsignarUsuario.TabIndex = 1;
            this.btnPermisosAsignarUsuario.Text = "Asignar Usuario";
            this.btnPermisosAsignarUsuario.UseVisualStyleBackColor = true;
            this.btnPermisosAsignarUsuario.Click += new System.EventHandler(this.btnPermisosAsignarUsuario_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(678, 68);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 54);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(678, 163);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 54);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 589);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlFamilia);
            this.Name = "frmPermisos";
            this.Text = "Gestión Permisos";
            this.pnlFamilia.ResumeLayout(false);
            this.pnlFamilia.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPermisosUsuario;
        private System.Windows.Forms.GroupBox pnlFamilia;
        private System.Windows.Forms.Label lbPermisos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPatenteRemover;
        private System.Windows.Forms.Button btnPatenteAgregar;
        private System.Windows.Forms.Label lbSector;
        private System.Windows.Forms.ListBox listPatenteNoContiene;
        private System.Windows.Forms.ListBox listPatenteContiene;
        private System.Windows.Forms.ListBox listPatenteContieneACT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFamiliaRemover;
        private System.Windows.Forms.Button btnFamiliaAgregar;
        private System.Windows.Forms.ListBox listFamiliaNoContiene;
        private System.Windows.Forms.ListBox listFamiliaContiene;
        private System.Windows.Forms.Button btnPermisoBuscar;
        private System.Windows.Forms.Button btnPermisosAsignarUsuario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tbSector;
    }
}