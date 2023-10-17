using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Principal
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public void AgregarCliente(string NombreCliente, string ApellidoCliente, int DNICliente)
        {
            Cliente nuevoCliente = new Cliente(NombreCliente, ApellidoCliente, DNICliente);

            context.Clientes.Add(nuevoCliente);
            context.SaveChanges();
        }
        public void EliminarCliente(int idCliente)
        {
            Cliente clienteEncontrado = context.Clientes.Find(idCliente);

            if(clienteEncontrado != null)
            {
                context.Clientes.Remove(clienteEncontrado);
                context.SaveChanges();
            }
        }
        public List<Cliente> DevolverClientes()
        {
            return context.Clientes.ToList();
        }
        public void CrearCuentaBancaria(Cliente Titular_, Tipos Tipo)
        {
            CuentaBancaria nuevaCuenta = new CuentaBancaria();
            nuevaCuenta.NroCuenta = GenerarNroCuenta();
            nuevaCuenta.Titular = Titular_;
            nuevaCuenta.NombreTitular = Titular_.NombreCompleto;
            nuevaCuenta.Saldo = 0;
            nuevaCuenta.Tipo = Tipo;

            context.CuentasBancarias.Add(nuevaCuenta);
            context.SaveChanges();
        }
        public List<CuentaBancaria> DevolverCuentas()
        {
            return context.CuentasBancarias.ToList();
        }
        public void RealizarDeposito(double Monto, long NroCuenta)
        {
            var cuentaEncontrada = context.CuentasBancarias.Find(NroCuenta);

            if (Monto > 0)
            {
                if (cuentaEncontrada != null)
                {
                    cuentaEncontrada.Saldo += Monto;
                    context.SaveChanges();
                }
            }
        }
        public void RealizarExtraccion(double Monto, string NroCuenta)
        {
            var cuentaEncontrada = context.CuentasBancarias.SingleOrDefault(x => x.NroCuenta == NroCuenta);

            if(cuentaEncontrada != null)
            {
                if (Monto > 0 && Monto <= cuentaEncontrada.Saldo)
                {
                    cuentaEncontrada.Saldo -= Monto;
                    context.SaveChanges();
                }
            }
        }
        public void RealizarTransferencia(double Monto, string IdCuentaOrigen, string IdCuentaDestinatario)
        {
            if (Monto > 0)
            {
                var cuentaOrigen = context.CuentasBancarias.SingleOrDefault(x=> x.NroCuenta == IdCuentaOrigen);
                var cuentaDestinatario = context.CuentasBancarias.SingleOrDefault(x => x.NroCuenta == IdCuentaDestinatario);

                if (cuentaOrigen != null && cuentaDestinatario != null && cuentaOrigen.Saldo >= Monto)
                {
                    cuentaOrigen.Saldo -= Monto;
                    cuentaDestinatario.Saldo += Monto;
                    context.SaveChanges();
                }
            }
        }
        public void EmitirTarjetaCredito(Cliente Titular_, double LimiteCredito, double Saldo)
        {
            TarjetaCredito nuevaTarjeta = new TarjetaCredito();
            nuevaTarjeta.NroTarjeta = GenerarNroTarjeta();
            nuevaTarjeta.Titular = Titular_;
            nuevaTarjeta.NombreTitular = Titular_.NombreCompleto;
            nuevaTarjeta.LimiteCredito = LimiteCredito;
            nuevaTarjeta.Saldo = Saldo;

            context.TarjetasDeCredito.Add(nuevaTarjeta);
            context.SaveChanges();
        }
        public void CambiarEstadoTarjeta(long IdTarjeta, Estados Estado)
        {
            var tarjetaEncontrada = context.TarjetasDeCredito.Find(IdTarjeta);

            if (tarjetaEncontrada != null)
            {
                tarjetaEncontrada.Estado = Estado;
                context.SaveChanges();
            }
        }
        public void PagarTarjetaCredito(double Monto, string IdTarjeta)
        {
            var tarjetaEncontrada = context.TarjetasDeCredito.SingleOrDefault(x=> x.NroTarjeta == IdTarjeta);

            if(tarjetaEncontrada != null)
            {
                if(tarjetaEncontrada.Estado == Estados.Activo)
                {                    
                    tarjetaEncontrada.MontoDeuda += Monto;
                    context.SaveChanges();
                }
            }
        }
        public string GenerarResumenTarjeta(string idTarjeta) 
        {
            TarjetaCredito tarjeta = context.TarjetasDeCredito.SingleOrDefault(x=> x.NroTarjeta == idTarjeta);
            if (tarjeta != null)
            {
                StringBuilder ret = new StringBuilder();

                ret.AppendLine("Resumen:");
                ret.AppendLine("Nro. tarjeta: " + tarjeta.NroTarjeta);
                ret.AppendLine("Titular: " + tarjeta.Titular.NombreCompleto);
                ret.AppendLine("Limite credito: " + tarjeta.LimiteCredito);
                ret.AppendLine("Saldo: " + tarjeta.Saldo);
                ret.AppendLine("Deuda: " + tarjeta.MontoDeuda);
                ret.AppendLine("Estado: " + tarjeta.Estado);

                return ret.ToString();
            }
            return "Error";
        }
        public List<TarjetaCredito> DevolverTarjetas()
        {
            return context.TarjetasDeCredito.ToList();
        }
        public bool NroCuentaYaExistente(string nroCuenta) 
        {
            return context.CuentasBancarias.Any(x => x.NroCuenta == nroCuenta);
        }
        public bool NroTarjetaYaExistente(string nroTarjeta)
        {
            return context.TarjetasDeCredito.Any(x => x.NroTarjeta == nroTarjeta);
        }
        public string GenerarNroTarjeta()
        {
            string nuevoNro = "";
            Random rnd = new Random();
            int cont = 0;

            do
            {
                cont++;
                nuevoNro += 
                    "1234-" + rnd.Next(1000, 9999) +"-"+ rnd.Next(1000, 9999) +"-"+ rnd.Next(1000, 9999);
            } while (NroTarjetaYaExistente(nuevoNro) && cont < 15);

            if (cont != 15)
            {
                return nuevoNro;
            }
            else
            {
                throw new Exception("No se pudo generar un nro valido.");
            }

        }
        public string GenerarNroCuenta()
        {
            string nuevoNro = "";
            Random rnd = new Random();
            int cont = 0;

            do
            {
                cont++;
                nuevoNro += 
                    "4321-" + rnd.Next(1000, 9999) +"-"+ rnd.Next(1000, 9999) +"-"+ rnd.Next(1000, 9999);
            } while (NroCuentaYaExistente(nuevoNro) && cont < 15);

            if(cont != 15)
            {
                return nuevoNro;
            }
            else
            {
                throw new Exception("No se pudo generar un nro valido.");
            }
            
        }
    }
}
