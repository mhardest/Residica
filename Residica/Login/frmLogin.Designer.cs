namespace Residica
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tB_Usuario = new System.Windows.Forms.TextBox();
            this.tB_Contraseña = new System.Windows.Forms.TextBox();
            this.lb_Login = new System.Windows.Forms.Label();
            this.btn_Acceder = new System.Windows.Forms.Button();
            this.llB_Olvido = new System.Windows.Forms.LinkLabel();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lb_ErrorMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            // 
            // tB_Usuario
            // 
            this.tB_Usuario.BackColor = System.Drawing.Color.DarkCyan;
            this.tB_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_Usuario.ForeColor = System.Drawing.Color.Black;
            this.tB_Usuario.Location = new System.Drawing.Point(354, 105);
            this.tB_Usuario.Name = "tB_Usuario";
            this.tB_Usuario.Size = new System.Drawing.Size(376, 22);
            this.tB_Usuario.TabIndex = 1;
            this.tB_Usuario.Text = "Username";
            this.tB_Usuario.Enter += new System.EventHandler(this.tB_Usuario_Enter);
            this.tB_Usuario.Leave += new System.EventHandler(this.tB_Usuario_Leave);
            // 
            // tB_Contraseña
            // 
            this.tB_Contraseña.BackColor = System.Drawing.Color.DarkCyan;
            this.tB_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_Contraseña.ForeColor = System.Drawing.Color.Black;
            this.tB_Contraseña.Location = new System.Drawing.Point(354, 159);
            this.tB_Contraseña.Name = "tB_Contraseña";
            this.tB_Contraseña.Size = new System.Drawing.Size(376, 22);
            this.tB_Contraseña.TabIndex = 2;
            this.tB_Contraseña.Text = "Password";
            this.tB_Contraseña.Enter += new System.EventHandler(this.tB_Contraseña_Enter);
            this.tB_Contraseña.Leave += new System.EventHandler(this.tB_Contraseña_Leave);
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Login.ForeColor = System.Drawing.Color.Black;
            this.lb_Login.Location = new System.Drawing.Point(497, 35);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(67, 24);
            this.lb_Login.TabIndex = 3;
            this.lb_Login.Text = "LOGIN";
            // 
            // btn_Acceder
            // 
            this.btn_Acceder.BackColor = System.Drawing.Color.Black;
            this.btn_Acceder.FlatAppearance.BorderSize = 0;
            this.btn_Acceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Acceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Acceder.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Acceder.Location = new System.Drawing.Point(354, 249);
            this.btn_Acceder.Name = "btn_Acceder";
            this.btn_Acceder.Size = new System.Drawing.Size(376, 40);
            this.btn_Acceder.TabIndex = 3;
            this.btn_Acceder.Text = "ACCEDER";
            this.btn_Acceder.UseVisualStyleBackColor = false;
            this.btn_Acceder.Click += new System.EventHandler(this.btn_Acceder_Click);
            // 
            // llB_Olvido
            // 
            this.llB_Olvido.ActiveLinkColor = System.Drawing.Color.Cyan;
            this.llB_Olvido.AutoSize = true;
            this.llB_Olvido.LinkColor = System.Drawing.Color.Black;
            this.llB_Olvido.Location = new System.Drawing.Point(463, 308);
            this.llB_Olvido.Name = "llB_Olvido";
            this.llB_Olvido.Size = new System.Drawing.Size(146, 13);
            this.llB_Olvido.TabIndex = 0;
            this.llB_Olvido.TabStop = true;
            this.llB_Olvido.Text = "¿Ha Olvidado la Contraseña?";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(753, 12);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(15, 15);
            this.btn_Cerrar.TabIndex = 6;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimizar.Image")));
            this.btn_Minimizar.Location = new System.Drawing.Point(732, 12);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(15, 15);
            this.btn_Minimizar.TabIndex = 7;
            this.btn_Minimizar.TabStop = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(43, 105);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(148, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lb_ErrorMessage
            // 
            this.lb_ErrorMessage.AutoSize = true;
            this.lb_ErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ErrorMessage.Location = new System.Drawing.Point(354, 210);
            this.lb_ErrorMessage.Name = "lb_ErrorMessage";
            this.lb_ErrorMessage.Size = new System.Drawing.Size(110, 16);
            this.lb_ErrorMessage.TabIndex = 8;
            this.lb_ErrorMessage.Text = "Error Message";
            this.lb_ErrorMessage.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_Acceder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.lb_ErrorMessage);
            this.Controls.Add(this.btn_Minimizar);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.llB_Olvido);
            this.Controls.Add(this.btn_Acceder);
            this.Controls.Add(this.lb_Login);
            this.Controls.Add(this.tB_Contraseña);
            this.Controls.Add(this.tB_Usuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tB_Usuario;
        private System.Windows.Forms.TextBox tB_Contraseña;
        private System.Windows.Forms.Label lb_Login;
        private System.Windows.Forms.Button btn_Acceder;
        private System.Windows.Forms.LinkLabel llB_Olvido;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private System.Windows.Forms.PictureBox btn_Minimizar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lb_ErrorMessage;
    }
}