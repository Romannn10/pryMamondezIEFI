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
    public partial class frmCantidadClientes : Form
    {
        public frmCantidadClientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalDeuda_Click(object sender, EventArgs e)
        {

        }

        private void mrcConsultaDatos_Enter(object sender, EventArgs e)
        {

        }

        private void frmCantidadClientes_Load(object sender, EventArgs e)
        {

        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            ClsClientes objCantidadClientes = new ClsClientes();
            objCantidadClientes.Listar(dgvDeudores);
        }
    }
}
