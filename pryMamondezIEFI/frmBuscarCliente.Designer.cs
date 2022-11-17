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
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.mskDNICliente = new System.Windows.Forms.MaskedTextBox();
            this.mrcDatosDeCliente = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mrcDatosDeCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDNICliente.Location = new System.Drawing.Point(12, 26);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(80, 13);
            this.lblDNICliente.TabIndex = 0;
            this.lblDNICliente.Text = "DNI del cliente:";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(130, 56);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(112, 23);
            this.cmdBuscar.TabIndex = 1;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(125, 23);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(112, 20);
            this.txtCodigoCliente.TabIndex = 2;
            // 
            // mskDNICliente
            // 
            this.mskDNICliente.Location = new System.Drawing.Point(125, 23);
            this.mskDNICliente.Mask = "99999999";
            this.mskDNICliente.Name = "mskDNICliente";
            this.mskDNICliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskDNICliente.Size = new System.Drawing.Size(112, 20);
            this.mskDNICliente.TabIndex = 3;
            this.mskDNICliente.ValidatingType = typeof(int);
            // 
            // mrcDatosDeCliente
            // 
            this.mrcDatosDeCliente.BackColor = System.Drawing.SystemColors.Control;
            this.mrcDatosDeCliente.Controls.Add(this.txtNombre);
            this.mrcDatosDeCliente.Controls.Add(this.txtSaldo);
            this.mrcDatosDeCliente.Controls.Add(this.lblSaldo);
            this.mrcDatosDeCliente.Controls.Add(this.txtEdad);
            this.mrcDatosDeCliente.Controls.Add(this.lblEdad);
            this.mrcDatosDeCliente.Controls.Add(this.txtBarrio);
            this.mrcDatosDeCliente.Controls.Add(this.txtActividad);
            this.mrcDatosDeCliente.Controls.Add(this.lblBarrio);
            this.mrcDatosDeCliente.Controls.Add(this.lblActividad);
            this.mrcDatosDeCliente.Controls.Add(this.lblNombre);
            this.mrcDatosDeCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mrcDatosDeCliente.Location = new System.Drawing.Point(15, 102);
            this.mrcDatosDeCliente.Name = "mrcDatosDeCliente";
            this.mrcDatosDeCliente.Size = new System.Drawing.Size(236, 206);
            this.mrcDatosDeCliente.TabIndex = 4;
            this.mrcDatosDeCliente.TabStop = false;
            this.mrcDatosDeCliente.Text = "Datos del cliente";
            this.mrcDatosDeCliente.Enter += new System.EventHandler(this.mrcDatosDeCliente_Enter);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(66, 170);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(151, 20);
            this.txtSaldo.TabIndex = 10;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSaldo.Location = new System.Drawing.Point(6, 171);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 9;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(66, 136);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(151, 20);
            this.txtEdad.TabIndex = 8;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEdad.Location = new System.Drawing.Point(6, 137);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 7;
            this.lblEdad.Text = "Edad:";
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(66, 102);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(151, 20);
            this.txtBarrio.TabIndex = 6;
            // 
            // txtActividad
            // 
            this.txtActividad.Location = new System.Drawing.Point(66, 68);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.ReadOnly = true;
            this.txtActividad.Size = new System.Drawing.Size(151, 20);
            this.txtActividad.TabIndex = 5;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBarrio.Location = new System.Drawing.Point(6, 103);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(37, 13);
            this.lblBarrio.TabIndex = 3;
            this.lblBarrio.Text = "Barrio:";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblActividad.Location = new System.Drawing.Point(6, 69);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(54, 13);
            this.lblActividad.TabIndex = 2;
            this.lblActividad.Text = "Actividad:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(6, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(12, 329);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(67, 31);
            this.cmdEliminar.TabIndex = 5;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(99, 329);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(67, 31);
            this.cmdModificar.TabIndex = 6;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(184, 329);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(67, 31);
            this.cmdGuardar.TabIndex = 7;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(12, 56);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(112, 23);
            this.cmdSalir.TabIndex = 8;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(66, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(263, 382);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.mrcDatosDeCliente);
            this.Controls.Add(this.mskDNICliente);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.lblDNICliente);
            this.Name = "frmBuscarCliente";
            this.Text = "Busqueda de un cliente";
            this.Load += new System.EventHandler(this.frmBuscarCliente_Load);
            this.mrcDatosDeCliente.ResumeLayout(false);
            this.mrcDatosDeCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.MaskedTextBox mskDNICliente;
        private System.Windows.Forms.GroupBox mrcDatosDeCliente;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.TextBox txtNombre;
    }
}