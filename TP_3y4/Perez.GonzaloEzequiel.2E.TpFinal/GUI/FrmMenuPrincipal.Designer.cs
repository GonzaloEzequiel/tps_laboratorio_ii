namespace GUI
{
    partial class FrmMenuPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblColaClientes = new System.Windows.Forms.Label();
            this.btnAtenderCliente = new System.Windows.Forms.Button();
            this.btnAdminSucursal = new System.Windows.Forms.Button();
            this.btnAdminGerencial = new System.Windows.Forms.Button();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblInfo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(609, 30);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Info del Empleado y Sucursal";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColaClientes
            // 
            this.lblColaClientes.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblColaClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColaClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblColaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblColaClientes.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblColaClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColaClientes.Location = new System.Drawing.Point(0, 30);
            this.lblColaClientes.Name = "lblColaClientes";
            this.lblColaClientes.Size = new System.Drawing.Size(609, 60);
            this.lblColaClientes.TabIndex = 1;
            this.lblColaClientes.Text = "Clientes en cola: ";
            this.lblColaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAtenderCliente
            // 
            this.btnAtenderCliente.Location = new System.Drawing.Point(172, 46);
            this.btnAtenderCliente.Name = "btnAtenderCliente";
            this.btnAtenderCliente.Size = new System.Drawing.Size(156, 32);
            this.btnAtenderCliente.TabIndex = 2;
            this.btnAtenderCliente.Text = "Atender Cliente";
            this.btnAtenderCliente.UseVisualStyleBackColor = true;
            this.btnAtenderCliente.Click += new System.EventHandler(this.btnAtenderCliente_Click);
            // 
            // btnAdminSucursal
            // 
            this.btnAdminSucursal.Enabled = false;
            this.btnAdminSucursal.Location = new System.Drawing.Point(352, 46);
            this.btnAdminSucursal.Name = "btnAdminSucursal";
            this.btnAdminSucursal.Size = new System.Drawing.Size(110, 32);
            this.btnAdminSucursal.TabIndex = 4;
            this.btnAdminSucursal.Text = "Admin Sucursal";
            this.btnAdminSucursal.UseVisualStyleBackColor = true;
            this.btnAdminSucursal.Click += new System.EventHandler(this.btnAdminSucursal_Click);
            // 
            // btnAdminGerencial
            // 
            this.btnAdminGerencial.Enabled = false;
            this.btnAdminGerencial.Location = new System.Drawing.Point(487, 46);
            this.btnAdminGerencial.Name = "btnAdminGerencial";
            this.btnAdminGerencial.Size = new System.Drawing.Size(110, 32);
            this.btnAdminGerencial.TabIndex = 5;
            this.btnAdminGerencial.Text = "Admin Gerencial";
            this.btnAdminGerencial.UseVisualStyleBackColor = true;
            this.btnAdminGerencial.Click += new System.EventHandler(this.btnAdminGerencial_Click);
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.Enabled = false;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(125, 52);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(203, 23);
            this.cmbSucursal.TabIndex = 7;
            // 
            // FrmMenuPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(609, 451);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.btnAdminGerencial);
            this.Controls.Add(this.btnAdminSucursal);
            this.Controls.Add(this.btnAtenderCliente);
            this.Controls.Add(this.lblColaClientes);
            this.Controls.Add(this.lblInfo);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblColaClientes;
        private System.Windows.Forms.Button btnAtenderCliente;
        private System.Windows.Forms.Button btnAdminSucursal;
        private System.Windows.Forms.Button btnAdminGerencial;
        private System.Windows.Forms.ComboBox cmbSucursal;
    }
}