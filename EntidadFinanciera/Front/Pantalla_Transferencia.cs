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
    public partial class Pantalla_Transferencia : Form
    {
        public Pantalla_Transferencia()
        {
            InitializeComponent();
        }
        Principal BDD = new Principal();
        private void Pantalla_Transferencia_Load(object sender, EventArgs e)
        {
            comboBoxDestinatario.DataSource = BDD.DevolverCuentas();
            comboBoxDestinatario.DisplayMember = "NombreTitular";
            comboBoxOrigen.DataSource = BDD.DevolverCuentas();
            comboBoxOrigen.DisplayMember = "NombreTitular";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            BDD.RealizarTransferencia((double)numMonto.Value, ((CuentaBancaria)comboBoxOrigen.SelectedItem).NroCuenta, ((CuentaBancaria)comboBoxDestinatario.SelectedItem).NroCuenta);
            this.Close();
        }
    }
}
