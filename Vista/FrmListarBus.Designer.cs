namespace Vista
{
    partial class FrmListarBus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.dgvListarBus = new System.Windows.Forms.DataGridView();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdBus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoAsientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnListarBus = new System.Windows.Forms.Button();
            this.btnExportarPDF = new System.Windows.Forms.Button();
            this.btnAbrirPDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCapacidadDesde = new System.Windows.Forms.NumericUpDown();
            this.nudCapacidadHasta = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarBus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidadDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidadHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(337, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Lista de Buses";
            // 
            // dgvListarBus
            // 
            this.dgvListarBus.AllowUserToAddRows = false;
            this.dgvListarBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarBus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNro,
            this.colIdBus,
            this.colMatricula,
            this.colMarca,
            this.colModelo,
            this.colCapacidad,
            this.colNoAsientos});
            this.dgvListarBus.Location = new System.Drawing.Point(28, 133);
            this.dgvListarBus.Name = "dgvListarBus";
            this.dgvListarBus.Size = new System.Drawing.Size(744, 256);
            this.dgvListarBus.TabIndex = 15;
            this.dgvListarBus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarBus_CellContentClick);
            // 
            // colNro
            // 
            this.colNro.HeaderText = "Nro";
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            // 
            // colIdBus
            // 
            this.colIdBus.HeaderText = "Identificador";
            this.colIdBus.Name = "colIdBus";
            this.colIdBus.ReadOnly = true;
            // 
            // colMatricula
            // 
            this.colMatricula.HeaderText = "Matricula (Placa)";
            this.colMatricula.Name = "colMatricula";
            this.colMatricula.ReadOnly = true;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            // 
            // colModelo
            // 
            this.colModelo.HeaderText = "Modelo (Carroceria)";
            this.colModelo.Name = "colModelo";
            this.colModelo.ReadOnly = true;
            // 
            // colCapacidad
            // 
            this.colCapacidad.HeaderText = "Capacidad (kg)";
            this.colCapacidad.Name = "colCapacidad";
            this.colCapacidad.ReadOnly = true;
            // 
            // colNoAsientos
            // 
            this.colNoAsientos.HeaderText = "Nro de Asientos";
            this.colNoAsientos.Name = "colNoAsientos";
            this.colNoAsientos.ReadOnly = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(142, 412);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(63, 19);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "_________";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Total de buses:";
            // 
            // btnListarBus
            // 
            this.btnListarBus.Location = new System.Drawing.Point(582, 405);
            this.btnListarBus.Name = "btnListarBus";
            this.btnListarBus.Size = new System.Drawing.Size(190, 35);
            this.btnListarBus.TabIndex = 21;
            this.btnListarBus.Text = "Enlistar";
            this.btnListarBus.UseVisualStyleBackColor = true;
            this.btnListarBus.Click += new System.EventHandler(this.btnListarBus_Click);
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.Location = new System.Drawing.Point(303, 405);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(94, 35);
            this.btnExportarPDF.TabIndex = 22;
            this.btnExportarPDF.Text = "Exportar PDF";
            this.btnExportarPDF.UseVisualStyleBackColor = true;
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click_1);
            // 
            // btnAbrirPDF
            // 
            this.btnAbrirPDF.Location = new System.Drawing.Point(403, 405);
            this.btnAbrirPDF.Name = "btnAbrirPDF";
            this.btnAbrirPDF.Size = new System.Drawing.Size(95, 35);
            this.btnAbrirPDF.TabIndex = 23;
            this.btnAbrirPDF.Text = "Abrir PDF";
            this.btnAbrirPDF.UseVisualStyleBackColor = true;
            this.btnAbrirPDF.Click += new System.EventHandler(this.btnAbrirPDF_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Capacidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Hasta:";
            // 
            // nudCapacidadDesde
            // 
            this.nudCapacidadDesde.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCapacidadDesde.Location = new System.Drawing.Point(112, 106);
            this.nudCapacidadDesde.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudCapacidadDesde.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCapacidadDesde.Name = "nudCapacidadDesde";
            this.nudCapacidadDesde.ReadOnly = true;
            this.nudCapacidadDesde.Size = new System.Drawing.Size(67, 20);
            this.nudCapacidadDesde.TabIndex = 27;
            this.nudCapacidadDesde.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudCapacidadHasta
            // 
            this.nudCapacidadHasta.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCapacidadHasta.Location = new System.Drawing.Point(238, 106);
            this.nudCapacidadHasta.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudCapacidadHasta.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCapacidadHasta.Name = "nudCapacidadHasta";
            this.nudCapacidadHasta.ReadOnly = true;
            this.nudCapacidadHasta.Size = new System.Drawing.Size(67, 20);
            this.nudCapacidadHasta.TabIndex = 29;
            this.nudCapacidadHasta.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // FrmListarBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudCapacidadHasta);
            this.Controls.Add(this.nudCapacidadDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbrirPDF);
            this.Controls.Add(this.btnExportarPDF);
            this.Controls.Add(this.btnListarBus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvListarBus);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListarBus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Buses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmListarBus_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarBus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidadDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidadHasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvListarBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoAsientos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnListarBus;
        private System.Windows.Forms.Button btnExportarPDF;
        private System.Windows.Forms.Button btnAbrirPDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCapacidadDesde;
        private System.Windows.Forms.NumericUpDown nudCapacidadHasta;
    }
}