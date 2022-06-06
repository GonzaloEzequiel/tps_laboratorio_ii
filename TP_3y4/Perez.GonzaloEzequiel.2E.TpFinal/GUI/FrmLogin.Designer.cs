namespace GUI
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.grpbLogIn = new System.Windows.Forms.GroupBox();
            this.btnLogGerente = new System.Windows.Forms.Button();
            this.btnLogEncargado = new System.Windows.Forms.Button();
            this.btnLogEmpleado = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpbLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 325);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(381, 66);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 23);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(381, 122);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '•';
            this.txtContrasenia.Size = new System.Drawing.Size(200, 23);
            this.txtContrasenia.TabIndex = 2;
            this.txtContrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblUsuario.Location = new System.Drawing.Point(381, 45);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 18);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContrasenia.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblContrasenia.Location = new System.Drawing.Point(381, 101);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(84, 18);
            this.lblContrasenia.TabIndex = 4;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // grpbLogIn
            // 
            this.grpbLogIn.Controls.Add(this.btnLogGerente);
            this.grpbLogIn.Controls.Add(this.btnLogEncargado);
            this.grpbLogIn.Controls.Add(this.btnLogEmpleado);
            this.grpbLogIn.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpbLogIn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grpbLogIn.Location = new System.Drawing.Point(25, 356);
            this.grpbLogIn.Name = "grpbLogIn";
            this.grpbLogIn.Size = new System.Drawing.Size(556, 82);
            this.grpbLogIn.TabIndex = 7;
            this.grpbLogIn.TabStop = false;
            this.grpbLogIn.Text = " Log In Rápido ";
            // 
            // btnLogGerente
            // 
            this.btnLogGerente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogGerente.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogGerente.Location = new System.Drawing.Point(385, 36);
            this.btnLogGerente.Name = "btnLogGerente";
            this.btnLogGerente.Size = new System.Drawing.Size(150, 23);
            this.btnLogGerente.TabIndex = 6;
            this.btnLogGerente.Text = "Log Gerente";
            this.btnLogGerente.UseVisualStyleBackColor = true;
            this.btnLogGerente.Click += new System.EventHandler(this.btnLogGerente_Click);
            // 
            // btnLogEncargado
            // 
            this.btnLogEncargado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogEncargado.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogEncargado.Location = new System.Drawing.Point(203, 36);
            this.btnLogEncargado.Name = "btnLogEncargado";
            this.btnLogEncargado.Size = new System.Drawing.Size(150, 23);
            this.btnLogEncargado.TabIndex = 5;
            this.btnLogEncargado.Text = "Log Encargado";
            this.btnLogEncargado.UseVisualStyleBackColor = true;
            this.btnLogEncargado.Click += new System.EventHandler(this.btnLogEncargado_Click);
            // 
            // btnLogEmpleado
            // 
            this.btnLogEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogEmpleado.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogEmpleado.Location = new System.Drawing.Point(23, 36);
            this.btnLogEmpleado.Name = "btnLogEmpleado";
            this.btnLogEmpleado.Size = new System.Drawing.Size(150, 23);
            this.btnLogEmpleado.TabIndex = 4;
            this.btnLogEmpleado.Text = "Log Empleado";
            this.btnLogEmpleado.UseVisualStyleBackColor = true;
            this.btnLogEmpleado.Click += new System.EventHandler(this.btnLogEmpleado_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnIngresar.Location = new System.Drawing.Point(381, 234);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(200, 46);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalir.Location = new System.Drawing.Point(381, 303);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(609, 451);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.grpbLogIn);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoFacil LogIn";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbLogIn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.GroupBox grpbLogIn;
        private System.Windows.Forms.Button btnLogGerente;
        private System.Windows.Forms.Button btnLogEncargado;
        private System.Windows.Forms.Button btnLogEmpleado;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
    }
}
