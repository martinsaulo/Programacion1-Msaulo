using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Bateria : InstrumentoMusical
    {
        public override void Tocar()
        {
            Console.WriteLine("El instrumento que esta sonando es una Bateria.");
        }
    }
}
