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
    public partial class FrmAcercaDe : Form
    {
        FrmMenuBus frmMenuBus = null;

        private DataGridView dgvProgramadores;
        private Label lblTitulo;
        private Label lblFilas;
        private Button btnGenerarProgramadores;
        private NumericUpDown nudFilas;

        ControlProgramadores programadores = new ControlProgramadores();

        public FrmAcercaDe(FrmMenuBus frmMenuBus)
        {
            this.frmMenuBus = frmMenuBus;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(800, 500);
            this.FormClosed += FrmAcercaDe_FormClosed_1;
            GenerarForm();

            //InitializeComponent();
        }

        private void GenerarForm()
        {
            lblTitulo = new Label();
            lblTitulo.Text = "Desarrolladores del Sistema";
            lblTitulo.Font = new Font("Arial", 14, FontStyle.Bold);
            lblTitulo.Location = new Point(10, 10);
            lblTitulo.Size = new Size(780, 30);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            lblFilas = new Label();
            lblFilas.Text = "Número de programadores:";
            lblFilas.Location = new Point(10, 50);
            lblFilas.Size = new Size(200, 25);

            nudFilas = new NumericUpDown();
            nudFilas.Minimum = 1;
            nudFilas.Maximum = 5;
            nudFilas.Value = 1;
            nudFilas.Location = new Point(220, 50);
            nudFilas.Size = new Size(50, 25);

            btnGenerarProgramadores = new Button();
            btnGenerarProgramadores.Text = "Generar Programadores";
            btnGenerarProgramadores.Location = new Point(290, 50);
            btnGenerarProgramadores.Size = new Size(180, 30);
            btnGenerarProgramadores.Click += BtnGenerar_Click;

            dgvProgramadores = new DataGridView();
            dgvProgramadores.Location = new Point(10, 100);
            dgvProgramadores.Size = new Size(760, 350);
            dgvProgramadores.AllowUserToAddRows = false;
            dgvProgramadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvProgramadores.Columns.Add("NroProgramadores", "Nro");
            dgvProgramadores.Columns.Add("nombreSistema", "Nombre del Sistema");
            dgvProgramadores.Columns.Add("nombreIntegrante", "Programador");
            dgvProgramadores.Columns.Add("correoIntegrante", "Correo");
            dgvProgramadores.Columns.Add("celularIntegrante", "Celular");

            DataGridViewImageColumn fotoColumn = new DataGridViewImageColumn();
            fotoColumn.Name = "fotoLink";
            fotoColumn.HeaderText = "Foto";
            fotoColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvProgramadores.Columns.Add(fotoColumn);

            dgvProgramadores.RowTemplate.Height = 100;

            Controls.Add(lblTitulo);
            Controls.Add(lblFilas);
            Controls.Add(nudFilas);
            Controls.Add(btnGenerarProgramadores);
            Controls.Add(dgvProgramadores);
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            int filas = (int)nudFilas.Value;
            programadores.LlenarProgramadores(filas, dgvProgramadores);
        }

        private void FrmAcercaDe_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            frmMenuBus.Visible = true;
        }
    }
}