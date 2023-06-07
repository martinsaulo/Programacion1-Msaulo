using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Parcial
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string NombreCompleto { get; set; }
        public Cliente(int DNI_, string Nombre_, string Apellido_)
        {
            Nombre = Nombre_;
            Apellido = Apellido_;
            DNI = DNI_;
            NombreCompleto = Nombre_ + " " + Apellido_;
        } 

    }
}
