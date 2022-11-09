using pryMamondezIEFI.Resources;
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
        public frmAgregarCliente()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los datos se cargaron con exito");
            txtDNI.Text = "";
            txtNyANuevoCliente.Text = "";
            txtDireccion.Text = "";
            mskDNI.Text = "";
            mskEdad.Text = "";
            lstActividad.SelectedIndex = -1;
            lstBarrio.SelectedIndex = -1;
            this.Close();
        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            clsBarrio Barrio = new clsBarrio();
            Barrio.Listar(lstBarrio);
            clsActividad ActividadD = new clsActividad();
            ActividadD.ListarActividad(lstActividad);
            lstActividad.SelectedIndex = -1;
            lstBarrio.SelectedIndex = -1;
        }

        private void lstActividad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdAgregarNuevo_Click(object sender, EventArgs e)
        {
            clsAgregarCliente Registro = new clsAgregarCliente(); 
            Registro.Dni = Convert.ToInt32(mskDNI.Text);
            Registro.NyA = txtNyANuevoCliente.Text;
            Registro.Direc = txtDireccion.Text;
            Registro.Barrio = Convert.ToInt32(lstBarrio.SelectedValue);
            Registro.Act = Convert.ToInt32(lstActividad.SelectedValue);
            Registro.Monto = Convert.ToDecimal(txtPagara.Text);
            Registro.EdadCliente = Convert.ToInt32(mskEdad.Text);
            Registro.Agregar();

        }
    }
}
