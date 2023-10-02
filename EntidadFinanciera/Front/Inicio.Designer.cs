namespace Front
{
    partial class Inicio
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
            btnTarjetas = new Button();
            btnCuentas = new Button();
            btnClientes = new Button();
            SuspendLayout();
            // 
            // btnTarjetas
            // 
            btnTarjetas.Location = new Point(414, 61);
            btnTarjetas.Name = "btnTarjetas";
            btnTarjetas.Size = new Size(195, 112);
            btnTarjetas.TabIndex = 5;
            btnTarjetas.Text = "Tarjetas de Credito";
            btnTarjetas.UseVisualStyleBackColor = true;
            btnTarjetas.Click += btnTarjetas_Click;
            // 
            // btnCuentas
            // 
            btnCuentas.Location = new Point(213, 61);
            btnCuentas.Name = "btnCuentas";
            btnCuentas.Size = new Size(195, 112);
            btnCuentas.TabIndex = 4;
            btnCuentas.Text = "Cuentas Bancarias";
            btnCuentas.UseVisualStyleBackColor = true;
            btnCuentas.Click += btnCuentas_Click;
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(12, 61);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(195, 112);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 227);
            Controls.Add(btnTarjetas);
            Controls.Add(btnCuentas);
            Controls.Add(btnClientes);
            Name = "Inicio";
            Text = "Inicio";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTarjetas;
        private Button btnCuentas;
        private Button btnClientes;
    }
}