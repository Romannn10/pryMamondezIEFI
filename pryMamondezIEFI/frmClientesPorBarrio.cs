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
    public partial class frmClientesPorBarrio : Form
    {
        public frmClientesPorBarrio()
        {
            InitializeComponent();
        }

        private void frmClientesPorBarrio_Load(object sender, EventArgs e)
        {
            clsBarrio Barrio = new clsBarrio();
            Barrio.Listar(lstBarrio);
            lstBarrio.SelectedIndex = -1;
        }

        private void lstBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            Int32 CodigoBarrio = Convert.ToInt32(lstBarrio.SelectedValue);
            ClsClientes objListadoBarrios = new ClsClientes();
            objListadoBarrios.ListarPorBarrio(dgvListadoBarrio, CodigoBarrio);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
