using Back;

namespace Front
{
    public partial class Pantalla_Cuentas : Form
    {
        public Pantalla_Cuentas()
        {
            InitializeComponent();
        }
        Principal BDD = new Principal();
        private void ActualizarDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BDD.DevolverCuentas();
            dataGridView1.Columns["Titular"].Visible = false;
            dataGridView1.Columns["NombreTitular"].Width = 150;
            BDD = null;
            BDD = new Principal();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pantalla_Cuentas_Load(object sender, EventArgs e)
        {
            comboBoxTitular.DataSource = BDD.DevolverClientes();
            comboBoxTitular.DisplayMember = "NombreCompleto";

            ActualizarDataGridView();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (comboBoxTipo.SelectedItem == null || comboBoxTitular.SelectedItem == null)
            {
                MessageBox.Show("Complete todos los campos.");
            }
            else
            {
                Tipos tipoCuenta = (comboBoxTipo.SelectedIndex == 0) ? Tipos.Ahorro : Tipos.Corriente;

                BDD.CrearCuentaBancaria((Cliente)comboBoxTitular.SelectedItem, tipoCuenta);
                ActualizarDataGridView();

                comboBoxTipo.SelectedIndex = -1;
                comboBoxTitular.SelectedIndex = -1;
            }
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            Pantalla_Transferencia nuevaPantalla = new Pantalla_Transferencia();

            this.Visible = false;
            nuevaPantalla.ShowDialog();
            this.Visible = true;
            ActualizarDataGridView();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Monto invalido.");
            }
            else
            {
                if (dataGridView1.SelectedRows == null)
                {
                    MessageBox.Show("Seleccione una cuenta");
                }
                else
                {
                    int indexFila = dataGridView1.CurrentCellAddress.Y;
                    BDD.RealizarDeposito((double)numericUpDown1.Value, (int)dataGridView1[0, indexFila].Value);
                    ActualizarDataGridView();
                }
            }
        }

        private void btnExtraccion_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Monto invalido.");
            }
            else
            {
                if (dataGridView1.SelectedRows == null)
                {
                    MessageBox.Show("Seleccione una cuenta");
                }
                else
                {
                    int indexFila = dataGridView1.CurrentCellAddress.Y;
                    BDD.RealizarExtraccion((double)numericUpDown1.Value, (int)dataGridView1[0, indexFila].Value);
                    ActualizarDataGridView();

                    numericUpDown1.Value = 0;

                }
            }
        }
    }
}
