using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Automovil : IVehiculo
    {
        public double Velocidad { get; set; } = 0;
        public void Acelerar()
        {
            Velocidad += 50;
        }
    }
}
