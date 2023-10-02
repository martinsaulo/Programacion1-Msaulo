namespace Front
{
    partial class Pantalla_Cuentas
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
            dataGridView1 = new DataGridView();
            btnTransferencia = new Button();
            btnVolver = new Button();
            comboBoxTitular = new ComboBox();
            label1 = new Label();
            comboBoxTipo = new ComboBox();
            label3 = new Label();
            btnAgregar = new Button();
            btnDeposito = new Button();
            btnExtraccion = new Button();
            numericUpDown1 = new NumericUpDown();
            NroCuenta = new DataGridViewTextBoxColumn();
            Saldo = new DataGridViewTextBoxColumn();
            NombreTitular = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NroCuenta, Saldo, NombreTitular, Tipo });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(494, 426);
            dataGridView1.TabIndex = 0;
            // 
            // btnTransferencia
            // 
            btnTransferencia.Location = new Point(512, 193);
            btnTransferencia.Name = "btnTransferencia";
            btnTransferencia.Size = new Size(199, 23);
            btnTransferencia.TabIndex = 1;
            btnTransferencia.Text = "Realizar Transferencia";
            btnTransferencia.UseVisualStyleBackColor = true;
            btnTransferencia.Click += btnTransferencia_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(611, 415);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(101, 23);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // comboBoxTitular
            // 
            comboBoxTitular.FormattingEnabled = true;
            comboBoxTitular.Location = new Point(561, 9);
            comboBoxTitular.Name = "comboBoxTitular";
            comboBoxTitular.Size = new Size(150, 23);
            comboBoxTitular.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(512, 12);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "Titular:";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Cuenta Ahorro", "Cuenta Corriente" });
            comboBoxTipo.Location = new Point(561, 53);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(150, 23);
            comboBoxTipo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(512, 53);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 8;
            label3.Text = "Tipo:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(610, 92);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(101, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnDeposito
            // 
            btnDeposito.Location = new Point(512, 323);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(199, 23);
            btnDeposito.TabIndex = 10;
            btnDeposito.Text = "Realizar Deposito";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // btnExtraccion
            // 
            btnExtraccion.Location = new Point(512, 352);
            btnExtraccion.Name = "btnExtraccion";
            btnExtraccion.Size = new Size(199, 23);
            btnExtraccion.TabIndex = 11;
            btnExtraccion.Text = "Realizar Extracción";
            btnExtraccion.UseVisualStyleBackColor = true;
            btnExtraccion.Click += btnExtraccion_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(512, 294);
            numericUpDown1.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(199, 23);
            numericUpDown1.TabIndex = 12;
            // 
            // NroCuenta
            // 
            NroCuenta.DataPropertyName = "NroCuenta";
            NroCuenta.HeaderText = "NroCuenta";
            NroCuenta.Name = "NroCuenta";
            NroCuenta.ReadOnly = true;
            // 
            // Saldo
            // 
            Saldo.DataPropertyName = "Saldo";
            Saldo.HeaderText = "Saldo";
            Saldo.Name = "Saldo";
            Saldo.ReadOnly = true;
            // 
            // NombreTitular
            // 
            NombreTitular.DataPropertyName = "NombreTitular";
            NombreTitular.HeaderText = "Nombre Titular";
            NombreTitular.Name = "NombreTitular";
            NombreTitular.ReadOnly = true;
            NombreTitular.Width = 150;
            // 
            // Tipo
            // 
            Tipo.DataPropertyName = "Tipo";
            Tipo.HeaderText = "Tipo Cuenta";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // Pantalla_Cuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(btnExtraccion);
            Controls.Add(btnDeposito);
            Controls.Add(btnAgregar);
            Controls.Add(label3);
            Controls.Add(comboBoxTipo);
            Controls.Add(label1);
            Controls.Add(comboBoxTitular);
            Controls.Add(btnVolver);
            Controls.Add(btnTransferencia);
            Controls.Add(dataGridView1);
            Name = "Pantalla_Cuentas";
            Text = "Cuentas";
            Load += Pantalla_Cuentas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnTransferencia;
        private Button btnVolver;
        private ComboBox comboBoxTitular;
        private Label label1;
        private ComboBox comboBoxTipo;
        private Label label3;
        private Button btnAgregar;
        private Button btnDeposito;
        private Button btnExtraccion;
        private NumericUpDown numericUpDown1;
        private DataGridViewTextBoxColumn NroCuenta;
        private DataGridViewTextBoxColumn Saldo;
        private DataGridViewTextBoxColumn NombreTitular;
        private DataGridViewTextBoxColumn Tipo;
    }
}