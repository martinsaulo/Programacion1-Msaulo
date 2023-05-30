using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Opcional_Polimorfirmos
{
    public class ProductoFisico : Producto
    {
        public double Peso { get; set; }
        public ProductoFisico(double pesoProducto, string nombreProducto, double precioProducto) 
            : base(nombreProducto, precioProducto)
        {
            Peso = pesoProducto;
            Precio = precioProducto;
            Nombre = nombreProducto;
        }
        public override double CalcularImpuesto()
        {
            return Precio * 0.1f;
        }
        public override double CalcularTotal()
        {
            return Precio + CalcularImpuesto();
        }
    }
}
