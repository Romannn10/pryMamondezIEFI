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
            this.mrcConsultaDatos = new System.Windows.Forms.GroupBox();
            this.cmdListar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.dgvDeudores = new System.Windows.Forms.DataGridView();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblMontoPromedio = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.mrcConsultaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudores)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcConsultaDatos
            // 
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
            // cmdListar
            // 
            this.cmdListar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdListar.Location = new System.Drawing.Point(649, 437);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(82, 28);
            this.cmdListar.TabIndex = 10;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.LightGray;
            this.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudores.Location = new System.Drawing.Point(22, 33);
            this.dgvDeudores.Name = "dgvDeudores";
            this.dgvDeudores.Size = new System.Drawing.Size(709, 285);
            this.dgvDeudores.TabIndex = 1;
            // 
            // lblMonto
            // 
            this.lblMonto.BackColor = System.Drawing.Color.LightGray;
            this.lblMonto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonto.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // lblMontoPromedio
            // 
            this.lblMontoPromedio.BackColor = System.Drawing.Color.LightGray;
            this.lblMontoPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMontoPromedio.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMontoPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // frmCantidadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.mrcConsultaDatos);
            this.Name = "frmCantidadClientes";
            this.Text = "Lista Cantidad de Clientes";
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
    }
}