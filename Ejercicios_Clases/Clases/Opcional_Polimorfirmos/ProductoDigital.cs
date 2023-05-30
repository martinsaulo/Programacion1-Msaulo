using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Opcional_Polimorfirmos
{
    public class ProductoDigital : Producto
    {
        public int Tamanio { get; set; }
        public override double CalcularImpuesto()
        {
            return Precio * 0.05f;
        }
        public ProductoDigital(int tamanioProducto, string nombreProducto, double precioProducto)
            :base(nombreProducto, precioProducto)
        {
            Tamanio = tamanioProducto;
            Nombre = nombreProducto;
            Precio = precioProducto;
        }

        public override double CalcularTotal()
        {
            return Precio + CalcularImpuesto();
        }

    }
}
