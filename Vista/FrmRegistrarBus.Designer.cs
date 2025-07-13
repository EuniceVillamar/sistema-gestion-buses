namespace Vista
{
    partial class FrmRegistrarBus
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.txtNoAsientos = new System.Windows.Forms.TextBox();
            this.btnRegistrarBus = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matricula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modelo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Capacidad (Kg):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Número de Asientos:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(412, 125);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(121, 20);
            this.txtMatricula.TabIndex = 7;
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            // 
            // cmbModelo
            // 
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Items.AddRange(new object[] {
            "Marcopolo",
            "Irizar",
            "Ayats",
            "Neobus",
            "Beulas"});
            this.cmbModelo.Location = new System.Drawing.Point(411, 183);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(121, 21);
            this.cmbModelo.TabIndex = 9;
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Location = new System.Drawing.Point(412, 217);
            this.nudCapacidad.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudCapacidad.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.ReadOnly = true;
            this.nudCapacidad.Size = new System.Drawing.Size(120, 20);
            this.nudCapacidad.TabIndex = 1000;
            this.nudCapacidad.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // txtNoAsientos
            // 
            this.txtNoAsientos.Location = new System.Drawing.Point(411, 251);
            this.txtNoAsientos.Name = "txtNoAsientos";
            this.txtNoAsientos.Size = new System.Drawing.Size(121, 20);
            this.txtNoAsientos.TabIndex = 11;
            this.txtNoAsientos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoAsientos_KeyPress);
            // 
            // btnRegistrarBus
            // 
            this.btnRegistrarBus.Location = new System.Drawing.Point(308, 293);
            this.btnRegistrarBus.Name = "btnRegistrarBus";
            this.btnRegistrarBus.Size = new System.Drawing.Size(200, 50);
            this.btnRegistrarBus.TabIndex = 12;
            this.btnRegistrarBus.Text = "Registrar";
            this.btnRegistrarBus.UseVisualStyleBackColor = true;
            this.btnRegistrarBus.Click += new System.EventHandler(this.btnRegistrarBus_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(242, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(339, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ingrese los datos del bus a registrar:";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Mercedes-Benz",
            "Volvo",
            "Scania",
            "MAN",
            "Yutong"});
            this.cmbMarca.Location = new System.Drawing.Point(412, 151);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca.TabIndex = 14;
            // 
            // FrmRegistrarBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRegistrarBus);
            this.Controls.Add(this.txtNoAsientos);
            this.Controls.Add(this.nudCapacidad);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistrarBus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Bus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRegistrarBus_FormClosed);
            this.Load += new System.EventHandler(this.FrmRegistrarBus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.TextBox txtNoAsientos;
        private System.Windows.Forms.Button btnRegistrarBus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMarca;
    }
}