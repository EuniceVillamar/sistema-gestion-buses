using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class FrmMenuBus : Form
    {
        private ControlBus controlBus;
        public FrmMenuBus()
        {
            InitializeComponent();
            controlBus = new ControlBus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistrarBus frmRegistrar = new FrmRegistrarBus(this, controlBus);
            this.Visible = false;
            frmRegistrar.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FrmListarBus frmListar = new FrmListarBus(this, controlBus);
            this.Visible = false;
            frmListar.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmEditarBus frmListar = new FrmEditarBus(this, controlBus);
            this.Visible = false;
            frmListar.ShowDialog();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            controlBus.Conectar();
        }

        private void FrmMenuBus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoDataSet.Buses' table. You can move, or remove it, as needed.
            this.busesTableAdapter.Fill(this.proyectoDataSet.Buses);

        }

        private void btnMenuEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarBus frmEliminar = new FrmEliminarBus(this, controlBus);
            this.Visible = false;
            frmEliminar.ShowDialog();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcercaDe = new FrmAcercaDe(this);
            this.Visible = false;
            frmAcercaDe.ShowDialog();
        }
    }
}
