using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Ejercicios_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro prueba = new Perro();
            prueba.HacerSonido();
            Console.ReadKey();
        }
    }
}
