using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Cliente
    {
        public Cliente(string Nombre_, string Apellido_, int DNI_)
        {
            Nombre = Nombre_;
            Apellido = Apellido_;
            DNI = DNI_;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
    }
}
