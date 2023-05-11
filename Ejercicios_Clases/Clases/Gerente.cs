using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Gerente : Empleado
    {
        public double Bonificacion { get; set; }

        public double CalcularSalario()
        {
            return Bonificacion + Salario;
        }

    }
}
