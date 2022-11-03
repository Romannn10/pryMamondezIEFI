using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMamondezIEFI
{
    public partial class frmAgregarCliente : Form
    {
        private void CheckButton()
        {
            if (txtNyANuevoCliente.Text != "" && txtDireccion.Text != "" && txtDNI.Text != "" && txtEdad.Text != "" && txtPagara.Text != "")
            {
                cmdAgregarNuevo.Enabled = false;
            }
            else
            {
                cmdAgregarNuevo.Enabled = true;
            }
        }
        public frmAgregarCliente()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAgregarNuevo_Click(object sender, EventArgs e)
        {
            ClsClientes Agregar = new ClsClientes();
            Agregar.NombreYApellido = txtNyANuevoCliente.Text;
            Agregar.DNI = Convert.ToInt32(mskDNI.Text);
            Agregar.Barrio = lstBarrio.Text;
            Agregar.Direccion = txtDireccion.Text;
            Agregar.Actividad = Convert.ToString(lstActividad.SelectedItem);
            Agregar.Edad = Convert.ToInt32(mskEdad.Text);
            Agregar.Monto = txtPagara.Text;
            Agregar.Agregar();
        }

        private void txtNyANuevoCliente_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void mskDNI_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            CheckButton();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void mskEdad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            CheckButton();
        }

        private void txtPagara_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
