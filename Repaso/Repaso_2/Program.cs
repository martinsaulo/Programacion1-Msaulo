// Carga Productos

int[,] productos = new int[10, 3]; //Precio, Cantidad, Ventas 

for (int i = 0; i<10; i++)
{
    for (int j = 0; j<3; j++)
    {
        productos[i,j] = 0;
    }
}



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

Console.WriteLine("Ventas.");
//Ventas
int ventasProducto;
codigoProducto = 1;

do
{
    Console.Write("Ingrese el código del producto[1-10]: ");
    codigoProducto = int.Parse(Console.ReadLine()!);



    if (codigoProducto != 0) 
    {
        Console.Write("Ingrese las ventas del producto: ");
        ventasProducto = int.Parse(Console.ReadLine()!);

        productos[codigoProducto-1,2] = ventasProducto;
    }

} while (codigoProducto != 0);


Console.Write("Los productos");

for (int i = 1; i<=10; i++)
{
    if (productos[i-1,1] - productos[i-1,2] <= 0)
    {
        Console.Write(" " + (i));
    }
}
Console.Write(" tienen una cantidad menor o igual a 0.\n");

//Nombres

string[] nombresProductos = new string[10];

for (int i=1; i<=10; i++)
{
    Console.Write("Ingrese el nombre del producto nro " + i + ":  ");

    nombresProductos[i - 1] = Console.ReadLine()!;

}

Console.Write("Los productos:");

for (int i = 0; i<10; i++)
{
    if (productos[i, 2] < 10)
    {
        Console.Write(" " + nombresProductos[i]);
    }
}

Console.Write(" tuvieron ventas menores a 10 unidades.");

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


