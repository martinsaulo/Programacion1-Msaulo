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
    public partial class Pantalla_Clientes : Form
    {
        public Pantalla_Clientes()
        {
            InitializeComponent();
        }
        Principal BDD = new Principal();
        private void ActualizarLista()
        {
            listBoxClientes.DataSource = BDD.DevolverClientes();
            listBoxClientes.DisplayMember = "NombreCompleto";
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "" || txtNombre.Text == "" || numDNI.Value == 0)
            {
                MessageBox.Show("Complete todos los campos.");
            }
            else
            {
                BDD.AgregarCliente(txtNombre.Text, txtApellido.Text, (int)numDNI.Value);
                ActualizarLista();

                txtApellido.Text = "";
                txtNombre.Text = "";
                numDNI.Value = 0;
            }
        }

        private void Pantalla_Clientes_Load(object sender, EventArgs e)
        {
             ActualizarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un cliente.");
            }
            else
            {
                Cliente clienteSeleccionado = (Cliente)listBoxClientes.SelectedItem;
                BDD.EliminarCliente(clienteSeleccionado.Id);
                ActualizarLista();
            }
        }
    }
}
