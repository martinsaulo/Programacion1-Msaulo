static int BusquedaCodigoCliente(List<string[]> lista, string codigo)
{
    int indice = -1;


    for(int i = 0; i < lista.Count(); i++)
    {
        if (lista[i][0] == codigo)
        {
            indice = i; 
            break;
        }
    }

    return indice;
}


List<string[]> listaClientes = new List<string[]>();

// DatosCliente = Código Cliente - Nombre  - Dirección - Email - Factura Compras - Pagos


string codigoCliente, nombreCliente, direccionCliente, emailCliente;

Console.WriteLine("Cargar clientes, ingrese el código 0 para finalizar la carga.");


//Carga de clientes
do
{

    Console.Write("Ingrese el código del cliente: ");
    codigoCliente = Console.ReadLine()!;
    
    if(codigoCliente != "0")
    {
        Console.Write("Ingrese el nombre del cliente: ");
        nombreCliente = Console.ReadLine()!;


        Console.Write("Ingrese la dirección del cliente: ");
        direccionCliente = Console.ReadLine()!;

        Console.Write("Ingrese el email del cliente: ");
        emailCliente = Console.ReadLine()!;

        //Guardo los datos del cliente en la lista
        listaClientes.Add(new string[6] {codigoCliente, nombreCliente, direccionCliente, emailCliente, "0", "0"});
    }

} while (codigoCliente != "0");



//Carga de facturas
Console.WriteLine("Cargue los montos de las facturas de los clientes, ingrese el código 0 para finalizar la carga.");
double montoFactura, totalFactura;
int indiceCliente;

do
{

    Console.Write("Ingrese el código del cliente: ");
    codigoCliente = Console.ReadLine()!;

    if (codigoCliente == "0") break;


    indiceCliente = BusquedaCodigoCliente(listaClientes, codigoCliente);

    while (indiceCliente == -1)
    {
        Console.WriteLine("No existe in cliente con dicho código, vuelva a intentarlo.");
        Console.Write("Ingrese el código del cliente: ");
        codigoCliente = Console.ReadLine()!;
        if (codigoCliente == "0") break;
    }


    Console.Write("Ingrese el monto de la factura: ");
    montoFactura = double.Parse(Console.ReadLine()!);

    totalFactura = double.Parse(listaClientes[indiceCliente][4]) + montoFactura;

    listaClientes[indiceCliente][4] = totalFactura.ToString();


}while(true);

//Carga de pagos

Console.WriteLine("Cargue los pagos, ingrese el código 0 para finalizar la carga.");
double pagoCliente, totalPago;

do
{

    Console.Write("Ingrese el código del cliente: ");
    codigoCliente = Console.ReadLine()!;

    if (codigoCliente == "0") break;


    indiceCliente = BusquedaCodigoCliente(listaClientes, codigoCliente);

    while (indiceCliente == -1)
    {
        Console.WriteLine("No existe in cliente con dicho código, vuelva a intentarlo.");
        Console.Write("Ingrese el código del cliente: ");
        codigoCliente = Console.ReadLine()!;
        if (codigoCliente == "0") break;
    }


    Console.Write("Ingrese el pago: ");
    pagoCliente = double.Parse(Console.ReadLine()!);

    totalPago = double.Parse(listaClientes[indiceCliente][5]) + pagoCliente;

    listaClientes[indiceCliente][5] = totalPago.ToString();

} while (true);

double deudaCliente, maxDeuda = 0, maxPago = 0;
string clienteMaxDeuda = "Ninguno", emailMaxDeuda = "Ninguno";
string clienteMaxPago = "Ninguno", emailMaxPago = "Ninguno";


foreach (var cliente in listaClientes)
{

    //Comprobar deuda
    deudaCliente = double.Parse(cliente[4]) - double.Parse(cliente[5]);
    if (deudaCliente > 0)
    {
        Console.WriteLine(cliente[1] + " Deuda: " + deudaCliente);

        if (deudaCliente > maxDeuda)
        {
            maxDeuda = deudaCliente;
            clienteMaxDeuda = cliente[1];
            emailMaxDeuda = cliente[3];
        }
    }

    //Comprobar pagos

    if (double.Parse(cliente[5]) > maxPago)
    {
        maxPago = double.Parse(cliente[5]);
        clienteMaxPago = cliente[1];
        emailMaxPago = cliente[3];
    }
}

Console.WriteLine("El cliente que más debe es " + clienteMaxDeuda + " y su email es " + emailMaxDeuda);
Console.WriteLine("El cliente que más pagó es " + clienteMaxPago + " y su email es " + emailMaxPago);

foreach (var cliente in listaClientes)
{
    if ((double.Parse(cliente[5]) - double.Parse(cliente[4])) > 0)
    {
        Console.WriteLine(cliente[1] + " " + cliente[2]);
    }
}