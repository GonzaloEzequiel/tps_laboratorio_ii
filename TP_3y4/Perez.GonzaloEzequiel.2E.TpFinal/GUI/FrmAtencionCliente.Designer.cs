namespace GUI
{
    partial class FrmAtencionCliente
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
            this.btnCobrarFacturas = new System.Windows.Forms.Button();
            this.rtxtbClienteInfo = new System.Windows.Forms.RichTextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCobrarFacturas
            // 
            this.btnCobrarFacturas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCobrarFacturas.Location = new System.Drawing.Point(331, 12);
            this.btnCobrarFacturas.Name = "btnCobrarFacturas";
            this.btnCobrarFacturas.Size = new System.Drawing.Size(254, 80);
            this.btnCobrarFacturas.TabIndex = 0;
            this.btnCobrarFacturas.Text = "Cobrar Facturas";
            this.btnCobrarFacturas.UseVisualStyleBackColor = true;
            this.btnCobrarFacturas.Click += new System.EventHandler(this.btnCobrarFacturas_Click);
            // 
            // rtxtbClienteInfo
            // 
            this.rtxtbClienteInfo.Enabled = false;
            this.rtxtbClienteInfo.Location = new System.Drawing.Point(12, 12);
            this.rtxtbClienteInfo.Name = "rtxtbClienteInfo";
            this.rtxtbClienteInfo.Size = new System.Drawing.Size(300, 337);
            this.rtxtbClienteInfo.TabIndex = 1;
            this.rtxtbClienteInfo.Text = "";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(331, 326);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(254, 23);
            this.btnFinalizar.TabIndex = 3;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.Location = new System.Drawing.Point(331, 199);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 25);
            this.lblMensaje.TabIndex = 2;
            // 
            // FrmAtencionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 361);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.rtxtbClienteInfo);
            this.Controls.Add(this.btnCobrarFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 90);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAtencionCliente";
            this.Text = "FrmAtencionCliente";
            this.Load += new System.EventHandler(this.FrmAtencionCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCobrarFacturas;
        private System.Windows.Forms.RichTextBox rtxtbClienteInfo;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblMensaje;
    }
}