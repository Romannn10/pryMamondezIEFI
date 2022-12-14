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
            lblCantidad.Text = objCantidadClientes.CantClientes.ToString();
            lblMonto.Text = objCantidadClientes.TotSaldos.ToString();
            lblMontoPromedio.Text = objCantidadClientes.PromSaldos.ToString();
            lblMontoo.Text = objCantidadClientes.MontoMayor.ToString();
            lblNombre.Text = objCantidadClientes.varNombreMontoMayor;
        }

        private void dgvDeudores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGenerarReporte_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            prtDocumento.Print();
            MessageBox.Show("Reporte impreso exitosamente");
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ClsClientes Imprimir = new ClsClientes();
            Imprimir.GenerarReporte(e);
        }
    }
}
