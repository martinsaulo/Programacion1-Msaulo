using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ProductoFisico : Producto
    {
        public double Peso { get; set; }
        public ProductoFisico(double pesoProducto, string nombreProducto, decimal precioProducto) 
            : base(nombreProducto, precioProducto)
        {
            Peso = pesoProducto;
            Precio = precioProducto;
            Nombre = nombreProducto;
        }
        public override decimal CalcularImpuesto()
        {
            return Precio * 0.1m;
        }
        public override decimal CalcularTotal()
        {
            return Precio + CalcularImpuesto();
        }
    }
}
