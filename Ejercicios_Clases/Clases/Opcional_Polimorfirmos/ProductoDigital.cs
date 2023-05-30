using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ProductoDigital : Producto
    {
        public int Tamanio { get; set; }
        public override decimal CalcularImpuesto()
        {
            return Precio * 0.05f;
        }
        public ProductoDigital(int tamanioProducto, string nombreProducto, decimal precioProducto)
            :base(nombreProducto, precioProducto)
        {
            Tamanio = tamanioProducto;
            Nombre = nombreProducto;
            Precio = precioProducto;
        }

        public override decimal CalcularTotal()
        {
            return Precio + CalcularImpuesto();
        }

    }
}
