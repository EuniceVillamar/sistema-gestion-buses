using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmEditarBus : Form
    {
        FrmMenuBus frmMenuBus = null;
        private ControlBus controlBus;

        public FrmEditarBus(FrmMenuBus frmMenuBus, ControlBus controlBus)
        {
            InitializeComponent();
            this.controlBus = controlBus;
            this.frmMenuBus = frmMenuBus;
        }

        private void FrmEditarBus_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenuBus.Visible = true;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string idBus = txtIdBus.Text.Trim();

            if (string.IsNullOrEmpty(idBus))
            {
                MessageBox.Show("Por favor, ingrese un ID de Bus para buscar.", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            controlBus.ObtenerBusIndividual(int.Parse(idBus), txtMatricula, txtMarca, txtModelo, nudCapacidad, txtNoAsientos);
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            string idBus = txtIdBus.Text.Trim();

            if (string.IsNullOrEmpty(idBus))
            {
                MessageBox.Show("Por favor, busque un bus antes de editar.", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string matricula = txtMatricula.Text.Trim();
            string marca = txtMarca.Text.Trim();
            string modelo = txtModelo.Text.Trim();
            decimal capacidad = nudCapacidad.Value;
            int noAsientos;

            if (!int.TryParse(txtNoAsientos.Text, out noAsientos))
            {
                MessageBox.Show("Número de asientos inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            controlBus.EditarBus(int.Parse(idBus), matricula, marca, modelo, capacidad, noAsientos);
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIdBus_TextChanged(object sender, EventArgs e)
        {
        }


        private void txtIdBus_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if (!char.IsDigit(letra) && letra != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (txtIdBus.Text.Length >= 10 && letra != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}