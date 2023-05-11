using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Circulo : FiguraGeometrica
    {
        public double Radio { get; set; }


        public new double CalcularArea()
        {
            return (Radio * Radio * Math.PI);
        }
    }
}
