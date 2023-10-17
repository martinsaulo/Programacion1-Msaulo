using Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class Pantalla_Tarjeta : Form
    {
        public Pantalla_Tarjeta()
        {
            InitializeComponent();
        }
        Principal BDD = new Principal();
        private void LimpiarCampos()
        {
            comboBoxEstado.SelectedIndex = -1;
            comboBoxTitular.SelectedIndex = -1;
            numSaldo.Value = 0;
            numPago.Value = 0;
            numCredito.Value = 0;
        }
        private void ActualizarDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BDD.DevolverTarjetas();
            dataGridView1.Columns["LimiteCredito"].Width = 150;
            dataGridView1.Columns["Titular"].Visible = false;
        }
        private void Pantalla_Tarjeta_Load(object sender, EventArgs e)
        {
            comboBoxTitular.DataSource = BDD.DevolverClientes();
            comboBoxTitular.DisplayMember = "NombreCompleto";
            ActualizarDataGridView();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            if (comboBoxTitular.SelectedIndex == -1 || numCredito.Value == 0 || numSaldo.Value == 0)
            {
                MessageBox.Show("Complete todos los campos.");
            }
            else
            {
                BDD.EmitirTarjetaCredito((Cliente)comboBoxTitular.SelectedItem, (double)numCredito.Value, (double)numSaldo.Value);
                ActualizarDataGridView();
            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null && comboBoxEstado.SelectedIndex != -1)
            {
                int indexFila = dataGridView1.CurrentCell.RowIndex;

                switch (comboBoxEstado.SelectedIndex)
                {
                    case 0:
                        BDD.CambiarEstadoTarjeta((int)dataGridView1[0, indexFila].Value, Estados.Activo);
                        break;
                    case 1:
                        BDD.CambiarEstadoTarjeta((int)dataGridView1[0, indexFila].Value, Estados.Pausado);
                        break;
                    case 2:
                        BDD.CambiarEstadoTarjeta((int)dataGridView1[0, indexFila].Value, Estados.Bloqueado);
                        break;
                }
                ActualizarDataGridView();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Seleccione una tarjeta y seleccione el estado.");
            }
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int indexFila = dataGridView1.CurrentCell.RowIndex;

                MessageBox.Show(BDD.GenerarResumenTarjeta((string)dataGridView1[0, indexFila].Value));
            }
            else
            {
                MessageBox.Show("Seleccione una tarjeta.");
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null && numPago.Value != 0)
            {
                int indexFila = dataGridView1.CurrentCell.RowIndex;

                BDD.PagarTarjetaCredito((double)numPago.Value, (string)dataGridView1[0,indexFila].Value);
                ActualizarDataGridView();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Seleccione una tarjeta.");
            }
        }
    }
}
