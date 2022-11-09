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

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {

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
                clsBarrio Barrio = new clsBarrio();
                txtBarrio.Text = Barrio.Buscar(Buscar.Barrio);
                txtEdad.Text = Convert.ToString(Buscar.EdadCliente);
                clsActividad Actividades = new clsActividad();
                txtActividad.Text = Actividades.Buscar(Buscar.Act);
                txtSaldo.Text = Convert.ToString(Buscar.Monto);
            }
        }
    }
}
