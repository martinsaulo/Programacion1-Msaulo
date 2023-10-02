namespace Front
{
    partial class Pantalla_Tarjeta
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
            NroTarjeta = new DataGridViewTextBoxColumn();
            LimiteCredito = new DataGridViewTextBoxColumn();
            Saldo = new DataGridViewTextBoxColumn();
            Deuda = new DataGridViewTextBoxColumn();
            NombreTitular = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            label1 = new Label();
            comboBoxTitular = new ComboBox();
            label2 = new Label();
            numCredito = new NumericUpDown();
            btnEmitir = new Button();
            btnResumen = new Button();
            btnEstado = new Button();
            comboBoxEstado = new ComboBox();
            label3 = new Label();
            numSaldo = new NumericUpDown();
            numPago = new NumericUpDown();
            btnPagar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCredito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSaldo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPago).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NroTarjeta, LimiteCredito, Saldo, Deuda, NombreTitular, Estado });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(594, 426);
            dataGridView1.TabIndex = 0;
            // 
            // NroTarjeta
            // 
            NroTarjeta.DataPropertyName = "NroTarjeta";
            NroTarjeta.HeaderText = "Nro. Tarjeta";
            NroTarjeta.Name = "NroTarjeta";
            // 
            // LimiteCredito
            // 
            LimiteCredito.DataPropertyName = "LimiteCredito";
            LimiteCredito.HeaderText = "Limite Credito";
            LimiteCredito.Name = "LimiteCredito";
            LimiteCredito.Width = 150;
            // 
            // Saldo
            // 
            Saldo.DataPropertyName = "Saldo";
            Saldo.HeaderText = "Saldo";
            Saldo.Name = "Saldo";
            // 
            // Deuda
            // 
            Deuda.DataPropertyName = "MontoDeuda";
            Deuda.HeaderText = "Deuda";
            Deuda.Name = "Deuda";
            // 
            // NombreTitular
            // 
            NombreTitular.DataPropertyName = "NombreTitular";
            NombreTitular.HeaderText = "Titular";
            NombreTitular.Name = "NombreTitular";
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(713, 415);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(612, 12);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "Titular:";
            // 
            // comboBoxTitular
            // 
            comboBoxTitular.FormattingEnabled = true;
            comboBoxTitular.Location = new Point(612, 30);
            comboBoxTitular.Name = "comboBoxTitular";
            comboBoxTitular.Size = new Size(176, 23);
            comboBoxTitular.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(612, 56);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 4;
            label2.Text = "Limite Credito:";
            // 
            // numCredito
            // 
            numCredito.Location = new Point(612, 74);
            numCredito.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numCredito.Name = "numCredito";
            numCredito.Size = new Size(176, 23);
            numCredito.TabIndex = 5;
            // 
            // btnEmitir
            // 
            btnEmitir.Location = new Point(612, 147);
            btnEmitir.Name = "btnEmitir";
            btnEmitir.Size = new Size(176, 23);
            btnEmitir.TabIndex = 6;
            btnEmitir.Text = "Emitir";
            btnEmitir.UseVisualStyleBackColor = true;
            btnEmitir.Click += btnEmitir_Click;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(612, 364);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(176, 23);
            btnResumen.TabIndex = 7;
            btnResumen.Text = "Resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // btnEstado
            // 
            btnEstado.Location = new Point(612, 238);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(176, 23);
            btnEstado.TabIndex = 8;
            btnEstado.Text = "Cambiar Estado";
            btnEstado.UseVisualStyleBackColor = true;
            btnEstado.Click += btnEstado_Click;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Activa", "Pausada", "Bloqueada" });
            comboBoxEstado.Location = new Point(612, 209);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(176, 23);
            comboBoxEstado.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(612, 100);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 10;
            label3.Text = "Saldo:";
            // 
            // numSaldo
            // 
            numSaldo.Location = new Point(612, 118);
            numSaldo.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numSaldo.Name = "numSaldo";
            numSaldo.Size = new Size(176, 23);
            numSaldo.TabIndex = 11;
            // 
            // numPago
            // 
            numPago.Location = new Point(612, 287);
            numPago.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            numPago.Name = "numPago";
            numPago.Size = new Size(176, 23);
            numPago.TabIndex = 12;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(612, 316);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(176, 23);
            btnPagar.TabIndex = 13;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // Pantalla_Tarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPagar);
            Controls.Add(numPago);
            Controls.Add(numSaldo);
            Controls.Add(label3);
            Controls.Add(comboBoxEstado);
            Controls.Add(btnEstado);
            Controls.Add(btnResumen);
            Controls.Add(btnEmitir);
            Controls.Add(numCredito);
            Controls.Add(label2);
            Controls.Add(comboBoxTitular);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(dataGridView1);
            Name = "Pantalla_Tarjeta";
            Text = "Tarjetas";
            Load += Pantalla_Tarjeta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCredito).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSaldo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPago).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NroTarjeta;
        private DataGridViewTextBoxColumn LimiteCredito;
        private DataGridViewTextBoxColumn Saldo;
        private DataGridViewTextBoxColumn Deuda;
        private DataGridViewTextBoxColumn NombreTitular;
        private DataGridViewTextBoxColumn Estado;
        private Button btnVolver;
        private Label label1;
        private ComboBox comboBoxTitular;
        private Label label2;
        private NumericUpDown numCredito;
        private Button btnEmitir;
        private Button btnResumen;
        private Button btnEstado;
        private ComboBox comboBoxEstado;
        private Label label3;
        private NumericUpDown numSaldo;
        private NumericUpDown numPago;
        private Button btnPagar;
    }
}