using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Producto(string nombreProducto, decimal precioProducto)
        {
            Nombre = nombreProducto;
            Precio = precioProducto;
        }
        public abstract decimal CalcularImpuesto();
        public abstract decimal CalcularTotal();
    }
}
