namespace Front
{
    partial class Pantalla_Transferencia
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
            comboBoxOrigen = new ComboBox();
            comboBoxDestinatario = new ComboBox();
            numMonto = new NumericUpDown();
            label1 = new Label();
            btnCancelar = new Button();
            label2 = new Label();
            label3 = new Label();
            btnTransferir = new Button();
            ((System.ComponentModel.ISupportInitialize)numMonto).BeginInit();
            SuspendLayout();
            // 
            // comboBoxOrigen
            // 
            comboBoxOrigen.FormattingEnabled = true;
            comboBoxOrigen.Location = new Point(12, 27);
            comboBoxOrigen.Name = "comboBoxOrigen";
            comboBoxOrigen.Size = new Size(201, 23);
            comboBoxOrigen.TabIndex = 0;
            // 
            // comboBoxDestinatario
            // 
            comboBoxDestinatario.FormattingEnabled = true;
            comboBoxDestinatario.Location = new Point(12, 87);
            comboBoxDestinatario.Name = "comboBoxDestinatario";
            comboBoxDestinatario.Size = new Size(201, 23);
            comboBoxDestinatario.TabIndex = 1;
            // 
            // numMonto
            // 
            numMonto.DecimalPlaces = 2;
            numMonto.Location = new Point(12, 158);
            numMonto.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numMonto.Name = "numMonto";
            numMonto.Size = new Size(201, 23);
            numMonto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 3;
            label1.Text = "Transferir de:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 218);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Transferir a:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 6;
            label3.Text = "Monto:";
            // 
            // btnTransferir
            // 
            btnTransferir.Location = new Point(138, 218);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(75, 23);
            btnTransferir.TabIndex = 7;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = true;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // Pantalla_Transferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 254);
            Controls.Add(btnTransferir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Controls.Add(numMonto);
            Controls.Add(comboBoxDestinatario);
            Controls.Add(comboBoxOrigen);
            Name = "Pantalla_Transferencia";
            Text = "Transferencia";
            Load += Pantalla_Transferencia_Load;
            ((System.ComponentModel.ISupportInitialize)numMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxOrigen;
        private ComboBox comboBoxDestinatario;
        private NumericUpDown numMonto;
        private Label label1;
        private Button btnCancelar;
        private Label label2;
        private Label label3;
        private Button btnTransferir;
    }
}