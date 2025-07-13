using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class FrmListarBus : Form
    {
        FrmMenuBus frmMenuBus = null;
        private ControlBus controlBus;

        public FrmListarBus(FrmMenuBus frmMenuBus, ControlBus controlBus)
        {
            InitializeComponent();
            this.frmMenuBus = frmMenuBus;
            this.controlBus = controlBus;
        }

        private void FrmListarBus_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenuBus.Visible = true;
        }

        private void dgvListarBus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListarBus_Click(object sender, System.EventArgs e)
        {

            controlBus.LlenarBuses(dgvListarBus, lblTotal, nudCapacidadDesde, nudCapacidadHasta);
        }

        private void lblTotal_Click(object sender, System.EventArgs e)
        {

        }

        private void btnExportarPDF_Click_1(object sender, System.EventArgs e)
        {
            controlBus.GenerarPDF(nudCapacidadDesde, nudCapacidadHasta);
        }

        private void btnAbrirPDF_Click_1(object sender, System.EventArgs e)
        {
            controlBus.AbrirPDF();
        }
    }
}
