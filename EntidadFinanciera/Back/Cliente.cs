using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Cliente
    {
        public Cliente(string nombre, string apellido, int dNI)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string NombreCompleto { get { return Nombre + " " + Apellido; } }
    }
}
