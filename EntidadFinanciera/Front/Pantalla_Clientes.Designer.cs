namespace Front
{
    partial class Pantalla_Clientes
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
            listBoxClientes = new ListBox();
            btnVolver = new Button();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtApellido = new TextBox();
            btnAgregar = new Button();
            numDNI = new NumericUpDown();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)numDNI).BeginInit();
            SuspendLayout();
            // 
            // listBoxClientes
            // 
            listBoxClientes.FormattingEnabled = true;
            listBoxClientes.ItemHeight = 15;
            listBoxClientes.Location = new Point(12, 12);
            listBoxClientes.Name = "listBoxClientes";
            listBoxClientes.Size = new Size(278, 424);
            listBoxClientes.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(476, 413);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(402, 9);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(149, 23);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 12);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 68);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 130);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "DNI:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(402, 65);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(149, 23);
            txtApellido.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(476, 182);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // numDNI
            // 
            numDNI.Location = new Point(402, 128);
            numDNI.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numDNI.Name = "numDNI";
            numDNI.Size = new Size(149, 23);
            numDNI.TabIndex = 9;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(296, 413);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Pantalla_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 450);
            Controls.Add(btnEliminar);
            Controls.Add(numDNI);
            Controls.Add(btnAgregar);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(btnVolver);
            Controls.Add(listBoxClientes);
            Name = "Pantalla_Clientes";
            Text = "Pantalla_Clientes";
            Load += Pantalla_Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)numDNI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxClientes;
        private Button btnVolver;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtApellido;
        private Button btnAgregar;
        private NumericUpDown numDNI;
        private Button btnEliminar;
    }
}