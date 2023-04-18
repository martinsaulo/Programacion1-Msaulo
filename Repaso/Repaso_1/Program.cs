int opcion;



do
{
    Console.WriteLine(" 1) Ejercicios DO WHILE.");
    Console.WriteLine(" 2) Ejercicios FOR.");
    Console.WriteLine(" 3) Ejercicios WHILE.");
    Console.WriteLine(" 4) Salir.");
    Console.Write("Ingrese la opción: ");
    opcion = int.Parse(Console.ReadLine()!);

    switch (opcion)
    {
        case 1:

            // Ejercicios DO WHILE
            string nombreUsuario, contraseña;

            Console.WriteLine("Inicio sesión.");
            do
            {
                Console.Write("Ingrese el nombre de usuario: ");
                nombreUsuario = Console.ReadLine()!;

                Console.Write("Ingrese la contraseña: ");
                contraseña = Console.ReadLine()!;

            } while (contraseña != "667788");

            Console.WriteLine("Inicio de sesión correcto.");

            double numeroIngresado, promedioNegativos = 0, contadorNegativos = 0;

            do
            {
                Console.Write("Ingrese un número positivo: ");
                numeroIngresado = double.Parse(Console.ReadLine()!);

                if (numeroIngresado < 0)
                {
                    promedioNegativos += numeroIngresado;
                    contadorNegativos++;
                }


            } while (numeroIngresado < 0);


            promedioNegativos = (contadorNegativos > 0) ? promedioNegativos / contadorNegativos : 0;

            Console.WriteLine("El promedio de los números negativos ingresados es " + promedioNegativos);


            double contadorTresCifras = 0, promedioTresCifras = 0;
            do
            {
                Console.Write("Ingrese un número de más de 3 cifras: ");
                numeroIngresado = double.Parse(Console.ReadLine()!);

                promedioTresCifras += numeroIngresado;
                contadorTresCifras++;

            } while (numeroIngresado < 999 && numeroIngresado > -999);

            promedioTresCifras = promedioTresCifras / contadorTresCifras;

            Console.WriteLine("El promedio de los números " + promedioTresCifras);

            break;

        // Ejercicios FOR
        case 2:

            Console.WriteLine("Sumatoria");

            int ingresoEnteros, sumatoriaEnteros = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un número: ");
                ingresoEnteros = int.Parse(Console.ReadLine()!);
                sumatoriaEnteros += ingresoEnteros;
            }

            Console.WriteLine("La sumatoria de los números ingresados es: " + sumatoriaEnteros);

            Console.WriteLine("Calcular el promedio de 8 números");

            double promedio = 0;

            for (int i = 0; i < 8; i++)
            {
                Console.Write("Ingrese un número: ");
                promedio += double.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("El promedio de los 8 números ingresados es: " + promedio / 8);


            Console.WriteLine("Costo y total.");

            double totalAdeudado = 0, ingresoCosto, ingresoTotal;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese el costo del producto: ");
                ingresoCosto = double.Parse(Console.ReadLine()!);

                Console.Write("Ingrese es costo total del producto:");
                ingresoTotal = double.Parse(Console.ReadLine()!);

                totalAdeudado += ingresoTotal;
            }
            Console.WriteLine("El total adeudado es: " + totalAdeudado);

            double ingresoMayor, mayor;
            Console.WriteLine("El mayor de 8 números.");

            Console.Write("Ingrese un número: ");
            mayor = double.Parse(Console.ReadLine()!);

            for (int i = 0; i < 7; i++)
            {
                Console.Write("Ingrese un número: ");
                ingresoMayor = double.Parse(Console.ReadLine()!);

                if (ingresoMayor > mayor) mayor = ingresoMayor;
            }

            Console.WriteLine("El número mayor de los 8 ingresados es: " + mayor);


            Console.WriteLine("Cliente que más gasto");

            string nombreCliente, clienteMayorGasto;
            double gastoCliente, mayorGasto;

            Console.Write("Ingrese el nombre del cliente: ");
            clienteMayorGasto = Console.ReadLine()!;

            Console.Write("Ingrese el gasto total del cliente: ");
            mayorGasto = double.Parse(Console.ReadLine()!);

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese el nombre del cliente: ");
                nombreCliente = Console.ReadLine()!;

                Console.Write("Ingrese el gasto total del cliente: ");
                gastoCliente = double.Parse(Console.ReadLine()!);

                if (gastoCliente > mayorGasto)
                {
                    mayorGasto = gastoCliente;
                    clienteMayorGasto = nombreCliente;
                }
            }

            Console.WriteLine(clienteMayorGasto + " fue el cliente que más gasto, con un gasto total de " + mayorGasto);

            break;


        //Ejercicios WHILE
        case 3:
            double ingresoSumatoria = 1, sumatoriaWhile = 0, promedioWhile;
            int contadorWhile = -1;
            Console.WriteLine("Sumatoria (Ingrese 0 para finalizar).");

            while (ingresoSumatoria != 0)
            {
                Console.Write("Ingrese un número: ");
                ingresoSumatoria = double.Parse(Console.ReadLine()!);
                sumatoriaWhile += ingresoSumatoria;
                contadorWhile++;
            }

            Console.WriteLine("La suma total es: " + sumatoriaWhile);

            promedioWhile = (contadorWhile > 0) ? sumatoriaWhile / contadorWhile : 0;
            Console.WriteLine("El promedio es: " + promedioWhile);

            Console.WriteLine("Cantidad de usuarios.");
            string? ingresoUsuario = "a";
            int contadorUsuario = 0;

            while (ingresoUsuario != "")
            {
                Console.Write("Ingrese un nombre de usuario: ");
                ingresoUsuario = Console.ReadLine()!;

                contadorUsuario = (ingresoUsuario != "") ? contadorUsuario++ : contadorUsuario;

            }
            Console.WriteLine("Se ingreso un total de " + contadorUsuario + " usuarios.");


            Console.WriteLine("Total facturado.");
            double costoProducto = 1, totalFactura = 0;

            while (costoProducto != 0)
            {
                Console.Write("Ingrese es costo del producto: ");
                costoProducto = double.Parse(Console.ReadLine()!);

                if (costoProducto != 0)
                {
                    Console.Write("Ingrese es costo total: ");
                    totalFactura += double.Parse(Console.ReadLine()!);
                }
            }
            Console.WriteLine("El total adeudado es " + totalFactura);


            Console.WriteLine("Total factura.");

            int cantidadProductos;
            totalFactura = 0;

            Console.Write("Ingrese la cantidad de productos: ");
            cantidadProductos = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < cantidadProductos; i++)
            {
                Console.Write("Ingrese el costo del producto: ");
                costoProducto = double.Parse(Console.ReadLine()!);

                Console.Write("Ingrese es costo total: ");
                totalFactura += double.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("El total adeudado es " + totalFactura);

            break;

        case 4:
            break;

        default:
            Console.WriteLine("Opción no valida.");
            break;
    }
    if (opcion != 4)
    {
        Console.WriteLine("Presione cualquier tecla para continuar.");
        Console.ReadKey();
    }


    Console.Clear();

} while (opcion != 4);

Console.WriteLine("Saliendo del programa.");

