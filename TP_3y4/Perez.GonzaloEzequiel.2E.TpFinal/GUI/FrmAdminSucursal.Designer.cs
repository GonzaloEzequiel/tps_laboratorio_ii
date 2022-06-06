namespace GUI
{
    partial class FrmAdminSucursal
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
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.rtxtbSucursaleInfo = new System.Windows.Forms.RichTextBox();
            this.btnRecaudar = new System.Windows.Forms.Button();
            this.btnContratarEmpleado = new System.Windows.Forms.Button();
            this.btnLiquidarSueldos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(337, 326);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(254, 23);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.Location = new System.Drawing.Point(337, 95);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 25);
            this.lblMensaje.TabIndex = 6;
            // 
            // rtxtbSucursaleInfo
            // 
            this.rtxtbSucursaleInfo.Enabled = false;
            this.rtxtbSucursaleInfo.Location = new System.Drawing.Point(18, 12);
            this.rtxtbSucursaleInfo.Name = "rtxtbSucursaleInfo";
            this.rtxtbSucursaleInfo.Size = new System.Drawing.Size(300, 337);
            this.rtxtbSucursaleInfo.TabIndex = 5;
            this.rtxtbSucursaleInfo.Text = "";
            // 
            // btnRecaudar
            // 
            this.btnRecaudar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRecaudar.Location = new System.Drawing.Point(337, 12);
            this.btnRecaudar.Name = "btnRecaudar";
            this.btnRecaudar.Size = new System.Drawing.Size(254, 80);
            this.btnRecaudar.TabIndex = 4;
            this.btnRecaudar.Text = "Recaudar Caja";
            this.btnRecaudar.UseVisualStyleBackColor = true;
            this.btnRecaudar.Click += new System.EventHandler(this.btnRecaudar_Click);
            // 
            // btnContratarEmpleado
            // 
            this.btnContratarEmpleado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContratarEmpleado.Location = new System.Drawing.Point(337, 149);
            this.btnContratarEmpleado.Name = "btnContratarEmpleado";
            this.btnContratarEmpleado.Size = new System.Drawing.Size(254, 80);
            this.btnContratarEmpleado.TabIndex = 8;
            this.btnContratarEmpleado.Text = "Contratar Empleado";
            this.btnContratarEmpleado.UseVisualStyleBackColor = true;
            this.btnContratarEmpleado.Click += new System.EventHandler(this.btnContratarEmpleado_Click);
            // 
            // btnLiquidarSueldos
            // 
            this.btnLiquidarSueldos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLiquidarSueldos.Location = new System.Drawing.Point(337, 235);
            this.btnLiquidarSueldos.Name = "btnLiquidarSueldos";
            this.btnLiquidarSueldos.Size = new System.Drawing.Size(254, 80);
            this.btnLiquidarSueldos.TabIndex = 9;
            this.btnLiquidarSueldos.Text = "Liquidar Sueldos";
            this.btnLiquidarSueldos.UseVisualStyleBackColor = true;
            this.btnLiquidarSueldos.Click += new System.EventHandler(this.btnLiquidarSueldos_Click);
            // 
            // FrmAdminSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 361);
            this.Controls.Add(this.btnLiquidarSueldos);
            this.Controls.Add(this.btnContratarEmpleado);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.rtxtbSucursaleInfo);
            this.Controls.Add(this.btnRecaudar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 90);
            this.Name = "FrmAdminSucursal";
            this.Text = "FrmAdminSucursal";
            this.Load += new System.EventHandler(this.FrmAdminSucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.RichTextBox rtxtbSucursaleInfo;
        private System.Windows.Forms.Button btnRecaudar;
        private System.Windows.Forms.Button btnContratarEmpleado;
        private System.Windows.Forms.Button btnLiquidarSueldos;
    }
}