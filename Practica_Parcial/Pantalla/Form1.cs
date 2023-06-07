using Practica_Parcial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxTipo.SelectedIndex = 0;
            comboBoxLibro.SelectedIndex = 0;
            comboBoxLibroPrestamo.DataSource = ABM.ListaLibros;
            LimpiarDatos();
        }
        Principal ABM = new Principal();
        string ultimoValor = ".";
        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
        }
        public void LimpiarDatos()
        {
            lblDato1.Visible = false;
            lblDato2.Visible = false;
            lblDato3.Visible = false;
            lblDato4.Visible = false;
            lblDato5.Visible = false;
        }
        public void LimpiarAlta()
        {
            comboBoxLibro.Visible = false;
            lblTipoLibro.Visible = false;
            btnEliminar.Visible = false;
            lblFechaDevolucion.Visible = false;
            lblFechaPrestamo.Visible = false;
            dateTimePickerFechaDevolucion.Visible = false;
            dateTimePickerFechaPrestamo.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            txt4.Visible = false;
            comboBox1.Visible = false;
            lblLibro.Visible = false;
            comboBoxLibroPrestamo.Visible = false;
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarAlta();
            LimpiarDatos();
            comboBoxLibro.SelectedIndex = 0;

            if (comboBoxTipo.SelectedItem.ToString() == "Libros Disponibles")
            {
                lblNombre.Visible = true;
                txtNombre.Visible = true;
                lbl2.Visible = true;
                txt2.Visible = true;
                lbl3.Visible = true;
                txt3.Visible = true;
                comboBoxLibro.Visible = true;
                lblTipoLibro.Visible = true;
                lbl4.Visible = true;
                txt4.Visible = true;
                listBoxItems.DataSource = ABM.ListaLibros.FindAll(x=>x.Disponible);
                listBoxItems.DisplayMember = "Titulo";
                listBoxItems.ValueMember = "Titulo";
                lbl2.Text = "Autor:";
                lbl3.Text = "Año:";
            }
            else if (comboBoxTipo.SelectedItem.ToString() == "Clientes")
            {
                listBoxItems.DataSource = ABM.ListaClientes;
                listBoxItems.DisplayMember = "NombreCompleto";
                listBoxItems.ValueMember = "NombreCompleto";
                lblNombre.Visible = true;
                txtNombre.Visible = true;
                lbl2.Text = "Apellido:";
                lbl2.Visible = true;
                txt2.Visible = true;
                lbl3.Visible = true;
                lbl3.Text = "DNI:";
                txt3.Visible = true;
            }
            else
            {
                listBoxItems.DataSource = ABM.ListaPrestamos;
                listBoxItems.DisplayMember = "NombreLibro";
                listBoxItems.ValueMember = "NombreLibro";
                lbl2.Visible = false;
                txt2.Visible = false;
                lbl3.Visible = false;
                txt3.Visible = false;
                lblNombre.Visible = false;
                txtNombre.Visible = false;
                lbl5.Visible = true;
                lbl5.Text = "Cliente:";
                comboBox1.Visible = true;
                lblFechaDevolucion.Visible = true;
                lblFechaPrestamo.Visible = true;
                dateTimePickerFechaDevolucion.Visible = true;
                dateTimePickerFechaPrestamo.Visible = true;
                lblLibro.Visible = true;
                comboBoxLibroPrestamo.Visible = true;

                comboBoxLibroPrestamo.DataSource = ABM.ListaLibros.FindAll(x=>x.Disponible);
                comboBoxLibroPrestamo.DisplayMember = "Titulo";
                comboBoxLibroPrestamo.ValueMember = "Titulo";
                comboBox1.DataSource = ABM.ListaClientes;
                comboBox1.ValueMember = "NombreCompleto";
                comboBox1.DisplayMember = "NombreCompleto";
            }
            
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarDatos();
            if (listBoxItems.SelectedValue !=null)
            {
                btnEliminar.Visible = true;

                if (comboBoxTipo.SelectedItem.ToString() == "Clientes")
                {
                    Cliente clienteSeleccionado =
                        ABM.ListaClientes.Find(x => x.NombreCompleto == listBoxItems.SelectedValue.ToString());
                    lblDato1.Visible = true;
                    lblDato1.Text = "Nombre: " + clienteSeleccionado.Nombre;

                    lblDato2.Visible = true;
                    lblDato2.Text = "Apellido: " + clienteSeleccionado.Apellido;

                    lblDato3.Visible = true;
                    lblDato3.Text = "DNI: " + clienteSeleccionado.DNI;
                }
                else if (comboBoxTipo.SelectedItem.ToString() == "Prestamos")
                {
                    Prestamo prestamoSeleccionado =
                        ABM.ListaPrestamos.Find(x => x.NombreLibro == listBoxItems.SelectedValue.ToString());
                    
                    lblDato1.Visible = true;
                    lblDato1.Text = "Nombre: " + prestamoSeleccionado.ClientePrestamo.Nombre;

                    lblDato2.Visible = true;
                    lblDato2.Text = "Apellido: " + prestamoSeleccionado.ClientePrestamo.Apellido;

                    lblDato3.Visible = true;
                    lblDato3.Text = "Libro: " + prestamoSeleccionado.LibroPrestamo.Titulo;

                    lblDato4.Visible = true;
                    lblDato4.Text = "Fecha: " + prestamoSeleccionado.FechaPrestamo.ToShortDateString();

                    lblDato5.Visible = true;
                    lblDato5.Text = "Devolución: " + prestamoSeleccionado.FechaDevolucion.ToShortDateString();
                }
                else
                {
                    Libro libroSeleccionado = 
                        ABM.ListaLibros.Find(x=>x.Titulo == listBoxItems.SelectedValue.ToString());

                    if (libroSeleccionado != null)
                    {
                        lblDato1.Visible = true;
                        lblDato1.Text = "Titulo: " + libroSeleccionado.Titulo;

                        lblDato2.Visible = true;
                        lblDato2.Text = "Autor: " + libroSeleccionado.Autor;

                        lblDato3.Visible = true;
                        lblDato3.Text = "Publicación: " + libroSeleccionado.AnioPublicacion;

                        if (libroSeleccionado.ObtenerTipo() == "Libro Físico")
                        {
                            lblDato4.Visible = true;
                            lblDato4.Text = "Páginas: " + libroSeleccionado.ObtenerInformacion();
                        }
                        else
                        {
                            lblDato4.Visible = true;
                            lblDato4.Text = "Tamaño: " + libroSeleccionado.ObtenerInformacion().Split(',')[1] + "MB";

                            lblDato5.Visible = true;
                            lblDato5.Text = "Formato: " + libroSeleccionado.ObtenerInformacion().Split(',')[0];
                        }
                    }
                    
                }
                ultimoValor = listBoxItems.SelectedValue.ToString();
            }
            

        }

        private void comboBoxLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(comboBoxLibro.SelectedItem.ToString() == "Libro Físico")
            {
                
                lbl5.Visible = false;
                comboBox1.Visible = false;
                lbl4.Text = "Páginas:";
            }
            else
            {
                lbl5.Visible = true;
                comboBox1.Visible = true;
                lbl4.Text = "Tamaño:";
                comboBox1.DataSource = new List<string> { "epub", "pdf", "azw3", "txt", "docx","mobi"};
            }
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if(comboBoxTipo.SelectedItem.ToString() == "Clientes")
            {
                Cliente nuevoCliente = new Cliente(int.Parse(txt3.Text), txtNombre.Text, txt2.Text);
                ABM.AltaCliente(nuevoCliente);

                listBoxItems.DataSource = null;
                listBoxItems.DataSource = ABM.ListaClientes;
                listBoxItems.DisplayMember = "NombreCompleto";

            }
            else if (comboBoxTipo.SelectedItem.ToString() == "Prestamos")
            {
                Cliente clientePrestamo = ABM.ListaClientes.Find(x=>x.NombreCompleto == comboBox1.SelectedValue.ToString());
                Libro libroPrestamo = ABM.ListaLibros.Find(x => x.Titulo == comboBoxLibroPrestamo.SelectedValue.ToString());

                Prestamo nuevoPrestamo = new Prestamo(clientePrestamo, libroPrestamo,
                    dateTimePickerFechaPrestamo.Value, dateTimePickerFechaDevolucion.Value);
                libroPrestamo.Disponible = false;

                ABM.AltaPrestamo(nuevoPrestamo);

                comboBox1.ResetText();
                comboBoxLibroPrestamo.ResetText();
                comboBoxLibroPrestamo.DataSource = ABM.ListaLibros.FindAll(x => x.Disponible);

                listBoxItems.DataSource = null;
                listBoxItems.DataSource = ABM.ListaPrestamos;
                listBoxItems.DisplayMember = "NombreLibro";
            }
            else
            {
                if(comboBoxLibro.SelectedItem.ToString() == "Libro Físico")
                {
                    LibroFisico nuevoLibroFisico = new LibroFisico(txtNombre.Text, txt2.Text,
                        int.Parse(txt3.Text), int.Parse(txt4.Text));
                    ABM.AltaLibro(nuevoLibroFisico);
                }
                else
                {
                    LibroDigital nuevoLibroDigital = new LibroDigital(txtNombre.Text, txt2.Text,
                        int.Parse(txt3.Text), int.Parse(txt4.Text), comboBox1.SelectedItem.ToString());
                    ABM.AltaLibro(nuevoLibroDigital);
                }
                listBoxItems.DataSource = null;
                listBoxItems.DataSource = ABM.ListaLibros;
                listBoxItems.DisplayMember = "Titulo";
            }

            LimpiarCampos();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (comboBoxTipo.SelectedItem.ToString() == "Clientes")
            {
                int dni = 
                    ABM.ListaClientes.Find(x => x.NombreCompleto == listBoxItems.SelectedValue.ToString()).DNI;
                ABM.BajaCliente(dni);
                listBoxItems.DataSource = null;
                listBoxItems.DataSource = ABM.ListaClientes;
                listBoxItems.DisplayMember = "NombreCompleto";

            }
            else if (comboBoxTipo.SelectedItem.ToString() == "Prestamos")
            {

                Libro libroDevuelto =
                    ABM.ListaPrestamos.Find(x => x.LibroPrestamo.Titulo == listBoxItems.SelectedValue.ToString()).LibroPrestamo;

                ABM.BajaPrestamo(libroDevuelto);
                libroDevuelto.Disponible = true;

                listBoxItems.DataSource = null;
                listBoxItems.DataSource = ABM.ListaPrestamos;
                listBoxItems.DisplayMember = "NombreLibro";
            }
            else
            {
                ABM.BajaLibro(listBoxItems.SelectedValue.ToString());
                listBoxItems.DataSource = null;
                listBoxItems.DataSource = ABM.ListaLibros;
                listBoxItems.DisplayMember = "Titulo";
            }
            LimpiarDatos();
        }
    }
}
