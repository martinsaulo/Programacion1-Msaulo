using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clases
{
    public class CarritoDeCompra
    {
        public  List<ProductoA> Productos { get; set; } = new List<ProductoA>();

        public void AgregarProducto(ProductoA NuevoProducto) 
        {
            Productos.Add(NuevoProducto);
        }
        public void EliminarProducto(int IdProducto) 
        {
            ProductoA productoEliminado = new ProductoA();
            foreach (var producto in Productos) 
            {

                if (producto.Id == IdProducto) 
                {
                    productoEliminado = producto;
                }
            }
            Productos.Remove(productoEliminado);
        }
        public double CalcularTotal()
        {
            double retorno = 0;

            foreach (var producto in Productos)
            {
                retorno += producto.Precio;
            }

            return retorno;
        }
    }
}
