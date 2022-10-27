namespace pryMamondezIEFI
{
    partial class frmClientesPorBarrio
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
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.dgvListadoBarrio = new System.Windows.Forms.DataGridView();
            this.cmdGenerarReporte = new System.Windows.Forms.Button();
            this.cmdListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoBarrio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.ForeColor = System.Drawing.Color.White;
            this.lblBarrio.Location = new System.Drawing.Point(26, 29);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(50, 17);
            this.lblBarrio.TabIndex = 0;
            this.lblBarrio.Text = "Barrio:";
            // 
            // lstBarrio
            // 
            this.lstBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Location = new System.Drawing.Point(88, 26);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(669, 24);
            this.lstBarrio.TabIndex = 1;
            // 
            // dgvListadoBarrio
            // 
            this.dgvListadoBarrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoBarrio.Location = new System.Drawing.Point(29, 67);
            this.dgvListadoBarrio.Name = "dgvListadoBarrio";
            this.dgvListadoBarrio.Size = new System.Drawing.Size(728, 341);
            this.dgvListadoBarrio.TabIndex = 2;
            // 
            // cmdGenerarReporte
            // 
            this.cmdGenerarReporte.Location = new System.Drawing.Point(529, 415);
            this.cmdGenerarReporte.Name = "cmdGenerarReporte";
            this.cmdGenerarReporte.Size = new System.Drawing.Size(105, 32);
            this.cmdGenerarReporte.TabIndex = 3;
            this.cmdGenerarReporte.Text = "Generar Reporte";
            this.cmdGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(652, 415);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(105, 32);
            this.cmdListar.TabIndex = 4;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            // 
            // frmClientesPorBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.cmdGenerarReporte);
            this.Controls.Add(this.dgvListadoBarrio);
            this.Controls.Add(this.lstBarrio);
            this.Controls.Add(this.lblBarrio);
            this.Name = "frmClientesPorBarrio";
            this.Text = "Listado de clientes de una ciudad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoBarrio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.DataGridView dgvListadoBarrio;
        private System.Windows.Forms.Button cmdGenerarReporte;
        private System.Windows.Forms.Button cmdListar;
    }
}