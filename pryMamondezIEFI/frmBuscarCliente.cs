using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using pryMamondezIEFI.Resources;

namespace pryMamondezIEFI
{
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
        }

        private void mrcDatosDeCliente_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LimpiarControles()
        {
            mskDNICliente.Text = "";
            txtNombre.Text = "";
            lstBarrio.SelectedIndex = -1;
            lstActividad.SelectedIndex = -1;
            txtEdad.Text = "";
            txtSaldo.Text = "";
        }

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            clsBarrio Barrio = new clsBarrio();
            Barrio.Listar(lstBarrio);
            clsActividad ActividadD = new clsActividad();
            ActividadD.ListarActividad(lstActividad);
            lstActividad.SelectedIndex = -1;
            lstBarrio.SelectedIndex = -1;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            //Llamo a la clase y al procedimiento BUSCAR
            //traera la informacion que tengo cargadas en las
            //variables de la clase y posteriormente las mostrara
            Int32 DNI = Convert.ToInt32(mskDNICliente.Text);
            clsAgregarCliente Buscar = new clsAgregarCliente();
            Buscar.Buscar(DNI);

            if (Buscar.Dni != DNI)
            {
                MessageBox.Show("El cliente no se encuentra en la base de datos");
            }
            else
            {
                MessageBox.Show("Datos encontrados con exito");
                txtNombre.Text = Buscar.NyA;
                lstBarrio.SelectedValue =Buscar.Barrio;
                txtEdad.Text = Convert.ToString(Buscar.EdadCliente);
                lstActividad.SelectedValue = Buscar.Act;
                txtSaldo.Text = Convert.ToString(Buscar.Monto);
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //=============================================
        private void cmdModificar_Click(object sender, EventArgs e)
        {
            //Llamo a la clase y al procedimiento
            Int32 Cliente = Convert.ToInt32(mskDNICliente.Text);
            clsAgregarCliente Modificar = new clsAgregarCliente();
            //Le digo que llene los campos con los txt
            Modificar.NyA = txtNombre.Text;
            Modificar.Barrio = Convert.ToInt32(lstBarrio.SelectedValue);
            Modificar.Act = Convert.ToInt32(lstActividad.SelectedValue);
            Modificar.Monto = Convert.ToInt32(txtSaldo.Text);
            Modificar.EdadCliente = Convert.ToInt32(txtEdad.Text);
            Modificar.Modificar(Cliente);
            LimpiarControles();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            //Llamo a la clase y al procedimiento ELIMINAR
            //y este eliminara toda la fila seleccionada
            //por el CodigoDeportista
            Int32 DNI = Convert.ToInt32(mskDNICliente.Text);
            clsAgregarCliente Eliminar = new clsAgregarCliente();
            Eliminar.Eliminar(DNI);
            LimpiarControles();
        }
    }
}
