using System;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class FrmEliminarBus : Form
    {
        FrmMenuBus frmMenuBus = null;
        private ControlBus controlBus;
        
        public FrmEliminarBus(FrmMenuBus frmMenuBus, ControlBus controlBus)
        {
            InitializeComponent();
            this.frmMenuBus = frmMenuBus;
            this.controlBus = controlBus;
        }

        private void btnListarBus_Click(object sender, EventArgs e)
        {
            controlBus.LlenarBuses(dgvListarBus, lblTotal);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListarBus.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvListarBus.SelectedRows[0];
                // Aquí puedes acceder a las celdas de la fila seleccionada
                // Por ejemplo, si tienes una columna "IdBus":
                int idBus = Convert.ToInt32(selectedRow.Cells["colIdBus"].Value);
        
                // Lógica para eliminar el bus utilizando el idBus
                controlBus.EliminarBus(idBus);
        
                // Actualizar la lista de buses
                controlBus.LlenarBuses(dgvListarBus, lblTotal);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }

        private void FrmEliminarBus_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenuBus.Visible = true;
        }

        private void dgvListarBus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}