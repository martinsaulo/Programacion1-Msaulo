using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cuadrado : FiguraGeometrica
    {
        public double Lado { get; set; }

        public override double CalcularArea()
        {

            return (Lado * Lado);
        }
    }
}
