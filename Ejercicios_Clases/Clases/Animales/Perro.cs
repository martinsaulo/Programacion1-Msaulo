using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Perro : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("Guau");
        }
    }
}
