namespace Residica.Residentes
{
    partial class frmGestionResidente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionResidente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVerResidentes = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevoResidente = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbNroCuil = new DevExpress.XtraEditors.LabelControl();
            this.lbNroDocumento = new DevExpress.XtraEditors.LabelControl();
            this.txtNroCuil = new DevExpress.XtraEditors.TextEdit();
            this.txtNroDocumento = new DevExpress.XtraEditors.TextEdit();
            this.btnBuscarResidente = new DevExpress.XtraEditors.SimpleButton();
            this.gbResidente = new System.Windows.Forms.GroupBox();
            this.tbResidenteId = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbFechaNacimiento = new System.Windows.Forms.Label();
            this.rbObservacion = new System.Windows.Forms.RichTextBox();
            this.tbDireccionContacto = new System.Windows.Forms.TextBox();
            this.tbPersonaContacto = new System.Windows.Forms.TextBox();
            this.tbTelefonoContacto = new System.Windows.Forms.TextBox();
            this.tbTelefonoEmergencia = new System.Windows.Forms.TextBox();
            this.tbObraSocial = new System.Windows.Forms.TextBox();
            this.tbCuil = new System.Windows.Forms.TextBox();
            this.tbDocumento = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.lbTelefonoEmergencia = new System.Windows.Forms.Label();
            this.lbDireccionContacto = new System.Windows.Forms.Label();
            this.lbPersonaContacto = new System.Windows.Forms.Label();
            this.lbTelefonoContacto = new System.Windows.Forms.Label();
            this.lbObservacion = new System.Windows.Forms.Label();
            this.lbObraSocial = new System.Windows.Forms.Label();
            this.lbCuil = new System.Windows.Forms.Label();
            this.lbDocumento = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroCuil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroDocumento.Properties)).BeginInit();
            this.gbResidente.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerResidentes);
            this.groupBox1.Controls.Add(this.btnNuevoResidente);
            this.groupBox1.Location = new System.Drawing.Point(13, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnVerResidentes
            // 
            this.btnVerResidentes.Location = new System.Drawing.Point(106, 113);
            this.btnVerResidentes.Name = "btnVerResidentes";
            this.btnVerResidentes.Size = new System.Drawing.Size(155, 62);
            this.btnVerResidentes.TabIndex = 1;
            this.btnVerResidentes.Text = "Ver Residentes";
            this.btnVerResidentes.Click += new System.EventHandler(this.btnVerResidentes_Click);
            // 
            // btnNuevoResidente
            // 
            this.btnNuevoResidente.Location = new System.Drawing.Point(106, 30);
            this.btnNuevoResidente.Name = "btnNuevoResidente";
            this.btnNuevoResidente.Size = new System.Drawing.Size(155, 62);
            this.btnNuevoResidente.TabIndex = 0;
            this.btnNuevoResidente.Text = "Nuevo Residente";
            this.btnNuevoResidente.Click += new System.EventHandler(this.btnNuevoResidente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbNroCuil);
            this.groupBox2.Controls.Add(this.lbNroDocumento);
            this.groupBox2.Controls.Add(this.txtNroCuil);
            this.groupBox2.Controls.Add(this.txtNroDocumento);
            this.groupBox2.Controls.Add(this.btnBuscarResidente);
            this.groupBox2.Location = new System.Drawing.Point(414, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 199);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lbNroCuil
            // 
            this.lbNroCuil.Location = new System.Drawing.Point(18, 56);
            this.lbNroCuil.Name = "lbNroCuil";
            this.lbNroCuil.Size = new System.Drawing.Size(78, 13);
            this.lbNroCuil.TabIndex = 6;
            this.lbNroCuil.Text = "Número de CUIL";
            // 
            // lbNroDocumento
            // 
            this.lbNroDocumento.Location = new System.Drawing.Point(18, 22);
            this.lbNroDocumento.Name = "lbNroDocumento";
            this.lbNroDocumento.Size = new System.Drawing.Size(109, 13);
            this.lbNroDocumento.TabIndex = 4;
            this.lbNroDocumento.Text = "Número de Documento";
            // 
            // txtNroCuil
            // 
            this.txtNroCuil.Location = new System.Drawing.Point(177, 53);
            this.txtNroCuil.Name = "txtNroCuil";
            this.txtNroCuil.Size = new System.Drawing.Size(163, 20);
            this.txtNroCuil.TabIndex = 3;
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(177, 19);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(163, 20);
            this.txtNroDocumento.TabIndex = 2;
            // 
            // btnBuscarResidente
            // 
            this.btnBuscarResidente.Location = new System.Drawing.Point(130, 105);
            this.btnBuscarResidente.Name = "btnBuscarResidente";
            this.btnBuscarResidente.Size = new System.Drawing.Size(155, 62);
            this.btnBuscarResidente.TabIndex = 1;
            this.btnBuscarResidente.Text = "Buscar Residente";
            this.btnBuscarResidente.Click += new System.EventHandler(this.btnBuscarResidente_Click);
            // 
            // gbResidente
            // 
            this.gbResidente.Controls.Add(this.tbResidenteId);
            this.gbResidente.Controls.Add(this.dtpFechaNacimiento);
            this.gbResidente.Controls.Add(this.lbFechaNacimiento);
            this.gbResidente.Controls.Add(this.rbObservacion);
            this.gbResidente.Controls.Add(this.tbDireccionContacto);
            this.gbResidente.Controls.Add(this.tbPersonaContacto);
            this.gbResidente.Controls.Add(this.tbTelefonoContacto);
            this.gbResidente.Controls.Add(this.tbTelefonoEmergencia);
            this.gbResidente.Controls.Add(this.tbObraSocial);
            this.gbResidente.Controls.Add(this.tbCuil);
            this.gbResidente.Controls.Add(this.tbDocumento);
            this.gbResidente.Controls.Add(this.tbNombre);
            this.gbResidente.Controls.Add(this.tbApellido);
            this.gbResidente.Controls.Add(this.lbTelefonoEmergencia);
            this.gbResidente.Controls.Add(this.lbDireccionContacto);
            this.gbResidente.Controls.Add(this.lbPersonaContacto);
            this.gbResidente.Controls.Add(this.lbTelefonoContacto);
            this.gbResidente.Controls.Add(this.lbObservacion);
            this.gbResidente.Controls.Add(this.lbObraSocial);
            this.gbResidente.Controls.Add(this.lbCuil);
            this.gbResidente.Controls.Add(this.lbDocumento);
            this.gbResidente.Controls.Add(this.lbNombre);
            this.gbResidente.Controls.Add(this.lbApellido);
            this.gbResidente.Location = new System.Drawing.Point(13, 209);
            this.gbResidente.Name = "gbResidente";
            this.gbResidente.Size = new System.Drawing.Size(775, 300);
            this.gbResidente.TabIndex = 3;
            this.gbResidente.TabStop = false;
            // 
            // tbResidenteId
            // 
            this.tbResidenteId.Location = new System.Drawing.Point(527, 154);
            this.tbResidenteId.Name = "tbResidenteId";
            this.tbResidenteId.Size = new System.Drawing.Size(158, 20);
            this.tbResidenteId.TabIndex = 22;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(220, 74);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(159, 20);
            this.dtpFechaNacimiento.TabIndex = 14;
            // 
            // lbFechaNacimiento
            // 
            this.lbFechaNacimiento.AutoSize = true;
            this.lbFechaNacimiento.Location = new System.Drawing.Point(109, 74);
            this.lbFechaNacimiento.Name = "lbFechaNacimiento";
            this.lbFechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.lbFechaNacimiento.TabIndex = 21;
            this.lbFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // rbObservacion
            // 
            this.rbObservacion.Location = new System.Drawing.Point(112, 209);
            this.rbObservacion.Name = "rbObservacion";
            this.rbObservacion.Size = new System.Drawing.Size(574, 75);
            this.rbObservacion.TabIndex = 20;
            this.rbObservacion.Text = "";
            // 
            // tbDireccionContacto
            // 
            this.tbDireccionContacto.Location = new System.Drawing.Point(221, 126);
            this.tbDireccionContacto.Name = "tbDireccionContacto";
            this.tbDireccionContacto.Size = new System.Drawing.Size(464, 20);
            this.tbDireccionContacto.TabIndex = 18;
            // 
            // tbPersonaContacto
            // 
            this.tbPersonaContacto.Location = new System.Drawing.Point(527, 100);
            this.tbPersonaContacto.Name = "tbPersonaContacto";
            this.tbPersonaContacto.Size = new System.Drawing.Size(158, 20);
            this.tbPersonaContacto.TabIndex = 17;
            // 
            // tbTelefonoContacto
            // 
            this.tbTelefonoContacto.Location = new System.Drawing.Point(221, 100);
            this.tbTelefonoContacto.Name = "tbTelefonoContacto";
            this.tbTelefonoContacto.Size = new System.Drawing.Size(158, 20);
            this.tbTelefonoContacto.TabIndex = 16;
            // 
            // tbTelefonoEmergencia
            // 
            this.tbTelefonoEmergencia.Location = new System.Drawing.Point(221, 154);
            this.tbTelefonoEmergencia.Name = "tbTelefonoEmergencia";
            this.tbTelefonoEmergencia.Size = new System.Drawing.Size(158, 20);
            this.tbTelefonoEmergencia.TabIndex = 19;
            // 
            // tbObraSocial
            // 
            this.tbObraSocial.Location = new System.Drawing.Point(528, 74);
            this.tbObraSocial.Name = "tbObraSocial";
            this.tbObraSocial.Size = new System.Drawing.Size(157, 20);
            this.tbObraSocial.TabIndex = 15;
            // 
            // tbCuil
            // 
            this.tbCuil.Location = new System.Drawing.Point(527, 48);
            this.tbCuil.Name = "tbCuil";
            this.tbCuil.Size = new System.Drawing.Size(158, 20);
            this.tbCuil.TabIndex = 13;
            // 
            // tbDocumento
            // 
            this.tbDocumento.Location = new System.Drawing.Point(221, 48);
            this.tbDocumento.Name = "tbDocumento";
            this.tbDocumento.Size = new System.Drawing.Size(158, 20);
            this.tbDocumento.TabIndex = 12;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(527, 22);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(158, 20);
            this.tbNombre.TabIndex = 11;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(221, 22);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(158, 20);
            this.tbApellido.TabIndex = 10;
            // 
            // lbTelefonoEmergencia
            // 
            this.lbTelefonoEmergencia.AutoSize = true;
            this.lbTelefonoEmergencia.Location = new System.Drawing.Point(109, 154);
            this.lbTelefonoEmergencia.Name = "lbTelefonoEmergencia";
            this.lbTelefonoEmergencia.Size = new System.Drawing.Size(108, 13);
            this.lbTelefonoEmergencia.TabIndex = 9;
            this.lbTelefonoEmergencia.Text = "Telefono Emergencia";
            // 
            // lbDireccionContacto
            // 
            this.lbDireccionContacto.AutoSize = true;
            this.lbDireccionContacto.Location = new System.Drawing.Point(109, 126);
            this.lbDireccionContacto.Name = "lbDireccionContacto";
            this.lbDireccionContacto.Size = new System.Drawing.Size(98, 13);
            this.lbDireccionContacto.TabIndex = 8;
            this.lbDireccionContacto.Text = "Dirección Contacto";
            // 
            // lbPersonaContacto
            // 
            this.lbPersonaContacto.AutoSize = true;
            this.lbPersonaContacto.Location = new System.Drawing.Point(408, 100);
            this.lbPersonaContacto.Name = "lbPersonaContacto";
            this.lbPersonaContacto.Size = new System.Drawing.Size(92, 13);
            this.lbPersonaContacto.TabIndex = 7;
            this.lbPersonaContacto.Text = "Persona Contacto";
            // 
            // lbTelefonoContacto
            // 
            this.lbTelefonoContacto.AutoSize = true;
            this.lbTelefonoContacto.Location = new System.Drawing.Point(109, 100);
            this.lbTelefonoContacto.Name = "lbTelefonoContacto";
            this.lbTelefonoContacto.Size = new System.Drawing.Size(95, 13);
            this.lbTelefonoContacto.TabIndex = 6;
            this.lbTelefonoContacto.Text = "Telefono Contacto";
            // 
            // lbObservacion
            // 
            this.lbObservacion.AutoSize = true;
            this.lbObservacion.Location = new System.Drawing.Point(109, 184);
            this.lbObservacion.Name = "lbObservacion";
            this.lbObservacion.Size = new System.Drawing.Size(67, 13);
            this.lbObservacion.TabIndex = 5;
            this.lbObservacion.Text = "Observación";
            // 
            // lbObraSocial
            // 
            this.lbObraSocial.AutoSize = true;
            this.lbObraSocial.Location = new System.Drawing.Point(408, 74);
            this.lbObraSocial.Name = "lbObraSocial";
            this.lbObraSocial.Size = new System.Drawing.Size(62, 13);
            this.lbObraSocial.TabIndex = 4;
            this.lbObraSocial.Text = "Obra Social";
            // 
            // lbCuil
            // 
            this.lbCuil.AutoSize = true;
            this.lbCuil.Location = new System.Drawing.Point(408, 48);
            this.lbCuil.Name = "lbCuil";
            this.lbCuil.Size = new System.Drawing.Size(46, 13);
            this.lbCuil.TabIndex = 3;
            this.lbCuil.Text = "N° CUIL";
            // 
            // lbDocumento
            // 
            this.lbDocumento.AutoSize = true;
            this.lbDocumento.Location = new System.Drawing.Point(109, 48);
            this.lbDocumento.Name = "lbDocumento";
            this.lbDocumento.Size = new System.Drawing.Size(77, 13);
            this.lbDocumento.TabIndex = 2;
            this.lbDocumento.Text = "N° Documento";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(408, 22);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(109, 22);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(44, 13);
            this.lbApellido.TabIndex = 0;
            this.lbApellido.Text = "Apellido";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(337, 515);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(155, 62);
            this.btnGuardarCambios.TabIndex = 7;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // frmGestionResidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.gbResidente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionResidente";
            this.Text = "Gestión Residentes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroCuil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroDocumento.Properties)).EndInit();
            this.gbResidente.ResumeLayout(false);
            this.gbResidente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnVerResidentes;
        private DevExpress.XtraEditors.SimpleButton btnNuevoResidente;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl lbNroCuil;
        private DevExpress.XtraEditors.LabelControl lbNroDocumento;
        private DevExpress.XtraEditors.TextEdit txtNroCuil;
        private DevExpress.XtraEditors.TextEdit txtNroDocumento;
        private DevExpress.XtraEditors.SimpleButton btnBuscarResidente;
        private System.Windows.Forms.GroupBox gbResidente;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lbFechaNacimiento;
        private System.Windows.Forms.RichTextBox rbObservacion;
        private System.Windows.Forms.TextBox tbDireccionContacto;
        private System.Windows.Forms.TextBox tbPersonaContacto;
        private System.Windows.Forms.TextBox tbTelefonoContacto;
        private System.Windows.Forms.TextBox tbTelefonoEmergencia;
        private System.Windows.Forms.TextBox tbObraSocial;
        private System.Windows.Forms.TextBox tbCuil;
        private System.Windows.Forms.TextBox tbDocumento;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label lbTelefonoEmergencia;
        private System.Windows.Forms.Label lbDireccionContacto;
        private System.Windows.Forms.Label lbPersonaContacto;
        private System.Windows.Forms.Label lbTelefonoContacto;
        private System.Windows.Forms.Label lbObservacion;
        private System.Windows.Forms.Label lbObraSocial;
        private System.Windows.Forms.Label lbCuil;
        private System.Windows.Forms.Label lbDocumento;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private DevExpress.XtraEditors.SimpleButton btnGuardarCambios;
        private System.Windows.Forms.TextBox tbResidenteId;
    }
}