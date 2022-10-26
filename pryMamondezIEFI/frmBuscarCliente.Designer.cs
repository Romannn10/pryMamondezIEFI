namespace pryMamondezIEFI
{
    partial class frmBuscarCliente
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
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.mskCodigoCliente = new System.Windows.Forms.MaskedTextBox();
            this.mrcDatosDeCliente = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblLimiteDeCredito = new System.Windows.Forms.Label();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.mrcDatosDeCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCodigoCliente.Location = new System.Drawing.Point(12, 26);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(91, 13);
            this.lblCodigoCliente.TabIndex = 0;
            this.lblCodigoCliente.Text = "Codigo del cliente";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(125, 56);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(112, 23);
            this.cmdBuscar.TabIndex = 1;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(125, 23);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(112, 20);
            this.txtCodigoCliente.TabIndex = 2;
            // 
            // mskCodigoCliente
            // 
            this.mskCodigoCliente.Location = new System.Drawing.Point(125, 23);
            this.mskCodigoCliente.Mask = "99999";
            this.mskCodigoCliente.Name = "mskCodigoCliente";
            this.mskCodigoCliente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mskCodigoCliente.Size = new System.Drawing.Size(112, 20);
            this.mskCodigoCliente.TabIndex = 3;
            this.mskCodigoCliente.ValidatingType = typeof(int);
            // 
            // mrcDatosDeCliente
            // 
            this.mrcDatosDeCliente.BackColor = System.Drawing.SystemColors.Control;
            this.mrcDatosDeCliente.Controls.Add(this.txtLimiteCredito);
            this.mrcDatosDeCliente.Controls.Add(this.txtDeuda);
            this.mrcDatosDeCliente.Controls.Add(this.txtNombre);
            this.mrcDatosDeCliente.Controls.Add(this.lblLimiteDeCredito);
            this.mrcDatosDeCliente.Controls.Add(this.lblDeuda);
            this.mrcDatosDeCliente.Controls.Add(this.lblNombre);
            this.mrcDatosDeCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mrcDatosDeCliente.Location = new System.Drawing.Point(15, 102);
            this.mrcDatosDeCliente.Name = "mrcDatosDeCliente";
            this.mrcDatosDeCliente.Size = new System.Drawing.Size(236, 180);
            this.mrcDatosDeCliente.TabIndex = 4;
            this.mrcDatosDeCliente.TabStop = false;
            this.mrcDatosDeCliente.Text = "Datos del cliente";
            this.mrcDatosDeCliente.Enter += new System.EventHandler(this.mrcDatosDeCliente_Enter);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(15, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeuda.Location = new System.Drawing.Point(15, 79);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(42, 13);
            this.lblDeuda.TabIndex = 2;
            this.lblDeuda.Text = "Deuda:";
            // 
            // lblLimiteDeCredito
            // 
            this.lblLimiteDeCredito.AutoSize = true;
            this.lblLimiteDeCredito.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLimiteDeCredito.Location = new System.Drawing.Point(15, 123);
            this.lblLimiteDeCredito.Name = "lblLimiteDeCredito";
            this.lblLimiteDeCredito.Size = new System.Drawing.Size(87, 13);
            this.lblLimiteDeCredito.TabIndex = 3;
            this.lblLimiteDeCredito.Text = "Limite de credito:";
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(12, 304);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(67, 31);
            this.cmdEliminar.TabIndex = 5;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(99, 304);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(67, 31);
            this.cmdModificar.TabIndex = 6;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(184, 304);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(67, 31);
            this.cmdGuardar.TabIndex = 7;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(68, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(151, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(110, 77);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.ReadOnly = true;
            this.txtDeuda.Size = new System.Drawing.Size(109, 20);
            this.txtDeuda.TabIndex = 5;
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.Location = new System.Drawing.Point(110, 122);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.ReadOnly = true;
            this.txtLimiteCredito.Size = new System.Drawing.Size(109, 20);
            this.txtLimiteCredito.TabIndex = 6;
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(263, 345);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.mrcDatosDeCliente);
            this.Controls.Add(this.mskCodigoCliente);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.lblCodigoCliente);
            this.Name = "frmBuscarCliente";
            this.Text = "Busqueda de un cliente";
            this.mrcDatosDeCliente.ResumeLayout(false);
            this.mrcDatosDeCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.MaskedTextBox mskCodigoCliente;
        private System.Windows.Forms.GroupBox mrcDatosDeCliente;
        private System.Windows.Forms.Label lblLimiteDeCredito;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.TextBox txtNombre;
    }
}