namespace pryMamondezIEFI
{
    partial class frmAgregarCliente
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
            this.mrcCargaDatos = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblNyANuevoCliente = new System.Windows.Forms.Label();
            this.lblLimiteDeCredito = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtNyANuevoCliente = new System.Windows.Forms.TextBox();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.mskLimiteCredito = new System.Windows.Forms.MaskedTextBox();
            this.lstCiudad = new System.Windows.Forms.ComboBox();
            this.cmdAgregarNuevo = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.mrcCargaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcCargaDatos
            // 
            this.mrcCargaDatos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mrcCargaDatos.Controls.Add(this.cmdAgregarNuevo);
            this.mrcCargaDatos.Controls.Add(this.cmdCargar);
            this.mrcCargaDatos.Controls.Add(this.lstCiudad);
            this.mrcCargaDatos.Controls.Add(this.mskLimiteCredito);
            this.mrcCargaDatos.Controls.Add(this.txtLimiteCredito);
            this.mrcCargaDatos.Controls.Add(this.txtNyANuevoCliente);
            this.mrcCargaDatos.Controls.Add(this.lblCiudad);
            this.mrcCargaDatos.Controls.Add(this.lblLimiteDeCredito);
            this.mrcCargaDatos.Controls.Add(this.lblNyANuevoCliente);
            this.mrcCargaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcCargaDatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mrcCargaDatos.Location = new System.Drawing.Point(28, 22);
            this.mrcCargaDatos.Name = "mrcCargaDatos";
            this.mrcCargaDatos.Size = new System.Drawing.Size(452, 272);
            this.mrcCargaDatos.TabIndex = 0;
            this.mrcCargaDatos.TabStop = false;
            this.mrcCargaDatos.Text = "Carga de datos";
            // 
            // lblNyANuevoCliente
            // 
            this.lblNyANuevoCliente.AutoSize = true;
            this.lblNyANuevoCliente.Location = new System.Drawing.Point(28, 59);
            this.lblNyANuevoCliente.Name = "lblNyANuevoCliente";
            this.lblNyANuevoCliente.Size = new System.Drawing.Size(129, 17);
            this.lblNyANuevoCliente.TabIndex = 0;
            this.lblNyANuevoCliente.Text = "Nombre Y Apellido:";
            // 
            // lblLimiteDeCredito
            // 
            this.lblLimiteDeCredito.AutoSize = true;
            this.lblLimiteDeCredito.Location = new System.Drawing.Point(28, 116);
            this.lblLimiteDeCredito.Name = "lblLimiteDeCredito";
            this.lblLimiteDeCredito.Size = new System.Drawing.Size(116, 17);
            this.lblLimiteDeCredito.TabIndex = 1;
            this.lblLimiteDeCredito.Text = "Limite de credito:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(28, 173);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(56, 17);
            this.lblCiudad.TabIndex = 2;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // txtNyANuevoCliente
            // 
            this.txtNyANuevoCliente.Location = new System.Drawing.Point(163, 56);
            this.txtNyANuevoCliente.Name = "txtNyANuevoCliente";
            this.txtNyANuevoCliente.Size = new System.Drawing.Size(276, 23);
            this.txtNyANuevoCliente.TabIndex = 3;
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.Location = new System.Drawing.Point(163, 116);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Size = new System.Drawing.Size(118, 23);
            this.txtLimiteCredito.TabIndex = 4;
            // 
            // mskLimiteCredito
            // 
            this.mskLimiteCredito.Location = new System.Drawing.Point(163, 116);
            this.mskLimiteCredito.Mask = "99999999";
            this.mskLimiteCredito.Name = "mskLimiteCredito";
            this.mskLimiteCredito.Size = new System.Drawing.Size(118, 23);
            this.mskLimiteCredito.TabIndex = 5;
            this.mskLimiteCredito.ValidatingType = typeof(int);
            // 
            // lstCiudad
            // 
            this.lstCiudad.FormattingEnabled = true;
            this.lstCiudad.Location = new System.Drawing.Point(160, 173);
            this.lstCiudad.Name = "lstCiudad";
            this.lstCiudad.Size = new System.Drawing.Size(279, 24);
            this.lstCiudad.TabIndex = 6;
            // 
            // cmdAgregarNuevo
            // 
            this.cmdAgregarNuevo.Location = new System.Drawing.Point(190, 225);
            this.cmdAgregarNuevo.Name = "cmdAgregarNuevo";
            this.cmdAgregarNuevo.Size = new System.Drawing.Size(117, 27);
            this.cmdAgregarNuevo.TabIndex = 1;
            this.cmdAgregarNuevo.Text = "Agregar Nuevo";
            this.cmdAgregarNuevo.UseVisualStyleBackColor = true;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(313, 225);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(117, 27);
            this.cmdCargar.TabIndex = 2;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(511, 317);
            this.Controls.Add(this.mrcCargaDatos);
            this.Name = "frmAgregarCliente";
            this.Text = "Nuevo Cliente";
            this.mrcCargaDatos.ResumeLayout(false);
            this.mrcCargaDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcCargaDatos;
        private System.Windows.Forms.ComboBox lstCiudad;
        private System.Windows.Forms.MaskedTextBox mskLimiteCredito;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.TextBox txtNyANuevoCliente;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblLimiteDeCredito;
        private System.Windows.Forms.Label lblNyANuevoCliente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button cmdAgregarNuevo;
        private System.Windows.Forms.Button cmdCargar;
    }
}