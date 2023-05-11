using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Asistente : Empleado
    {
        public double Deduccion { get; set; }

        public double CalcularSalario()
        {
            return Salario - Deduccion;
        }
    }
}
