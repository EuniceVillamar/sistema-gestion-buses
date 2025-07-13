using System;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class FrmRegistrarBus : Form
    {
        FrmMenuBus frmMenuBus;
        private ControlBus controlBus;

        public FrmRegistrarBus(FrmMenuBus frmMenuBus, ControlBus controlBus)
        {
            InitializeComponent();
            this.frmMenuBus = frmMenuBus;
            this.controlBus = controlBus;
        }

        private void FrmRegistrarBus_Load(object sender, EventArgs e)
        {

        }

        private void FrmRegistrarBus_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenuBus.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if (!char.IsLetterOrDigit(letra) && letra != '-' && letra != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (txtMatricula.Text.Length >= 8 && letra != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if (!char.IsLetter(letra) && letra != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNoAsientos_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if (!char.IsDigit(letra) && letra != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (txtNoAsientos.Text.Length >= 2 && letra != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnRegistrarBus_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text == "" || txtNoAsientos.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string matricula = txtMatricula.Text;
                string marca = cmbMarca.SelectedItem.ToString();
                string modelo = cmbModelo.SelectedItem.ToString();
                decimal capacidad = (decimal)nudCapacidad.Value;
                int noAsientos = int.Parse(txtNoAsientos.Text);
                controlBus.AgregarBus(matricula, marca, modelo, capacidad, noAsientos);
            }
        }

    }
}

