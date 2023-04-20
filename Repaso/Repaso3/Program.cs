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
double pagoCliente;

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

    totalFactura = double.Parse(listaClientes[indiceCliente][4]) - pagoCliente;

    listaClientes[indiceCliente][4] = totalFactura.ToString();


} while (true);

