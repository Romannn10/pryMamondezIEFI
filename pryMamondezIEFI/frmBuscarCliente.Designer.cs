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
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
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
            this.txtNombre.Location = new System.Drawing.Point(100, 121);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(99, 259);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(151, 20);
            this.txtSaldo.TabIndex = 15;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(100, 225);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(151, 20);
            this.txtEdad.TabIndex = 14;
            // 
            // lstBarrio
            // 
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Location = new System.Drawing.Point(100, 190);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(151, 21);
            this.lstBarrio.TabIndex = 17;
            // 
            // lstActividad
            // 
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Location = new System.Drawing.Point(100, 155);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(151, 21);
            this.lstActividad.TabIndex = 18;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombre.Location = new System.Drawing.Point(9, 121);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 13);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre y Apellido";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblActividad.Location = new System.Drawing.Point(9, 154);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(51, 13);
            this.lblActividad.TabIndex = 20;
            this.lblActividad.Text = "Actividad";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBarrio.Location = new System.Drawing.Point(9, 190);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(34, 13);
            this.lblBarrio.TabIndex = 21;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEdad.Location = new System.Drawing.Point(9, 226);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 22;
            this.lblEdad.Text = "Edad";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSaldo.Location = new System.Drawing.Point(9, 262);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 23;
            this.lblSaldo.Text = "Saldo";
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(263, 382);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lstActividad);
            this.Controls.Add(this.lstBarrio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.mskDNICliente);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.lblDNICliente);
            this.Name = "frmBuscarCliente";
            this.Text = "Busqueda de un cliente";
            this.Load += new System.EventHandler(this.frmBuscarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.MaskedTextBox mskDNICliente;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblSaldo;
    }
}