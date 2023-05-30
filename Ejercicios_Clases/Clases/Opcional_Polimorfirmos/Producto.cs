using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Opcional_Polimorfirmos
{
    public abstract class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public Producto(string nombreProducto, double precioProducto) 
        {
            Nombre = nombreProducto;
            Precio = precioProducto;
        }
        public abstract double CalcularImpuesto();
        public abstract double CalcularTotal();
    }
}
