// Carga Productos

int[,] productos = new int[10, 2];

int codigoProducto, precioProducto, cantidadProducto;

do
{
    Console.Write("Ingrese el código del producto[1-10]: ");
    codigoProducto = int.Parse(Console.ReadLine()!);

    if (codigoProducto != 0)
    {
        Console.Write("Ingrese el precio del producto: ");
        precioProducto = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese la cantidad en stock: ");
        cantidadProducto = int.Parse(Console.ReadLine()!);

        productos[codigoProducto - 1, 0] = precioProducto;
        productos[codigoProducto - 1, 1] = cantidadProducto;

    }


} while (codigoProducto != 0);


int maxCantidad = productos[0, 1], productoMaxCantidad = 1;

for (int i = 0; i < 10; i++)
{
    if (maxCantidad < productos[i, 1])
    {
        productoMaxCantidad = i + 1;
        maxCantidad = productos[i, 1];
    }
}

Console.WriteLine("El producto con mayor stock es el producto nro " + productoMaxCantidad);


//Ventas
do
{

} while ();


/* IMPRIMIR MATRIZ
for (int fila = 0; fila < productos.GetLength(0); fila++)
{
    for (int columna = 0; columna < productos.GetLength(1); columna++)
    {
        Console.Write(productos[fila, columna] + " ");
    }
    Console.WriteLine();
}
*/


