namespace GUI
{
    partial class FrmAdminGerencial
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
            this.btnLiquidarSueldos = new System.Windows.Forms.Button();
            this.btnContratarEmpleado = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnRecaudar = new System.Windows.Forms.Button();
            this.btnPromoverEmpleado = new System.Windows.Forms.Button();
            this.btnDespedirEmpleado = new System.Windows.Forms.Button();
            this.btnTransferirEmpleado = new System.Windows.Forms.Button();
            this.btnAbrirNuevaSucursal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLiquidarSueldos
            // 
            this.btnLiquidarSueldos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLiquidarSueldos.Location = new System.Drawing.Point(331, 184);
            this.btnLiquidarSueldos.Name = "btnLiquidarSueldos";
            this.btnLiquidarSueldos.Size = new System.Drawing.Size(254, 136);
            this.btnLiquidarSueldos.TabIndex = 15;
            this.btnLiquidarSueldos.Text = "Liquidación de Sueldos";
            this.btnLiquidarSueldos.UseVisualStyleBackColor = true;
            this.btnLiquidarSueldos.Click += new System.EventHandler(this.btnLiquidarSueldos_Click);
            // 
            // btnContratarEmpleado
            // 
            this.btnContratarEmpleado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContratarEmpleado.Location = new System.Drawing.Point(12, 12);
            this.btnContratarEmpleado.Name = "btnContratarEmpleado";
            this.btnContratarEmpleado.Size = new System.Drawing.Size(254, 80);
            this.btnContratarEmpleado.TabIndex = 14;
            this.btnContratarEmpleado.Text = "Contratar Empleado";
            this.btnContratarEmpleado.UseVisualStyleBackColor = true;
            this.btnContratarEmpleado.Click += new System.EventHandler(this.btnContratarEmpleado_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(331, 326);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(254, 23);
            this.btnFinalizar.TabIndex = 13;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.Location = new System.Drawing.Point(331, 95);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 25);
            this.lblMensaje.TabIndex = 12;
            // 
            // btnRecaudar
            // 
            this.btnRecaudar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRecaudar.Location = new System.Drawing.Point(331, 46);
            this.btnRecaudar.Name = "btnRecaudar";
            this.btnRecaudar.Size = new System.Drawing.Size(254, 132);
            this.btnRecaudar.TabIndex = 10;
            this.btnRecaudar.Text = "Recaudación Total";
            this.btnRecaudar.UseVisualStyleBackColor = true;
            this.btnRecaudar.Click += new System.EventHandler(this.btnRecaudar_Click);
            // 
            // btnPromoverEmpleado
            // 
            this.btnPromoverEmpleado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPromoverEmpleado.Location = new System.Drawing.Point(12, 98);
            this.btnPromoverEmpleado.Name = "btnPromoverEmpleado";
            this.btnPromoverEmpleado.Size = new System.Drawing.Size(254, 80);
            this.btnPromoverEmpleado.TabIndex = 16;
            this.btnPromoverEmpleado.Text = "PromoverEmpleado";
            this.btnPromoverEmpleado.UseVisualStyleBackColor = true;
            this.btnPromoverEmpleado.Click += new System.EventHandler(this.btnPromoverEmpleado_Click);
            // 
            // btnDespedirEmpleado
            // 
            this.btnDespedirEmpleado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDespedirEmpleado.Location = new System.Drawing.Point(12, 269);
            this.btnDespedirEmpleado.Name = "btnDespedirEmpleado";
            this.btnDespedirEmpleado.Size = new System.Drawing.Size(254, 80);
            this.btnDespedirEmpleado.TabIndex = 17;
            this.btnDespedirEmpleado.Text = "Despedir Empleado";
            this.btnDespedirEmpleado.UseVisualStyleBackColor = true;
            this.btnDespedirEmpleado.Click += new System.EventHandler(this.btnDespedirEmpleado_Click);
            // 
            // btnTransferirEmpleado
            // 
            this.btnTransferirEmpleado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTransferirEmpleado.Location = new System.Drawing.Point(12, 184);
            this.btnTransferirEmpleado.Name = "btnTransferirEmpleado";
            this.btnTransferirEmpleado.Size = new System.Drawing.Size(254, 80);
            this.btnTransferirEmpleado.TabIndex = 18;
            this.btnTransferirEmpleado.Text = "Transferir Empleado";
            this.btnTransferirEmpleado.UseVisualStyleBackColor = true;
            this.btnTransferirEmpleado.Click += new System.EventHandler(this.btnTransferirEmpleado_Click);
            // 
            // btnAbrirNuevaSucursal
            // 
            this.btnAbrirNuevaSucursal.Location = new System.Drawing.Point(331, 12);
            this.btnAbrirNuevaSucursal.Name = "btnAbrirNuevaSucursal";
            this.btnAbrirNuevaSucursal.Size = new System.Drawing.Size(254, 28);
            this.btnAbrirNuevaSucursal.TabIndex = 19;
            this.btnAbrirNuevaSucursal.Text = "Abrir Nueva Sucursal";
            this.btnAbrirNuevaSucursal.UseVisualStyleBackColor = true;
            this.btnAbrirNuevaSucursal.Click += new System.EventHandler(this.btnAbrirNuevaSucursal_Click);
            // 
            // FrmAdminGerencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 361);
            this.Controls.Add(this.btnAbrirNuevaSucursal);
            this.Controls.Add(this.btnTransferirEmpleado);
            this.Controls.Add(this.btnDespedirEmpleado);
            this.Controls.Add(this.btnPromoverEmpleado);
            this.Controls.Add(this.btnLiquidarSueldos);
            this.Controls.Add(this.btnContratarEmpleado);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnRecaudar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 90);
            this.Name = "FrmAdminGerencial";
            this.Text = "FrmAdminGerencial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLiquidarSueldos;
        private System.Windows.Forms.Button btnContratarEmpleado;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnRecaudar;
        private System.Windows.Forms.Button btnPromoverEmpleado;
        private System.Windows.Forms.Button btnDespedirEmpleado;
        private System.Windows.Forms.Button btnTransferirEmpleado;
        private System.Windows.Forms.Button btnAbrirNuevaSucursal;
    }
}