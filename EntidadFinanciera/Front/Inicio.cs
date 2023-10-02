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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Pantalla_Clientes nuevaPantalla = new Pantalla_Clientes();

            this.Visible = false;
            nuevaPantalla.ShowDialog();
            this.Visible = true;

        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            Pantalla_Cuentas nuevaPantalla = new Pantalla_Cuentas();

            this.Visible = false;
            nuevaPantalla.ShowDialog();
            this.Visible = true;
        }

        private void btnTarjetas_Click(object sender, EventArgs e)
        {
            Pantalla_Tarjeta nuevaPantalla = new Pantalla_Tarjeta();

            this.Visible = false;
            nuevaPantalla.ShowDialog();
            this.Visible = true;
        }
    }
}
