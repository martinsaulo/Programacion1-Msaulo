using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Libro : ProductoA
    {
        public long ISBN { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
    }
}
