using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Parcial
{
    public class Principal
    {
        public List<Libro> ListaLibros = new List<Libro>();
        public List<Cliente> ListaClientes = new List<Cliente>();
        public List<Prestamo> ListaPrestamos = new List<Prestamo>();

        public void AltaLibro(Libro libro)
        {
            ListaLibros.Add(libro);
        }
        public void BajaLibro(string titulo) 
        {
            ListaLibros.Remove(ListaLibros.Find(i => i.Titulo == titulo));
        }
        public void AltaCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }
        public void BajaCliente(int dni)
        {
            ListaClientes.Remove( ListaClientes.Find(x => x.DNI == dni) );
        }
        public void AltaPrestamo(Prestamo prestamo)
        {
            ListaPrestamos.Add(prestamo);
        }
        public void BajaPrestamo(Libro libro)
        {
            ListaPrestamos.Remove( ListaPrestamos.Find(x=> x.LibroPrestamo == libro) );
        }
    }
}
