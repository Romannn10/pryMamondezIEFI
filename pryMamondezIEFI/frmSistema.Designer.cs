namespace pryMamondezIEFI
{
    partial class frmSistema
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblNombree = new System.Windows.Forms.Label();
            this.lblApellidoo = new System.Windows.Forms.Label();
            this.lblContactoo = new System.Windows.Forms.Label();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(12, 60);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(79, 22);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Location = new System.Drawing.Point(12, 97);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(82, 22);
            this.lblContacto.TabIndex = 2;
            this.lblContacto.Text = "Contacto";
            // 
            // lblNombree
            // 
            this.lblNombree.AutoSize = true;
            this.lblNombree.BackColor = System.Drawing.Color.Gold;
            this.lblNombree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombree.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombree.ForeColor = System.Drawing.Color.Blue;
            this.lblNombree.Location = new System.Drawing.Point(117, 23);
            this.lblNombree.Name = "lblNombree";
            this.lblNombree.Size = new System.Drawing.Size(69, 24);
            this.lblNombree.TabIndex = 3;
            this.lblNombree.Text = "Roman";
            // 
            // lblApellidoo
            // 
            this.lblApellidoo.AutoSize = true;
            this.lblApellidoo.BackColor = System.Drawing.Color.Gold;
            this.lblApellidoo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApellidoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoo.ForeColor = System.Drawing.Color.Blue;
            this.lblApellidoo.Location = new System.Drawing.Point(117, 62);
            this.lblApellidoo.Name = "lblApellidoo";
            this.lblApellidoo.Size = new System.Drawing.Size(98, 24);
            this.lblApellidoo.TabIndex = 4;
            this.lblApellidoo.Text = "Mamondez";
            // 
            // lblContactoo
            // 
            this.lblContactoo.AutoSize = true;
            this.lblContactoo.BackColor = System.Drawing.Color.Gold;
            this.lblContactoo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContactoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactoo.ForeColor = System.Drawing.Color.Blue;
            this.lblContactoo.Location = new System.Drawing.Point(117, 101);
            this.lblContactoo.Name = "lblContactoo";
            this.lblContactoo.Size = new System.Drawing.Size(283, 24);
            this.lblContactoo.TabIndex = 5;
            this.lblContactoo.Text = "Romanmamondez010@gmail.com";
            // 
            // cmdVolver
            // 
            this.cmdVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVolver.Location = new System.Drawing.Point(330, 140);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(70, 30);
            this.cmdVolver.TabIndex = 6;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // frmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(420, 184);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.lblContactoo);
            this.Controls.Add(this.lblApellidoo);
            this.Controls.Add(this.lblNombree);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmSistema";
            this.Text = "Sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblNombree;
        private System.Windows.Forms.Label lblApellidoo;
        private System.Windows.Forms.Label lblContactoo;
        private System.Windows.Forms.Button cmdVolver;
    }
}