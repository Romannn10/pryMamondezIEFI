namespace pryMamondezIEFI
{
    partial class frmCantidadClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mrcConsultaDatos = new System.Windows.Forms.GroupBox();
            this.cmdGenerarReporte = new System.Windows.Forms.Button();
            this.lblM = new System.Windows.Forms.Label();
            this.lblMontoo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.lblMontoPromedio = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.cmdListar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.dgvDeudores = new System.Windows.Forms.DataGridView();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NyA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            this.mrcConsultaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudores)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcConsultaDatos
            // 
            this.mrcConsultaDatos.Controls.Add(this.cmdGenerarReporte);
            this.mrcConsultaDatos.Controls.Add(this.lblM);
            this.mrcConsultaDatos.Controls.Add(this.lblMontoo);
            this.mrcConsultaDatos.Controls.Add(this.lblNombre);
            this.mrcConsultaDatos.Controls.Add(this.lblMayor);
            this.mrcConsultaDatos.Controls.Add(this.cmdSalir);
            this.mrcConsultaDatos.Controls.Add(this.lblMontoPromedio);
            this.mrcConsultaDatos.Controls.Add(this.lblPromedio);
            this.mrcConsultaDatos.Controls.Add(this.lblMonto);
            this.mrcConsultaDatos.Controls.Add(this.lblMontoTotal);
            this.mrcConsultaDatos.Controls.Add(this.cmdListar);
            this.mrcConsultaDatos.Controls.Add(this.lblCantidad);
            this.mrcConsultaDatos.Controls.Add(this.lblCantidadClientes);
            this.mrcConsultaDatos.Controls.Add(this.dgvDeudores);
            this.mrcConsultaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcConsultaDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.mrcConsultaDatos.Location = new System.Drawing.Point(23, 12);
            this.mrcConsultaDatos.Name = "mrcConsultaDatos";
            this.mrcConsultaDatos.Size = new System.Drawing.Size(756, 471);
            this.mrcConsultaDatos.TabIndex = 0;
            this.mrcConsultaDatos.TabStop = false;
            this.mrcConsultaDatos.Text = "Consulta de datos";
            this.mrcConsultaDatos.Enter += new System.EventHandler(this.mrcConsultaDatos_Enter);
            // 
            // cmdGenerarReporte
            // 
            this.cmdGenerarReporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdGenerarReporte.Location = new System.Drawing.Point(396, 437);
            this.cmdGenerarReporte.Name = "cmdGenerarReporte";
            this.cmdGenerarReporte.Size = new System.Drawing.Size(132, 28);
            this.cmdGenerarReporte.TabIndex = 20;
            this.cmdGenerarReporte.Text = "Generar Reporte";
            this.cmdGenerarReporte.UseVisualStyleBackColor = true;
            this.cmdGenerarReporte.Click += new System.EventHandler(this.cmdGenerarReporte_Click);
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(30, 385);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(103, 17);
            this.lblM.TabIndex = 19;
            this.lblM.Text = "monto pagado:";
            // 
            // lblMontoo
            // 
            this.lblMontoo.BackColor = System.Drawing.Color.LightGray;
            this.lblMontoo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMontoo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMontoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMontoo.Location = new System.Drawing.Point(160, 394);
            this.lblMontoo.Name = "lblMontoo";
            this.lblMontoo.Size = new System.Drawing.Size(139, 24);
            this.lblMontoo.TabIndex = 18;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.LightGray;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(160, 360);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(139, 24);
            this.lblNombre.TabIndex = 17;
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Location = new System.Drawing.Point(30, 368);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(121, 17);
            this.lblMayor.TabIndex = 16;
            this.lblMayor.Text = "Cliente con mayor";
            // 
            // cmdSalir
            // 
            this.cmdSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdSalir.Location = new System.Drawing.Point(544, 437);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(82, 28);
            this.cmdSalir.TabIndex = 15;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // lblMontoPromedio
            // 
            this.lblMontoPromedio.BackColor = System.Drawing.Color.LightGray;
            this.lblMontoPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMontoPromedio.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMontoPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoPromedio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMontoPromedio.Location = new System.Drawing.Point(611, 402);
            this.lblMontoPromedio.Name = "lblMontoPromedio";
            this.lblMontoPromedio.Size = new System.Drawing.Size(120, 24);
            this.lblMontoPromedio.TabIndex = 14;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(455, 402);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(111, 17);
            this.lblPromedio.TabIndex = 13;
            this.lblPromedio.Text = "Monto Promedio";
            // 
            // lblMonto
            // 
            this.lblMonto.BackColor = System.Drawing.Color.LightGray;
            this.lblMonto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonto.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMonto.Location = new System.Drawing.Point(611, 368);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(120, 24);
            this.lblMonto.TabIndex = 12;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(455, 368);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(158, 17);
            this.lblMontoTotal.TabIndex = 11;
            this.lblMontoTotal.Text = "Total Dinero Facturado:";
            // 
            // cmdListar
            // 
            this.cmdListar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdListar.Location = new System.Drawing.Point(649, 437);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(82, 28);
            this.cmdListar.TabIndex = 10;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.LightGray;
            this.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCantidad.Location = new System.Drawing.Point(611, 334);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(120, 24);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.Location = new System.Drawing.Point(455, 334);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(140, 17);
            this.lblCantidadClientes.TabIndex = 4;
            this.lblCantidadClientes.Text = "Cantidad de clientes:";
            // 
            // dgvDeudores
            // 
            this.dgvDeudores.AllowUserToAddRows = false;
            this.dgvDeudores.AllowUserToDeleteRows = false;
            this.dgvDeudores.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.NyA,
            this.Direccion,
            this.CodigoB,
            this.Actividad,
            this.Saldo,
            this.Edad});
            this.dgvDeudores.GridColor = System.Drawing.Color.Black;
            this.dgvDeudores.Location = new System.Drawing.Point(22, 22);
            this.dgvDeudores.Name = "dgvDeudores";
            this.dgvDeudores.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDeudores.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeudores.Size = new System.Drawing.Size(709, 285);
            this.dgvDeudores.TabIndex = 1;
            this.dgvDeudores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeudores_CellContentClick);
            // 
            // Dni
            // 
            this.Dni.HeaderText = "DNI";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            // 
            // NyA
            // 
            this.NyA.HeaderText = "Nombre y Apellido";
            this.NyA.Name = "NyA";
            this.NyA.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // CodigoB
            // 
            this.CodigoB.HeaderText = "Barrio";
            this.CodigoB.Name = "CodigoB";
            this.CodigoB.ReadOnly = true;
            // 
            // Actividad
            // 
            this.Actividad.HeaderText = "Actividad";
            this.Actividad.Name = "Actividad";
            this.Actividad.ReadOnly = true;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // prtDocumento
            // 
            this.prtDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumento_PrintPage);
            // 
            // frmCantidadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.mrcConsultaDatos);
            this.Name = "frmCantidadClientes";
            this.Text = "Lista Cantidad de Clientes";
            this.Load += new System.EventHandler(this.frmCantidadClientes_Load);
            this.mrcConsultaDatos.ResumeLayout(false);
            this.mrcConsultaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcConsultaDatos;
        private System.Windows.Forms.DataGridView dgvDeudores;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Label lblMontoPromedio;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn NyA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblMontoo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Button cmdGenerarReporte;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Drawing.Printing.PrintDocument prtDocumento;
    }
}