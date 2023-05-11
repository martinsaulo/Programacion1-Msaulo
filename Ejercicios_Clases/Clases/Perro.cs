using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Perro : Animal
    {
        public new void HacerSonido()
        {
            Console.WriteLine("Guau");
        }
    }
}
