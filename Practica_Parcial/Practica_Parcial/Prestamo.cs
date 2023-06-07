using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Parcial
{
    public class Prestamo
    {
        public Cliente ClientePrestamo { get; set; }
        public Libro LibroPrestamo { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public string NombreLibro { get; set; }
        public Prestamo(Cliente ClientePrestamo_, Libro LibroPrestamo_, DateTime FechaPrestamo_,
            DateTime FechaDevolucion_) 
        {
            ClientePrestamo = ClientePrestamo_;
            LibroPrestamo = LibroPrestamo_;
            FechaPrestamo = FechaPrestamo_;
            FechaDevolucion = FechaDevolucion_;
            NombreLibro = LibroPrestamo_.Titulo;
        }
    }
}
