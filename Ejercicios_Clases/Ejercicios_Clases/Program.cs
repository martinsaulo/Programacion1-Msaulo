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
            CarritoDeCompra nuevoCarrito = new CarritoDeCompra();

            Disco nuevoDisco = new Disco {Nombre = "disc1", Id = 1, Descripcion = "fsdf", 
            NombreBanda = "Soda", Precio = 100.0 };
            Libro nuevoLibro = new Libro {Nombre = "lib2", Id = 2, Precio = 200.0, Descripcion = "fsd",
            ISBN = 432432, Autor = "asds", Editorial = "fgdfg"};

            nuevoDisco.Id = 1;
            nuevoLibro.Id = 2;

            nuevoCarrito.AgregarProducto(nuevoLibro);
            nuevoCarrito.AgregarProducto(nuevoDisco);

            foreach (var item in nuevoCarrito.Productos)
            {
                Console.WriteLine(item.Nombre);
            }
            Console.WriteLine("Eliminando el producto nro1");
            nuevoCarrito.EliminarProducto(1);
            foreach (var item in nuevoCarrito.Productos)
            {
                Console.WriteLine(item.Nombre);
            }


            Console.ReadKey();

        }
    }
}
