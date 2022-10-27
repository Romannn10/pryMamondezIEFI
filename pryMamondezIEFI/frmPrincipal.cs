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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void msMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCliente objVentanaAgregarCliente = new frmAgregarCliente();
            objVentanaAgregarCliente.ShowDialog();
        }

        private void buscarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarCliente objVentanaBuscarCliente = new frmBuscarCliente();
            objVentanaBuscarCliente.ShowDialog();
        }

        private void listadoDeClientesDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCantidadClientes objVentanaCantidadClientes = new frmCantidadClientes();
            objVentanaCantidadClientes.ShowDialog();
        }

        private void listadoDeClientesDeUnaCiudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientesPorBarrio objClientesBarrio = new frmClientesPorBarrio();
            objClientesBarrio.ShowDialog();
        }

        private void consultaDeUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistema objSistema = new frmSistema();   
            objSistema.ShowDialog();
        }
    }
}
