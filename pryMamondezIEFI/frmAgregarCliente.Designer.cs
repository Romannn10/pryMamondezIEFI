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
            this.txtPagara = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.mskEdad = new System.Windows.Forms.MaskedTextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.mskDNI = new System.Windows.Forms.MaskedTextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.cmdAgregarNuevo = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.txtNyANuevoCliente = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblNyANuevoCliente = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusConexion = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.Label();
            this.mrcCargaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcCargaDatos
            // 
            this.mrcCargaDatos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mrcCargaDatos.Controls.Add(this.txtPagara);
            this.mrcCargaDatos.Controls.Add(this.lblSaldo);
            this.mrcCargaDatos.Controls.Add(this.txtDireccion);
            this.mrcCargaDatos.Controls.Add(this.lblDireccion);
            this.mrcCargaDatos.Controls.Add(this.mskEdad);
            this.mrcCargaDatos.Controls.Add(this.txtEdad);
            this.mrcCargaDatos.Controls.Add(this.lblEdad);
            this.mrcCargaDatos.Controls.Add(this.mskDNI);
            this.mrcCargaDatos.Controls.Add(this.txtDNI);
            this.mrcCargaDatos.Controls.Add(this.lblDNI);
            this.mrcCargaDatos.Controls.Add(this.lstActividad);
            this.mrcCargaDatos.Controls.Add(this.lblActividad);
            this.mrcCargaDatos.Controls.Add(this.cmdAgregarNuevo);
            this.mrcCargaDatos.Controls.Add(this.cmdCargar);
            this.mrcCargaDatos.Controls.Add(this.lstBarrio);
            this.mrcCargaDatos.Controls.Add(this.txtNyANuevoCliente);
            this.mrcCargaDatos.Controls.Add(this.lblBarrio);
            this.mrcCargaDatos.Controls.Add(this.lblNyANuevoCliente);
            this.mrcCargaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcCargaDatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mrcCargaDatos.Location = new System.Drawing.Point(28, 22);
            this.mrcCargaDatos.Name = "mrcCargaDatos";
            this.mrcCargaDatos.Size = new System.Drawing.Size(452, 306);
            this.mrcCargaDatos.TabIndex = 0;
            this.mrcCargaDatos.TabStop = false;
            this.mrcCargaDatos.Text = "Carga de datos";
            // 
            // txtPagara
            // 
            this.txtPagara.Location = new System.Drawing.Point(154, 226);
            this.txtPagara.Name = "txtPagara";
            this.txtPagara.Size = new System.Drawing.Size(118, 23);
            this.txtPagara.TabIndex = 18;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(19, 224);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(58, 17);
            this.lblSaldo.TabIndex = 17;
            this.lblSaldo.Text = "Pagara:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(154, 129);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(276, 23);
            this.txtDireccion.TabIndex = 16;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(19, 126);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(71, 17);
            this.lblDireccion.TabIndex = 15;
            this.lblDireccion.Text = "Direccion:";
            // 
            // mskEdad
            // 
            this.mskEdad.Location = new System.Drawing.Point(154, 192);
            this.mskEdad.Mask = "99999999";
            this.mskEdad.Name = "mskEdad";
            this.mskEdad.Size = new System.Drawing.Size(118, 23);
            this.mskEdad.TabIndex = 14;
            this.mskEdad.ValidatingType = typeof(int);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(154, 192);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(118, 23);
            this.txtEdad.TabIndex = 13;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(19, 190);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(45, 17);
            this.lblEdad.TabIndex = 12;
            this.lblEdad.Text = "Edad:";
            // 
            // mskDNI
            // 
            this.mskDNI.Location = new System.Drawing.Point(154, 56);
            this.mskDNI.Mask = "99999999";
            this.mskDNI.Name = "mskDNI";
            this.mskDNI.Size = new System.Drawing.Size(118, 23);
            this.mskDNI.TabIndex = 11;
            this.mskDNI.ValidatingType = typeof(int);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(154, 56);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(118, 23);
            this.txtDNI.TabIndex = 10;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(19, 57);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(35, 17);
            this.lblDNI.TabIndex = 9;
            this.lblDNI.Text = "DNI:";
            // 
            // lstActividad
            // 
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Location = new System.Drawing.Point(154, 161);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(279, 24);
            this.lstActividad.TabIndex = 8;
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(19, 158);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(69, 17);
            this.lblActividad.TabIndex = 7;
            this.lblActividad.Text = "Actividad:";
            // 
            // cmdAgregarNuevo
            // 
            this.cmdAgregarNuevo.Location = new System.Drawing.Point(197, 265);
            this.cmdAgregarNuevo.Name = "cmdAgregarNuevo";
            this.cmdAgregarNuevo.Size = new System.Drawing.Size(117, 27);
            this.cmdAgregarNuevo.TabIndex = 1;
            this.cmdAgregarNuevo.Text = "Agregar Nuevo";
            this.cmdAgregarNuevo.UseVisualStyleBackColor = true;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(320, 265);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(117, 27);
            this.cmdCargar.TabIndex = 2;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            // 
            // lstBarrio
            // 
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Location = new System.Drawing.Point(154, 94);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(279, 24);
            this.lstBarrio.TabIndex = 6;
            // 
            // txtNyANuevoCliente
            // 
            this.txtNyANuevoCliente.Location = new System.Drawing.Point(154, 22);
            this.txtNyANuevoCliente.Name = "txtNyANuevoCliente";
            this.txtNyANuevoCliente.Size = new System.Drawing.Size(276, 23);
            this.txtNyANuevoCliente.TabIndex = 3;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(19, 94);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(50, 17);
            this.lblBarrio.TabIndex = 2;
            this.lblBarrio.Text = "Barrio:";
            // 
            // lblNyANuevoCliente
            // 
            this.lblNyANuevoCliente.AutoSize = true;
            this.lblNyANuevoCliente.Location = new System.Drawing.Point(19, 25);
            this.lblNyANuevoCliente.Name = "lblNyANuevoCliente";
            this.lblNyANuevoCliente.Size = new System.Drawing.Size(129, 17);
            this.lblNyANuevoCliente.TabIndex = 0;
            this.lblNyANuevoCliente.Text = "Nombre Y Apellido:";
            // 
            // statusConexion
            // 
            this.statusConexion.Location = new System.Drawing.Point(0, 332);
            this.statusConexion.Name = "statusConexion";
            this.statusConexion.Size = new System.Drawing.Size(511, 22);
            this.statusConexion.TabIndex = 3;
            this.statusConexion.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(12, 336);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(10, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "-";
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(511, 354);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.statusConexion);
            this.Controls.Add(this.mrcCargaDatos);
            this.Name = "frmAgregarCliente";
            this.Text = "Agregar Cliente";
            this.mrcCargaDatos.ResumeLayout(false);
            this.mrcCargaDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcCargaDatos;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.TextBox txtNyANuevoCliente;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblNyANuevoCliente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button cmdAgregarNuevo;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.MaskedTextBox mskDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.MaskedTextBox mskEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtPagara;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.StatusStrip statusConexion;
        private System.Windows.Forms.Label lblEstado;
    }
}