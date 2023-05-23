using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Animal
    {
        public string NombreAnimal { get; set; }
        public abstract void HacerSonido();
    }
}
