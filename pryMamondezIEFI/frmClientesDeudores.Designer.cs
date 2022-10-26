namespace pryMamondezIEFI
{
    partial class frmClientesDeudores
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
            this.dgvDeudores = new System.Windows.Forms.DataGridView();
            this.lblPromedioDeDeuda = new System.Windows.Forms.Label();
            this.lblTotalDeDeuda = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.cmdListar = new System.Windows.Forms.Button();
            this.mrcConsultaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudores)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcConsultaDatos
            // 
            this.mrcConsultaDatos.Controls.Add(this.cmdListar);
            this.mrcConsultaDatos.Controls.Add(this.lblPromedio);
            this.mrcConsultaDatos.Controls.Add(this.lblCantidad);
            this.mrcConsultaDatos.Controls.Add(this.lblTotalDeuda);
            this.mrcConsultaDatos.Controls.Add(this.lblCantidadClientes);
            this.mrcConsultaDatos.Controls.Add(this.lblTotalDeDeuda);
            this.mrcConsultaDatos.Controls.Add(this.lblPromedioDeDeuda);
            this.mrcConsultaDatos.Controls.Add(this.dgvDeudores);
            this.mrcConsultaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcConsultaDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.mrcConsultaDatos.Location = new System.Drawing.Point(23, 12);
            this.mrcConsultaDatos.Name = "mrcConsultaDatos";
            this.mrcConsultaDatos.Size = new System.Drawing.Size(756, 463);
            this.mrcConsultaDatos.TabIndex = 0;
            this.mrcConsultaDatos.TabStop = false;
            this.mrcConsultaDatos.Text = "Consulta de datos";
            this.mrcConsultaDatos.Enter += new System.EventHandler(this.mrcConsultaDatos_Enter);
            // 
            // dgvDeudores
            // 
            this.dgvDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudores.Location = new System.Drawing.Point(22, 33);
            this.dgvDeudores.Name = "dgvDeudores";
            this.dgvDeudores.Size = new System.Drawing.Size(709, 285);
            this.dgvDeudores.TabIndex = 1;
            // 
            // lblPromedioDeDeuda
            // 
            this.lblPromedioDeDeuda.AutoSize = true;
            this.lblPromedioDeDeuda.Location = new System.Drawing.Point(456, 393);
            this.lblPromedioDeDeuda.Name = "lblPromedioDeDeuda";
            this.lblPromedioDeDeuda.Size = new System.Drawing.Size(136, 17);
            this.lblPromedioDeDeuda.TabIndex = 2;
            this.lblPromedioDeDeuda.Text = "Promedio de deuda:";
            // 
            // lblTotalDeDeuda
            // 
            this.lblTotalDeDeuda.AutoSize = true;
            this.lblTotalDeDeuda.Location = new System.Drawing.Point(460, 325);
            this.lblTotalDeDeuda.Name = "lblTotalDeDeuda";
            this.lblTotalDeDeuda.Size = new System.Drawing.Size(108, 17);
            this.lblTotalDeDeuda.TabIndex = 3;
            this.lblTotalDeDeuda.Text = "Total de deuda:";
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.Location = new System.Drawing.Point(456, 357);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(140, 17);
            this.lblCantidadClientes.TabIndex = 4;
            this.lblCantidadClientes.Text = "Cantidad de clientes:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.LightGray;
            this.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(610, 359);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(120, 24);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.BackColor = System.Drawing.Color.LightGray;
            this.lblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeuda.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuda.Location = new System.Drawing.Point(610, 325);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(120, 24);
            this.lblTotalDeuda.TabIndex = 7;
            this.lblTotalDeuda.Click += new System.EventHandler(this.lblTotalDeuda_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.BackColor = System.Drawing.Color.LightGray;
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(610, 393);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(120, 24);
            this.lblPromedio.TabIndex = 9;
            // 
            // cmdListar
            // 
            this.cmdListar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdListar.Location = new System.Drawing.Point(649, 429);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(82, 28);
            this.cmdListar.TabIndex = 10;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            // 
            // frmClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.mrcConsultaDatos);
            this.Name = "frmClientesDeudores";
            this.Text = "Listado de Clientes Deudores";
            this.mrcConsultaDatos.ResumeLayout(false);
            this.mrcConsultaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcConsultaDatos;
        private System.Windows.Forms.DataGridView dgvDeudores;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblTotalDeDeuda;
        private System.Windows.Forms.Label lblPromedioDeDeuda;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Button cmdListar;
    }
}