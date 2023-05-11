using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clases
{
    public class CarritoDeCompra
    {
        public  List<Producto> Productos { get; set; } = new List<Producto>();

        public void AgregarProducto(Producto NuevoProducto) 
        {
            Productos.Add(NuevoProducto);
        }
        public void EliminarProducto(int IdProducto) 
        {
            Producto productoEliminado = new Producto();
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
